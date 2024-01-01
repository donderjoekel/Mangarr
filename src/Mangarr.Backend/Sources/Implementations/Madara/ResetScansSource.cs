using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ResetScansSource : MadaraSourceBase
{
    protected override string Id => "resetscans";
    protected override string Name => "Reset Scans";
    protected override string Url => "https://reset-scans.us";
    protected override bool UseAjaxChapterListMethod => true;

    public ResetScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
