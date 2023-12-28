using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class KunMangaSource : MadaraSourceBase
{
    protected override string Id => "kunmanga";
    protected override string Name => "Kun Manga";
    protected override string Url => "https://kunmanga.com";

    public KunMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
