// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class QuantumScansSource : MangaStreamSourceBase
{
    protected override string Id => "quantumscans";
    protected override string Name => "Quantum Scans";
    protected override string Url => "https://readers-point.space";
    protected override bool HasCloudflareProtection => false;

    public QuantumScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
