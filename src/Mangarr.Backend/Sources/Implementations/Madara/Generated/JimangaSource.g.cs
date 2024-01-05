// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class JimangaSource : MadaraSourceBase
{
    protected override string Id => "jimanga";
    protected override string Name => "Jimanga";
    protected override string Url => "https://s2manga.io";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => true;
    protected override bool UseIdChapterListMethod => false;

    public JimangaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
