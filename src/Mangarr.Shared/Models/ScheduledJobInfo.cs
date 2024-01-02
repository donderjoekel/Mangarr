namespace Mangarr.Shared.Models;

public class ScheduledJobInfo
{
    public string Name { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public DateTimeOffset? PreviousFireTime { get; set; }
    public DateTimeOffset? NextFireTime { get; set; }
}
