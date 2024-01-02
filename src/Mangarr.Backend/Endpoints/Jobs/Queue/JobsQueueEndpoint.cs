using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Quartz;
using Quartz.Impl.Matchers;

namespace Mangarr.Backend.Endpoints.Jobs.Queue;

public class JobsQueueEndpoint : Endpoint<JobsQueueRequest, JobsQueueResponse>
{
    private readonly ISchedulerFactory _schedulerFactory;

    public JobsQueueEndpoint(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    public override void Configure()
    {
        Get("/jobs/queue");
        AllowAnonymous();
    }

    public override async Task HandleAsync(JobsQueueRequest req, CancellationToken ct)
    {
        IReadOnlyList<IScheduler> schedulers = await _schedulerFactory.GetAllSchedulers(ct);

        List<JobQueueItemModel> items = new();

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

                JobQueueItemModel item = new()
                {
                    Group = trigger.Key.Group,
                    Name = trigger.Key.Name,
                    Description = trigger.Description,
                    PreviousFireTime = trigger.GetPreviousFireTimeUtc(),
                    NextFireTime = trigger.GetNextFireTimeUtc()
                };

                items.Add(item);
            }
        }

        await SendOkAsync(new JobsQueueResponse { Data = items }, ct);
    }
}
