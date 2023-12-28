using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class FlameComicsSource : MangaStreamSourceBase
{
    protected override string Id => "flamecomics";
    protected override string Name => "Flame Comics";
    protected override string Url => "https://flamecomics.com";

    public FlameComicsSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
