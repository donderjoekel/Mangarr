using Mangarr.Backend.Jobs;
using Quartz;

namespace Mangarr.Backend.Initialization;

public class JobsInitializer : IInitializer
{
    private readonly ISchedulerFactory _schedulerFactory;

    public JobsInitializer(ISchedulerFactory schedulerFactory) => _schedulerFactory = schedulerFactory;

    int IInitializer.Order => 0;

    async Task IInitializer.Initialize()
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
