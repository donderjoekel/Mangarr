using Anilist4Net;
using FluentResults;
using Mandarr.Backend.Database.Documents;
using Mandarr.Backend.Services;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;
using MongoDB.Driver;

namespace Mandarr.Backend.Endpoints.Manga.Request;

public partial class MangaRequestEndpoint : Endpoint<MangaRequestRequest, MangaRequestResponse>
{
    private readonly IMongoCollection<RequestedMangaDocument> _collection;
    private readonly AniListService _aniListService;
    private readonly NotificationService _notificationService;

    public MangaRequestEndpoint(
        IMongoCollection<RequestedMangaDocument> collection,
        AniListService aniListService,
        NotificationService notificationService
    )
    {
        _collection = collection;
        _aniListService = aniListService;
        _notificationService = notificationService;
    }

    public override void Configure()
    {
        Post("/manga/request");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaRequestRequest req, CancellationToken ct)
    {
        RequestedMangaDocument? existingRequest = await _collection
            .Find(x => x.SearchId == req.SearchId)
            .FirstOrDefaultAsync(ct);

        if (existingRequest != null)
        {
            if (!AreEqual(existingRequest, req))
            {
                ThrowError("Manga already requested", StatusCodes.Status409Conflict);
            }

            await SendOkAsync(ct);
            return;
        }

        Result<Media?> mediaResult = await _aniListService.GetMedia(req.SearchId);

        if (mediaResult.IsFailed)
        {
            Logger.LogError("Unable to get media: {Result}", mediaResult.ToString());
            ThrowError("Unable to get media", StatusCodes.Status500InternalServerError);
        }

        if (mediaResult.Value == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        Media media = mediaResult.Value;

        // TODO: Make this configurable
        string title = !string.IsNullOrEmpty(media.Title.English)
            ? media.Title.English
            : media.Title.Romaji;

        RequestedMangaDocument requestedMangaDocument = new()
        {
            MangaId = req.MangaId,
            ProviderId = req.ProviderId,
            SearchId = req.SearchId,
            Title = title,
            CoverUrl = media.CoverImage.ExtraLarge,
            NewChaptersOnly = req.NewChaptersOnly
        };

        await _collection.InsertOneAsync(requestedMangaDocument, null, ct);
        await _notificationService.NotifyNewManga(requestedMangaDocument);
        await SendOkAsync(new MangaRequestResponse() { Id = requestedMangaDocument.Id }, ct);
    }

    private static bool AreEqual(RequestedMangaDocument requestedMangaDocument, MangaRequestRequest requestModel) =>
        requestedMangaDocument.SearchId == requestModel.SearchId &&
        requestedMangaDocument.ProviderId == requestModel.ProviderId &&
        requestedMangaDocument.MangaId == requestModel.MangaId;
}
