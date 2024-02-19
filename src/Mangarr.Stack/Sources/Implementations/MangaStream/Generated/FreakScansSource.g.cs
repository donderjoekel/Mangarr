// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class FreakScansSource : MangaStreamSourceBase
{
    protected override string Id => "freakscans";
    protected override string Name => "Freak Scans";
    protected override string Url => "https://freakscans.com";
    protected override bool HasCloudflareProtection => false;

    public FreakScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
