// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AscalonScansSource : MangaStreamSourceBase
{
    protected override string Id => "ascalonscans";
    protected override string Name => "AscalonScans";
    protected override string Url => "https://ascalonscans.com";
    protected override bool HasCloudflareProtection => false;

    public AscalonScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
