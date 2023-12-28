using Mangarr.Backend.Workers.Processors;

namespace Mangarr.Backend.Workers;

public class MainWorker : ScheduledWorkerBase
{
    private readonly MangaProcessor _mangaProcessor;
    private readonly ChapterProcessor _chapterProcessor;

    public MainWorker(
        ILogger<MainWorker> logger,
        MangaProcessor mangaProcessor,
        ChapterProcessor chapterProcessor
    )
        : base(logger)
    {
        _mangaProcessor = mangaProcessor;
        _chapterProcessor = chapterProcessor;
    }

    protected override TimeSpan Interval => TimeSpan.FromMinutes(30);

    protected override async Task ExecuteWork(CancellationToken stoppingToken)
    {
        await _mangaProcessor.Run(stoppingToken);
        await _chapterProcessor.Run(stoppingToken);
    }
}
