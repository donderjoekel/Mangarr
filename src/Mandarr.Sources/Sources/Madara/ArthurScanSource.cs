using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ArthurScanSource : MadaraSourceBase
{
    protected override string Id => "arthurscans";
    protected override string Name => "Arthur Scans";
    protected override string Url => "https://arthurscan.xyz";
    protected override bool UseAjaxChapterListMethod => true;

    public ArthurScanSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
