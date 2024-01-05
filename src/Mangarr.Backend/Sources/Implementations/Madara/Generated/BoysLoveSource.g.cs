// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class BoysLoveSource : MadaraSourceBase
{
    protected override string Id => "boyslove";
    protected override string Name => "BoysLove";
    protected override string Url => "https://boyslove.me";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => false;
    protected override bool UseIdChapterListMethod => true;

    public BoysLoveSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
