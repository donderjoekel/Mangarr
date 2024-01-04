using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class TooniTubeSource : BuddyComplexSourceBase
{
    protected override string Id => "toonitube";
    protected override string Name => "Tooni Tube";
    protected override string Url => "https://toonitube.com";

    public TooniTubeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
