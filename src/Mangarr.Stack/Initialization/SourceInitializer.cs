using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Sources;

namespace Mangarr.Stack.Initialization;

public class SourceInitializer : IInitializable
{
    private readonly ILogger<SourceInitializer> _logger;
    private readonly SourceRepository _sourceRepository;
    private readonly IEnumerable<ISource> _sources;

    public SourceInitializer(
        IEnumerable<ISource> sources,
        SourceRepository sourceRepository,
        ILogger<SourceInitializer> logger
    )
    {
        _sources = sources;
        _sourceRepository = sourceRepository;
        _logger = logger;
    }

    public int Order => -1;

    public async Task Initialize()
    {
        foreach (ISource source in _sources)
        {
            await source.Initialize();

            if (_sourceRepository.Any(x => x.Identifier == source.Identifier))
            {
                continue;
            }

            _logger.LogInformation("Adding source '{Name}' with identifier '{Identifier}'",
                source.Name,
                source.Identifier);
            SourceDocument document = new()
            {
                Version = SourceDocument.CurrentVersion,
                Identifier = source.Identifier,
                Name = source.Name,
                Url = source.Url
            };
            await _sourceRepository.AddAsync(document);
        }

        foreach (SourceDocument existingSource in _sourceRepository)
        {
            if (_sources.Any(x => x.Identifier == existingSource.Identifier))
            {
                continue;
            }

            _logger.LogInformation("Removing source '{Name}' with identifier '{Identifier}'",
                existingSource.Name,
                existingSource.Identifier);
            await _sourceRepository.DeleteAsync(existingSource.Id);
        }
    }
}
