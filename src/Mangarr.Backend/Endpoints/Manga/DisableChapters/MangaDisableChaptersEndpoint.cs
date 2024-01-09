using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;

namespace Mangarr.Backend.Endpoints.Manga.DisableChapters;

public class MangaDisableChaptersEndpoint : Endpoint<MangaDisableChaptersRequest, MangaDisableChaptersResponse>
{
    private readonly IMongoCollection<ChapterProgressDocument> _chapterProgressCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;

    public MangaDisableChaptersEndpoint(
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
        Post("manga/{id}/disable/chapters");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaDisableChaptersRequest req, CancellationToken ct)
    {
        RequestedMangaDocument manga =
            await _requestedMangaCollection.Find(x => x.Id == req.Id).FirstOrDefaultAsync(ct);

        if (manga == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        UpdateResult updateResult = await _requestedChapterCollection.UpdateManyAsync(
            RequestedChapterDocument.Filter.And(
                RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, manga.Id),
                RequestedChapterDocument.Filter.Eq(x => x.MarkedForDownload, false)),
            RequestedChapterDocument.Update.Set(x => x.MarkedForDownload, false),
            cancellationToken: ct);

        if (!updateResult.IsAcknowledged)
        {
            ThrowError("Unable to update chapters");
        }

        DeleteResult deleteResult = await _chapterProgressCollection.DeleteManyAsync(
            ChapterProgressDocument.Filter.Eq(x => x.MangaId, manga.Id),
            ct);

        if (!deleteResult.IsAcknowledged)
        {
            // TODO: Log error
            await SendOkAsync(ct);
        }
        else
        {
            await SendOkAsync(ct);
        }
    }
}
