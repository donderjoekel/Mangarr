using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ImmortalUpdatesSource : MadaraSourceBase
{
    protected override string Id => "immortalupdates";
    protected override string Name => "Immortal Updates";
    protected override string Url => "https://immortalupdates.com";

    public ImmortalUpdatesSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
