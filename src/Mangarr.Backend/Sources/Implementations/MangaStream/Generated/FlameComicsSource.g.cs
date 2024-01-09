// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Caching;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class FlameComicsSource : MangaStreamSourceBase
{
    protected override string Id => "flamecomics";
    protected override string Name => "Flame Comics";
    protected override string Url => "https://flamecomics.com";
    protected override bool HasCloudflareProtection => false;

    public FlameComicsSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
