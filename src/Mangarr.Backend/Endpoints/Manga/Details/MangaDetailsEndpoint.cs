using Anilist4Net;
using FluentResults;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Endpoints.Manga.Details;

public class MangaDetailsEndpoint : Endpoint<MangaDetailsRequest, MangaDetailsResponse>
{
    private readonly AniListService _aniListService;
    private readonly IMongoCollection<RequestedMangaDocument> _mangaCollection;
    private readonly IMongoCollection<SourceDocument> _sourceCollection;

    public MangaDetailsEndpoint(
        IMongoCollection<RequestedMangaDocument> mangaCollection,
        AniListService aniListService,
        IMongoCollection<SourceDocument> sourceCollection
    )
    {
        _mangaCollection = mangaCollection;
        _aniListService = aniListService;
        _sourceCollection = sourceCollection;
    }

    public override void Configure()
    {
        Get("/manga/{id}/details");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaDetailsRequest req, CancellationToken ct)
    {
        RequestedMangaDocument? document = await _mangaCollection
            .Find(x => x.Id == req.Id)
            .FirstOrDefaultAsync(ct);

        if (document == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        SourceDocument? source = await _sourceCollection
            .Find(x => x.Identifier == document.SourceId)
            .FirstOrDefaultAsync(ct);

        if (source == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        Result<Media?> result = await _aniListService.GetMedia(document.SearchId);

        if (result.IsFailed)
        {
            Logger.LogError("Unable to get manga by id: {Id}; {Result}", req.Id, result.ToString());
            ThrowError("An error occurred while getting the manga");
        }

        if (result.Value == null)
        {
            Logger.LogError("The manga with id {Id} was not found", req.Id);
            await SendNotFoundAsync(ct);
            return;
        }

        SourceBase.DeconstructId(document.MangaId, out string url, out _);

        string title = !string.IsNullOrEmpty(result.Value.Title.English)
            ? result.Value.Title.English
            : result.Value.Title.Romaji;

        await SendOkAsync(new MangaDetailsResponse
            {
                Data = new MangaDetailsModel
                {
                    Title = title,
                    SourceName = source.Name,
                    SourceUrl = url,
                    Description = result.Value.DescriptionHtml,
                    CoverImage = result.Value.CoverImage.Large,
                    BannerImage = result.Value.BannerImage
                }
            },
            ct);
    }
}
