using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class SinensisScansSource : MadaraSourceBase
{
    protected override string Id => "sinensisscans";
    protected override string Name => "Sinensis Scans";
    protected override string Url => "https://sinensisscans.com";
    protected override bool UseAjaxChapterListMethod => true;

    public SinensisScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
