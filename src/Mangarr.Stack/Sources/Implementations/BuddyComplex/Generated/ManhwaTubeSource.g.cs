// Auto generated

using Injectio.Attributes;
using Mangarr.Stack.Sources;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Implementations.BuddyComplex;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwaTubeSource : BuddyComplexSourceBase
{
    protected override string Id => "manhwatube";
    protected override string Name => "ManhwaTube";
    protected override string Url => "https://manhwatube.com";
    protected override bool HasCloudflareProtection => false;

    public ManhwaTubeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
