using FluentResults;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Conversion;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;

namespace Mangarr.Stack.Cover;

public class CoverImageService
{
    private readonly CachingService _cachingService;
    private readonly ConversionService _conversionService;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly MangaMetadataRepository _mangaMetadataRepository;

    public CoverImageService(
        IHttpClientFactory httpClientFactory,
        MangaMetadataRepository mangaMetadataRepository,
        CachingService cachingService,
        ConversionService conversionService
    )
    {
        _httpClientFactory = httpClientFactory;
        _mangaMetadataRepository = mangaMetadataRepository;
        _cachingService = cachingService;
        _conversionService = conversionService;
    }

    public async Task<Result<CoverImage>> GetCoverImage(RequestedMangaDocument requestedMangaDocument)
    {
        MangaMetadataDocument? metadataDocument = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

        if (metadataDocument == null)
        {
            return Result.Fail("No metadata available");
        }

        if (_cachingService.TryGetValue(requestedMangaDocument.Id, out CoverImage? cachedCoverImage))
        {
            return Result.Ok(cachedCoverImage);
        }

        HttpClient httpClient = _httpClientFactory.CreateClient();
        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(metadataDocument.CoverUrl);

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
