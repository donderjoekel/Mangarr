using Mangarr.Stack.Configuration;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Cloudflare;
using Microsoft.Extensions.Options;

namespace Mangarr.Stack.Sources;

public static class HostExtensions
{
    public static void AddMangarrSources(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<FlareSolverrOptions>(builder.Configuration.GetSection(FlareSolverrOptions.SECTION));

        builder.Services.AddSingleton<SourceProvider>();
        builder.Services.AddTransient<CustomClearanceHandler>(provider =>
        {
            FlareSolverrOptions options = provider.GetRequiredService<IOptions<FlareSolverrOptions>>().Value;
            return new CustomClearanceHandler(options.Host);
        });
        builder.Services.AddHttpClient("Generic").AddRetryPolicy();
        builder.Services.AddHttpClient("Cloudflare").AddRetryPolicy().AddHttpMessageHandler<CustomClearanceHandler>();
        builder.Services.AddMangarrStack();
    }
}
