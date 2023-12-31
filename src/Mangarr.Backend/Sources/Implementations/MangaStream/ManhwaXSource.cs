using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

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
