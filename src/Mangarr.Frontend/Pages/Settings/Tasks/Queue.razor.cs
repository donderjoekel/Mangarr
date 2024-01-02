using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Settings.Tasks;

public partial class Queue
{
    private readonly List<JobQueueItemModel> _items = new();

    private bool _isRefreshing = false;

    [Inject] public BackendApi BackendApi { get; set; }

    protected override void OnInitialized() => RefreshAsync();

    private async void RefreshAsync()
    {
        _isRefreshing = true;
        await InvokeAsync(StateHasChanged);

        Result<JobsQueueResponse> result = await BackendApi.GetJobQueue();

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            _items.Clear();
            _items.AddRange(result.Value.Data);
        }

        _isRefreshing = false;
        await InvokeAsync(StateHasChanged);
    }
}
