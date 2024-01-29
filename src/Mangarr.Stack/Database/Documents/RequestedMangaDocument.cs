namespace Mangarr.Stack.Database.Documents;

public class RequestedMangaDocument : DocumentBase<RequestedMangaDocument>
{
    public const int CurrentVersion = 1;

    public required int SearchId { get; set; }
    public required string SourceId { get; set; } = null!;
    public required string MangaId { get; set; } = null!;
    public required string RootFolderId { get; set; } = null!;
    public required bool NewChaptersOnly { get; set; }
    public required bool Monitor { get; set; }
    public DateTime? LastScanDate { get; set; }
    public bool Deleted { get; set; }
    public required DateTime CreationDate { get; set; } = DateTime.UtcNow;
}
