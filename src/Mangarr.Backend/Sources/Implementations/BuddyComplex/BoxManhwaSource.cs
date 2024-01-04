using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class BoxManhwaSource : BuddyComplexSourceBase
{
    protected override string Id => "boxmanhwa";
    protected override string Name => "Box Manhwa";
    protected override string Url => "https://boxmanhwa.com";

    public BoxManhwaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
