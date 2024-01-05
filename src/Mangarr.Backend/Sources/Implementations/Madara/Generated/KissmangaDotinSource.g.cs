// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class KissmangaDotinSource : MadaraSourceBase
{
    protected override string Id => "kissmanga.in";
    protected override string Name => "Kissmanga.in";
    protected override string Url => "https://kissmanga.in";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => true;
    protected override bool UseIdChapterListMethod => false;

    public KissmangaDotinSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
