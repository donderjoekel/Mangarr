// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaLifeSource : NepNepSourceBase
{
    protected override string Id => "mangalife";
    protected override string Name => "Manga Life";
    protected override string Url => "https://manga4life.com";
    protected override bool HasCloudflareProtection => false;

    public MangaLifeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
