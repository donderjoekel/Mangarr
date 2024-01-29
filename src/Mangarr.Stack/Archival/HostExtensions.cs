namespace Mangarr.Stack.Archival;

public static class HostExtensions
{
    public static void AddMangarrArchiving(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<ArchiveService>();
}
