using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class LuminousScansSource : MangaStreamSourceBase
{
    public LuminousScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected override string Id => "luminousscans";
    protected override string Name => "Luminous Scans";
    protected override string Url => "https://luminousscans.net";
}
