// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class KaiScansSource : MangaStreamSourceBase
{
    protected override string Id => "kaiscans";
    protected override string Name => "Kai Scans";
    protected override string Url => "https://kaiscans.com";
    protected override bool HasCloudflareProtection => true;

    public KaiScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
