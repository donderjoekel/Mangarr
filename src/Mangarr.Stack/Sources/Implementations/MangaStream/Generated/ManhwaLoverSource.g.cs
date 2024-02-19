// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwaLoverSource : MangaStreamSourceBase
{
    protected override string Id => "manhwalover";
    protected override string Name => "Manhwa Lover";
    protected override string Url => "https://manhwalover.com";
    protected override bool HasCloudflareProtection => false;

    public ManhwaLoverSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
