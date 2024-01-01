using Mangarr.Backend.Sources;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;

namespace Mangarr.Backend.Endpoints.Manga.Chapters;

public class MangaChaptersEndpoint : Endpoint<MangaChaptersRequest, MangaChaptersResponse>
{
    private readonly IMongoCollection<RequestedChapterDocument> _chapterCollection;

    public MangaChaptersEndpoint(IMongoCollection<RequestedChapterDocument> chapterCollection) =>
        _chapterCollection = chapterCollection;

    public override void Configure()
    {
        Get("/manga/{id}/chapters");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaChaptersRequest req, CancellationToken ct)
    {
        List<RequestedChapterDocument> documents = await _chapterCollection
            .Find(x => x.RequestedMangaId == req.Id)
            .ToListAsync(ct);

        await SendOkAsync(new MangaChaptersResponse
            {
                Data = documents
                    .OrderByDescending(x => x.ChapterNumber)
                    .Select(Map)
                    .ToList()
            },
            ct);
    }

    private MangaChapterModel Map(RequestedChapterDocument document)
    {
        SourceBase.DeconstructId(document.ChapterId, out string url, out _);

        return new MangaChapterModel
        {
            Id = document.Id,
            ChapterUrl = url,
            ChapterName = document.ChapterName,
            ChapterNumber = document.ChapterNumber,
            ReleaseDate = document.ReleaseDate,
            MarkedForDownload = document.MarkedForDownload,
            Downloaded = document.Downloaded
        };
    }
}
