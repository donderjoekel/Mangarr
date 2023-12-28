using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class HiperDexSource : MadaraSourceBase
{
    protected override string Id => "hiperdex";
    protected override string Name => "Hiper Dex";
    protected override string Url => "https://hiperdex.com";
    protected override bool UseAjaxChapterListMethod => true;

    public HiperDexSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
