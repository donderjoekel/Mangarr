using Mangarr.Backend.Sources;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Endpoints.Manga.List;

public class MangaListEndpoint : Endpoint<MangaListRequest, MangaListResponse>
{
    private readonly IMongoCollection<RequestedChapterDocument> _chapterCollection;
    private readonly IMongoCollection<RequestedMangaDocument> _mangaCollection;
    private readonly IMongoCollection<SourceDocument> _sourceCollection;

    public MangaListEndpoint(
        IMongoCollection<RequestedMangaDocument> mangaCollection,
        IMongoCollection<RequestedChapterDocument> chapterCollection,
        IMongoCollection<SourceDocument> sourceCollection
    )
    {
        _mangaCollection = mangaCollection;
        _chapterCollection = chapterCollection;
        _sourceCollection = sourceCollection;
    }

    public override void Configure()
    {
        Get("/manga");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaListRequest req, CancellationToken ct)
    {
        List<MangaListDetailsModel> items = new();

        List<RequestedMangaDocument> mangaDocuments = await _mangaCollection
            .Find(x => true)
            .ToListAsync(ct);

        List<string> sources = mangaDocuments.Select(x => x.SourceId)
            .Distinct()
            .ToList();

        List<SourceDocument> sourceDocuments = await _sourceCollection
            .Find(SourceDocument.Filter.In(x => x.Identifier, sources))
            .ToListAsync(ct);

        foreach (RequestedMangaDocument mangaDocument in mangaDocuments)
        {
            long downloadedChapters = await _chapterCollection.CountDocumentsAsync(
                RequestedChapterDocument.Filter.And(
                    RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, mangaDocument.Id),
                    RequestedChapterDocument.Filter.Eq(x => x.Downloaded, true),
                    RequestedChapterDocument.Filter.Eq(x => x.MarkedForDownload, true)),
                cancellationToken: ct);

            long totalChapters = await _chapterCollection.CountDocumentsAsync(
                RequestedChapterDocument.Filter.And(
                    RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, mangaDocument.Id),
                    RequestedChapterDocument.Filter.Eq(x => x.MarkedForDownload, true)),
                cancellationToken: ct);

            SourceDocument? source = sourceDocuments.FirstOrDefault(x => x.Identifier == mangaDocument.SourceId);
            SourceBase.DeconstructId(mangaDocument.MangaId, out string sourceUrl, out _);

            items.Add(new MangaListDetailsModel
            {
                Id = mangaDocument.Id,
                CoverUrl = mangaDocument.CoverUrl,
                Title = mangaDocument.Title,
                ChaptersDownloaded = downloadedChapters,
                ChaptersTotal = totalChapters,
                SearchId = mangaDocument.SearchId,
                SourceName = source?.Name ?? "[MISSING]",
                SourceUrl = sourceUrl
            });
        }

        await SendOkAsync(new MangaListResponse { Data = items }, ct);

        // await SendOkAsync(
        //     new MangaListResponse { Data = mangaDocuments.Select(x => _mapper.Map<RequestedMangaModel>(x)).ToList() },
        //     ct);
    }
}
