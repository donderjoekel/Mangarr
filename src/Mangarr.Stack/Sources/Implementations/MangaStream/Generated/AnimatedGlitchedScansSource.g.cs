// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AnimatedGlitchedScansSource : MangaStreamSourceBase
{
    protected override string Id => "anigliscans";
    protected override string Name => "Animated Glitched Scans";
    protected override string Url => "https://anigliscans.xyz";
    protected override bool HasCloudflareProtection => false;

    public AnimatedGlitchedScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
