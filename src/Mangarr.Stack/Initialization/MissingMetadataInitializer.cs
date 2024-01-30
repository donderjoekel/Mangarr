using Anilist4Net;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;

namespace Mangarr.Stack.Initialization;

public class MissingMetadataInitializer : IInitializable
{
    private readonly AniListApi _aniListApi;
    private readonly ILogger<MissingMetadataInitializer> _logger;
    private readonly MangaMetadataRepository _mangaMetadataRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;

    public MissingMetadataInitializer(
        AniListApi aniListApi,
        MangaMetadataRepository mangaMetadataRepository,
        RequestedMangaRepository requestedMangaRepository,
        ILogger<MissingMetadataInitializer> logger
    )
    {
        _aniListApi = aniListApi;
        _mangaMetadataRepository = mangaMetadataRepository;
        _requestedMangaRepository = requestedMangaRepository;
        _logger = logger;
    }

    public int Order => 1;

    public async Task Initialize()
    {
        foreach (RequestedMangaDocument requestedMangaDocument in _requestedMangaRepository.Items)
        {
            MangaMetadataDocument? mangaMetadataDocument = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

            if (mangaMetadataDocument != null)
            {
                continue;
            }

            _logger.LogInformation("Fetching metadata for manga with id '{Id}'", requestedMangaDocument.Id);

            Result<Media?> result = await _aniListApi.GetMedia(requestedMangaDocument.SearchId);

            if (result.IsFailed)
            {
                _logger.LogError("Failed to fetch metadata for manga with id '{Id}'; Result: {Result}",
                    requestedMangaDocument.Id,
                    result);
                continue;
            }

            Media? media = result.Value;

            if (media == null)
            {
                continue;
            }

            mangaMetadataDocument = new MangaMetadataDocument
            {
                Version = MangaMetadataDocument.CurrentVersion,
                MangaId = requestedMangaDocument.Id,
                TitleEnglish = media.Title?.English ?? string.Empty,
                TitleRomaji = media.Title?.Romaji ?? string.Empty,
                TitleNative = media.Title?.Native ?? string.Empty,
                CoverUrl = media.CoverImage.ExtraLarge,
                BannerUrl = media.BannerImage,
                DescriptionHtml = media.DescriptionHtml,
                DescriptionMd = media.DescriptionMd,
                Url = media.SiteUrl,
                Genres = media.Genres,
                Tags = media.Tags.Select(x => x.Name).ToArray()
            };

            await _mangaMetadataRepository.AddAsync(mangaMetadataDocument);
        }
    }
}
