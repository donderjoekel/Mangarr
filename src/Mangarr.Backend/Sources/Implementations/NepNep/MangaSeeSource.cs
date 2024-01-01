using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.NepNep;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaSeeSource : NepNepSourceBase
{
    protected override string Id => "mangasee";
    protected override string Name => "MangaSee";
    protected override string Url => "https://mangasee123.com";

    public MangaSeeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
