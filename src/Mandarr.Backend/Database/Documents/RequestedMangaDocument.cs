namespace Mandarr.Backend.Database.Documents;

public class RequestedMangaDocument : DocumentBase<RequestedMangaDocument>
{
    public required int SearchId { get; set; }
    public required string ProviderId { get; set; } = null!;
    public required string MangaId { get; set; } = null!;
    public required string Title { get; set; } = null!;
    public required string CoverUrl { get; set; } = null!;
    public required bool NewChaptersOnly { get; set; }
    public DateTime? LastScanDate { get; set; }
}