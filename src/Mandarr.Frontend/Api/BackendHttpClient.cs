namespace Mandarr.Frontend.Api;

public class BackendHttpClient : CustomHttpClient
{
    public BackendHttpClient(IHttpClientFactory httpClientFactory)
        : base(httpClientFactory)
    {
    }

    protected override string ClientName => "backend";
}
