using System.Net;
using FluentResults;
using Newtonsoft.Json;

namespace Mandarr.Frontend.Api;

public abstract class CustomHttpClient
{
    private readonly IHttpClientFactory httpClientFactory;

    protected abstract string ClientName { get; }

    public CustomHttpClient(IHttpClientFactory httpClientFactory) => this.httpClientFactory = httpClientFactory;

    private HttpClient CreateClient() => httpClientFactory.CreateClient(ClientName);

    public async Task<Result<string>> Get(string requestUri, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.GetAsync(requestUri, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        string content = await response.Content.ReadAsStringAsync(ct);
        return Result.Ok(content);
    }

    public async Task<Result<T>> Get<T>(string requestUri, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.GetAsync(requestUri, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        if (response.StatusCode == HttpStatusCode.NoContent)
        {
            return Result.Ok();
        }

        T content;

        try
        {
            string data = await response.Content.ReadAsStringAsync(ct);
            content = JsonConvert.DeserializeObject<T>(data)!;
        }
        catch (JsonSerializationException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok(content);
    }

    public async Task<Result<TAbstract>> Get<TAbstract, TConcrete>(string requestUri, CancellationToken ct = default)
        where TConcrete : TAbstract
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.GetAsync(requestUri, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        if (response.StatusCode == HttpStatusCode.NoContent)
        {
            return Result.Ok();
        }

        TAbstract content;

        try
        {
            string data = await response.Content.ReadAsStringAsync(ct);
            content = JsonConvert.DeserializeObject<TConcrete>(data)!;
        }
        catch (JsonSerializationException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok(content);
    }

    public async Task<Result<TAbstract>> Put<TAbstract, TConcrete>(
        string requestUri,
        object data,
        CancellationToken ct = default
    ) where TConcrete : TAbstract
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.PutAsJsonAsync(requestUri, data, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        if (response.StatusCode == HttpStatusCode.NoContent)
        {
            return Result.Ok();
        }

        TAbstract content;

        try
        {
            string stringContent = await response.Content.ReadAsStringAsync(ct);
            content = JsonConvert.DeserializeObject<TConcrete>(stringContent)!;
        }
        catch (JsonSerializationException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok(content);
    }

    public async Task<Result> Post(string requestUri, object data, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.PostAsJsonAsync(requestUri, data, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok();
    }

    public async Task<Result<T>> Post<T>(string requestUri, object data, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.PostAsJsonAsync(requestUri, data, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        if (response.StatusCode == HttpStatusCode.NoContent)
        {
            return Result.Ok();
        }

        T content;

        try
        {
            string stringContent = await response.Content.ReadAsStringAsync(ct);
            content = JsonConvert.DeserializeObject<T>(stringContent)!;
        }
        catch (JsonSerializationException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok(content);
    }

    public async Task<Result<TAbstract>> Post<TAbstract, TConcrete>(
        string requestUri,
        object data,
        CancellationToken ct = default
    ) where TConcrete : TAbstract
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.PostAsJsonAsync(requestUri, data, ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        if (response.StatusCode == HttpStatusCode.NoContent)
        {
            return Result.Ok();
        }

        TAbstract content;

        try
        {
            string stringContent = await response.Content.ReadAsStringAsync(ct);
            content = JsonConvert.DeserializeObject<TConcrete>(stringContent)!;
        }
        catch (JsonSerializationException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok(content);
    }
}
