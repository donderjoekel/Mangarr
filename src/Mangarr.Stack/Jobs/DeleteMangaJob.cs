using FluentResults;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Exporting;
using MongoDB.Driver;
using Quartz;
using Quartz.Impl.Matchers;

namespace Mangarr.Stack.Jobs;

public class DeleteMangaJob : IJob
{
    public const string IdDataKey = "Id";
    public const string DeleteChaptersFromDiskDataKey = "DeleteChaptersFromDisk";
    public static readonly JobKey JobKey = new(nameof(DeleteMangaJob));

    private readonly ChapterProgressRepository _chapterProgressRepository;
    private readonly ExportService _exportService;
    private readonly ILogger<DeleteMangaJob> _logger;
    private readonly MangaMetadataRepository _mangaMetadataRepository;
    private readonly RequestedChapterRepository _requestedChapterRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly ISchedulerFactory _schedulerFactory;

    public DeleteMangaJob(
        ILogger<DeleteMangaJob> logger,
        ChapterProgressRepository chapterProgressRepository,
        MangaMetadataRepository mangaMetadataRepository,
        RequestedChapterRepository requestedChapterRepository,
        RequestedMangaRepository requestedMangaRepository,
        ISchedulerFactory schedulerFactory,
        ExportService exportService
    )
    {
        _logger = logger;
        _chapterProgressRepository = chapterProgressRepository;
        _mangaMetadataRepository = mangaMetadataRepository;
        _requestedChapterRepository = requestedChapterRepository;
        _requestedMangaRepository = requestedMangaRepository;
        _schedulerFactory = schedulerFactory;
        _exportService = exportService;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        if (!context.MergedJobDataMap.TryGetString(IdDataKey, out string? id))
        {
            _logger.LogError("Unable to get id from job data");
            return;
        }

        if (!context.MergedJobDataMap.TryGetBooleanValue(DeleteChaptersFromDiskDataKey,
                out bool deleteChaptersFromDisk))
        {
            _logger.LogError("Unable to get deleteChaptersFromDisk from job data");
            return;
        }

        if (!await DeleteProgress(id!))
        {
            _logger.LogError("Unable to delete manga progress with id {Id}", id);
            return;
        }

        if (!await DeleteChapters(id!, deleteChaptersFromDisk))
        {
            _logger.LogError("Unable to delete manga chapters with id {Id}", id);
            return;
        }

        if (!await DeleteManga(id!))
        {
            _logger.LogError("Unable to delete manga with id {Id}", id);
            return;
        }

        if (!await DeleteMetadata(id!))
        {
            _logger.LogError("Unable to delete manga metadata with id {Id}", id);
        }
    }

    private async Task<bool> DeleteMetadata(string id)
    {
        MangaMetadataDocument? mangaMetadataDocument = _mangaMetadataRepository.GetByManga(id);

        if (mangaMetadataDocument == null)
        {
            _logger.LogWarning("Manga metadata has already been deleted, maybe by another job");
            return false;
        }

        DeleteResult deleteResult = await _mangaMetadataRepository.DeleteAsync(mangaMetadataDocument.Id);
        return deleteResult.IsAcknowledged && deleteResult.DeletedCount == 1;
    }

    private async Task<bool> DeleteProgress(string id)
    {
        IScheduler scheduler = await _schedulerFactory.GetScheduler();

        IReadOnlyCollection<TriggerKey> keys =
            await scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.GroupContains(id));

        if (keys.Count == 0)
        {
            return true;
        }

        while (keys.Count > 0)
        {
            await Task.Delay(1000);
            keys = await scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.GroupContains(id));
        }

        DeleteResult deleteManyAsync =
            await _chapterProgressRepository.DeleteManyAsync(
                ChapterProgressDocument.Filter.Eq(x => x.MangaId, id));

        return deleteManyAsync.IsAcknowledged;
    }

    private async Task<bool> DeleteChapters(string id, bool deleteChaptersFromDisk)
    {
        if (deleteChaptersFromDisk)
        {
            RequestedMangaDocument? requestedMangaDocument = _requestedMangaRepository[id];

            List<RequestedChapterDocument> requestedChapterDocuments = _requestedChapterRepository.GetByMangaId(id);
            foreach (RequestedChapterDocument requestedChapterDocument in requestedChapterDocuments)
            {
                Result<bool> result = _exportService.DoesChapterExist(requestedMangaDocument, requestedChapterDocument);

                if (result.IsFailed || !result.Value)
                {
                    continue;
                }

                _exportService.DeleteChapter(requestedMangaDocument, requestedChapterDocument);
            }
        }

        DeleteResult deleteManyAsync =
            await _requestedChapterRepository.DeleteManyAsync(
                RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, id));

        return deleteManyAsync.IsAcknowledged;
    }

    private async Task<bool> DeleteManga(string id)
    {
        DeleteResult deleteResult = await _requestedMangaRepository.DeleteAsync(id);
        return deleteResult.IsAcknowledged && deleteResult.DeletedCount == 1;
    }
}
