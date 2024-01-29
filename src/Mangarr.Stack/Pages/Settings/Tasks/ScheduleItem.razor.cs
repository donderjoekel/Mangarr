using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;
using Quartz;

namespace Mangarr.Stack.Pages.Settings.Tasks;

public partial class ScheduleItem
{
    [Notify] private bool _isRequesting;
    [Parameter] public ITrigger Item { get; set; } = null!;
    [Inject] public ISchedulerFactory SchedulerFactory { get; set; } = null!;

    private async void RequestClicked()
    {
        IsRequesting = false;

        IScheduler scheduler = await SchedulerFactory.GetScheduler();

        ITrigger? trigger = await scheduler.GetTrigger(Item.Key);

        if (trigger == null)
        {
            return;
        }

        ITrigger newTrigger = TriggerBuilder.Create()
            .WithIdentity(new TriggerKey(Item.Key.Name + "-now", Item.Key.Group))
            .WithDescription(trigger.Description)
            .ForJob(trigger.JobKey)
            .UsingJobData(trigger.JobDataMap)
            .StartAt(DateTimeOffset.UtcNow.AddSeconds(5))
            .Build();

        await scheduler.ScheduleJob(newTrigger);

        IsRequesting = true;
    }
}
