using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

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
