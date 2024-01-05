// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaForestSource : BuddyComplexSourceBase
{
    protected override string Id => "mangaforest";
    protected override string Name => "MangaForest";
    protected override string Url => "https://mangaforest.me";
    protected override bool HasCloudflareProtection => false;

    public MangaForestSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
