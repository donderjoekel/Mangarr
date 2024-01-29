namespace Mangarr.Stack.Manga;

public static class HostExtensions
{
    public static void AddMangarrMangaApi(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<MangaApi>();
}
