using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ZinMangaSource : MadaraSourceBase
{
    protected override string Id => "zinmanga";
    protected override string Name => "Zin Manga";
    protected override string Url => "https://zinmanga.com";

    public ZinMangaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
