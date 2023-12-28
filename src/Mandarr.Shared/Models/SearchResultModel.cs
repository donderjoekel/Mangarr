namespace Mandarr.Shared.Models;

public class SearchResultModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string[] AlternativeTitles { get; set; } = null!;
    public string? Description { get; set; }
    public string CoverImage { get; set; } = null!;
    public string[] Genres { get; set; } = null!;
    public int? Score { get; set; }
}
