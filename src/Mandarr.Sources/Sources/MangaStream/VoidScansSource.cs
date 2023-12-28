using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class VoidScansSource : MangaStreamSourceBase
{
    protected override string Id => "voidscans";
    protected override string Name => "Void Scans";
    protected override string Url => "https://void-scans.com";

    public VoidScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
