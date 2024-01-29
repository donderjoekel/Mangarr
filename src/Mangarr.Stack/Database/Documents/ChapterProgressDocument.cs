namespace Mangarr.Stack.Database.Documents;

public class ChapterProgressDocument : DocumentBase<ChapterProgressDocument>
{
    public const int CurrentVersion = 1;
    public string MangaId { get; set; } = null!;
    public string ChapterId { get; set; } = null!;
    public string MangaTitle { get; set; } = null!;
    public string ChapterTitle { get; set; } = null!;
    public double ChapterNumber { get; set; }
    public bool IsActive { get; set; }
    public bool IsFailed { get; set; }
    public int Progress { get; set; }
}
