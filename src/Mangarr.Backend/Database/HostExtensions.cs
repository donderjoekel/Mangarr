using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Mangarr.Backend.Database;

public static class HostExtensions
{
    public static void AddMangarrDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<MongoOptions>(builder.Configuration.GetSection(MongoOptions.SECTION));
        builder.Services.AddTransient<IMongoClient>(provider =>
        {
            MongoOptions mongoOptions = provider.GetRequiredService<IOptions<MongoOptions>>().Value;
            return new MongoClient($"mongodb://{mongoOptions.Username}:{mongoOptions.Password}@{mongoOptions.Host}");
        });

        builder.Services.AddSingleton<CollectionFactory>();
        builder.Services.AddSingleton(typeof(IMongoCollection<>), typeof(MongoCollection<>));
    }
}
