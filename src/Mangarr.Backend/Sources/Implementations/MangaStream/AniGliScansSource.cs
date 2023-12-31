using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AniGliScansSource : MangaStreamSourceBase
{
    protected override string Id => "anigliscans";
    protected override string Name => "Animated Glitch Scans";
    protected override string Url => "https://anigliscans.xyz";

    public AniGliScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
