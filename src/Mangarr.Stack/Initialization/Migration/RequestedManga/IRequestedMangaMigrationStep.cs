using Mangarr.Stack.Database.Documents;

namespace Mangarr.Stack.Initialization.Migration.RequestedManga;

public interface IRequestedMangaMigrationStep
{
    int RequiredVersion { get; }

    Task Migrate(RequestedMangaDocument requestedMangaDocument);
}
