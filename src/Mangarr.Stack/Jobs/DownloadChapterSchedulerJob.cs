using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Quartz;

namespace Mangarr.Stack.Jobs;

public class DownloadChapterSchedulerJob : IJob
{
    public static readonly JobKey JobKey = new("DownloadChapterSchedulerJob");

    private readonly AniListApi _aniListApi;
    private readonly ChapterProgressRepository _chapterProgressRepository;
    private readonly ILogger<DownloadChapterSchedulerJob> _logger;
    private readonly RequestedChapterRepository _requestedChapterRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;

    public DownloadChapterSchedulerJob(
        ILogger<DownloadChapterSchedulerJob> logger,
        RequestedMangaRepository requestedMangaRepository,
        RequestedChapterRepository requestedChapterRepository,
        ChapterProgressRepository chapterProgressRepository,
        AniListApi aniListApi
    )
    {
        _logger = logger;
        _requestedMangaRepository = requestedMangaRepository;
        _requestedChapterRepository = requestedChapterRepository;
        _chapterProgressRepository = chapterProgressRepository;
        _aniListApi = aniListApi;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        List<RequestedChapterDocument> chapters = _requestedChapterRepository
            .Where(x => x.MarkedForDownload && !x.Downloaded)
            .OrderBy(x => x.DateCreated)
            .ToList();

        foreach (RequestedChapterDocument chapter in chapters)
        {
            RequestedMangaDocument? manga = _requestedMangaRepository[chapter.RequestedMangaId];

            if (manga == null)
            {
                _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping chapter download scheduling",
                    chapter.RequestedMangaId);
                continue;
            }

            ChapterProgressDocument? progress = _chapterProgressRepository.GetByChapterId(chapter.Id);

            if (progress != null && progress.IsFailed)
            {
                _logger.LogWarning("Skipping chapter {Title} because there is a previously failed download",
                    _aniListApi.GetPreferredTitle(manga) + " - " + chapter.ChapterName);

                continue;
            }

            if (progress == null)
            {
                progress = new ChapterProgressDocument
                {
                    Version = ChapterProgressDocument.CurrentVersion,
                    MangaId = manga.Id,
                    MangaTitle = _aniListApi.GetPreferredTitle(manga),
                    ChapterId = chapter.Id,
                    ChapterTitle = chapter.ChapterName,
                    ChapterNumber = chapter.ChapterNumber,
                    Progress = 0
                };

                await _chapterProgressRepository.AddAsync(progress);
            }

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("DownloadChapterJob-" + chapter.ChapterId, manga.Id)
                .WithDescription($"Download '{_aniListApi.GetPreferredTitle(manga)} - {chapter.ChapterName}'")
                .ForJob(DownloadChapterJob.JobKey)
                .UsingJobData(DownloadChapterJob.IdDataKey, chapter.Id)
                .Build();

            await context.Scheduler.ScheduleJob(trigger, context.CancellationToken);
        }
    }
}
