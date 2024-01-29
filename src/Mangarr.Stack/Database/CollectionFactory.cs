using MongoDB.Driver;

namespace Mangarr.Stack.Database;

public class CollectionFactory
{
    private readonly IServiceProvider _provider;

    public CollectionFactory(IServiceProvider provider) => _provider = provider;

    public IMongoCollection<T> Create<T>(string name) =>
        _provider
            .GetRequiredService<IMongoClient>()
            .GetDatabase("Mangarr")
            .GetCollection<T>(name);
}
