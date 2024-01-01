namespace Mangarr.Shared.Models;

public class MangaChapterModel
{
    public string Id { get; set; } = null!;
    public string ChapterUrl { get; set; } = null!;
    public string ChapterName { get; set; } = null!;
    public double ChapterNumber { get; set; }
    public DateTime ReleaseDate { get; set; }
    public bool MarkedForDownload { get; set; }
    public bool Downloaded { get; set; }
}
