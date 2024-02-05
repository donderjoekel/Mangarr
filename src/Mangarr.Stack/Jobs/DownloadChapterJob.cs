using FluentResults;
using Mangarr.Stack.Archival;
using Mangarr.Stack.Comic;
using Mangarr.Stack.Cover;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Downloading;
using Mangarr.Stack.Exporting;
using Mangarr.Stack.Notifications;
using Mangarr.Stack.Sources;
using Quartz;
using ISource = Mangarr.Stack.Sources.ISource;
using PageList = Mangarr.Stack.Sources.Models.Page.PageList;

namespace Mangarr.Stack.Jobs;

public class DownloadChapterJob : IJob
{
    public const string IdDataKey = "Id";

    public static readonly JobKey JobKey = new("DownloadChapterJob");

    private readonly ArchiveService _archiveService;
    private readonly ChapterProgressRepository _chapterProgressRepository;
    private readonly ComicInfoService _comicInfoService;
    private readonly CoverImageService _coverImageService;
    private readonly ExportService _exportService;
    private readonly ILogger<DownloadChapterJob> _logger;
    private readonly NotificationService _notificationService;
    private readonly PageDownloaderService _pageDownloaderService;
    private readonly RequestedChapterRepository _requestedChapterRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly SourceProvider _sourceProvider;

    private Archive _archive = null!;
    private RequestedChapterDocument? _chapter;
    private ComicInfo _comicInfo = null!;
    private CoverImage _coverImage = null!;
    private CancellationToken _ct;
    private DownloadedPages _downloadedPages = null!;
    private RequestedMangaDocument? _manga;
    private PageList _pageList = null!;
    private ISource? _source;

    public DownloadChapterJob(
        ILogger<DownloadChapterJob> logger,
        ArchiveService archiveService,
        ComicInfoService comicInfoService,
        CoverImageService coverImageService,
        ExportService exportService,
        PageDownloaderService pageDownloaderService,
        NotificationService notificationService,
        RequestedChapterRepository requestedChapterRepository,
        RequestedMangaRepository requestedMangaRepository,
        SourceProvider sourceProvider,
        ChapterProgressRepository chapterProgressRepository
    )
    {
        _logger = logger;
        _archiveService = archiveService;
        _comicInfoService = comicInfoService;
        _coverImageService = coverImageService;
        _exportService = exportService;
        _pageDownloaderService = pageDownloaderService;
        _notificationService = notificationService;
        _requestedChapterRepository = requestedChapterRepository;
        _requestedMangaRepository = requestedMangaRepository;
        _sourceProvider = sourceProvider;
        _chapterProgressRepository = chapterProgressRepository;

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

        try
        {
            await DownloadChapter(id!);
        }
        catch (Exception e)
        {
            RequestedMangaDocument? requestedMangaDocument = _requestedMangaRepository[id!];

            if (requestedMangaDocument == null)
            {
                return;
            }

            _logger.LogError(e, "Error while downloading chapter");
            throw;
        }
    }

    private async Task DownloadChapter(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            _logger.LogError("Id is empty");
            return;
        }

        if (!TryGetChapter(id))
        {
            _logger.LogInformation("Chapter with id '{Id}' no longer exists, skipping download", id);
            return;
        }

        if (!TryGetManga())
        {
            _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping download",
                _chapter!.RequestedMangaId);
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
        await MarkChapterDownloadSucceeded();
    }

    private bool TryGetChapter(string id)
    {
        _chapter = _requestedChapterRepository[id];
        return _chapter != null;
    }

    private bool TryGetManga()
    {
        _manga = _requestedMangaRepository[_chapter!.RequestedMangaId];
        return _manga != null && !_manga.Deleted;
    }

    private bool TryGetSource()
    {
        _source = _sourceProvider.GetById(_manga!.SourceId);
        return _source != null;
    }

    private async Task<bool> TryGetPageList()
    {
        Result<PageList> result = await _source!.GetPageList(_chapter!.ChapterId);

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
        Result<DownloadedPages> downloadPages =
            await _pageDownloaderService.DownloadPages(_chapter!.Id, _source!, _pageList);

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
        Result<ComicInfo> result = await _comicInfoService.Create(_manga!.SearchId,
            _chapter!.ChapterNumber,
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
        Result<CoverImage> result = await _coverImageService.GetCoverImage(_manga!);

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
        Result result = await _exportService.Export(_manga!, _chapter!, _archive);

        if (result.IsFailed)
        {
            _logger.LogError("Unable to export archive: {Result}", result.ToString());
            return false;
        }

        return true;
    }

    private Task OnPageDownloaderProgress(string chapterId, int progress)
    {
        if (chapterId != _chapter!.Id)
        {
            return Task.CompletedTask;
        }

        return SetProgress(10 + (int)Math.Round(progress * 0.8f));
    }

    private async Task SetProgress(int progress) =>
        await _chapterProgressRepository.UpdateAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, _chapter!.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, progress),
                ChapterProgressDocument.Update.Set(x => x.IsActive, true)));

    private async Task MarkChapterDownloadFailed()
    {
        await _requestedChapterRepository.UpdateAsync(_chapter!.Id,
            RequestedChapterDocument.Update.Set(x => x.Downloaded, false));

        await _chapterProgressRepository.UpdateAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, _chapter.Id),
            ChapterProgressDocument.Update.Combine(
                ChapterProgressDocument.Update.Set(x => x.Progress, 0),
                ChapterProgressDocument.Update.Set(x => x.IsActive, false),
                ChapterProgressDocument.Update.Set(x => x.IsFailed, true)));

        await _notificationService.NotifyChapterDownloadFailed(_manga!, _chapter);
    }

    private async Task MarkChapterDownloadSucceeded()
    {
        await _requestedChapterRepository.UpdateAsync(_chapter!.Id,
            RequestedChapterDocument.Update.Combine(
                RequestedChapterDocument.Update.Set(x => x.DateDownloaded, DateTime.UtcNow),
                RequestedChapterDocument.Update.Set(x => x.Downloaded, true),
                RequestedChapterDocument.Update.Set(x => x.MarkedForDownload, false)));

        await _chapterProgressRepository.DeleteAsync(
            ChapterProgressDocument.Filter.Eq(x => x.ChapterId, _chapter.Id));

        await _notificationService.NotifyChapterDownloadSucceeded(_manga!, _chapter);
    }
}
