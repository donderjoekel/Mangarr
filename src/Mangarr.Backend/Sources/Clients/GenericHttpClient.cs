using Injectio.Attributes;

namespace Mangarr.Backend.Sources.Clients;

[RegisterTransient]
public class GenericHttpClient : CustomHttpClient
{
    public GenericHttpClient(IHttpClientFactory httpClientFactory)
        : base(httpClientFactory)
    {
    }

    protected override string ClientName => "Generic";
}
