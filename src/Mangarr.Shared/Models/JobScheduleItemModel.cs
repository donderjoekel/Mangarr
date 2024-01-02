namespace Mangarr.Shared.Models;

public class JobScheduleItemModel
{
    public string Id { get; set; }
    public string Group { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public DateTimeOffset? PreviousFireTime { get; set; }
    public DateTimeOffset? NextFireTime { get; set; }
}
