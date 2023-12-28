using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ResetScansSource : MadaraSourceBase
{
    protected override string Id => "resetscans";
    protected override string Name => "Reset Scans";
    protected override string Url => "https://reset-scans.us";
    protected override bool UseAjaxChapterListMethod => true;

    public ResetScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
