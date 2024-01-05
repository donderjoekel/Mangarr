// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class BeeHentaiSource : BuddyComplexSourceBase
{
    protected override string Id => "beehentai";
    protected override string Name => "BeeHentai";
    protected override string Url => "https://beehentai.com";
    protected override bool HasCloudflareProtection => false;

    public BeeHentaiSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
