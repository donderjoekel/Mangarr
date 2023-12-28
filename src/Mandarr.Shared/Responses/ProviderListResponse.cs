using Mandarr.Shared.Models;

namespace Mandarr.Shared.Responses;

public class ProviderListResponse
{
    public List<ProviderModel> Data { get; set; } = new();
}
