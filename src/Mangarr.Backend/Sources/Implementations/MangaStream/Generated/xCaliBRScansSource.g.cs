// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class xCaliBRScansSource : MangaStreamSourceBase
{
    protected override string Id => "xcalibr";
    protected override string Name => "xCaliBR Scans";
    protected override string Url => "https://xcalibrscans.com";
    protected override bool HasCloudflareProtection => false;

    public xCaliBRScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
