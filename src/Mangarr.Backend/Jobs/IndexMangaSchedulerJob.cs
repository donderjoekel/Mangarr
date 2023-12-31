using MongoDB.Driver;
using Quartz;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Jobs;

public class IndexMangaSchedulerJob : IJob
{
    public static readonly JobKey JobKey = new("IndexMangaSchedulerJob");

    private readonly IMongoCollection<RequestedMangaDocument> _collection;

    public IndexMangaSchedulerJob(IMongoCollection<RequestedMangaDocument> collection) => _collection = collection;

    public async Task Execute(IJobExecutionContext context)
    {
        List<RequestedMangaDocument> documents = await _collection
            .Find(x => true)
            .ToListAsync(context.CancellationToken);

        foreach (RequestedMangaDocument document in documents)
        {
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("IndexMangaJob-" + document.MangaId)
                .ForJob(IndexMangaJob.JobKey)
                .UsingJobData(IndexMangaJob.IdDataKey, document.Id)
                .Build();

            await context.Scheduler.ScheduleJob(trigger, context.CancellationToken);
        }
    }
}
