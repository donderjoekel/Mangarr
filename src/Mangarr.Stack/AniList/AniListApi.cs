using Anilist4Net;
using Anilist4Net.Enums;
using FluentResults;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Settings;

namespace Mangarr.Stack.AniList;

public class AniListApi
{
    private readonly CachingService _cachingService;
    private readonly Client _client;
    private readonly MangaMetadataRepository _mangaMetadataRepository;
    private readonly SettingsApi _settingsApi;

    public AniListApi(
        CachingService cachingService,
        SettingsApi settingsApi,
        MangaMetadataRepository mangaMetadataRepository,
        IHttpClientFactory httpClientFactory
    )
    {
        _cachingService = cachingService;
        _settingsApi = settingsApi;
        _mangaMetadataRepository = mangaMetadataRepository;
        _client = new Client(httpClientFactory.CreateClient("AniList"));
    }

    public async Task<Result<Page?>> Search(string query, int page)
    {
        string key = "search:" + query + ":" + page;

        if (_cachingService.TryGetValue(key, out Page? mediaPage))
        {
            return mediaPage;
        }

        try
        {
            mediaPage = await _client.GetMediaBySearch(query, MediaTypes.MANGA, page, 50);
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        foreach (Media media in mediaPage.Media)
        {
            _cachingService.Set("media:" + media.Id, media, TimeSpan.FromDays(1));
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

        try
        {
            media = await _client.GetMediaById(id);
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        _cachingService.Set(key, media, TimeSpan.FromDays(1));
        return media;
    }

    public string GetPreferredTitle(RequestedMangaDocument requestedMangaDocument)
    {
        MangaMetadataDocument? document = _mangaMetadataRepository.GetByManga(requestedMangaDocument.Id);
        return document == null ? string.Empty : GetPreferredTitle(document);
    }

    public string GetPreferredTitle(MangaMetadataDocument mangaMetadataDocument) =>
        _settingsApi.AniList.PreferredTitleMode switch
        {
            AniListPreferredTitleMode.EnglishRomajiNative => GetNonEmptyStringInOrder(
                mangaMetadataDocument.TitleEnglish,
                mangaMetadataDocument.TitleRomaji,
                mangaMetadataDocument.TitleNative),
            AniListPreferredTitleMode.EnglishNativeRomaji => GetNonEmptyStringInOrder(
                mangaMetadataDocument.TitleEnglish,
                mangaMetadataDocument.TitleNative,
                mangaMetadataDocument.TitleRomaji),
            AniListPreferredTitleMode.RomajiEnglishNative => GetNonEmptyStringInOrder(
                mangaMetadataDocument.TitleRomaji,
                mangaMetadataDocument.TitleEnglish,
                mangaMetadataDocument.TitleNative),
            AniListPreferredTitleMode.RomajiNativeEnglish => GetNonEmptyStringInOrder(
                mangaMetadataDocument.TitleRomaji,
                mangaMetadataDocument.TitleNative,
                mangaMetadataDocument.TitleEnglish),
            AniListPreferredTitleMode.NativeEnglishRomaji => GetNonEmptyStringInOrder(
                mangaMetadataDocument.TitleNative,
                mangaMetadataDocument.TitleEnglish,
                mangaMetadataDocument.TitleRomaji),
            AniListPreferredTitleMode.NativeRomajiEnglish => GetNonEmptyStringInOrder(
                mangaMetadataDocument.TitleNative,
                mangaMetadataDocument.TitleRomaji,
                mangaMetadataDocument.TitleEnglish),
            _ => throw new ArgumentOutOfRangeException()
        };

    public string GetPreferredTitle(Media media) =>
        _settingsApi.AniList.PreferredTitleMode switch
        {
            AniListPreferredTitleMode.EnglishRomajiNative => GetNonEmptyStringInOrder(media.EnglishTitle,
                media.RomajiTitle,
                media.NativeTitle),
            AniListPreferredTitleMode.EnglishNativeRomaji => GetNonEmptyStringInOrder(media.EnglishTitle,
                media.NativeTitle,
                media.RomajiTitle),
            AniListPreferredTitleMode.RomajiEnglishNative => GetNonEmptyStringInOrder(media.RomajiTitle,
                media.EnglishTitle,
                media.NativeTitle),
            AniListPreferredTitleMode.RomajiNativeEnglish => GetNonEmptyStringInOrder(media.RomajiTitle,
                media.NativeTitle,
                media.EnglishTitle),
            AniListPreferredTitleMode.NativeEnglishRomaji => GetNonEmptyStringInOrder(media.NativeTitle,
                media.EnglishTitle,
                media.RomajiTitle),
            AniListPreferredTitleMode.NativeRomajiEnglish => GetNonEmptyStringInOrder(media.NativeTitle,
                media.RomajiTitle,
                media.EnglishTitle),
            _ => throw new ArgumentOutOfRangeException()
        };

    private string GetNonEmptyStringInOrder(params string?[] strings)
    {
        foreach (string s in strings)
        {
            if (!string.IsNullOrEmpty(s))
            {
                return s;
            }
        }

        return "[No title]";
    }
}
