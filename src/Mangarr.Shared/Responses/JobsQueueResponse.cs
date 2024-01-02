using Mangarr.Shared.Models;

namespace Mangarr.Shared.Responses;

public class JobsQueueResponse
{
    public List<JobQueueItemModel> Data { get; set; } = new();
}
