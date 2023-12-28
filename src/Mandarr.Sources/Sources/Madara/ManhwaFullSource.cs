using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwaFullSource : MadaraSourceBase
{
    protected override string Id => "manhwafull";
    protected override string Name => "Manhwa Full";
    protected override string Url => "https://manhwafull.com";

    public ManhwaFullSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
