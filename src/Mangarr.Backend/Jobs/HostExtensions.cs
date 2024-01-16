using Quartz;

namespace Mangarr.Backend.Jobs;

public static class HostExtensions
{
    public static void AddMangarrJobs(this WebApplicationBuilder builder) =>
        builder.Services
            .AddQuartzHostedService(options =>
            {
                options.AwaitApplicationStarted = true;
                options.WaitForJobsToComplete = true;
            })
            .AddQuartz(options =>
            {
                options.AddJob<CacheSourceSchedulerJob>(CacheSourceSchedulerJob.JobKey);
                options.AddJob<CacheSourceJob>(CacheSourceJob.JobKey, configure => configure.StoreDurably())
                    .UseDefaultThreadPool(3);

                options.AddJob<IndexMangaSchedulerJob>(IndexMangaSchedulerJob.JobKey);
                options.AddJob<IndexMangaJob>(IndexMangaJob.JobKey, configure => configure.StoreDurably())
                    .UseDefaultThreadPool(5);

                options.AddJob<DownloadChapterSchedulerJob>(DownloadChapterSchedulerJob.JobKey);
                options.AddJob<DownloadChapterJob>(DownloadChapterJob.JobKey, configure => configure.StoreDurably())
                    .UseDefaultThreadPool(1);

                options.AddTrigger(configure =>
                {
                    configure
                        .WithIdentity("CacheSourceSchedulerJob")
                        .WithDescription("Cache enabled sources")
                        .ForJob(CacheSourceSchedulerJob.JobKey)
                        .WithCronSchedule("0 0/30 0 ? * * *", x => x.InTimeZone(TimeZoneInfo.Local));
                });

                options.AddTrigger(configure =>
                {
                    configure
                        .WithIdentity("IndexMangaSchedulerJob")
                        .WithDescription("Check for new chapters")
                        .ForJob(IndexMangaSchedulerJob.JobKey)
                        .WithCronSchedule("0 0 0/4 ? * * *", x => x.InTimeZone(TimeZoneInfo.Local));
                });

                options.AddTrigger(configure =>
                {
                    configure
                        .WithIdentity("DownloadChapterSchedulerJob")
                        .WithDescription("Download requested chapters")
                        .ForJob(DownloadChapterSchedulerJob.JobKey)
                        .StartNow()
                        .WithCronSchedule("0 10 0/4 ? * * *", x => x.InTimeZone(TimeZoneInfo.Local));
                });
            });
}
