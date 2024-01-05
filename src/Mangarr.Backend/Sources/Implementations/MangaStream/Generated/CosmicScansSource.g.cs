// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class CosmicScansSource : MangaStreamSourceBase
{
    protected override string Id => "cosmicscans";
    protected override string Name => "Cosmic Scans";
    protected override string Url => "https://cosmic-scans.com";
    protected override bool HasCloudflareProtection => false;

    public CosmicScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
