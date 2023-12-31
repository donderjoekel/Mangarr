using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class PlatinumScansSource : MadaraSourceBase
{
    protected override string Id => "platinumscans";
    protected override string Name => "Platinum Scans";
    protected override string Url => "https://platinumscans.com";
    protected override bool UseIdChapterListMethod => true;

    public PlatinumScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
