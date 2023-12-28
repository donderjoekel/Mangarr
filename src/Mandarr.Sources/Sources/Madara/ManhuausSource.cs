using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhuausSource : MadaraSourceBase
{
    protected override string Id => "manhuaus";
    protected override string Name => "Manhuaus";
    protected override string Url => "https://manhuaus.com";

    public ManhuausSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
