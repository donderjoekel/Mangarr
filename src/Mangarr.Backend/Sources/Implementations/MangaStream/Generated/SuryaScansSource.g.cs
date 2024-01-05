// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class SuryaScansSource : MangaStreamSourceBase
{
    protected override string Id => "suryascans";
    protected override string Name => "Surya Scans";
    protected override string Url => "https://suryacomics.com";
    protected override bool HasCloudflareProtection => false;

    public SuryaScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
