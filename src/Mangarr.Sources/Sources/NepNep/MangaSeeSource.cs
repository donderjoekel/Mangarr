using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.NepNep;

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
