// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class NightScansSource : MangaStreamSourceBase
{
    protected override string Id => "nightscans";
    protected override string Name => "Night Scans";
    protected override string Url => "https://nightscans.net";
    protected override bool HasCloudflareProtection => false;

    public NightScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
