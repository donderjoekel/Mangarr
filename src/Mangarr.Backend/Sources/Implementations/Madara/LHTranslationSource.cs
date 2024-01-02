using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class LHTranslationSource : MadaraSourceBase
{
    protected override string Id => "lhtranslation";
    protected override string Name => "LH Translation";
    protected override string Url => "https://lhtranslation.net";
    protected override bool UseAjaxChapterListMethod => true;

    public LHTranslationSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
