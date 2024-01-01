using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ImmortalUpdatesSource : MadaraSourceBase
{
    protected override string Id => "immortalupdates";
    protected override string Name => "Immortal Updates";
    protected override string Url => "https://immortalupdates.com";

    public ImmortalUpdatesSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
