// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ToonilymeSource : BuddyComplexSourceBase
{
    protected override string Id => "toonily.me";
    protected override string Name => "Toonily.me";
    protected override string Url => "https://toonily.me";
    protected override bool HasCloudflareProtection => false;

    public ToonilymeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
