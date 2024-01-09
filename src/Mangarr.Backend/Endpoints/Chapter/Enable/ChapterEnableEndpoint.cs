using Mangarr.Backend.Sources;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;

namespace Mangarr.Backend.Endpoints.Chapter.Enable;

public class ChapterEnableEndpoint : Endpoint<ChapterEnableRequest, ChapterEnableResponse>
{
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;

    public ChapterEnableEndpoint(
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection
    ) =>
        _requestedChapterCollection = requestedChapterCollection;

    public override void Configure()
    {
        Post("chapter/{Id}/enable");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ChapterEnableRequest req, CancellationToken ct)
    {
        RequestedChapterDocument? chapterDocument = await _requestedChapterCollection
            .Find(x => x.Id == req.Id)
            .FirstOrDefaultAsync(ct);

        if (chapterDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        if (chapterDocument.MarkedForDownload)
        {
            await SendOkAsync(chapterDocument, ct);
            return;
        }

        UpdateResult result = await _requestedChapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, req.Id),
            RequestedChapterDocument.Update.Set(x => x.MarkedForDownload, true),
            cancellationToken: ct);

        if (!result.IsAcknowledged)
        {
            ThrowError("Unable to update chapter");
        }

        await SendOkAsync(chapterDocument, ct);
    }

    private async Task SendOkAsync(RequestedChapterDocument chapterDocument, CancellationToken ct)
    {
        SourceBase.DeconstructId(chapterDocument.ChapterId, out string url, out _);

        await SendOkAsync(new ChapterEnableResponse
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
