using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Quartz;
using Quartz.Impl.Matchers;

namespace Mangarr.Backend.Endpoints.Jobs.Schedule;

public class JobsScheduleEndpoint : Endpoint<JobsScheduleRequest, JobsScheduleResponse>
{
    private readonly ISchedulerFactory _schedulerFactory;

    public JobsScheduleEndpoint(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    public override void Configure()
    {
        Get("/jobs/schedule");
        AllowAnonymous();
    }

    public override async Task HandleAsync(JobsScheduleRequest req, CancellationToken ct)
    {
        IReadOnlyList<IScheduler> schedulers = await _schedulerFactory.GetAllSchedulers(ct);

        List<JobScheduleItemModel> items = new();

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

                // Pretty poor way of filtering this to be honest
                if (trigger.Description?.Contains("(initial)", StringComparison.OrdinalIgnoreCase) ?? false)
                {
                    continue;
                }

                // Also pretty poor way of filtering this
                if (trigger.JobKey.Name.EndsWith("-now", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                IJobDetail? jobDetail = await scheduler.GetJobDetail(trigger.JobKey, ct);

                if (jobDetail == null)
                {
                    continue;
                }

                if (jobDetail.Durable)
                {
                    continue;
                }

                JobScheduleItemModel item = new()
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

        await SendOkAsync(new JobsScheduleResponse { Data = items }, ct);
    }
}
