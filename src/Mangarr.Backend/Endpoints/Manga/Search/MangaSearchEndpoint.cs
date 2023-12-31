using Anilist4Net;
using Anilist4Net.Enums;
using FluentResults;
using Mangarr.Backend.Configuration;
using Mangarr.Backend.Services;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Microsoft.Extensions.Options;

namespace Mangarr.Backend.Endpoints.Manga.Search;

public class MangaSearchEndpoint : Endpoint<MangaSearchRequest, MangaSearchResponse>
{
    private readonly AniListOptions _aniListOptions;
    private readonly AniListService _aniListService;

    public MangaSearchEndpoint(AniListService aniListService, IOptions<AniListOptions> aniListOptions)
    {
        _aniListService = aniListService;
        _aniListOptions = aniListOptions.Value;
    }

    public override void Configure()
    {
        Get("/manga/search/{query}/{page}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaSearchRequest req, CancellationToken ct)
    {
        Result<Page?> searchResult = await _aniListService.Search(req.Query, req.Page);

        if (searchResult.IsFailed)
        {
            Logger.LogError("Unable to search: {Result}", searchResult.ToString());
            ThrowError("Unable to search", StatusCodes.Status500InternalServerError);
        }

        if (searchResult.Value == null)
        {
            await SendOkAsync(new MangaSearchResponse { Data = [] },
                ct);
            return;
        }

        Page? mediaPage = searchResult.Value;

        await SendOkAsync(new MangaSearchResponse
            {
                Data = mediaPage.Media
                    .Where(x => x.Format == MediaFormats.MANGA)
                    .Where(FilterAdult)
                    .Select(CreateSearchResult)
                    .ToList()
            },
            ct);
    }

    private bool FilterAdult(Media media) => _aniListOptions.AllowAdult || !media.IsAdult;

    private SearchResultModel CreateSearchResult(Media media)
    {
        string mainTitle = media.Title.English ?? media.Title.Romaji;

        List<string> alternativeTitles =
        [
            media.Title.English,
            media.Title.Native,
            media.Title.Romaji
        ];

        alternativeTitles = alternativeTitles.Distinct().ToList();
        alternativeTitles.Remove(mainTitle);

        return new SearchResultModel
        {
            Id = media.Id,
            Title = mainTitle,
            AlternativeTitles = alternativeTitles.ToArray(),
            Description = media.DescriptionMd,
            CoverImage = media.CoverImageExtraLarge,
            Genres = media.Genres,
            Score = media.AverageScore
        };
    }
}
