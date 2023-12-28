using FluentResults;
using Mangarr.Backend.Database.Documents;

namespace Mangarr.Backend.Services;

public class CoverImageService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CoverImageService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

    public async Task<Result<byte[]>> DownloadCoverImage(RequestedMangaDocument requestedMangaDocument)
    {
        HttpClient httpClient = _httpClientFactory.CreateClient();

        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestedMangaDocument.CoverUrl);

        try
        {
            httpResponseMessage.EnsureSuccessStatusCode();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        try
        {
            return await httpResponseMessage.Content.ReadAsByteArrayAsync();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }
}
