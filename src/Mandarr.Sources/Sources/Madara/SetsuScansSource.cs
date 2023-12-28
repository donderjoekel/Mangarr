using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class SetsuScansSource : MadaraSourceBase
{
    protected override string Id => "setsuscans";
    protected override string Name => "Setsu Scans";
    protected override string Url => "https://setsuscans.com";
    protected override bool UseAjaxChapterListMethod => true;

    public SetsuScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
