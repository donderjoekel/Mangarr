using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Repositories;
using Quartz;
using RequestedMangaDocument = Mangarr.Stack.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Stack.Jobs;

public class IndexMangaSchedulerJob : IJob
{
    public static readonly JobKey JobKey = new("IndexMangaSchedulerJob");

    private readonly AniListApi _aniListApi;
    private readonly RequestedMangaRepository _repository;

    public IndexMangaSchedulerJob(RequestedMangaRepository repository, AniListApi aniListApi)
    {
        _repository = repository;
        _aniListApi = aniListApi;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        foreach (RequestedMangaDocument document in _repository.Items)
        {
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("IndexMangaJob-" + document.MangaId)
                .WithDescription($"Check '{_aniListApi.GetPreferredTitle(document)}' for new chapters")
                .ForJob(IndexMangaJob.JobKey)
                .UsingJobData(IndexMangaJob.IdDataKey, document.Id)
                .Build();

            await context.Scheduler.ScheduleJob(trigger, context.CancellationToken);
        }
    }
}
