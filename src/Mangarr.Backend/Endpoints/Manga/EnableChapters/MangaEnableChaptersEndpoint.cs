using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;

namespace Mangarr.Backend.Endpoints.Manga.EnableChapters;

public class MangaEnableChaptersEndpoint : Endpoint<MangaEnableChaptersRequest, MangaEnableChaptersResponse>
{
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;

    public MangaEnableChaptersEndpoint(
        IMongoCollection<RequestedMangaDocument> requestedMangaCollection,
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection
    )
    {
        _requestedMangaCollection = requestedMangaCollection;
        _requestedChapterCollection = requestedChapterCollection;
    }

    public override void Configure()
    {
        Post("manga/{id}/enable/chapters");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaEnableChaptersRequest req, CancellationToken ct)
    {
        RequestedMangaDocument manga =
            await _requestedMangaCollection.Find(x => x.Id == req.Id).FirstOrDefaultAsync(ct);

        if (manga == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        UpdateResult result = await _requestedChapterCollection.UpdateManyAsync(
            RequestedChapterDocument.Filter.And(
                RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, manga.Id),
                RequestedChapterDocument.Filter.Eq(x => x.MarkedForDownload, false)),
            RequestedChapterDocument.Update.Set(x => x.MarkedForDownload, true),
            cancellationToken: ct);

        if (!result.IsAcknowledged)
        {
            ThrowError("Unable to update chapters");
        }

        await SendOkAsync(ct);
    }
}
