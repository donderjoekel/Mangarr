using System.Text.Json;
using Discord.Webhook;
using FastEndpoints.Swagger;
using IdGen.DependencyInjection;
using Mangarr.Backend.Configuration;
using Mangarr.Backend.Extensions;
using Mangarr.Backend.Jobs;
using Mangarr.Backend.Services;
using Mangarr.Backend.Services.Notifications;
using Mangarr.Backend.Sources.Extensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Quartz;
using Serilog;
using Serilog.Events;
using StackExchange.Redis;
using ExportOptions = Mangarr.Backend.Configuration.ExportOptions;
using ISource = Mangarr.Backend.Sources.ISource;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.AddServerHeader = false;
    options.AllowSynchronousIO = false;
});

builder.Host.UseSerilog((context, provider, configuration) =>
{
    SeqOptions seqOptions = provider.GetRequiredService<IOptions<SeqOptions>>().Value;

    if (!string.IsNullOrEmpty(seqOptions.Host))
    {
        configuration
            .Enrich.WithProperty("Application", "Mangarr")
            .Enrich.FromLogContext()
            .WriteTo.Seq(seqOptions.Host, apiKey: seqOptions.Key, restrictedToMinimumLevel: LogEventLevel.Information);
    }

    configuration
        .WriteTo.Console(LogEventLevel.Debug);
});

builder.Host.UseConsoleLifetime(options => options.SuppressStatusMessages = true);

// builder.Services.AddHostedService<MainWorker>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.Configure<AniListOptions>(builder.Configuration.GetSection(AniListOptions.SECTION));
builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));
builder.Services.Configure<RedisOptions>(builder.Configuration.GetSection(RedisOptions.SECTION));
builder.Services.Configure<SeqOptions>(builder.Configuration.GetSection(SeqOptions.SECTION));
builder.Services.Configure<NotificationOptions>(builder.Configuration.GetSection(NotificationOptions.SECTION));

builder.Services.AddQuartz(options =>
{
    options.AddJob<CacheSourceSchedulerJob>(CacheSourceSchedulerJob.JobKey);
    options.AddJob<CacheSourceJob>(CacheSourceJob.JobKey, configure => configure.StoreDurably())
        .UseDefaultThreadPool(3);

    options.AddJob<IndexMangaSchedulerJob>(IndexMangaSchedulerJob.JobKey);
    options.AddJob<IndexMangaJob>(IndexMangaJob.JobKey, configure => configure.StoreDurably())
        .UseDefaultThreadPool(5);

    options.AddJob<DownloadChapterSchedulerJob>(DownloadChapterSchedulerJob.JobKey);
    options.AddJob<DownloadChapterJob>(DownloadChapterJob.JobKey, configure => configure.StoreDurably())
        .UseDefaultThreadPool(3);

    options.AddTrigger(configure =>
    {
        configure
            .WithIdentity("CacheSourceSchedulerJob")
            .WithDescription("Cache enabled sources")
            .ForJob(CacheSourceSchedulerJob.JobKey)
            .WithCronSchedule("0 0/30 0 ? * * *");
    });

    options.AddTrigger(configure =>
    {
        configure
            .WithIdentity("IndexMangaSchedulerJob")
            .WithDescription("Check for new chapters")
            .ForJob(IndexMangaSchedulerJob.JobKey)
            .WithCronSchedule("0 0 * ? * * *");
    });

    options.AddTrigger(configure =>
    {
        configure
            .WithIdentity("DownloadChapterSchedulerJob")
            .WithDescription("Download requested chapters")
            .ForJob(DownloadChapterSchedulerJob.JobKey)
            .StartNow()
            .WithCronSchedule("0 10/20 * ? * * *");
    });
});

builder.Services.AddQuartzHostedService(options =>
{
    options.AwaitApplicationStarted = true;
    options.WaitForJobsToComplete = true;
});

builder.Services.ConfigureMongo(builder.Configuration);
builder.Services.AddMongo();

builder.Services.ConfigureSources(builder.Configuration);
builder.Services.AddSources();

builder.Services.AddHttpClient();

builder.Services.AddSingleton<AniListService>();
builder.Services.AddSingleton<ArchiveService>();
builder.Services.AddSingleton<CachingService>();
builder.Services.AddSingleton<ComicInfoService>();
builder.Services.AddSingleton<CoverImageService>();
builder.Services.AddSingleton<ExportService>();
builder.Services.AddSingleton<PageDownloaderService>();
// builder.Services.AddSingleton<MangaProcessor>();
builder.Services.AddSingleton<NotificationService>();
builder.Services.AddSingleton<INotificationProcessor, DiscordNotificationProcessor>();
builder.Services.AddSingleton<DiscordWebhookClient>(provider =>
{
    IOptions<NotificationOptions> options = provider.GetRequiredService<IOptions<NotificationOptions>>();
    return new DiscordWebhookClient(options.Value.Discord);
});
// builder.Services.AddSingleton<ChapterProcessor>();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddFastEndpoints(options =>
{
    // options.SourceGeneratorDiscoveredTypes.Insert(0, null);
});
builder.Services.AddSwaggerDoc(addJwtBearerAuth: false);
builder.Services.AddIdGen(0);

builder.Services.AddSingleton<IConnectionMultiplexer>(provider =>
{
    RedisOptions redisOptions = provider.GetRequiredService<IOptions<RedisOptions>>().Value;
    return ConnectionMultiplexer.Connect(redisOptions.Host,
        options => { options.Password = redisOptions.Password; });
});
builder.Services.AddTransient<IDatabase>(
    provider => provider.GetRequiredService<IConnectionMultiplexer>().GetDatabase());

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDefaultExceptionHandler();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseFastEndpoints(options =>
{
    options.Errors.ResponseBuilder = (errors, _, _) => errors.ToResponse();
    options.Errors.StatusCode = StatusCodes.Status422UnprocessableEntity;
    options.Serializer.Options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3(x => x.ConfigureDefaults());
}

{
    // Initialize sources and update DB
    List<ISource> sources = app.Services.GetRequiredService<IEnumerable<ISource>>().ToList();
    IMongoCollection<SourceDocument> sourceCollection =
        app.Services.GetRequiredService<IMongoCollection<SourceDocument>>();

    List<SourceDocument> existingSources = await sourceCollection.Find(x => true).ToListAsync();

    foreach (ISource source in sources)
    {
        await source.Initialize();

        if (existingSources.Any(x => x.Identifier == source.Identifier))
        {
            continue;
        }

        SourceDocument document = new() { Identifier = source.Identifier, Name = source.Name, Url = source.Url };
        await sourceCollection.InsertOneAsync(document);
    }

    foreach (SourceDocument existingSource in existingSources)
    {
        if (sources.All(x => x.Identifier != existingSource.Identifier))
        {
            await sourceCollection.DeleteOneAsync(x => x.Identifier == existingSource.Identifier);
        }
    }
}

{
    ISchedulerFactory schedulerFactory = app.Services.GetRequiredService<ISchedulerFactory>();
    IScheduler scheduler = await schedulerFactory.GetScheduler();

    ITrigger indexMangaTrigger = TriggerBuilder.Create()
        .WithIdentity("LaunchIndexMangaSchedulerJob")
        .WithDescription("(Initial) Check for new chapters")
        .ForJob(IndexMangaSchedulerJob.JobKey)
        .StartAt(DateTimeOffset.UtcNow.AddSeconds(15))
        .Build();

    await scheduler.ScheduleJob(indexMangaTrigger);

    ITrigger downloadChapterTrigger = TriggerBuilder.Create()
        .WithIdentity("LaunchDownloadChapterSchedulerJob")
        .WithDescription("(Initial) Download requested chapters")
        .ForJob(DownloadChapterSchedulerJob.JobKey)
        .StartAt(DateTimeOffset.UtcNow.AddSeconds(30))
        .Build();

    await scheduler.ScheduleJob(downloadChapterTrigger);
}

await app.RunAsync();

namespace Mangarr.Backend
{
    public class Program
    {
    }
}
