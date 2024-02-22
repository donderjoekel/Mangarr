using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Activity;

public partial class ActivityItem
{
    [Inject] public ChapterProgressRepository ChapterProgressRepository { get; set; } = null!;
    [Parameter] public ChapterProgressDocument Item { get; set; } = null!;
    [Parameter] public int Index { get; set; }
    [Parameter] public EventCallback OnDelete { get; set; }

    private async Task Recycle()
    {
        await ChapterProgressRepository.DeleteAsync(Item);
        await OnDelete.InvokeAsync();
    }
}
