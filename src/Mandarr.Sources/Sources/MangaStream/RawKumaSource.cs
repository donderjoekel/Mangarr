using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class RawKumaSource : MangaStreamSourceBase
{
    protected override string Id => "rawkuma";
    protected override string Name => "Raw Kuma";
    protected override string Url => "https://rawkuma.com";

    public RawKumaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
