// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaPumaSource : BuddyComplexSourceBase
{
    protected override string Id => "mangapuma";
    protected override string Name => "MangaPuma";
    protected override string Url => "https://mangapuma.com";
    protected override bool HasCloudflareProtection => false;

    public MangaPumaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
