using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

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
