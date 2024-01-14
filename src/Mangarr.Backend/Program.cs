using System.Text.Json;
using FastEndpoints.Swagger;
using IdGen.DependencyInjection;
using Mangarr.Backend.AniList;
using Mangarr.Backend.Caching;
using Mangarr.Backend.Extensions;
using Mangarr.Backend.Initialization;
using Mangarr.Backend.Jobs;
using Mangarr.Backend.Logging;
using Mangarr.Backend.Notifications;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources;
using ExportOptions = Mangarr.Backend.Configuration.ExportOptions;

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

builder.Services.AddTransient<IInitializer, SourceInitializer>();
builder.Services.AddTransient<IInitializer, JobsInitializer>();

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

IEnumerable<IInitializer> initializers =
    app.Services.GetRequiredService<IEnumerable<IInitializer>>().OrderBy(x => x.Order);

foreach (IInitializer initializer in initializers)
{
    await initializer.Initialize();
}

await app.RunAsync();
