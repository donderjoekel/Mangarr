namespace Mangarr.Stack.Library;

public static class HostExtensions
{
    public static void AddMangarrLibraryApi(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<LibraryApi>();
}
