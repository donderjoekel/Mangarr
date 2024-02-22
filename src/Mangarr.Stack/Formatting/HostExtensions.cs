namespace Mangarr.Stack.Formatting;

public static class HostExtensions
{
    public static void AddMangarrFormatting(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<FormattingService>();
}
