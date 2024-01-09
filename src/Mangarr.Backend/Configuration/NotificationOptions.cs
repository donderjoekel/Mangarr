namespace Mangarr.Backend.Configuration;

public class NotificationOptions
{
    public const string SECTION = "Notifications";

    public string Discord { get; set; } = string.Empty;
    public bool IsDiscordEnabled => !string.IsNullOrEmpty(Discord);
}
