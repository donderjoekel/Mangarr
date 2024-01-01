using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AquaMangaSource : MadaraSourceBase
{
    protected override string Id => "aquamanga";
    protected override string Name => "Aqua Manga";
    protected override string Url => "https://aquamanga.org";

    protected override bool UseAjaxChapterListMethod => true;

    public AquaMangaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
