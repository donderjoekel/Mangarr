using Mangarr.Stack.Sources;
using Quartz;

namespace Mangarr.Stack.Jobs;

public class CacheSourceSchedulerJob : IJob
{
    public static readonly JobKey JobKey = new("CacheSourceSchedulerJob");

    private readonly IEnumerable<ISource> _sources;

    public CacheSourceSchedulerJob(IEnumerable<ISource> sources) => _sources = sources;

    public async Task Execute(IJobExecutionContext context)
    {
        foreach (ISource source in _sources)
        {
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("CacheSourceJob-" + source.Identifier)
                .ForJob(CacheSourceJob.JobKey)
                .UsingJobData(CacheSourceJob.IdDataKey, source.Identifier)
                .Build();

            await context.Scheduler.ScheduleJob(trigger, context.CancellationToken);
        }
    }
}
