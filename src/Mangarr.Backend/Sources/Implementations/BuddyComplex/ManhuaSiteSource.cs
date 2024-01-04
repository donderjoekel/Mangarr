using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhuaSiteSource : BuddyComplexSourceBase
{
    protected override string Id => "manhuasite";
    protected override string Name => "Manhua Site";
    protected override string Url => "https://manhuasite.com";

    public ManhuaSiteSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
