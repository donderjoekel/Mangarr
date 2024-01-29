using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;

namespace Mangarr.Stack.Initialization.Migration.RequestedManga;

public class RequestedMangaNoneToOneMigrationStep : IRequestedMangaMigrationStep
{
    private readonly ILogger<RequestedMangaNoneToOneMigrationStep> _logger;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly SourceRepository _sourceRepository;

    public RequestedMangaNoneToOneMigrationStep(
        RequestedMangaRepository requestedMangaRepository,
        SourceRepository sourceRepository,
        ILogger<RequestedMangaNoneToOneMigrationStep> logger
    )
    {
        _requestedMangaRepository = requestedMangaRepository;
        _sourceRepository = sourceRepository;
        _logger = logger;
    }

    public int RequiredVersion => 0;

    public async Task Migrate(RequestedMangaDocument requestedMangaDocument)
    {
        await MigrateMonitored();
        await MigrateSourceId();
    }

    private async Task MigrateMonitored()
    {
        foreach (RequestedMangaDocument requestedMangaDocument in _requestedMangaRepository)
        {
            if (requestedMangaDocument.Monitor)
            {
                continue;
            }

            _logger.LogInformation(
                "Updating monitor for manga with id '{Id}' from '{OldMonitor}' to '{NewMonitor}'",
                requestedMangaDocument.Id,
                requestedMangaDocument.Monitor,
                true);

            await _requestedMangaRepository.UpdateAsync(requestedMangaDocument.Id,
                RequestedMangaDocument.Update.Set(x => x.Monitor, true));
        }
    }

    private async Task MigrateSourceId()
    {
        foreach (RequestedMangaDocument requestedMangaDocument in _requestedMangaRepository)
        {
            SourceDocument? sourceByIdentifier =
                _sourceRepository.Items.FirstOrDefault(x => x.Identifier == requestedMangaDocument.SourceId);

            SourceDocument? sourceById =
                _sourceRepository.Items.FirstOrDefault(x => x.Id == requestedMangaDocument.SourceId);

            if (sourceByIdentifier == null && sourceById != null)
            {
                continue;
            }

            if (sourceByIdentifier == null && sourceById == null)
            {
                throw new NotImplementedException(
                    "This situation isn't handled properly yet as it is unknown what the desired outcome is");
            }

            if (sourceByIdentifier == null || sourceById != null)
            {
                continue;
            }

            _logger.LogInformation(
                "Updating source id for manga with id '{Id}' from '{OldSourceId}' to '{NewSourceId}'",
                requestedMangaDocument.Id,
                requestedMangaDocument.SourceId,
                sourceByIdentifier.Id);
            await _requestedMangaRepository.UpdateAsync(requestedMangaDocument.Id,
                RequestedMangaDocument.Update.Set(x => x.SourceId, sourceByIdentifier.Id));
        }
    }
}
