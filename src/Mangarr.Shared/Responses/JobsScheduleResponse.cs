using Mangarr.Shared.Models;

namespace Mangarr.Shared.Responses;

public class JobsScheduleResponse
{
    public List<JobScheduleItemModel> Data { get; set; } = new();
}
