using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwaTubeSource : BuddyComplexSourceBase
{
    protected override string Id => "manhwatube";
    protected override string Name => "Manhwa Tube";
    protected override string Url => "https://manhwatube.com";

    public ManhwaTubeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
