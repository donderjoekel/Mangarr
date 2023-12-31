using Mangarr.Backend.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Mangarr.Backend.Database;

public static class Extensions
{
    public static IServiceCollection ConfigureMongo(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoOptions>(configuration.GetSection(MongoOptions.SECTION));
        return services;
    }

    public static IServiceCollection AddMongo(this IServiceCollection services)
    {
        services.AddTransient<IMongoClient>(provider =>
        {
            MongoOptions mongoOptions = provider.GetRequiredService<IOptions<MongoOptions>>().Value;
            return new MongoClient($"mongodb://{mongoOptions.Username}:{mongoOptions.Password}@{mongoOptions.Host}");
        });

        services.AddSingleton<CollectionFactory>();
        services.AddSingleton(typeof(IMongoCollection<>), typeof(MongoCollection<>));

        return services;
    }
}
