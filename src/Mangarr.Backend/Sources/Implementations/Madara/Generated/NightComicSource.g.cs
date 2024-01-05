// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class NightComicSource : MadaraSourceBase
{
    protected override string Id => "nightcomic";
    protected override string Name => "Night Comic";
    protected override string Url => "https://www.nightcomic.com";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => false;
    protected override bool UseIdChapterListMethod => true;

    public NightComicSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
