namespace Mangarr.Backend.Sources.Clients;

public abstract partial class CustomHttpClient
{
    public enum PostMethod
    {
        None,
        Json,
        FormUrlEncoded
    }

    private readonly Dictionary<string, string> _headers = new();

    private readonly IHttpClientFactory _httpClientFactory;

    protected abstract string ClientName { get; }

    public CustomHttpClient(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

    private HttpClient CreateClient() => _httpClientFactory.CreateClient(ClientName);

    public void AddHeader(string key, string value) => _headers[key] = value;

    public void RemoveHeader(string key) => _headers.Remove(key);

    public void ClearHeaders() => _headers.Clear();
}
