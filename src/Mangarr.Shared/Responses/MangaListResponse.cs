using Mangarr.Shared.Models;

namespace Mangarr.Shared.Responses;

public class MangaListResponse
{
    public List<RequestedMangaModel> Data { get; set; }
}
