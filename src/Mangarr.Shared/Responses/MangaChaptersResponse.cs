using Mangarr.Shared.Models;

namespace Mangarr.Shared.Responses;

public class MangaChaptersResponse
{
    public List<MangaChapterModel> Data { get; set; } = null!;
}
