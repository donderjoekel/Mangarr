// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Sources;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Implementations.BuddyComplex;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class BoxManhwaSource : BuddyComplexSourceBase
{
    protected override string Id => "boxmanhwa";
    protected override string Name => "BoxManhwa";
    protected override string Url => "https://boxmanhwa.com";
    protected override bool HasCloudflareProtection => false;

    public BoxManhwaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
