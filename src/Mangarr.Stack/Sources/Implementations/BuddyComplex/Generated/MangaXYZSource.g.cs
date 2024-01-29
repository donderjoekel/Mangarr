// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Sources;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Implementations.BuddyComplex;

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
