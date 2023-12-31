using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class PianMangaSource : MadaraSourceBase
{
    protected override string Id => "pianmanga";
    protected override string Name => "Pian Manga";
    protected override string Url => "https://pianmanga.com";

    public PianMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
