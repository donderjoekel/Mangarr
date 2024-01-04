using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ToonilyMeSource : BuddyComplexSourceBase
{
    protected override string Id => "toonilyme";
    protected override string Name => "Toonily Me";
    protected override string Url => "https://toonily.me";

    public ToonilyMeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
