namespace Mangarr.Stack.Comic;

public static class HostExtensions
{
    public static void AddMangarrComic(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<ComicInfoService>();
}
