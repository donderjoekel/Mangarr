using FluentResults;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Exporting;
using Mangarr.Stack.Notifications;
using Quartz;
using ChapterList = Mangarr.Stack.Sources.Models.Chapter.ChapterList;
using ChapterListItem = Mangarr.Stack.Sources.Models.Chapter.ChapterListItem;
using ISource = Mangarr.Stack.Sources.ISource;
using RequestedChapterDocument = Mangarr.Stack.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Stack.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Stack.Jobs;

public class IndexMangaJob : IJob
{
    public const string IdDataKey = "Id";

    public static readonly JobKey JobKey = new("IndexMangaJob");
    private readonly ExportService _exportService;
    private readonly ILogger<IndexMangaJob> _logger;
    private readonly NotificationService _notificationService;
    private readonly RequestedChapterRepository _requestedChapterRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly SourceRepository _sourceRepository;
    private readonly IEnumerable<ISource> _sources;

    public IndexMangaJob(
        ILogger<IndexMangaJob> logger,
        IEnumerable<ISource> sources,
        NotificationService notificationService,
        ExportService exportService,
        RequestedMangaRepository requestedMangaRepository,
        RequestedChapterRepository requestedChapterRepository,
        SourceRepository sourceRepository
    )
    {
        _logger = logger;
        _sources = sources;
        _notificationService = notificationService;
        _exportService = exportService;
        _requestedMangaRepository = requestedMangaRepository;
        _requestedChapterRepository = requestedChapterRepository;
        _sourceRepository = sourceRepository;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        if (!context.MergedJobDataMap.TryGetString(IdDataKey, out string? id))
        {
            _logger.LogError("Unable to get id from job data");
            return;
        }

        RequestedMangaDocument? manga = _requestedMangaRepository[id!];

        if (manga == null)
        {
            _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping indexation", id);
            return;
        }

        if (!manga.Monitor)
        {
            _logger.LogInformation("Skipping indexation of manga '{Id}' because it is not monitored", id);
            return;
        }

        await ProcessManga(manga, context.CancellationToken);
    }

    private async Task ProcessManga(RequestedMangaDocument manga, CancellationToken ct)
    {
        SourceDocument? sourceDocument = _sourceRepository[manga.SourceId];

        if (sourceDocument == null)
        {
            _logger.LogError("Unable to find source {SourceId} for manga {MangaId}", manga.SourceId, manga.Id);
            return;
        }

        ISource? source = _sources.FirstOrDefault(x => x.Identifier == sourceDocument.Identifier);
        if (source == null)
        {
            _logger.LogError("source {SourceId} not found", manga.SourceId);
            return;
        }

        Result<ChapterList> chapterListResult = await source.GetChapterList(manga.MangaId);
        if (chapterListResult.IsFailed)
        {
            _logger.LogError("unable to get chapter list for {MangaId} from {SourceId}: {Result}",
                manga.MangaId,
                manga.SourceId,
                chapterListResult.ToResult());
            return;
        }

        List<RequestedChapterDocument> requestedChapterDocuments = _requestedChapterRepository.GetByMangaId(manga.Id);
        List<RequestedChapterDocument> newChapters = new();
        List<ChapterListItem> chapterListItems = chapterListResult.Value.Items.OrderBy(x => x.Number).ToList();
        foreach (ChapterListItem chapterListItem in chapterListItems)
        {
            RequestedChapterDocument? existingChapter = GetExistingChapter(requestedChapterDocuments, chapterListItem);

            if (existingChapter != null)
            {
                await UpdateChapterIfNeeded(existingChapter, chapterListItem);
                continue;
            }

            bool markedForDownload = true;

            if (manga.NewChaptersOnly)
            {
                markedForDownload = manga.LastScanDate != null;
            }

            RequestedChapterDocument requestedChapterDocument = new()
            {
                Version = RequestedChapterDocument.CurrentVersion,
                RequestedMangaId = manga.Id,
                ChapterId = chapterListItem.Id,
                ChapterName = chapterListItem.Name,
                ChapterNumber = chapterListItem.Number,
                VolumeNumber = chapterListItem.Volume,
                ReleaseDate = chapterListItem.Date,
                MarkedForDownload = markedForDownload,
                Downloaded = false
            };

            Result<bool> doesChapterExistResult = _exportService.DoesChapterExist(manga, requestedChapterDocument);

            if (doesChapterExistResult.IsFailed)
            {
                // TODO: Log this here?
                continue;
            }

            requestedChapterDocument.Downloaded = doesChapterExistResult.Value;
            requestedChapterDocument.MarkedForDownload = !doesChapterExistResult.Value && markedForDownload;

            await _requestedChapterRepository.AddAsync(requestedChapterDocument);

            if (!markedForDownload)
            {
                continue;
            }

            newChapters.Add(requestedChapterDocument);
        }

        if (newChapters.Any())
        {
            await _notificationService.NotifyNewChapters(manga, newChapters);
        }

        await _requestedMangaRepository.UpdateAsync(manga.Id,
            RequestedMangaDocument.Update.Set(x => x.LastScanDate, DateTime.UtcNow));
    }

    private RequestedChapterDocument? GetExistingChapter(
        List<RequestedChapterDocument> requestedChapterDocuments,
        ChapterListItem chapterListItem
    )
    {
        foreach (RequestedChapterDocument requestedChapterDocument in requestedChapterDocuments)
        {
            if (requestedChapterDocument.ChapterId == chapterListItem.Id)
            {
                return requestedChapterDocument;
            }

            if (Math.Abs(requestedChapterDocument.ChapterNumber - chapterListItem.Number) < 0.01 &&
                requestedChapterDocument.VolumeNumber == chapterListItem.Volume)
            {
                return requestedChapterDocument;
            }
        }

        return null;
    }

    private async Task UpdateChapterIfNeeded(RequestedChapterDocument chapter, ChapterListItem chapterListItem) =>
        await _requestedChapterRepository.UpdateAsync(chapter.Id,
            RequestedChapterDocument.Update.Combine(
                RequestedChapterDocument.Update.Set(x => x.ChapterId, chapterListItem.Id),
                RequestedChapterDocument.Update.Set(x => x.ChapterName, chapterListItem.Name),
                RequestedChapterDocument.Update.Set(x => x.ChapterNumber, chapterListItem.Number),
                RequestedChapterDocument.Update.Set(x => x.VolumeNumber, chapterListItem.Volume),
                RequestedChapterDocument.Update.Set(x => x.ReleaseDate, chapterListItem.Date)
            ));
}
