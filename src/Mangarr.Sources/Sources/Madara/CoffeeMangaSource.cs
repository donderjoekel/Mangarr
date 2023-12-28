using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class CoffeeMangaSource : MadaraSourceBase
{
    protected override string Id => "coffeemanga";
    protected override string Name => "Coffee Manga";
    protected override string Url => "https://coffeemanga.io";
    protected override bool UseAjaxChapterListMethod => true;

    public CoffeeMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
