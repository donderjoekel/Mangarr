using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class BibiMangaSource : MadaraSourceBase
{
    protected override string Id => "bibimanga";
    protected override string Name => "Bibi Manga";
    protected override string Url => "https://bibimanga.com";

    public BibiMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
