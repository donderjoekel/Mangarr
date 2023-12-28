using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class LilyMangaSource : MadaraSourceBase
{
    protected override string Id => "lilymanga";
    protected override string Name => "Lily Manga";
    protected override string Url => "https://lilymanga.net";
    protected override bool UseAjaxChapterListMethod => true;
    protected override bool HasCloudflareProtection => true;

    public LilyMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
