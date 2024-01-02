using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Quartz;

namespace Mangarr.Backend.Endpoints.Jobs.Trigger;

public class JobsTriggerEndpoint : Endpoint<JobsTriggerRequest, JobsTriggerResponse>
{
    private readonly ISchedulerFactory _schedulerFactory;

    public JobsTriggerEndpoint(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    public override void Configure()
    {
        Get("/jobs/{group}/{name}/trigger");
        AllowAnonymous();
    }

    public override async Task HandleAsync(JobsTriggerRequest req, CancellationToken ct)
    {
        IScheduler scheduler = await _schedulerFactory.GetScheduler(ct);

        ITrigger? trigger = await scheduler.GetTrigger(new TriggerKey(req.Name, req.Group), ct);

        if (trigger == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        ITrigger newTrigger = TriggerBuilder.Create()
            .WithIdentity(new TriggerKey(req.Name + "-now", req.Group))
            .WithDescription(trigger.Description)
            .ForJob(trigger.JobKey)
            .UsingJobData(trigger.JobDataMap)
            .StartAt(DateTimeOffset.UtcNow.AddSeconds(5))
            .Build();

        await scheduler.ScheduleJob(newTrigger, ct);
        await SendOkAsync(ct);
    }
}
