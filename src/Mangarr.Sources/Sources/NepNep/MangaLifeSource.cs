using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaLifeSource : NepNepSourceBase
{
    protected override string Id => "mangalife";
    protected override string Name => "MangaLife";
    protected override string Url => "https://manga4life.com";

    public MangaLifeSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
