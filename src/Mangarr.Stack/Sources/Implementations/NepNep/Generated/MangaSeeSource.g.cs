// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;

namespace Mangarr.Stack.Sources.Implementations.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaSeeSource : NepNepSourceBase
{
    protected override string Id => "mangasee";
    protected override string Name => "Manga See";
    protected override string Url => "https://mangasee123.com";
    protected override bool HasCloudflareProtection => false;

    public MangaSeeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        ICachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory, cachingService)
    {
    }
}
