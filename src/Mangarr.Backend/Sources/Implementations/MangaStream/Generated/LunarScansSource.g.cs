// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class LunarScansSource : MangaStreamSourceBase
{
    protected override string Id => "lunarscans";
    protected override string Name => "Lunar Scans";
    protected override string Url => "https://lunarscan.org";
    protected override bool HasCloudflareProtection => false;

    public LunarScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
