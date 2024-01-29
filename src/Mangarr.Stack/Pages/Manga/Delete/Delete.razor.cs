using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Jobs;
using Microsoft.AspNetCore.Components;
using Quartz;

namespace Mangarr.Stack.Pages.Manga.Delete;

public partial class Delete
{
    [Parameter] public string Id { get; set; } = null!;
    [Parameter] public bool DeleteChaptersFromDisk { get; set; }

    [Inject] public RequestedMangaRepository RequestedMangaRepository { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public ISchedulerFactory SchedulerFactory { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        await RequestedMangaRepository.UpdateAsync(Id,
            RequestedMangaDocument.Update.Set(x => x.Deleted, true));

        IScheduler scheduler = await SchedulerFactory.GetScheduler();

        await scheduler.ScheduleJob(TriggerBuilder.Create()
            .WithIdentity("DeleteMangaTrigger-" + Id)
            .WithDescription("Delete manga")
            .UsingJobData(DeleteMangaJob.IdDataKey, Id)
            .UsingJobData(DeleteMangaJob.DeleteChaptersFromDiskDataKey, DeleteChaptersFromDisk)
            .ForJob(DeleteMangaJob.JobKey)
            .StartNow()
            .WithPriority(int.MaxValue)
            .Build());

        NavigationManager.NavigateTo("/");
    }
}
