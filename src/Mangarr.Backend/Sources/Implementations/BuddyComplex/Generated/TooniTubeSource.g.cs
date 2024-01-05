// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class TooniTubeSource : BuddyComplexSourceBase
{
    protected override string Id => "toonitube";
    protected override string Name => "TooniTube";
    protected override string Url => "https://toonitube.com";
    protected override bool HasCloudflareProtection => false;

    public TooniTubeSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
