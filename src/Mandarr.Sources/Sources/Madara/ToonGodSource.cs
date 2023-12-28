using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ToonGodSource : MadaraSourceBase
{
    protected override string Id => "toongod";
    protected override string Name => "Toon God";
    protected override string Url => "https://toongod.org";
    protected override bool HasCloudflareProtection => true;

    public ToonGodSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
