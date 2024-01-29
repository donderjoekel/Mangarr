using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;
using Quartz;
using Quartz.Impl.Matchers;

namespace Mangarr.Stack.Pages.Settings.Tasks;

public partial class Queue
{
    private readonly List<ITrigger> _items = new();
    [Notify] private bool _isRefreshing = false;
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

                if (trigger == null)
                {
                    continue;
                }

                items.Add(trigger);
            }
        }

        _items.Clear();
        _items.AddRange(items.OrderBy(x => x.GetNextFireTimeUtc() ?? DateTimeOffset.MaxValue));

        IsRefreshing = false;
    }
}
