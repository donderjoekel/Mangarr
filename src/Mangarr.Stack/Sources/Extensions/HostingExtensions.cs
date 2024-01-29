using Mangarr.Stack.Configuration;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Cloudflare;
using Microsoft.Extensions.Options;

namespace Mangarr.Stack.Sources.Extensions;

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

        services.AddMangarrStack();
        return services;
    }
}
