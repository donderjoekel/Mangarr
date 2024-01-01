using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class HiperDexSource : MadaraSourceBase
{
    protected override string Id => "hiperdex";
    protected override string Name => "Hiper Dex";
    protected override string Url => "https://hiperdex.com";
    protected override bool UseAjaxChapterListMethod => true;

    public HiperDexSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
