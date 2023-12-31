using System.Net;
using FluentResults;
using Newtonsoft.Json;

namespace Mangarr.Backend.Sources.Clients;

public abstract partial class CustomHttpClient
{
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
}
