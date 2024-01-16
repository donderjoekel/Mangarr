using FluentResults;
using Mangarr.Backend.Archival;
using Mangarr.Backend.Conversion;
using Mangarr.Backend.Cover;
using Mangarr.Backend.Data;
using Mangarr.Backend.Downloading;
using Mangarr.Backend.Notifications;
using Mangarr.Backend.Services;
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
    private readonly ConversionService _conversionService;
    private readonly CoverImageService _coverImageService;
    private readonly ExportService _exportService;
    private readonly ILogger<DownloadChapterJob> _logger;
    private readonly IMongoCollection<RequestedMangaDocument> _mangaCollection;
    private readonly NotificationService _notificationService;
    private readonly PageDownloaderService _pageDownloaderService;
    private readonly IMongoCollection<ChapterProgressDocument> _progressCollection;
    private readonly IEnumerable<ISource> _sources;
    private Archive _archive = null!;

    private RequestedChapterDocument _chapter = null!;
    private ComicInfo _comicInfo = null!;
    private CoverImage _coverImage = null!;
    private CancellationToken _ct;
    private DownloadedPages _downloadedPages = null!;
    private RequestedMangaDocument _manga = null!;
    private PageList _pageList = null!;
    private int _progress;
    private ISource _source = null!;

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
        NotificationService notificationService,
        ConversionService conversionService
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
        _conversionService = conversionService;

        _pageDownloaderService.Progress += OnPageDownloaderProgress;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        _ct = context.CancellationToken;

        if (!context.MergedJobDataMap.TryGetString(IdDataKey, out string? id))
        {
            _logger.LogError("Unable to get id from job data");
            return;
        }

        if (!await TryGetChapter(id!))
        {
            _logger.LogInformation("Chapter with id '{Id}' no longer exists, skipping download", id);
            return;
        }

        if (!await TryGetManga())
        {
            _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping download",
                _chapter.RequestedMangaId);
            return;
        }

        if (!TryGetSource())
        {
            _logger.LogError("Unable to find source with id '{Id}', aborting download", _manga!.SourceId);
            return;
        }

        await SetProgress(5);

        if (!await TryGetPageList())
        {
            await MarkChapterDownloadFailed();
            return;
        }

        await SetProgress(10);

        if (!await TryDownloadPages())
        {
            await MarkChapterDownloadFailed();
            return;
        }

        if (!await TryCreateComicInfo())
        {
            await MarkChapterDownloadFailed();
            return;
        }

        await SetProgress(85);

        if (!await TryGetCoverImage())
        {
            await MarkChapterDownloadFailed();
            return;
        }

        await SetProgress(90);

        if (!await TryCreateArchive())
        {
            await MarkChapterDownloadFailed();
            return;
        }

        await SetProgress(95);

        if (!await TryExportArchive())
        {
            await MarkChapterDownloadFailed();
            return;
        }

        await SetProgress(100);
        await MarkChapterDownloadSucceeded(_manga, _chapter, _ct);
    }

    private async Task<bool> TryGetChapter(string id)
    {
        _chapter = await _chapterCollection
            .Find(x => x.Id == id)
            .FirstOrDefaultAsync(_ct);

        return _chapter != null;
    }

    private async Task<bool> TryGetManga()
    {
        _manga = await _mangaCollection
            .Find(x => x.Id == _chapter!.RequestedMangaId)
            .FirstOrDefaultAsync(_ct);

        return _manga != null;
    }

    private bool TryGetSource()
    {
        ISource? source = _sources.FirstOrDefault(x => x.Identifier == _manga.SourceId);

        if (source == null)
        {
            return false;
        }

        _source = source;
        return true;
    }

    private async Task<bool> TryGetPageList()
    {
        Result<PageList> result = await _source.GetPageList(_chapter.ChapterId);

        if (result.IsFailed)
        {
            _logger.LogError("Unable to get page list: {Result}", result.ToString());
            return false;
        }

        _pageList = result.Value;
        return true;
    }

    private async Task<bool> TryDownloadPages()
    {
        Result<DownloadedPages> downloadPages = await _pageDownloaderService.DownloadPages(_source, _pageList);

        if (downloadPages.IsFailed)
        {
            _logger.LogError("Unable to download pages: {Result}", downloadPages.ToString());
            return false;
        }

        _downloadedPages = downloadPages.Value;
        return true;
    }

    private async Task<bool> TryCreateComicInfo()
    {
        Result<ComicInfo> result = await _comicInfoService.Create(_manga.SearchId,
            _chapter.ChapterNumber,
            _downloadedPages.Pages.Count);

        if (result.IsFailed)
        {
            _logger.LogError("Unable to create comic info: {Result}", result.ToString());
            return false;
        }

        _comicInfo = result.Value;
        return true;
    }

    private async Task<bool> TryGetCoverImage()
    {
        Result<CoverImage> result = await _coverImageService.GetCoverImage(_manga);

        if (result.IsFailed)
        {
            _logger.LogError("Unable to get cover image: {Result}", result.ToString());
            return false;
        }

        _coverImage = result.Value;
        return true;
    }

    private async Task<bool> TryCreateArchive()
    {
        Result<Archive> archive = await _archiveService.CreateArchive(_comicInfo, _coverImage, _downloadedPages, _ct);

        if (archive.IsFailed)
        {
            _logger.LogError("Unable to create archive: {Result}", archive.ToString());
            return false;
        }

        _archive = archive.Value;
        return true;
    }

    private async Task<bool> TryExportArchive()
    {
        Result result = await _exportService.Export(_manga, _chapter, _archive);

        if (result.IsFailed)
        {
            _logger.LogError("Unable to export archive: {Result}", result.ToString());
            return false;
        }

        return true;
    }

    private Task OnPageDownloaderProgress(int progress) => SetProgress(10 + (int)Math.Round(progress * 0.8f));

    private async Task SetProgress(int progress)
    {
        _progress = progress;

        await _progressCollection.UpdateOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, _chapter.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, _progress),
                ChapterProgressDocument.Update.Set(x => x.IsActive, true)),
            null,
            _ct);
    }

    private Task IncrementProgress(int amount) => SetProgress(_progress + amount);

    private async Task MarkChapterDownloadFailed()
    {
        await _chapterCollection.UpdateOneAsync(
            RequestedChapterDocument.Filter.Eq(x => x.Id, _chapter.Id),
            RequestedChapterDocument.Update.Set(x => x.Downloaded, false),
            null,
            _ct);

        await _progressCollection.UpdateOneAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, _chapter.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, 0),
                ChapterProgressDocument.Update.Set(x => x.IsActive, false),
                ChapterProgressDocument.Update.Set(x => x.IsFailed, true)),
            null,
            _ct);

        await _notificationService.NotifyChapterDownloadFailed(_manga, _chapter);
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
