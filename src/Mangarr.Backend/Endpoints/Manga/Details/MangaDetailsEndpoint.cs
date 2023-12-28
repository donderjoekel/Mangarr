using Anilist4Net;
using FluentResults;
using Mangarr.Backend.Database.Documents;
using Mangarr.Backend.Services;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;

namespace Mangarr.Backend.Endpoints.Manga.Details;

public class MangaDetailsEndpoint : Endpoint<MangaDetailsRequest, MangaDetailsResponse>
{
    private readonly IMongoCollection<RequestedMangaDocument> _collection;
    private readonly AniListService _aniListService;

    public MangaDetailsEndpoint(IMongoCollection<RequestedMangaDocument> collection, AniListService aniListService)
    {
        _collection = collection;
        _aniListService = aniListService;
    }

    public override void Configure()
    {
        Get("/manga/{id}/details");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaDetailsRequest req, CancellationToken ct)
    {
        RequestedMangaDocument? document = await _collection
            .Find(x => x.Id == req.Id)
            .FirstOrDefaultAsync(ct);

        if (document == null)
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

        await SendOkAsync(new MangaDetailsResponse()
            {
                Data = new MangaDetailsModel()
                {
                    Title = result.Value.Title.English,
                    Description = result.Value.DescriptionHtml,
                    CoverImage = result.Value.CoverImage.Large,
                    BannerImage = result.Value.BannerImage
                }
            },
            ct);
    }
}
