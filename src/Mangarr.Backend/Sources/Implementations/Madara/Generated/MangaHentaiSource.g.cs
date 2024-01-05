// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaHentaiSource : MadaraSourceBase
{
    protected override string Id => "mangahentai";
    protected override string Name => "Manga Hentai";
    protected override string Url => "https://mangahentai.me";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => true;
    protected override bool UseIdChapterListMethod => false;

    public MangaHentaiSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
