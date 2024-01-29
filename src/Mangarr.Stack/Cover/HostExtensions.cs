namespace Mangarr.Stack.Cover;

public static class HostExtensions
{
    public static void AddMangarrCover(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<CoverImageService>();
}
