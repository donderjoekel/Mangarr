using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.MangaStream;

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
