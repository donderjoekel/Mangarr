using Mangarr.Stack.Initialization.Migration;
using Mangarr.Stack.Initialization.Migration.RequestedManga;

namespace Mangarr.Stack.Initialization;

public static class HostExtensions
{
    public static void AddMangarrInitialization(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IInitializable, FixRootFolderInitializer>();
        builder.Services.AddSingleton<IInitializable, InitialJobScheduleInitializer>();
        builder.Services.AddSingleton<IInitializable, MissingMetadataInitializer>();
        builder.Services.AddSingleton<IInitializable, RepositoryInitializer>();
        builder.Services.AddSingleton<IInitializable, SourceInitializer>();

        builder.Services.AddSingleton<IInitializable, RequestedMangaMigrationInitializer>();
        builder.Services.AddSingleton<IRequestedMangaMigrationStep, RequestedMangaNoneToOneMigrationStep>();
    }
}
