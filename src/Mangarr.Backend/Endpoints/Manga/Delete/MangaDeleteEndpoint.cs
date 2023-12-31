using Mangarr.Shared.Requests;
using MongoDB.Driver;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Endpoints.Manga.Delete;

public class MangaDeleteEndpoint : Endpoint<MangaDeleteRequest>
{
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;

    public MangaDeleteEndpoint(
        IMongoCollection<RequestedMangaDocument> requestedMangaCollection,
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection
    )
    {
        _requestedMangaCollection = requestedMangaCollection;
        _requestedChapterCollection = requestedChapterCollection;
    }

    public override void Configure()
    {
        Post("/manga/{id}/delete");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaDeleteRequest req, CancellationToken ct)
    {
        if (req.DeleteChaptersFromDisk)
        {
            // TODO: Implement
        }

        DeleteResult deleteChaptersResult = await _requestedChapterCollection.DeleteManyAsync(
            RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, req.Id),
            ct);

        if (!deleteChaptersResult.IsAcknowledged)
        {
            ThrowError("Unable to delete chapters");
        }

        DeleteResult deleteMangaResult = await _requestedMangaCollection.DeleteOneAsync(
            RequestedMangaDocument.Filter.Eq(x => x.Id, req.Id),
            ct);

        if (!deleteMangaResult.IsAcknowledged)
        {
            ThrowError("Unable to delete manga");
        }

        await SendOkAsync(ct);
    }
}
