using Mangarr.Stack.Database.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Mangarr.Stack.Database;

public static class HostExtensions
{
    public static void AddMangarrDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<MongoOptions>(builder.Configuration.GetSection(MongoOptions.SECTION));
        builder.Services.AddTransient<IMongoClient>(provider =>
        {
            MongoOptions mongoOptions = provider.GetRequiredService<IOptions<MongoOptions>>().Value;
            ConventionRegistry.Register(
                "My stuff",
                new ConventionPack { new IgnoreExtraElementsConvention(true) },
                _ => true);
            return new MongoClient($"mongodb://{mongoOptions.Username}:{mongoOptions.Password}@{mongoOptions.Host}");
        });

        builder.Services.AddSingleton<CollectionFactory>();
        builder.Services.AddSingleton(typeof(IMongoCollection<>), typeof(MongoCollection<>));

        builder.Services.AddSingleton<ChapterProgressRepository>();
        builder.Services.AddSingleton<IRepository>(provider =>
            provider.GetRequiredService<ChapterProgressRepository>());

        builder.Services.AddSingleton<MangaMetadataRepository>();
        builder.Services.AddSingleton<IRepository>(provider => provider.GetRequiredService<MangaMetadataRepository>());

        builder.Services.AddSingleton<RequestedMangaRepository>();
        builder.Services.AddSingleton<IRepository>(provider => provider.GetRequiredService<RequestedMangaRepository>());

        builder.Services.AddSingleton<RequestedChapterRepository>();
        builder.Services.AddSingleton<IRepository>(
            provider => provider.GetRequiredService<RequestedChapterRepository>());

        builder.Services.AddSingleton<RootFolderRepository>();
        builder.Services.AddSingleton<IRepository>(provider => provider.GetRequiredService<RootFolderRepository>());

        builder.Services.AddSingleton<SourceRepository>();
        builder.Services.AddSingleton<IRepository>(provider => provider.GetRequiredService<SourceRepository>());
    }
}
