using System.Text.Json;
using FastEndpoints.Swagger;
using IdGen.DependencyInjection;
using Mangarr.Backend.AniList;
using Mangarr.Backend.Caching;
using Mangarr.Backend.Extensions;
using Mangarr.Backend.Jobs;
using Mangarr.Backend.Logging;
using Mangarr.Backend.Notifications;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources;
using MongoDB.Driver;
using Quartz;
using ExportOptions = Mangarr.Backend.Configuration.ExportOptions;
using ISource = Mangarr.Backend.Sources.ISource;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.AddServerHeader = false;
    options.AllowSynchronousIO = false;
});

builder.Host.UseConsoleLifetime(options => options.SuppressStatusMessages = true);

// builder.Services.AddHostedService<MainWorker>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));

builder.AddMangarrAniList();
builder.AddMangarrCaching();
builder.AddMangarrDatabase();
builder.AddMangarrLogging();
builder.AddMangarrJobs();
builder.AddMangarrNotifications();
builder.AddMangarrSources();

builder.Services.AddHttpClient();
builder.Services.AddSingleton<ArchiveService>();
builder.Services.AddSingleton<ComicInfoService>();
builder.Services.AddSingleton<CoverImageService>();
builder.Services.AddSingleton<ExportService>();
builder.Services.AddSingleton<PageDownloaderService>();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddFastEndpoints(options =>
{
    // options.SourceGeneratorDiscoveredTypes.Insert(0, null);
});
builder.Services.AddSwaggerDoc(addJwtBearerAuth: false);
builder.Services.AddIdGen(0);

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
