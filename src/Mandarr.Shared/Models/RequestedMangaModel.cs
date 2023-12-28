namespace Mandarr.Shared.Models;

public class RequestedMangaModel
{
    public string Id { get; set; }
    public int SearchId { get; set; }
    public string ProviderId { get; set; } = null!;
    public string MangaId { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string CoverUrl { get; set; } = null!;
    public bool NewChaptersOnly { get; set; }
    public DateTime? LastScanDate { get; set; }
}
