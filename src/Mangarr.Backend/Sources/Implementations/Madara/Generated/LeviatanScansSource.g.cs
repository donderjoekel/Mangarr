// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class LeviatanScansSource : MadaraSourceBase
{
    protected override string Id => "lscomic";
    protected override string Name => "Leviatan Scans";
    protected override string Url => "https://lscomic.com";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => true;
    protected override bool UseIdChapterListMethod => false;

    public LeviatanScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
