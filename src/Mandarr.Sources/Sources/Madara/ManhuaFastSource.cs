using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhuaFastSource : MadaraSourceBase
{
    protected override string Id => "manhuafast";
    protected override string Name => "Manhua Fast";
    protected override string Url => "https://manhuafast.com";
    protected override bool UseAjaxChapterListMethod => true;

    public ManhuaFastSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
