using Mangarr.Backend.Configuration;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;

namespace Mangarr.Backend.Logging;

public static class HostExtensions
{
    public static void AddMangarrLogging(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<SeqOptions>(builder.Configuration.GetSection(SeqOptions.SECTION));
        builder.Services.AddSerilog((provider, configuration) =>
        {
            SeqOptions seqOptions = provider.GetRequiredService<IOptions<SeqOptions>>().Value;

            if (!string.IsNullOrEmpty(seqOptions.Host))
            {
                configuration
                    .Enrich.WithProperty("Application", "Mangarr")
                    .Enrich.FromLogContext()
                    .WriteTo.Seq(seqOptions.Host,
                        apiKey: seqOptions.Key,
                        restrictedToMinimumLevel: LogEventLevel.Information);
            }

            configuration
                .WriteTo.Console(LogEventLevel.Debug);
        });
    }
}
