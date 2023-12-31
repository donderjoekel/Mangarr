using System.Net;
using FluentResults;
using Mangarr.Backend.Sources.FluentResults;
using Newtonsoft.Json;

namespace Mangarr.Backend.Sources.Clients;

public abstract partial class CustomHttpClient
{
    private HttpRequestMessage CreateGetRequest(string requestUri)
    {
        HttpRequestMessage requestMessage = new(HttpMethod.Get, requestUri);

        foreach (KeyValuePair<string, string> kvp in headers)
        {
            requestMessage.Headers.Add(kvp.Key, kvp.Value);
        }

        return requestMessage;
    }

    public async Task<Result<string>> Get(string requestUri, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.SendAsync(CreateGetRequest(requestUri), ct);

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

    public async Task<Result<byte[]>> GetBuffer(string requestUri, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.SendAsync(CreateGetRequest(requestUri), ct);

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

        byte[] content = await response.Content.ReadAsByteArrayAsync(ct);
        return Result.Ok(content);
    }

    public async Task<Result<T>> Get<T>(string requestUri, CancellationToken ct = default)
    {
        HttpClient httpClient = CreateClient();
        using HttpResponseMessage response = await httpClient.SendAsync(CreateGetRequest(requestUri), ct);

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
        using HttpResponseMessage response = await httpClient.SendAsync(CreateGetRequest(requestUri), ct);

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
            string data = await response.Content.ReadAsStringAsync(ct);
            content = JsonConvert.DeserializeObject<TConcrete>(data)!;
        }
        catch (JsonSerializationException e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        return Result.Ok(content);
    }
}
