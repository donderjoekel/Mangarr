using Anilist4Net;
using Anilist4Net.Enums;
using FluentResults;

namespace Mangarr.Backend.Services;

public class AniListService
{
    private readonly CachingService _cachingService;

    public AniListService(CachingService cachingService) => _cachingService = cachingService;

    public async Task<Result<Page?>> Search(string query, int page)
    {
        string key = "search:" + query + ":" + page;

        if (_cachingService.TryGetValue(key, out Page? mediaPage))
        {
            return mediaPage;
        }

        Client client = new();

        try
        {
            mediaPage = await client.GetMediaBySearch(query, MediaTypes.MANGA, page, 50);
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        _cachingService.Set(key, mediaPage, TimeSpan.FromMinutes(5));
        return mediaPage;
    }

    public async Task<Result<Media?>> GetMedia(int id)
    {
        string key = "media:" + id;

        if (_cachingService.TryGetValue(key, out Media? media))
        {
            return media;
        }

        Client client = new();

        try
        {
            media = await client.GetMediaById(id);
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        _cachingService.Set(key, media, TimeSpan.FromDays(1));
        return media;
    }
}
