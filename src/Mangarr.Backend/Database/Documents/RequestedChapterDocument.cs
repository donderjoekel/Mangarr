namespace Mangarr.Backend.Database.Documents;

public class RequestedChapterDocument : DocumentBase<RequestedChapterDocument>
{
    public required string RequestedMangaId { get; set; }
    public required string ChapterId { get; set; } = null!;
    public required double ChapterNumber { get; set; }
    public required bool MarkedForDownload { get; set; }
    public bool Downloaded { get; set; }
}
