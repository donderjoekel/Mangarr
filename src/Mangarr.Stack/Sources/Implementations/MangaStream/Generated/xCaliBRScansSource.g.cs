// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

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
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
