using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaLifeSource : NepNepSourceBase
{
    protected override string Id => "mangalife";
    protected override string Name => "MangaLife";
    protected override string Url => "https://manga4life.com";

    public MangaLifeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
