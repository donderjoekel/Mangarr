using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AquaMangaSource : MadaraSourceBase
{
    protected override string Id => "aquamanga";
    protected override string Name => "Aqua Manga";
    protected override string Url => "https://aquamanga.org";

    public AquaMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
