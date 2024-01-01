using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class DarkScansSource : MadaraSourceBase
{
    protected override string Id => "darkscans";
    protected override string Name => "Dark Scans";
    protected override string Url => "https://darkscans.com";
    protected override bool UseAjaxChapterListMethod => true;

    public DarkScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
