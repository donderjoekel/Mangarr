using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;

namespace Mangarr.Stack.Sources;

public class SourceProvider
{
    private readonly SourceRepository _sourceRepository;
    private readonly IEnumerable<ISource> _sources;

    public SourceProvider(IEnumerable<ISource> sources, SourceRepository sourceRepository)
    {
        _sources = sources;
        _sourceRepository = sourceRepository;
    }

    public ISource? GetById(string id)
    {
        SourceDocument? sourceDocument = _sourceRepository[id];
        return sourceDocument == null ? null : _sources.FirstOrDefault(x => x.Identifier == sourceDocument.Identifier);
    }
}
