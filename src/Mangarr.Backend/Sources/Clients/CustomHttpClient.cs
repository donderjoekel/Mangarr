namespace Mangarr.Backend.Sources.Clients;

public abstract partial class CustomHttpClient
{
    public enum PostMethod
    {
        None,
        Json,
        FormUrlEncoded
    }

    private readonly IHttpClientFactory httpClientFactory;
    private readonly Dictionary<string, string> headers = new();

    protected abstract string ClientName { get; }

    public CustomHttpClient(IHttpClientFactory httpClientFactory) => this.httpClientFactory = httpClientFactory;

    private HttpClient CreateClient() => httpClientFactory.CreateClient(ClientName);

    public void AddHeader(string key, string value) => headers[key] = value;

    public void RemoveHeader(string key) => headers.Remove(key);

    public void ClearHeaders() => headers.Clear();
}
