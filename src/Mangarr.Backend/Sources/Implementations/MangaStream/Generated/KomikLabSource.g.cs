// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class KomikLabSource : MangaStreamSourceBase
{
    protected override string Id => "komiklab";
    protected override string Name => "Komik Lab";
    protected override string Url => "https://komiklab.com";
    protected override bool HasCloudflareProtection => false;

    public KomikLabSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
