// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwaxSource : MangaStreamSourceBase
{
    protected override string Id => "manhwax";
    protected override string Name => "Manhwax";
    protected override string Url => "https://manhwax.org";
    protected override bool HasCloudflareProtection => false;

    public ManhwaxSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
