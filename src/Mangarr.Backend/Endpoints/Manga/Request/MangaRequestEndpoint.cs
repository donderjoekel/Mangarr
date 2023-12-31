using Anilist4Net;
using FluentResults;
using Mangarr.Backend.Jobs;
using Mangarr.Backend.Services;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using Quartz;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Endpoints.Manga.Request;

public class MangaRequestEndpoint : Endpoint<MangaRequestRequest, MangaRequestResponse>
{
    private readonly AniListService _aniListService;
    private readonly IMongoCollection<RequestedMangaDocument> _collection;
    private readonly NotificationService _notificationService;
    private readonly ISchedulerFactory _schedulerFactory;

    public MangaRequestEndpoint(
        IMongoCollection<RequestedMangaDocument> collection,
        AniListService aniListService,
        NotificationService notificationService,
        ISchedulerFactory schedulerFactory
    )
    {
        _collection = collection;
        _aniListService = aniListService;
        _notificationService = notificationService;
        _schedulerFactory = schedulerFactory;
    }

    public override void Configure()
    {
        Post("/manga/request");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaRequestRequest req, CancellationToken ct)
    {
        RequestedMangaDocument? existingRequest = await _collection
            .Find(x => x.SearchId == req.SearchId)
            .FirstOrDefaultAsync(ct);

        if (existingRequest != null)
        {
            if (!AreEqual(existingRequest, req))
            {
                ThrowError("Manga already requested", StatusCodes.Status409Conflict);
            }

            await SendOkAsync(ct);
            return;
        }

        Result<Media?> mediaResult = await _aniListService.GetMedia(req.SearchId);

        if (mediaResult.IsFailed)
        {
            Logger.LogError("Unable to get media: {Result}", mediaResult.ToString());
            ThrowError("Unable to get media", StatusCodes.Status500InternalServerError);
        }

        if (mediaResult.Value == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        Media media = mediaResult.Value;

        // TODO: Make this configurable
        string title = !string.IsNullOrEmpty(media.Title.English)
            ? media.Title.English
            : media.Title.Romaji;

        RequestedMangaDocument requestedMangaDocument = new()
        {
            MangaId = req.MangaId,
            SourceId = req.ProviderId,
            SearchId = req.SearchId,
            Title = title,
            CoverUrl = media.CoverImage.ExtraLarge,
            NewChaptersOnly = req.NewChaptersOnly
        };

        await _collection.InsertOneAsync(requestedMangaDocument, null, ct);
        await _notificationService.NotifyNewManga(requestedMangaDocument);

        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("IndexMangaJob-" + requestedMangaDocument.Id)
            .ForJob(IndexMangaJob.JobKey)
            .UsingJobData(IndexMangaJob.IdDataKey, requestedMangaDocument.Id)
            .Build();

        IScheduler scheduler = await _schedulerFactory.GetScheduler(ct);
        await scheduler.ScheduleJob(trigger, ct);

        await SendOkAsync(new MangaRequestResponse { Id = requestedMangaDocument.Id }, ct);
    }

    private static bool AreEqual(RequestedMangaDocument requestedMangaDocument, MangaRequestRequest requestModel) =>
        requestedMangaDocument.SearchId == requestModel.SearchId &&
        requestedMangaDocument.SourceId == requestModel.ProviderId &&
        requestedMangaDocument.MangaId == requestModel.MangaId;
}
