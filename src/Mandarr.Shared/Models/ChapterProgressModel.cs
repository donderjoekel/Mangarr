namespace Mandarr.Shared.Models;

public class ChapterProgressModel
{
    public string MangaId { get; set; } = null!;
    public string ChapterId { get; set; } = null!;
    public string MangaTitle { get; set; } = string.Empty;
    public double ChapterNumber { get; set; }
    public bool IsActive { get; set; } = false;
    public int Progress { get; set; }
}
