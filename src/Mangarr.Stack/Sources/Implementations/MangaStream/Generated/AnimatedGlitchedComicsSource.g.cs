// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AnimatedGlitchedComicsSource : MangaStreamSourceBase
{
    protected override string Id => "animatedglitchedcomics";
    protected override string Name => "Animated Glitched Comics";
    protected override string Url => "https://agscomics.com";
    protected override bool HasCloudflareProtection => false;

    public AnimatedGlitchedComicsSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
