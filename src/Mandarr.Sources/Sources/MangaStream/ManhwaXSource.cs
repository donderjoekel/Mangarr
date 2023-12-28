using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManwhaXSource : MangaStreamSourceBase
{
    protected override string Id => "manhwax";
    protected override string Name => "Manhwa X";
    protected override string Url => "https://manhwax.org";

    public ManwhaXSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
