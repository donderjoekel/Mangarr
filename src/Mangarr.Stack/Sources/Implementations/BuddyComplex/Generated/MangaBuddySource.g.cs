// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Sources;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Implementations.BuddyComplex;

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
