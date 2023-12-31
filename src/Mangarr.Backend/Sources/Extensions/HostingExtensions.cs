using Mangarr.Backend.Configuration;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Caching;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Cloudflare;
using Microsoft.Extensions.Options;

namespace Mangarr.Backend.Sources.Extensions;

public static class HostingExtensions
{
    public static IServiceCollection ConfigureSources(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<FlareSolverrOptions>(configuration.GetSection(FlareSolverrOptions.SECTION));
        return services;
    }

    public static IServiceCollection AddSources(this IServiceCollection services)
    {
        services.AddTransient<CachingHandler>(provider =>
            new CachingHandler(provider.GetRequiredService<CachingService>()));

        services.AddHttpClient("Generic")
            .AddRetryPolicy()
            .AddHttpMessageHandler<CachingHandler>();

        services.AddTransient<CustomClearanceHandler>(provider =>
        {
            FlareSolverrOptions options = provider.GetRequiredService<IOptions<FlareSolverrOptions>>().Value;
            return new CustomClearanceHandler(options.Host);
        });

        services.AddHttpClient("Cloudflare")
            .AddRetryPolicy()
            .AddHttpMessageHandler<CachingHandler>()
            .AddHttpMessageHandler<CustomClearanceHandler>();

        services.AddMangarrBackend();
        return services;
    }
}
