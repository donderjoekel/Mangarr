using Mandarr.Shared.Models;

namespace Mandarr.Shared.Responses;

public class MangaChaptersResponse
{
    public List<MangaChapterModel> Data { get; set; } = null!;
}
