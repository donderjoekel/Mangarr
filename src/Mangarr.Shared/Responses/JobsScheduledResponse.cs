using Mangarr.Shared.Models;

namespace Mangarr.Shared.Responses;

public class JobsScheduledResponse
{
    public List<ScheduledJobInfo> Data { get; set; } = new();
}
