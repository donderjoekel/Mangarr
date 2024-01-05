// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhuaSiteSource : BuddyComplexSourceBase
{
    protected override string Id => "manhuasite";
    protected override string Name => "ManhuaSite";
    protected override string Url => "https://manhuasite.com";
    protected override bool HasCloudflareProtection => false;

    public ManhuaSiteSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
