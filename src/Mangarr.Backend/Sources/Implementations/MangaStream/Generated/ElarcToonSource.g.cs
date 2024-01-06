// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ElarcToonSource : MangaStreamSourceBase
{
    protected override string Id => "elarcpage";
    protected override string Name => "Elarc Toon";
    protected override string Url => "https://elarctoon.com";
    protected override bool HasCloudflareProtection => false;

    public ElarcToonSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
