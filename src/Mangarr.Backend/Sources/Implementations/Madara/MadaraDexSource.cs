using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MadaraDexSource : MadaraSourceBase
{
    protected override string Id => "madaradex";
    protected override string Name => "Madara Dex";
    protected override string Url => "https://madaradex.org";
    protected override bool HasCloudflareProtection => true;

    public MadaraDexSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
