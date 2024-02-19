using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace Mangarr.Stack.Caching;

public static class HostExtensions
{
    public static void AddMangarrCaching(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<RedisOptions>(builder.Configuration.GetSection(RedisOptions.SECTION));
        builder.Services.AddSingleton<ICachingService, CachingService>();
        builder.Services.AddSingleton<IConnectionMultiplexer>(provider =>
        {
            RedisOptions redisOptions = provider.GetRequiredService<IOptions<RedisOptions>>().Value;
            return ConnectionMultiplexer.Connect(redisOptions.Host,
                options => { options.Password = redisOptions.Password; });
        });
        builder.Services.AddTransient<IDatabase>(
            provider => provider.GetRequiredService<IConnectionMultiplexer>().GetDatabase());
    }
}
