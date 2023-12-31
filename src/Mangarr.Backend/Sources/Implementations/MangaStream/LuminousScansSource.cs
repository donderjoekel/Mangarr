using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

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
