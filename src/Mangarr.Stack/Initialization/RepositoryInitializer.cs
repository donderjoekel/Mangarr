using Mangarr.Stack.Database.Repositories;

namespace Mangarr.Stack.Initialization;

public class RepositoryInitializer : IInitializable
{
    private readonly IEnumerable<IRepository> _repositories;

    public RepositoryInitializer(IEnumerable<IRepository> repositories) => _repositories = repositories;

    public int Order => -2;

    public async Task Initialize()
    {
        foreach (IRepository repository in _repositories)
        {
            await repository.Initialize();
        }
    }
}
