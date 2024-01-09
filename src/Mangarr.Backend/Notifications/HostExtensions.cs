using Discord.Webhook;
using Mangarr.Backend.Configuration;
using Microsoft.Extensions.Options;

namespace Mangarr.Backend.Notifications;

public static class HostExtensions
{
    public static void AddMangarrNotifications(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<NotificationOptions>(builder.Configuration.GetSection(NotificationOptions.SECTION));
        builder.Services.AddSingleton<NotificationService>();
        builder.Services.AddSingleton<INotificationProcessor, DiscordNotificationProcessor>();
        builder.Services.AddSingleton<DiscordWebhookClient>(provider =>
        {
            IOptions<NotificationOptions> options = provider.GetRequiredService<IOptions<NotificationOptions>>();
            return options.Value.IsDiscordEnabled ? new DiscordWebhookClient(options.Value.Discord) : null!;
        });
    }
}
