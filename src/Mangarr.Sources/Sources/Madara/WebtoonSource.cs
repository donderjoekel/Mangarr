using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class WebtoonSource : MadaraSourceBase
{
    protected override string Id => "webtoon";
    protected override string Name => "Webtoon";
    protected override string Url => "https://webtoon.xyz";
    protected override bool HasCloudflareProtection => true;

    public WebtoonSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
