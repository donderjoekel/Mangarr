using Mangarr.Backend.Jobs;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Quartz;

namespace Mangarr.Backend.Endpoints.Manga.Refresh;

public class MangaRefreshEndpoint : Endpoint<MangaRefreshRequest, MangaRefreshResponse>
{
    private readonly ISchedulerFactory _schedulerFactory;

    public MangaRefreshEndpoint(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    public override void Configure()
    {
        Get("/manga/{id}/refresh");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaRefreshRequest req, CancellationToken ct)
    {
        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("IndexMangaJob-" + req.Id)
            .ForJob(IndexMangaJob.JobKey)
            .UsingJobData(IndexMangaJob.IdDataKey, req.Id)
            .Build();

        IScheduler scheduler = await _schedulerFactory.GetScheduler(ct);
        await scheduler.ScheduleJob(trigger, ct);
        await SendOkAsync(ct);
    }
}
