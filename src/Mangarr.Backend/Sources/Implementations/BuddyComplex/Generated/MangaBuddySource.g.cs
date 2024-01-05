// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaBuddySource : BuddyComplexSourceBase
{
    protected override string Id => "mangabuddy";
    protected override string Name => "MangaBuddy";
    protected override string Url => "https://mangabuddy.com";
    protected override bool HasCloudflareProtection => false;

    public MangaBuddySource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
