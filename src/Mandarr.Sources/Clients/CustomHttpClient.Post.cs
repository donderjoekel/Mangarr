using System.Net;
using System.Text;
using FluentResults;
using Mandarr.Sources.FluentResults;
using Newtonsoft.Json;

namespace Mandarr.Sources.Clients;

public abstract partial class CustomHttpClient
{
    private HttpRequestMessage CreatePostRequest(string requestUri, PostMethod postMethod, object? data)
    {
        HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, requestUri);

        foreach (KeyValuePair<string, string> kvp in headers)
        {
            httpRequestMessage.Headers.Add(kvp.Key, kvp.Value);
        }

        httpRequestMessage.Content = postMethod switch
        {
            PostMethod.None => null,
            PostMethod.Json => CreateJsonContent(data!),
            PostMethod.FormUrlEncoded => CreateFormUrlEncodedContent(data!),
            _ => throw new ArgumentOutOfRangeException(nameof(postMethod), postMethod, null)
        };

        return httpRequestMessage;
    }

    private static HttpContent CreateJsonContent(object data) =>
        new StringContent(
            JsonConvert.SerializeObject(data),
            Encoding.UTF8,
            "application/json");

    private static HttpContent CreateFormUrlEncodedContent(object data)
    {
        Dictionary<string, object>? dict =
            JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(data));

        return dict == null
            ? new FormUrlEncodedContent(new List<KeyValuePair<string, string>>())
            : new FormUrlEncodedContent(dict.Select(x =>
                new KeyValuePair<string, string>(x.Key, x.Value?.ToString() ?? string.Empty)));
    }

    private async Task<Result<string>> Post(
        string requestUri,
        object? data,
        PostMethod postMethod,
        CancellationToken ct = default
    )
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.SendAsync(
            CreatePostRequest(requestUri, postMethod, data),
            ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e))
                .WithReason(new UrlReason(requestUri))
                .WithReason(new StatusCodeReason(e.StatusCode));
        }

        string content = await response.Content.ReadAsStringAsync(ct);
        return Result.Ok(content);
    }

    private async Task<Result<T>> Post<T>(
        string requestUri,
        object data,
        PostMethod postMethod,
        CancellationToken ct = default
    )
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response =
            await httpClient.SendAsync(CreatePostRequest(requestUri, postMethod, data), ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e))
                .WithReason(new UrlReason(requestUri))
                .WithReason(new StatusCodeReason(e.StatusCode));
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

    private async Task<Result<TAbstract>> Post<TAbstract, TConcrete>(
        string requestUri,
        object data,
        PostMethod postMethod,
        CancellationToken ct = default
    )
        where TConcrete : TAbstract
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response =
            await httpClient.SendAsync(CreatePostRequest(requestUri, postMethod, data), ct);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            return Result.Fail(new ExceptionalError(e))
                .WithReason(new UrlReason(requestUri))
                .WithReason(new StatusCodeReason(e.StatusCode));
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

    public Task<Result<string>> Post(string requestUri, CancellationToken ct = default) =>
        Post(requestUri, null, PostMethod.None, ct);

    public Task<Result<string>> PostAsJson(string requestUri, object data, CancellationToken ct = default) =>
        Post(requestUri, data, PostMethod.Json, ct);

    public Task<Result<string>> PostAsForm(string requestUri, object data, CancellationToken ct = default) =>
        Post(requestUri, data, PostMethod.FormUrlEncoded, ct);

    public Task<Result<T>> Post<T>(string requestUri, object data, CancellationToken ct = default) =>
        Post<T>(requestUri, data, PostMethod.None, ct);

    public Task<Result<T>> PostAsJson<T>(string requestUri, object data, CancellationToken ct = default) =>
        Post<T>(requestUri, data, PostMethod.Json, ct);

    public Task<Result<T>> PostAsForm<T>(string requestUri, object data, CancellationToken ct = default) =>
        Post<T>(requestUri, data, PostMethod.FormUrlEncoded, ct);

    public Task<Result<TAbstract>> Post<TAbstract, TConcrete>(
        string requestUri,
        object data,
        CancellationToken ct = default
    ) where TConcrete : TAbstract =>
        Post<TAbstract, TConcrete>(requestUri, data, PostMethod.None, ct);

    public Task<Result<TAbstract>> PostAsJson<TAbstract, TConcrete>(
        string requestUri,
        object data,
        CancellationToken ct = default
    ) where TConcrete : TAbstract =>
        Post<TAbstract, TConcrete>(requestUri, data, PostMethod.Json, ct);

    public Task<Result<TAbstract>> PostAsForm<TAbstract, TConcrete>(
        string requestUri,
        object data,
        CancellationToken ct = default
    ) where TConcrete : TAbstract =>
        Post<TAbstract, TConcrete>(requestUri, data, PostMethod.FormUrlEncoded, ct);
}
