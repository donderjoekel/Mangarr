using System.Text.Json;
using FastEndpoints.Swagger;
using IdGen.DependencyInjection;
using Mandarr.Backend.Configuration;
using Mandarr.Backend.Database;
using Mandarr.Backend.Database.Documents;
using Mandarr.Backend.Extensions;
using Mandarr.Backend.Services;
using Mandarr.Backend.Workers;
using Mandarr.Backend.Workers.Processors;
using Mandarr.Sources;
using Mandarr.Sources.Clients;
using Mandarr.Sources.Cloudflare;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Serilog;
using StackExchange.Redis;
using ExportOptions = Mandarr.Backend.Configuration.ExportOptions;

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

builder.Services.AddHostedService<MainWorker>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.Configure<AniListOptions>(builder.Configuration.GetSection(AniListOptions.SECTION));
builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));
builder.Services.Configure<FlareSolverrOptions>(builder.Configuration.GetSection(FlareSolverrOptions.SECTION));
builder.Services.Configure<MongoOptions>(builder.Configuration.GetSection(MongoOptions.SECTION));
builder.Services.Configure<RedisOptions>(builder.Configuration.GetSection(RedisOptions.SECTION));

builder.Services.AddSingleton<AniListService>();
builder.Services.AddSingleton<ArchiveService>();
builder.Services.AddSingleton<CachingService>();
builder.Services.AddSingleton<ComicInfoService>();
builder.Services.AddSingleton<CoverImageService>();
builder.Services.AddSingleton<ExportService>();
builder.Services.AddSingleton<PageDownloaderService>();
builder.Services.AddSingleton<MangaProcessor>();
builder.Services.AddSingleton<NotificationService>();
builder.Services.AddSingleton<ChapterProcessor>();
builder.Services.AddHttpClient("Generic").AddRetryPolicy();
builder.Services.AddTransient<CustomClearanceHandler>(provider =>
{
    FlareSolverrOptions flareSolverrOptions = provider.GetRequiredService<IOptions<FlareSolverrOptions>>().Value;
    return new CustomClearanceHandler(flareSolverrOptions.Host);
});
builder.Services.AddHttpClient("Cloudflare").AddHttpMessageHandler<CustomClearanceHandler>().AddRetryPolicy();
builder.Services.AddMandarrSources();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddFastEndpoints(options =>
{
    // options.SourceGeneratorDiscoveredTypes.Insert(0, null);
});
builder.Services.AddSwaggerDoc(addJwtBearerAuth: false);
builder.Services.AddIdGen(0);
builder.Services.AddTransient<IMongoClient>(provider =>
{
    MongoOptions mongoOptions = provider.GetRequiredService<IOptions<MongoOptions>>().Value;
    return new MongoClient($"mongodb://{mongoOptions.Username}:{mongoOptions.Password}@{mongoOptions.Host}");
});
// new MongoClient("mongodb://password:admin@localhost:27017")); // TODO: Should come from configuration
builder.Services.AddSingleton<CollectionFactory>();
builder.Services.AddSingleton(typeof(IMongoCollection<>), typeof(MongoCollection<>));
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
    // Update providers in DB
    List<ISource> providers = app.Services.GetRequiredService<IEnumerable<ISource>>().ToList();
    IMongoCollection<ProviderDocument> providerCollection =
        app.Services.GetRequiredService<IMongoCollection<ProviderDocument>>();

    List<ProviderDocument> existingProviders = await providerCollection.Find(x => true).ToListAsync();

    foreach (ISource provider in providers)
    {
        if (existingProviders.Any(x => x.Identifier == provider.Identifier))
        {
            continue;
        }

        ProviderDocument document = new()
        {
            Identifier = provider.Identifier, Name = provider.Name, Url = provider.Url
        };

        await providerCollection.InsertOneAsync(document);
    }

    foreach (ProviderDocument existingProvider in existingProviders)
    {
        if (providers.All(x => x.Identifier != existingProvider.Identifier))
        {
            await providerCollection.DeleteOneAsync(x => x.Identifier == existingProvider.Identifier);
        }
    }
}

await app.RunAsync();

namespace Mandarr.Backend
{
    public partial class Program
    {
    }
}
