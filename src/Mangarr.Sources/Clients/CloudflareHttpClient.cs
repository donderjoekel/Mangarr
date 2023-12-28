using Injectio.Attributes;

namespace Mangarr.Sources.Clients;

[RegisterTransient]
public class CloudflareHttpClient : CustomHttpClient
{
    public CloudflareHttpClient(IHttpClientFactory httpClientFactory)
        : base(httpClientFactory)
    {
    }

    protected override string ClientName => "Cloudflare";
}
