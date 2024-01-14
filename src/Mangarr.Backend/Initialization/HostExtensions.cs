namespace Mangarr.Backend.Initialization;

public static class HostExtensions
{
    public static void AddMangarrInitializers(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IInitializer, FixRootFoldersInitializer>();
        builder.Services.AddTransient<IInitializer, SourceInitializer>();
        builder.Services.AddTransient<IInitializer, JobsInitializer>();
    }
}
