using Mangarr.Shared.Requests;
using MongoDB.Driver;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Endpoints.Manga.Delete;

public class MangaDeleteEndpoint : Endpoint<MangaDeleteRequest>
{
    private readonly IMongoCollection<ChapterProgressDocument> _chapterProgressCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;

    public MangaDeleteEndpoint(
        IMongoCollection<RequestedMangaDocument> requestedMangaCollection,
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection,
        IMongoCollection<ChapterProgressDocument> chapterProgressCollection
    )
    {
        _requestedMangaCollection = requestedMangaCollection;
        _requestedChapterCollection = requestedChapterCollection;
        _chapterProgressCollection = chapterProgressCollection;
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

        DeleteResult deleteProgressResult = await _chapterProgressCollection.DeleteManyAsync(
            ChapterProgressDocument.Filter.Eq(x => x.MangaId, req.Id),
            ct);

        if (!deleteProgressResult.IsAcknowledged)
        {
            ThrowError("Unable to delete progress");
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
