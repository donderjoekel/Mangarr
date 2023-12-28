using MongoDB.Driver;

namespace Mandarr.Backend.Database;

public class CollectionFactory
{
    private readonly IServiceProvider _provider;

    public CollectionFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IMongoCollection<T> Create<T>(string name)
    {
        return _provider
            .GetRequiredService<IMongoClient>()
            .GetDatabase("mandarr")
            .GetCollection<T>(name);
    }
}