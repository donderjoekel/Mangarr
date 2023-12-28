using FluentResults;
using Mandarr.Backend.Data;
using Mandarr.Backend.Database.Documents;
using Mandarr.Backend.Services;
using Mandarr.Sources;
using Mandarr.Sources.Models.Page;
using MongoDB.Driver;

namespace Mandarr.Backend.Workers.Processors;

public class ChapterProcessor
{
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;
    private readonly IMongoCollection<ChapterProgressDocument> _chapterProgressCollection;
    private readonly IEnumerable<ISource> _providers;
    private readonly ILogger<ChapterProcessor> _logger;
    private readonly PageDownloaderService _pageDownloaderService;
    private readonly ComicInfoService _comicInfoService;
    private readonly CoverImageService _coverImageService;
    private readonly ArchiveService _archiveService;
    private readonly ExportService _exportService;
    private readonly NotificationService _notificationService;

    public ChapterProcessor(
        IMongoCollection<RequestedMangaDocument> requestedMangaCollection,
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection,
        IEnumerable<ISource> providers,
        ILogger<ChapterProcessor> logger,
        PageDownloaderService pageDownloaderService,
        ComicInfoService comicInfoService,
        CoverImageService coverImageService,
        ArchiveService archiveService,
        ExportService exportService,
        NotificationService notificationService,
        IMongoCollection<ChapterProgressDocument> chapterProgressCollection
    )
    {
        _requestedMangaCollection = requestedMangaCollection;
        _requestedChapterCollection = requestedChapterCollection;
        _providers = providers;
        _logger = logger;
        _pageDownloaderService = pageDownloaderService;
        _comicInfoService = comicInfoService;
        _coverImageService = coverImageService;
        _archiveService = archiveService;
        _exportService = exportService;
        _notificationService = notificationService;
        _chapterProgressCollection = chapterProgressCollection;
    }

    public async Task Run(CancellationToken stoppingToken)
    {
        List<RequestedChapterDocument> requestedChapterDocuments = await _requestedChapterCollection
            .Find(x => x.MarkedForDownload && !x.Downloaded)
            .ToListAsync(stoppingToken);

        foreach (RequestedChapterDocument requestedChapterDocument in requestedChapterDocuments)
        {
            await ProcessChapter(requestedChapterDocument, stoppingToken);
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }
    }

    private async Task ProcessChapter(RequestedChapterDocument requestedChapterDocument, CancellationToken ct)
    {
        RequestedMangaDocument requestedMangaDocument = await _requestedMangaCollection
            .Find(x => x.Id == requestedChapterDocument.RequestedMangaId)
            .FirstOrDefaultAsync(ct);

        if (requestedMangaDocument == null)
        {
            _logger.LogError("Unable to find matching manga with id '{MangaId}' for chapter '{ChapterId}'",
                requestedChapterDocument.Id,
                requestedChapterDocument.RequestedMangaId);
            // TODO: Delete this chapter
            return;
        }

        ISource? provider = _providers.FirstOrDefault(x => x.Identifier == requestedMangaDocument.ProviderId);

        if (provider == null)
        {
            _logger.LogError("Provider {ProviderId} not found", requestedMangaDocument.ProviderId);
            // TODO: Delete this chapter
            return;
        }

        await UpdateProgress(requestedChapterDocument, 5, ct);
        Result<PageList> pageListResult = await provider.GetPageList(requestedChapterDocument.ChapterId);

        if (pageListResult.IsFailed)
        {
            _logger.LogError("Unable to get page list for {ChapterId} from {ProviderId}: {Result}",
                requestedChapterDocument.ChapterId,
                requestedMangaDocument.ProviderId,
                pageListResult.ToString());
            await MarkChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument, ct);
            return;
        }

        await UpdateProgress(requestedChapterDocument, 10, ct);

        Result<List<byte[]>> downloadPagesResult = await _pageDownloaderService.DownloadPages(provider,
            pageListResult.Value,
            p => UpdateProgress(requestedChapterDocument, 10 + (int)Math.Round(p * 0.7), ct));

        if (downloadPagesResult.IsFailed)
        {
            _logger.LogError("Unable to download pages for {ChapterId} from {ProviderId}: {Result}",
                requestedChapterDocument.ChapterId,
                requestedMangaDocument.ProviderId,
                downloadPagesResult.ToString());
            await MarkChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument, ct);
            return;
        }

        Result<ComicInfo> comicInfoResult = await _comicInfoService.Create(requestedMangaDocument.SearchId,
            requestedChapterDocument.ChapterNumber,
            downloadPagesResult.Value.Count);

        if (comicInfoResult.IsFailed)
        {
            _logger.LogError("Unable to get comic info: {Result}", comicInfoResult.ToString());
            await MarkChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument, ct);
            return;
        }

        await UpdateProgress(requestedChapterDocument, 80, ct);

        Result<byte[]> coverImageResult = await _coverImageService.DownloadCoverImage(requestedMangaDocument);

        if (coverImageResult.IsFailed)
        {
            _logger.LogError("Unable to download cover image for: {Result}", coverImageResult.ToString());
            await MarkChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument, ct);
            return;
        }

        await UpdateProgress(requestedChapterDocument, 90, ct);

        Result<byte[]> archiveResult = await _archiveService.CreateArchive(comicInfoResult.Value,
            coverImageResult.Value,
            downloadPagesResult.Value,
            ct);

        if (archiveResult.IsFailed)
        {
            _logger.LogError("Unable to create archive: {Result}", archiveResult.ToString());
            await MarkChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument, ct);
            return;
        }

        await UpdateProgress(requestedChapterDocument, 95, ct);

        Result exportResult =
            await _exportService.Export(requestedMangaDocument, requestedChapterDocument, archiveResult.Value);

        if (exportResult.IsFailed)
        {
            _logger.LogError("Unable to export archive: {Result}", exportResult.ToString());
            await MarkChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument, ct);
            return;
        }

        await UpdateProgress(requestedChapterDocument, 100, ct);
        await MarkChapterDownloadSucceeded(requestedMangaDocument, requestedChapterDocument, ct);
    }

    private async Task UpdateProgress(
        RequestedChapterDocument requestedChapterDocument,
        int progress,
        CancellationToken ct
    )
    {
        await _chapterProgressCollection.UpdateOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, requestedChapterDocument.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, progress),
                ChapterProgressDocument.Update.Set(x => x.IsActive, true)),
            null,
            ct);
    }

    private async Task MarkChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument,
        CancellationToken ct
    )
    {
        await _requestedChapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, requestedChapterDocument.Id),
            RequestedChapterDocument.Update.Set(x => x.Downloaded, false),
            null,
            ct);

        await _chapterProgressCollection.UpdateOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, requestedChapterDocument.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, 0),
                ChapterProgressDocument.Update.Set(x => x.IsActive, false)),
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
        await _requestedChapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, requestedChapterDocument.Id),
            RequestedChapterDocument.Update.Set(x => x.Downloaded, true),
            null,
            ct);

        await _chapterProgressCollection.DeleteOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, requestedChapterDocument.Id),
            ct);

        await _notificationService.NotifyChapterDownloadSucceeded(requestedMangaDocument, requestedChapterDocument);
    }
}
