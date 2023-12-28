namespace Mandarr.Shared.Models;

public class MangaModel
{
    public string Title { get; set; }
    public string[] Titles { get; set; } = Array.Empty<string>();
    public string Description { get; set; }
    public string CoverImage { get; set; }
    public string BannerImage { get; set; }

    // TODO: Add more properties
}
