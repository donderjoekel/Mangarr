using Mangarr.Stack.Jobs;
using Quartz;

namespace Mangarr.Stack.Initialization;

public class InitialJobScheduleInitializer : IInitializable
{
    private readonly ISchedulerFactory _schedulerFactory;

    public InitialJobScheduleInitializer(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    public int Order => int.MaxValue;

    public async Task Initialize()
    {
        IScheduler scheduler = await _schedulerFactory.GetScheduler();

        ITrigger indexMangaTrigger = TriggerBuilder.Create()
            .WithIdentity("LaunchIndexMangaSchedulerJob")
            .WithDescription("(Initial) Check for new chapters")
            .ForJob(IndexMangaSchedulerJob.JobKey)
            .StartAt(DateTimeOffset.UtcNow.AddSeconds(15))
            .Build();

        await scheduler.ScheduleJob(indexMangaTrigger);

        ITrigger downloadChapterTrigger = TriggerBuilder.Create()
            .WithIdentity("LaunchDownloadChapterSchedulerJob")
            .WithDescription("(Initial) Download requested chapters")
            .ForJob(DownloadChapterSchedulerJob.JobKey)
            .StartAt(DateTimeOffset.UtcNow.AddSeconds(30))
            .Build();

        await scheduler.ScheduleJob(downloadChapterTrigger);
    }
}
