namespace Mangarr.Backend.Database.Documents;

public class ChapterProgressDocument : DocumentBase<ChapterProgressDocument>
{
    public string MangaId { get; set; } = null!;
    public string ChapterId { get; set; } = null!;
    public string MangaTitle { get; set; } = null!;
    public string ChapterTitle { get; set; } = null!;
    public double ChapterNumber { get; set; }
    public bool IsActive { get; set; }
    public int Progress { get; set; }
}
