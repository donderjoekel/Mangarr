using Mandarr.Shared.Models;

namespace Mandarr.Shared.Responses;

public class MangaListResponse
{
    public List<RequestedMangaModel> Data { get; set; }
}
