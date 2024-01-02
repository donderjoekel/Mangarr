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
        Post("/jobs/{group}/{name}/trigger");
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

        await scheduler.ScheduleJob(trigger, ct);
        await SendOkAsync(ct);
    }
}
