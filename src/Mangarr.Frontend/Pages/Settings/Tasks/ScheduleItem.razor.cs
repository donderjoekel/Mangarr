using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Settings.Tasks;

public partial class ScheduleItem
{
    private bool _isRequesting;
    [Parameter] public JobScheduleItemModel Item { get; set; }

    [Inject] public BackendApi BackendApi { get; set; }

    private async void RequestClicked()
    {
        _isRequesting = true;
        await InvokeAsync(StateHasChanged);

        await BackendApi.TriggerJob(Item.Group, Item.Name);

        _isRequesting = true;
        await InvokeAsync(StateHasChanged);
    }
}
