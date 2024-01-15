using FluentResults;
using Mangarr.Backend.Caching;

namespace Mangarr.Backend.Services;

public class CoverImageService
{
    private readonly CachingService _cachingService;
    private readonly IHttpClientFactory _httpClientFactory;

    public CoverImageService(IHttpClientFactory httpClientFactory, CachingService cachingService)
    {
        _httpClientFactory = httpClientFactory;
        _cachingService = cachingService;
    }

    public async Task<Result<byte[]>> DownloadCoverImage(RequestedMangaDocument requestedMangaDocument)
    {
        if (_cachingService.TryGetValue(requestedMangaDocument.Id, out byte[]? cachedCoverImage))
        {
            return Result.Ok(cachedCoverImage);
        }

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
            byte[] buffer = await httpResponseMessage.Content.ReadAsByteArrayAsync();
            _cachingService.Set(requestedMangaDocument.Id, buffer, TimeSpan.FromDays(1));
            return Result.Ok(buffer);
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }
}
