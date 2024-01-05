// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class Manhwa18DotappSource : MadaraSourceBase
{
    protected override string Id => "manhwa18.app";
    protected override string Name => "Manhwa18.app";
    protected override string Url => "https://manhwa18.app";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => false;
    protected override bool UseIdChapterListMethod => true;

    public Manhwa18DotappSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
