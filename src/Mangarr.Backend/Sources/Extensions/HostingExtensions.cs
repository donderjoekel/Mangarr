using Mangarr.Backend.Configuration;
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
        services.AddHttpClient("Generic").AddRetryPolicy();

        services.AddTransient<CustomClearanceHandler>(provider =>
        {
            FlareSolverrOptions options = provider.GetRequiredService<IOptions<FlareSolverrOptions>>().Value;
            return new CustomClearanceHandler(options.Host);
        });

        services.AddHttpClient("Cloudflare").AddRetryPolicy().AddHttpMessageHandler<CustomClearanceHandler>();

        services.AddMangarrBackend();
        return services;
    }
}
