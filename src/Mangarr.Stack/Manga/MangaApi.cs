using Anilist4Net;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Jobs;
using Mangarr.Stack.Notifications;
using MongoDB.Driver;
using Quartz;

namespace Mangarr.Stack.Manga;

public class MangaApi
{
    private readonly AniListApi _aniListApi;
    private readonly MangaMetadataRepository _mangaMetadataRepository;
    private readonly NotificationService _notificationService;
    private readonly RequestedChapterRepository _requestedChapterRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly ISchedulerFactory _schedulerFactory;

    public MangaApi(
        AniListApi aniListApi,
        NotificationService notificationService,
        ISchedulerFactory schedulerFactory,
        RequestedMangaRepository requestedMangaRepository,
        RequestedChapterRepository requestedChapterRepository,
        MangaMetadataRepository mangaMetadataRepository
    )
    {
        _aniListApi = aniListApi;
        _notificationService = notificationService;
        _schedulerFactory = schedulerFactory;
        _requestedMangaRepository = requestedMangaRepository;
        _requestedChapterRepository = requestedChapterRepository;
        _mangaMetadataRepository = mangaMetadataRepository;
    }

    public async Task<Result<string>> AddMangaAsync(
        int searchId,
        string sourceId,
        string mangaId,
        string rootFolderId,
        bool monitorNewChaptersOnly
    )
    {
        Result<Media?> mediaResult = await _aniListApi.GetMedia(searchId);

        if (mediaResult.IsFailed)
        {
            // TODO: Log error
            return mediaResult.ToResult();
        }

        Media? media = mediaResult.Value;

        if (media == null)
        {
            // TODO: Log error
            return Result.Fail("Media not found");
        }

        RequestedMangaDocument requestedMangaDocument = new()
        {
            Version = RequestedMangaDocument.CurrentVersion,
            MangaId = mangaId,
            SourceId = sourceId,
            SearchId = searchId,
            RootFolderId = rootFolderId,
            NewChaptersOnly = monitorNewChaptersOnly,
            Monitor = true,
            CreationDate = DateTime.UtcNow
        };

        await _requestedMangaRepository.AddAsync(requestedMangaDocument);

        MangaMetadataDocument mangaMetadataDocument = new()
        {
            Version = MangaMetadataDocument.CurrentVersion,
            MangaId = requestedMangaDocument.Id,
            TitleEnglish = media.Title?.English ?? string.Empty,
            TitleRomaji = media.Title?.Romaji ?? string.Empty,
            TitleNative = media.Title?.Native ?? string.Empty,
            CoverUrl = media.CoverImage.ExtraLarge,
            BannerUrl = media.BannerImage,
            DescriptionHtml = media.DescriptionHtml,
            DescriptionMd = media.DescriptionMd,
            Url = media.SiteUrl,
            Genres = media.Genres,
            Tags = media.Tags.Select(x => x.Name).ToArray()
        };

        await _mangaMetadataRepository.AddAsync(mangaMetadataDocument);

        await _notificationService.NotifyNewManga(requestedMangaDocument);

        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("IndexMangaJob-" + requestedMangaDocument.Id)
            .WithDescription($"Check '{_aniListApi.GetPreferredTitle(requestedMangaDocument)}' for new chapters")
            .ForJob(IndexMangaJob.JobKey)
            .UsingJobData(IndexMangaJob.IdDataKey, requestedMangaDocument.Id)
            .Build();

        IScheduler scheduler = await _schedulerFactory.GetScheduler();
        await scheduler.ScheduleJob(trigger);

        return Result.Ok(requestedMangaDocument.Id);
    }

    public async Task<Result> DeleteMangaAsync(string id, bool deleteChaptersFromDisk)
    {
        DeleteResult mangaDeleteResult = await _requestedMangaRepository.DeleteAsync(id);

        if (!mangaDeleteResult.IsAcknowledged)
        {
            // TODO: Handle
            return Result.Fail("Delete failed");
        }

        if (deleteChaptersFromDisk)
        {
            // TODO: Remove chapters from disk
        }

        DeleteResult chaptersDeleteResult =
            await _requestedChapterRepository.DeleteManyAsync(
                RequestedChapterDocument.Filter.Eq(x => x.RequestedMangaId, id));

        if (!chaptersDeleteResult.IsAcknowledged)
        {
            // TODO: Handle
            return Result.Fail("Delete failed");
        }

        return Result.Ok();
    }
}
