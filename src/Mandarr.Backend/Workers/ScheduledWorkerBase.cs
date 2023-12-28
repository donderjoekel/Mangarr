namespace Mandarr.Backend.Workers;

public abstract class ScheduledWorkerBase : BackgroundService
{
    private readonly ManualResetEvent _manualResetEvent = new(false);
    private readonly ILogger<ScheduledWorkerBase> _logger;

    protected ScheduledWorkerBase(ILogger<ScheduledWorkerBase> logger)
    {
        _logger = logger;
    }

    protected abstract TimeSpan Interval { get; }

    protected sealed override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Starting work");
            await ExecuteWork(stoppingToken);
            _logger.LogInformation("Work completed, waiting for timeout or reset");

            _manualResetEvent.Reset();
            int index = WaitHandle.WaitAny(new[] { stoppingToken.WaitHandle, _manualResetEvent }, Interval);

            switch (index)
            {
                case 0: // Stopping token
                    _logger.LogInformation("Stopping worker because cancellation was requested");
                    break;
                case 1: // Manual reset event
                    _logger.LogInformation("Interrupting timeout because a reset was triggered");
                    break;
                case WaitHandle.WaitTimeout: // Timeout
                    _logger.LogInformation("Timeout elapsed");
                    break;
                default: // Unexpected
                    _logger.LogWarning("Unexpected index ({Index}) returned from WaitAny", index);
                    break;
            }
        }
    }

    protected abstract Task ExecuteWork(CancellationToken stoppingToken);
}