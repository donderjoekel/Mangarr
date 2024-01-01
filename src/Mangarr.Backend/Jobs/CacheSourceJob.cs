using Mangarr.Backend.Sources;
using Quartz;

namespace Mangarr.Backend.Jobs;

public class CacheSourceJob : IJob
{
    public const string IdDataKey = "Id";
    public static readonly JobKey JobKey = new("CacheSourceJob");

    private readonly ILogger<CacheSourceJob> _logger;
    private readonly IEnumerable<ISource> _sources;

    public CacheSourceJob(ILogger<CacheSourceJob> logger, IEnumerable<ISource> sources)
    {
        _logger = logger;
        _sources = sources;
    }

    public Task Execute(IJobExecutionContext context)
    {
        if (!context.MergedJobDataMap.TryGetString(IdDataKey, out string? id))
        {
            _logger.LogError("Unable to get id from job data");
            return Task.CompletedTask;
        }

        ISource? source = _sources.FirstOrDefault(x => x.Identifier == id);
        if (source == null)
        {
            _logger.LogError("source {SourceId} not found", id);
            return Task.CompletedTask;
        }

        return source.Cache();
    }
}
