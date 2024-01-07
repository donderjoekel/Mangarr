using FluentResults;
using Mangarr.Backend.Data;
using Mangarr.Backend.Services;
using Mangarr.Backend.Services.Notifications;
using MongoDB.Driver;
using Quartz;
using ISource = Mangarr.Backend.Sources.ISource;
using PageList = Mangarr.Backend.Sources.Models.Page.PageList;

namespace Mangarr.Backend.Jobs;

public class DownloadChapterJob : IJob
{
    public const string IdDataKey = "Id";

    public static readonly JobKey JobKey = new("DownloadChapterJob");

    private readonly ArchiveService _archiveService;
    private readonly IMongoCollection<RequestedChapterDocument> _chapterCollection;
    private readonly ComicInfoService _comicInfoService;
    private readonly CoverImageService _coverImageService;
    private readonly ExportService _exportService;
    private readonly ILogger<DownloadChapterJob> _logger;
    private readonly IMongoCollection<RequestedMangaDocument> _mangaCollection;
    private readonly NotificationService _notificationService;
    private readonly PageDownloaderService _pageDownloaderService;
    private readonly IMongoCollection<ChapterProgressDocument> _progressCollection;
    private readonly IEnumerable<ISource> _sources;

    public DownloadChapterJob(
        ILogger<DownloadChapterJob> logger,
        IMongoCollection<RequestedMangaDocument> mangaCollection,
        IMongoCollection<RequestedChapterDocument> chapterCollection,
        IMongoCollection<ChapterProgressDocument> progressCollection,
        IEnumerable<ISource> sources,
        ArchiveService archiveService,
        ComicInfoService comicInfoService,
        CoverImageService coverImageService,
        ExportService exportService,
        PageDownloaderService pageDownloaderService,
        NotificationService notificationService
    )
    {
        _logger = logger;
        _mangaCollection = mangaCollection;
        _chapterCollection = chapterCollection;
        _progressCollection = progressCollection;
        _sources = sources;
        _archiveService = archiveService;
        _comicInfoService = comicInfoService;
        _coverImageService = coverImageService;
        _exportService = exportService;
        _pageDownloaderService = pageDownloaderService;
        _notificationService = notificationService;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        if (!context.MergedJobDataMap.TryGetString(IdDataKey, out string? id))
        {
            _logger.LogError("Unable to get id from job data");
            return;
        }

        RequestedChapterDocument chapter = await _chapterCollection
            .Find(x => x.Id == id)
            .FirstOrDefaultAsync(context.CancellationToken);

        if (chapter == null)
        {
            _logger.LogInformation("Chapter with id '{Id}' no longer exists, skipping download", id);
            return;
        }

        RequestedMangaDocument manga = await _mangaCollection
            .Find(x => x.Id == chapter.RequestedMangaId)
            .FirstOrDefaultAsync(context.CancellationToken);

        if (manga == null)
        {
            _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping download",
                chapter.RequestedMangaId);
            return;
        }

        ISource? source = _sources.FirstOrDefault(x => x.Identifier == manga.SourceId);

        if (source == null)
        {
            _logger.LogError("Unable to find source with id '{Id}', aborting download", manga.SourceId);
            return;
        }

        await UpdateProgress(chapter, 5, context.CancellationToken);
        Result<PageList> pageListResult = await source.GetPageList(chapter.ChapterId);

        if (pageListResult.IsFailed)
        {
            _logger.LogError("Unable to get page list: {Result}", pageListResult.ToString());
            await MarkChapterDownloadFailed(manga, chapter, context.CancellationToken);
            return;
        }

        await UpdateProgress(chapter, 10, context.CancellationToken);

        Result<List<byte[]>> downloadPagesResult = await _pageDownloaderService.DownloadPages(source,
            pageListResult.Value,
            p => UpdateProgress(chapter, 10 + (int)Math.Round(p * 0.7), context.CancellationToken));

        if (downloadPagesResult.IsFailed)
        {
            _logger.LogError("Unable to download pages: {Result}", downloadPagesResult.ToString());
            await MarkChapterDownloadFailed(manga, chapter, context.CancellationToken);
            return;
        }

        Result<ComicInfo> comicInfoResult = await _comicInfoService.Create(manga.SearchId,
            chapter.ChapterNumber,
            downloadPagesResult.Value.Count);

        if (comicInfoResult.IsFailed)
        {
            _logger.LogError("Unable to create comic info: {Result}", comicInfoResult.ToString());
            await MarkChapterDownloadFailed(manga, chapter, context.CancellationToken);
            return;
        }

        await UpdateProgress(chapter, 80, context.CancellationToken);

        Result<byte[]> coverImageResult = await _coverImageService.DownloadCoverImage(manga);

        if (coverImageResult.IsFailed)
        {
            _logger.LogError("Unable to download cover image: {Result}", coverImageResult.ToString());
            await MarkChapterDownloadFailed(manga, chapter, context.CancellationToken);
            return;
        }

        await UpdateProgress(chapter, 90, context.CancellationToken);

        Result<byte[]> archiveResult = await _archiveService.CreateArchive(comicInfoResult.Value,
            coverImageResult.Value,
            downloadPagesResult.Value,
            context.CancellationToken);

        if (archiveResult.IsFailed)
        {
            _logger.LogError("Unable to create archive: {Result}", archiveResult.ToString());
            await MarkChapterDownloadFailed(manga, chapter, context.CancellationToken);
            return;
        }

        await UpdateProgress(chapter, 95, context.CancellationToken);

        Result exportResult = await _exportService.Export(manga, chapter, archiveResult.Value);

        if (exportResult.IsFailed)
        {
            _logger.LogError("Unable to export archive: {Result}", exportResult.ToString());
            await MarkChapterDownloadFailed(manga, chapter, context.CancellationToken);
            return;
        }

        await UpdateProgress(chapter, 100, context.CancellationToken);
        await MarkChapterDownloadSucceeded(manga, chapter, context.CancellationToken);
    }

    private async Task UpdateProgress(
        RequestedChapterDocument requestedChapterDocument,
        int progress,
        CancellationToken ct
    ) =>
        await _progressCollection.UpdateOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, requestedChapterDocument.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, progress),
                ChapterProgressDocument.Update.Set(x => x.IsActive, true)),
            null,
            ct);

    private async Task MarkChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument,
        CancellationToken ct
    )
    {
        await _chapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, requestedChapterDocument.Id),
            RequestedChapterDocument.Update.Set(x => x.Downloaded, false),
            null,
            ct);

        await _progressCollection.UpdateOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, requestedChapterDocument.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, 0),
                ChapterProgressDocument.Update.Set(x => x.IsActive, false),
                ChapterProgressDocument.Update.Set(x => x.IsFailed, true)),
            null,
            ct);

        await _notificationService.NotifyChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument);
    }

    private async Task MarkChapterDownloadSucceeded(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument,
        CancellationToken ct
    )
    {
        await _chapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, requestedChapterDocument.Id),
            RequestedChapterDocument.Update.Set(x => x.Downloaded, true),
            null,
            ct);

        await _progressCollection.DeleteOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, requestedChapterDocument.Id),
            ct);

        await _notificationService.NotifyChapterDownloadSucceeded(requestedMangaDocument, requestedChapterDocument);
    }
}
