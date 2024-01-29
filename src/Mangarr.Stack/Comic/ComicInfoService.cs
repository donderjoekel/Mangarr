using System.Globalization;
using Anilist4Net;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Extensions;

namespace Mangarr.Stack.Comic;

public class ComicInfoService
{
    private readonly AniListApi _aniListApi;

    public ComicInfoService(AniListApi aniListApi) => _aniListApi = aniListApi;

    public async Task<Result<ComicInfo>> Create(int aniListId, double chapterNumber, int pageCount)
    {
        Result<Media?> mediaResult = await _aniListApi.GetMedia(aniListId);
        if (mediaResult.IsFailed)
        {
            return mediaResult.ToResult();
        }

        if (mediaResult.Value == null)
        {
            return Result.Fail(new Error("Media not found"));
        }

        Media media = mediaResult.Value;

        string title = GetTitle(media);
        double rating = media.AverageScore.HasValue ? media.AverageScore.Value / 20d : 0;

        return new ComicInfo
        {
            Series = title,
            Title = $"{title} - Chapter {chapterNumber}",
            Number = chapterNumber.ToString(CultureInfo.InvariantCulture),
            Summary = media.DescriptionHtml,
            PageCount = pageCount,
            CommunityRating = rating,
            Web = media.SiteUrl,
            Genres = media.Genres.JoinToString(','),
            Tags = media.Tags.Select(x => x.Name).JoinToString(',')
            // Characters = media.Characters.Edges.Select(x => x.Node.Name.Full).JoinToString(',')
        };
    }

    private static string GetTitle(Media media)
    {
        if (!string.IsNullOrEmpty(media.Title.English))
        {
            return media.Title.English;
        }

        if (!string.IsNullOrEmpty(media.Title.Romaji))
        {
            return media.Title.Romaji;
        }

        return media.Title.Native;
    }
}
