namespace Mandarr.Backend.Data;

public class ComicInfo
{
    public string Series { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Number { get; set; } = null!;
    public string Summary { get; set; } = null!;
    public int PageCount { get; set; }

    public string Web { get; set; } = null!;

    public double CommunityRating { get; set; }

    public string Genres { get; set; } = null!;
    public string Tags { get; set; } = null!;
    public string Characters { get; set; } = null!;
}
