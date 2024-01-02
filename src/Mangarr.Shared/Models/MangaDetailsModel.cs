namespace Mangarr.Shared.Models;

public class MangaDetailsModel
{
    public required int SearchId { get; set; }
    public required string Title { get; set; }
    public required string SourceName { get; set; }
    public required string SourceUrl { get; set; }
    public required string Description { get; set; }
    public required string CoverImage { get; set; }
    public required string BannerImage { get; set; }
}
