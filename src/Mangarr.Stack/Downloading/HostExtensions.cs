namespace Mangarr.Stack.Downloading;

public static class HostExtensions
{
    public static void AddMangarrDownloading(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<PageDownloaderService>();
}
