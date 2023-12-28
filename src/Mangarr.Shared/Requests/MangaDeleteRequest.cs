namespace Mangarr.Shared.Requests;

public class MangaDeleteRequest
{
    public string Id { get; set; }
    public bool DeleteChaptersFromDisk { get; set; }
}
