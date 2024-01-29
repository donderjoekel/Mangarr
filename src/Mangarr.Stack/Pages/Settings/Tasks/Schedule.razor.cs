using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;
using Quartz;
using Quartz.Impl.Matchers;

namespace Mangarr.Stack.Pages.Settings.Tasks;

public partial class Schedule
{
    private readonly List<ITrigger> _items = new();

    [Notify] private bool _isRefreshing;

    [Inject] public ISchedulerFactory SchedulerFactory { get; set; } = null!;

    protected override void OnInitialized() => RefreshAsync();

    private async void RefreshAsync()
    {
        IsRefreshing = true;

        IReadOnlyList<IScheduler> schedulers = await SchedulerFactory.GetAllSchedulers();

        List<ITrigger> items = new();

        foreach (IScheduler scheduler in schedulers)
        {
            IReadOnlyCollection<TriggerKey> triggerKeys =
                await scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());

            foreach (TriggerKey triggerKey in triggerKeys)
            {
                ITrigger? trigger = await scheduler.GetTrigger(triggerKey);

                if (await IsValid(scheduler, trigger))
                {
                    items.Add(trigger!);
                }
            }
        }

        _items.Clear();
        _items.AddRange(items);

        IsRefreshing = false;
    }

    private async Task<bool> IsValid(IScheduler scheduler, ITrigger? trigger)
    {
        if (trigger == null)
        {
            return false;
        }

        // Pretty poor way of filtering this to be honest
        if (trigger.Description?.Contains("(initial)", StringComparison.OrdinalIgnoreCase) ?? false)
        {
            return false;
        }

        // Also pretty poor way of filtering this
        if (trigger.Key.Name.EndsWith("-now", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        IJobDetail? jobDetail = await scheduler.GetJobDetail(trigger.JobKey);

        if (jobDetail == null)
        {
            return false;
        }

        if (jobDetail.Durable)
        {
            return false;
        }

        return true;
    }
}
