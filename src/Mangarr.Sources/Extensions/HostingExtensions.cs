using Mangarr.Sources.Clients;
using Mangarr.Sources.Cloudflare;
using Mangarr.Sources.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Mangarr.Sources.Extensions;

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
        services.AddHttpClient("Cloudflare").AddHttpMessageHandler<CustomClearanceHandler>().AddRetryPolicy();

        services.AddMangarrSources();
        return services;
    }
}
