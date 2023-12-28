using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class XCalibrSource : MangaStreamSourceBase
{
    protected override string Id => "xcalibr";
    protected override string Name => "X Calibr Scans";
    protected override string Url => "https://xcalibrscans.com";

    public XCalibrSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
