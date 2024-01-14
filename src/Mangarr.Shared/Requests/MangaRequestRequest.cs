namespace Mangarr.Shared.Requests;

public class MangaRequestRequest
{
    public int SearchId { get; set; }
    public string ProviderId { get; set; } = null!;
    public string MangaId { get; set; } = null!;
    public string FolderId { get; set; } = null!;
    public bool NewChaptersOnly { get; set; }
}
