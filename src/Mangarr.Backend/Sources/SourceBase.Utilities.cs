using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace Mangarr.Backend.Sources;

internal abstract partial class SourceBase
{
    protected IDocument CreateDocument(string html) => new HtmlParser().ParseDocument(html);

    // private HttpClient GetHttpClient()
    // {
    //     return httpClientFactory.CreateClient("Cloudflare");
    // }
    //
    // private async Task<Result<HttpResponseMessage>> GetResponse(HttpRequestMessage request)
    // {
    //     HttpClient httpClient = GetHttpClient();
    //     HttpResponseMessage response;
    //
    //     try
    //     {
    //         response = await httpClient.SendAsync(request);
    //     }
    //     catch (Exception e)
    //     {
    //         return Result.Fail(new ExceptionalError(e));
    //     }
    //
    //     try
    //     {
    //         response.EnsureSuccessStatusCode();
    //     }
    //     catch (Exception e)
    //     {
    //         return Result.Fail(new Error[] { new StatusCodeError(response.StatusCode), new ExceptionalError(e) });
    //     }
    //
    //     return response;
    // }
    //
    //
    //
    // protected async Task<Result<string>> GetHtml(HttpRequestMessage request)
    // {
    //     Result<HttpResponseMessage> result = await GetResponse(request);
    //     if (result.IsFailed)
    //         return result.ToResult();
    //
    //     try
    //     {
    //         return Result.Ok(await result.Value.Content.ReadAsStringAsync());
    //     }
    //     catch (Exception e)
    //     {
    //         return Result.Fail(new ExceptionalError(e));
    //     }
    // }
    //
    // protected async Task<Result<byte[]>> GetBytes(HttpRequestMessage request)
    // {
    //     Result<HttpResponseMessage> result = await GetResponse(request);
    //     if (result.IsFailed)
    //         return result.ToResult();
    //
    //     try
    //     {
    //         return Result.Ok(await result.Value.Content.ReadAsByteArrayAsync());
    //     }
    //     catch (Exception e)
    //     {
    //         return Result.Fail(new ExceptionalError(e));
    //     }
    // }
    //
    // protected Task<Result<string>> GetHtml(string url)
    // {
    //     return GetHtml(new HttpRequestMessage(HttpMethod.Get, url));
    // }
    //
    // protected Task<Result<byte[]>> GetBytes(string url)
    // {
    //     return GetBytes(new HttpRequestMessage(HttpMethod.Get, url));
    // }
}
