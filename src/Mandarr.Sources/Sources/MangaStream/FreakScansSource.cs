using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class FreakScansSource : MangaStreamSourceBase
{
    protected override string Id => "freakscans";
    protected override string Name => "Freak Scans";
    protected override string Url => "https://freakscans.com";

    public FreakScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
