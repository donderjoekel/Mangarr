// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwatopSource : MadaraSourceBase
{
    protected override string Id => "manhwatop";
    protected override string Name => "Manhwatop";
    protected override string Url => "https://manhwatop.com";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => false;
    protected override bool UseIdChapterListMethod => true;

    public ManhwatopSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
