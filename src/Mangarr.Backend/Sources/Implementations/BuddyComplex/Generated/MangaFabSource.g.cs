// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaFabSource : BuddyComplexSourceBase
{
    protected override string Id => "mangafab";
    protected override string Name => "MangaFab";
    protected override string Url => "https://mangacute.com";
    protected override bool HasCloudflareProtection => false;

    public MangaFabSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
