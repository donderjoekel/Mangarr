using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

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
