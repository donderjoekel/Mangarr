using MongoDB.Driver;
using Quartz;
using ChapterProgressDocument = Mangarr.Backend.Database.Documents.ChapterProgressDocument;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Drone.Jobs;

public class DownloadChapterSchedulerJob : IJob
{
    public static readonly JobKey JobKey = new("DownloadChapterSchedulerJob");

    private readonly ILogger<DownloadChapterSchedulerJob> _logger;
    private readonly IMongoCollection<RequestedMangaDocument> _mangaCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _chapterCollection;
    private readonly IMongoCollection<ChapterProgressDocument> _progressCollection;

    public DownloadChapterSchedulerJob(
        ILogger<DownloadChapterSchedulerJob> logger,
        IMongoCollection<RequestedMangaDocument> mangaCollection,
        IMongoCollection<RequestedChapterDocument> chapterCollection,
        IMongoCollection<ChapterProgressDocument> progressCollection
    )
    {
        _logger = logger;
        _mangaCollection = mangaCollection;
        _chapterCollection = chapterCollection;
        _progressCollection = progressCollection;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        List<RequestedMangaDocument> mangas = await _mangaCollection
            .Find(x => true)
            .ToListAsync(context.CancellationToken);

        List<RequestedChapterDocument> chapters = await _chapterCollection
            .Find(x => x.MarkedForDownload && !x.Downloaded)
            .ToListAsync(context.CancellationToken);

        foreach (RequestedChapterDocument chapter in chapters)
        {
            RequestedMangaDocument? manga = mangas.FirstOrDefault(x => x.Id == chapter.RequestedMangaId);

            if (manga == null)
            {
                _logger.LogInformation("Manga with id '{Id}' no longer exists, skipping chapter download scheduling",
                    chapter.RequestedMangaId);
                continue;
            }

            long count = await _progressCollection.CountDocumentsAsync(
                ChapterProgressDocument.Filter.Eq(x => x.ChapterId, chapter.Id),
                null,
                context.CancellationToken);

            if (count == 0)
            {
                ChapterProgressDocument progress = new()
                {
                    MangaId = manga.Id,
                    MangaTitle = manga.Title,
                    ChapterId = chapter.Id,
                    ChapterNumber = chapter.ChapterNumber,
                    Progress = 0
                };

                await _progressCollection.InsertOneAsync(progress, null, context.CancellationToken);
            }

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("DownloadChapterJob-" + chapter.ChapterId)
                .ForJob(DownloadChapterJob.JobKey)
                .UsingJobData(DownloadChapterJob.IdDataKey, chapter.Id)
                .Build();

            await context.Scheduler.ScheduleJob(trigger, context.CancellationToken);
        }
    }
}
