// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaSeeSource : NepNepSourceBase
{
    protected override string Id => "mangasee";
    protected override string Name => "Manga See";
    protected override string Url => "https://mangasee123.com";
    protected override bool HasCloudflareProtection => false;

    public MangaSeeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
