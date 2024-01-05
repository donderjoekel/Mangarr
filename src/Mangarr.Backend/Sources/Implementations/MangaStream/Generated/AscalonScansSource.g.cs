// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class AscalonScansSource : MangaStreamSourceBase
{
    protected override string Id => "ascalonscans";
    protected override string Name => "AscalonScans";
    protected override string Url => "https://ascalonscans.com";
    protected override bool HasCloudflareProtection => false;

    public AscalonScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
