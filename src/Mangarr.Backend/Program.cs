using System.Text.Json;
using FastEndpoints.Swagger;
using Mangarr.Backend.AniList;
using Mangarr.Backend.Archival;
using Mangarr.Backend.Caching;
using Mangarr.Backend.Conversion;
using Mangarr.Backend.Cover;
using Mangarr.Backend.Downloading;
using Mangarr.Backend.Extensions;
using Mangarr.Backend.Initialization;
using Mangarr.Backend.Jobs;
using Mangarr.Backend.Logging;
using Mangarr.Backend.Notifications;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources;
using ExportOptions = Mangarr.Backend.Configuration.ExportOptions;

namespace Mangarr.Backend;

internal partial class Program
{
    public static async Task Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.WebHost.ConfigureKestrel(options =>
        {
            options.AddServerHeader = false;
            options.AllowSynchronousIO = false;
        });

        builder.Host.UseConsoleLifetime(options => options.SuppressStatusMessages = true);

        builder.Services.AddAutoMapper(typeof(Program).Assembly);

        builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));

        builder.AddMangarrAniList();
        builder.AddMangarrCaching();
        builder.AddMangarrConversion();
        builder.AddMangarrDatabase();
        builder.AddMangarrInitializers();
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
        builder.Services.AddFastEndpoints();
        builder.Services.AddSwaggerDoc(addJwtBearerAuth: false);

        if (builder.Environment.IsDevelopment())
        {
            AddDevelopmentServices(builder);
        }
        else
        {
            AddReleaseServices(builder);
        }

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
    }
}
