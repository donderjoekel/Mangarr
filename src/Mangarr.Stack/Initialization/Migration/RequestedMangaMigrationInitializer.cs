using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Initialization.Migration.RequestedManga;

namespace Mangarr.Stack.Initialization.Migration;

public class RequestedMangaMigrationInitializer : IInitializable
{
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly IEnumerable<IRequestedMangaMigrationStep> _steps;

    public RequestedMangaMigrationInitializer(
        RequestedMangaRepository requestedMangaRepository,
        IEnumerable<IRequestedMangaMigrationStep> steps
    )
    {
        _requestedMangaRepository = requestedMangaRepository;
        _steps = steps.OrderBy(x => x.RequiredVersion);
    }

    public int Order => 0;

    public async Task Initialize()
    {
        foreach (RequestedMangaDocument requestedMangaDocument in _requestedMangaRepository.Items)
        {
            if (requestedMangaDocument.Version == RequestedMangaDocument.CurrentVersion)
            {
                continue;
            }

            foreach (IRequestedMangaMigrationStep step in _steps)
            {
                if (requestedMangaDocument.Version != step.RequiredVersion)
                {
                    continue;
                }

                await step.Migrate(requestedMangaDocument);
            }
        }
    }
}
