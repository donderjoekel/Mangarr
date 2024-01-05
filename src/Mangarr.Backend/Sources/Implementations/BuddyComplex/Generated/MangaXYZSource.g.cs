// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaXYZSource : BuddyComplexSourceBase
{
    protected override string Id => "mangaxyz";
    protected override string Name => "MangaXYZ";
    protected override string Url => "https://mangaxyz.com";
    protected override bool HasCloudflareProtection => false;

    public MangaXYZSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
