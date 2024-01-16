using FluentResults;
using Mangarr.Backend.Caching;
using Mangarr.Backend.Conversion;

namespace Mangarr.Backend.Cover;

public class CoverImageService
{
    private readonly CachingService _cachingService;
    private readonly ConversionService _conversionService;
    private readonly IHttpClientFactory _httpClientFactory;

    public CoverImageService(
        IHttpClientFactory httpClientFactory,
        CachingService cachingService,
        ConversionService conversionService
    )
    {
        _httpClientFactory = httpClientFactory;
        _cachingService = cachingService;
        _conversionService = conversionService;
    }

    public async Task<Result<CoverImage>> GetCoverImage(RequestedMangaDocument requestedMangaDocument)
    {
        if (_cachingService.TryGetValue(requestedMangaDocument.Id, out CoverImage? cachedCoverImage))
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

        byte[] buffer;

        try
        {
            buffer = await httpResponseMessage.Content.ReadAsByteArrayAsync();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        Result<byte[]> conversionResult = await _conversionService.Convert(buffer);

        CoverImage coverImage = conversionResult.IsSuccess
            ? new CoverImage(conversionResult.Value, _conversionService.GetExtension())
            : new CoverImage(buffer, ".jpg");

        _cachingService.Set(requestedMangaDocument.Id, coverImage, TimeSpan.FromDays(1));
        return coverImage;
    }
}
