using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Quartz;
using Quartz.Impl.Matchers;

namespace Mangarr.Backend.Endpoints.Jobs.Scheduled;

public class JobsScheduledEndpoint : Endpoint<JobsScheduledRequest, JobsScheduledResponse>
{
    private readonly ISchedulerFactory _schedulerFactory;

    public JobsScheduledEndpoint(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    public override void Configure()
    {
        Get("/jobs/scheduled");
        AllowAnonymous();
    }

    public override async Task HandleAsync(JobsScheduledRequest req, CancellationToken ct)
    {
        IReadOnlyList<IScheduler> schedulers = await _schedulerFactory.GetAllSchedulers(ct);

        List<ScheduledJobInfo> infos = new();

        foreach (IScheduler scheduler in schedulers)
        {
            IReadOnlyCollection<TriggerKey> triggerKeys =
                await scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup(), ct);

            foreach (TriggerKey triggerKey in triggerKeys)
            {
                ITrigger? trigger = await scheduler.GetTrigger(triggerKey, ct);

                if (trigger == null)
                {
                    continue;
                }

                ScheduledJobInfo scheduledJobInfo = new()
                {
                    Group = trigger.Key.Group,
                    Name = trigger.Key.Name,
                    Description = trigger.Description,
                    PreviousFireTime = trigger.GetPreviousFireTimeUtc(),
                    NextFireTime = trigger.GetNextFireTimeUtc()
                };

                infos.Add(scheduledJobInfo);
            }
        }

        await SendOkAsync(new JobsScheduledResponse { Data = infos }, ct);
    }
}
