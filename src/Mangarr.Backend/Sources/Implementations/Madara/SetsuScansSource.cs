using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class SetsuScansSource : MadaraSourceBase
{
    protected override string Id => "setsuscans";
    protected override string Name => "Setsu Scans";
    protected override string Url => "https://setsuscans.com";
    protected override bool UseAjaxChapterListMethod => true;

    public SetsuScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
