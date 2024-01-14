using FluentResults;
using Mangarr.Backend.Notifications;
using Mangarr.Backend.Services;
using MongoDB.Driver;
using Quartz;
using ChapterList = Mangarr.Backend.Sources.Models.Chapter.ChapterList;
using ChapterListItem = Mangarr.Backend.Sources.Models.Chapter.ChapterListItem;
using ISource = Mangarr.Backend.Sources.ISource;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Jobs;

public class IndexMangaJob : IJob
{
    public const string IdDataKey = "Id";

    public static readonly JobKey JobKey = new("IndexMangaJob");
    private readonly IMongoCollection<RequestedChapterDocument> _chapterCollection;
    private readonly ExportService _exportService;

    private readonly ILogger<IndexMangaJob> _logger;
    private readonly IMongoCollection<RequestedMangaDocument> _mangaCollection;
    private readonly NotificationService _notificationService;
    private readonly IEnumerable<ISource> _sources;

    public IndexMangaJob(
        ILogger<IndexMangaJob> logger,
        IMongoCollection<RequestedMangaDocument> mangaCollection,
        IMongoCollection<RequestedChapterDocument> chapterCollection,
        IEnumerable<ISource> sources,
        NotificationService notificationService,
        ExportService exportService
    )
    {
        _logger = logger;
        _mangaCollection = mangaCollection;
        _chapterCollection = chapterCollection;
        _sources = sources;
        _notificationService = notificationService;
        _exportService = exportService;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        if (!context.MergedJobDataMap.TryGetString(IdDataKey, out string? id))
        {
            _logger.LogError("Unable to get id from job data");
            return;
        }

        RequestedMangaDocument? manga = await _mangaCollection
            .Find(x => x.Id == id)
            .FirstOrDefaultAsync(context.CancellationToken);

        if (manga == null)
        {
            _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping indexation", id);
            return;
        }

        await ProcessManga(manga, context.CancellationToken);
    }

    private async Task ProcessManga(RequestedMangaDocument manga, CancellationToken ct)
    {
        ISource? source = _sources.FirstOrDefault(x => x.Identifier == manga.SourceId);
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

        List<RequestedChapterDocument> requestedChapterDocuments = await _chapterCollection
            .Find(x => x.RequestedMangaId == manga.Id)
            .ToListAsync(ct);

        List<RequestedChapterDocument> newChapters = new();
        List<ChapterListItem> chapterListItems = chapterListResult.Value.Items.OrderBy(x => x.Number).ToList();
        foreach (ChapterListItem chapterListItem in chapterListItems)
        {
            RequestedChapterDocument? existingChapter = requestedChapterDocuments
                .FirstOrDefault(x => x.ChapterId == chapterListItem.Id);

            if (existingChapter != null)
            {
                continue;
            }

            bool markedForDownload = true;

            if (manga.NewChaptersOnly)
            {
                markedForDownload = manga.LastScanDate != null;
            }

            RequestedChapterDocument requestedChapterDocument = new()
            {
                RequestedMangaId = manga.Id,
                ChapterId = chapterListItem.Id,
                ChapterName = chapterListItem.Name,
                ChapterNumber = chapterListItem.Number,
                ReleaseDate = chapterListItem.Date,
                MarkedForDownload = markedForDownload,
                Downloaded = false,
                CreationDate = DateTime.UtcNow
            };

            Result<bool> doesChapterExistResult =
                await _exportService.DoesChapterExist(manga, requestedChapterDocument);

            if (doesChapterExistResult.IsFailed)
            {
                // TODO: Should there be a log here that it failed because of some reason?
                continue;
            }

            requestedChapterDocument.Downloaded = doesChapterExistResult.Value;

            await _chapterCollection.InsertOneAsync(requestedChapterDocument, null, ct);

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

        await _mangaCollection.UpdateOneAsync(
            RequestedMangaDocument.Filter.Eq(x => x.Id, manga.Id),
            RequestedMangaDocument.Update.Set(x => x.LastScanDate, DateTime.UtcNow),
            cancellationToken: ct);
    }
}
