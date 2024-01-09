using Mangarr.Backend.Sources;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;

namespace Mangarr.Backend.Endpoints.Chapter.Disable;

public class ChapterDisableEndpoint : Endpoint<ChapterDisableRequest, ChapterDisableResponse>
{
    private readonly IMongoCollection<ChapterProgressDocument> _chapterProgressCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;

    public ChapterDisableEndpoint(
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection,
        IMongoCollection<ChapterProgressDocument> chapterProgressCollection
    )
    {
        _requestedChapterCollection = requestedChapterCollection;
        _chapterProgressCollection = chapterProgressCollection;
    }

    public override void Configure()
    {
        Post("chapter/{Id}/disable");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ChapterDisableRequest req, CancellationToken ct)
    {
        RequestedChapterDocument? chapterDocument = await _requestedChapterCollection
            .Find(x => x.Id == req.Id)
            .FirstOrDefaultAsync(ct);

        if (chapterDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        if (!chapterDocument.MarkedForDownload)
        {
            await SendOkAsync(chapterDocument, ct);
            return;
        }

        UpdateResult result = await _requestedChapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, req.Id),
            RequestedChapterDocument.Update.Set(x => x.MarkedForDownload, false),
            cancellationToken: ct);

        if (!result.IsAcknowledged)
        {
            ThrowError("Unable to update chapter");
        }

        ChapterProgressDocument progressDocument = await _chapterProgressCollection
            .Find(x => x.ChapterId == req.Id)
            .FirstOrDefaultAsync(ct);

        if (progressDocument != null)
        {
            await _chapterProgressCollection.DeleteOneAsync(
                ChapterProgressDocument.Filter.Eq(x => x.Id, progressDocument.Id),
                ct);
        }

        await SendOkAsync(chapterDocument, ct);
    }

    private async Task SendOkAsync(RequestedChapterDocument chapterDocument, CancellationToken ct)
    {
        SourceBase.DeconstructId(chapterDocument.ChapterId, out string url, out _);

        await SendOkAsync(new ChapterDisableResponse
            {
                Data = new MangaChapterModel
                {
                    Id = chapterDocument.Id,
                    MarkedForDownload = true,
                    ChapterName = chapterDocument.ChapterName,
                    ChapterNumber = chapterDocument.ChapterNumber,
                    ChapterUrl = url,
                    Downloaded = false,
                    ReleaseDate = chapterDocument.ReleaseDate
                }
            },
            ct);
    }
}
