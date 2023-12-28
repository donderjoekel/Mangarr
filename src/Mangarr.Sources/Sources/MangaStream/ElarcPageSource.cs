using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ElarcPageSource : MangaStreamSourceBase
{
    protected override string Id => "elarcpage";
    protected override string Name => "Elarc Toon";
    protected override string Url => "https://elarctoon.com";

    public ElarcPageSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
