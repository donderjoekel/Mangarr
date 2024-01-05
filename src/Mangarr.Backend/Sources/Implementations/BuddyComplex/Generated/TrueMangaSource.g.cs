// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.BuddyComplex;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class TrueMangaSource : BuddyComplexSourceBase
{
    protected override string Id => "truemanga";
    protected override string Name => "TrueManga";
    protected override string Url => "https://truemanga.com";
    protected override bool HasCloudflareProtection => false;

    public TrueMangaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
