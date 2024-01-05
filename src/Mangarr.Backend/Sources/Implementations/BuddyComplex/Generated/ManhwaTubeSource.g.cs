// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

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
