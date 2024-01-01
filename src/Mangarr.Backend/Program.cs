using System.Text.Json;
using FastEndpoints.Swagger;
using IdGen.DependencyInjection;
using Mangarr.Backend.Configuration;
using Mangarr.Backend.Extensions;
using Mangarr.Backend.Jobs;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Extensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Quartz;
using Serilog;
using StackExchange.Redis;
using ExportOptions = Mangarr.Backend.Configuration.ExportOptions;
using ISource = Mangarr.Backend.Sources.ISource;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.AddServerHeader = false;
    options.AllowSynchronousIO = false;
});

builder.Host.UseSerilog((context, configuration) =>
{
    configuration
        .MinimumLevel.Debug()
        .WriteTo.Console();
});

builder.Host.UseConsoleLifetime(options => options.SuppressStatusMessages = true);

// builder.Services.AddHostedService<MainWorker>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.Configure<AniListOptions>(builder.Configuration.GetSection(AniListOptions.SECTION));
builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));
builder.Services.Configure<RedisOptions>(builder.Configuration.GetSection(RedisOptions.SECTION));

builder.Services.AddQuartz(options =>
{
    options.UseDefaultThreadPool(3);

    options.AddJob<CacheSourceSchedulerJob>(CacheSourceSchedulerJob.JobKey);
    options.AddJob<CacheSourceJob>(CacheSourceJob.JobKey, configure => configure.StoreDurably());

    options.AddJob<IndexMangaSchedulerJob>(IndexMangaSchedulerJob.JobKey);
    options.AddJob<IndexMangaJob>(IndexMangaJob.JobKey, configure => configure.StoreDurably());

    options.AddJob<DownloadChapterSchedulerJob>(DownloadChapterSchedulerJob.JobKey);
    options.AddJob<DownloadChapterJob>(DownloadChapterJob.JobKey, configure => configure.StoreDurably());

    options.AddTrigger(configure =>
    {
        configure
            .WithIdentity("CacheSourceSchedulerJob")
            .ForJob(CacheSourceSchedulerJob.JobKey)
            .StartNow()
            .WithCronSchedule("0 0/30 0 ? * * *");
    });

    options.AddTrigger(configure =>
    {
        configure
            .WithIdentity("IndexMangaSchedulerJob")
            .ForJob(IndexMangaSchedulerJob.JobKey)
            .StartNow()
            .WithCronSchedule("0 0 * ? * * *");
    });

    options.AddTrigger(configure =>
    {
        configure
            .WithIdentity("DownloadChapterSchedulerJob")
            .ForJob(DownloadChapterSchedulerJob.JobKey)
            .StartNow()
            .WithCronSchedule("0 0/20 * ? * * *");
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

await app.RunAsync();

namespace Mangarr.Backend
{
    public class Program
    {
    }
}
