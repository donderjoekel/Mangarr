using Mangarr.Shared.Models;

namespace Mangarr.Shared.Responses;

public class ProviderListResponse
{
    public List<ProviderModel> Data { get; set; } = new();
}
