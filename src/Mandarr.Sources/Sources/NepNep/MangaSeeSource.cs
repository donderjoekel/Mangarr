using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaSeeSource : NepNepSourceBase
{
    protected override string Id => "mangasee";
    protected override string Name => "MangaSee";
    protected override string Url => "https://mangasee123.com";

    public MangaSeeSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
