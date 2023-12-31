using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AsuraScansSource : MangaStreamSourceBase
{
    protected override string Id => "asurascans";
    protected override string Name => "Asura Toons";
    protected override string Url => "https://asuratoon.com";
    protected override bool HasCloudflareProtection => true;

    public AsuraScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
