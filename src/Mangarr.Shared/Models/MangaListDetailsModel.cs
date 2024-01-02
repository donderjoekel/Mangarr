namespace Mangarr.Shared.Models;

public class MangaListDetailsModel
{
    public required string Id { get; set; }
    public required int SearchId { get; set; }
    public required string Title { get; set; }
    public required string SourceName { get; set; }
    public required string SourceUrl { get; set; }
    public required long ChaptersDownloaded { get; set; }
    public required long ChaptersTotal { get; set; }
    public required string CoverUrl { get; set; }
}
