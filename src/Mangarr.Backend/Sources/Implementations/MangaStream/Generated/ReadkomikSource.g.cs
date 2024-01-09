// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Caching;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ReadkomikSource : MangaStreamSourceBase
{
    protected override string Id => "readkomik";
    protected override string Name => "Readkomik";
    protected override string Url => "https://readkomik.com";
    protected override bool HasCloudflareProtection => false;

    public ReadkomikSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
