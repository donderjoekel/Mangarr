using Mangarr.Backend.Configuration;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Cloudflare;
using Microsoft.Extensions.Options;

namespace Mangarr.Backend.Sources;

public static class HostExtensions
{
    public static void AddMangarrSources(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<FlareSolverrOptions>(builder.Configuration.GetSection(FlareSolverrOptions.SECTION));

        builder.Services.AddTransient<CustomClearanceHandler>(provider =>
        {
            FlareSolverrOptions options = provider.GetRequiredService<IOptions<FlareSolverrOptions>>().Value;
            return new CustomClearanceHandler(options.Host);
        });
        builder.Services.AddHttpClient("Generic").AddRetryPolicy();
        builder.Services.AddHttpClient("Cloudflare").AddRetryPolicy().AddHttpMessageHandler<CustomClearanceHandler>();
        builder.Services.AddMangarrBackend();
    }
}
