using Mangarr.Backend.Sources;
using MongoDB.Driver;

namespace Mangarr.Backend.Initialization;

public class SourceInitializer : IInitializer
{
    private readonly IEnumerable<ISource> _sources;
    private readonly IMongoCollection<SourceDocument> _sourcesCollection;

    public SourceInitializer(IMongoCollection<SourceDocument> sourcesCollection, IEnumerable<ISource> sources)
    {
        _sourcesCollection = sourcesCollection;
        _sources = sources;
    }

    int IInitializer.Order => -1;

    async Task IInitializer.Initialize()
    {
        List<SourceDocument> existingSources = await _sourcesCollection.Find(x => true).ToListAsync();

        foreach (ISource source in _sources)
        {
            await source.Initialize();

            if (existingSources.Any(x => x.Identifier == source.Identifier))
            {
                continue;
            }

            SourceDocument document = new() { Identifier = source.Identifier, Name = source.Name, Url = source.Url };
            await _sourcesCollection.InsertOneAsync(document);
        }

        foreach (SourceDocument existingSource in existingSources)
        {
            if (_sources.All(x => x.Identifier != existingSource.Identifier))
            {
                await _sourcesCollection.DeleteOneAsync(x => x.Identifier == existingSource.Identifier);
            }
        }
    }
}
