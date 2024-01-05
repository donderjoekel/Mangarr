// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class RavenScansSource : MangaStreamSourceBase
{
    protected override string Id => "ravenscans";
    protected override string Name => "Raven Scans";
    protected override string Url => "https://ravenscans.com";
    protected override bool HasCloudflareProtection => false;

    public RavenScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
