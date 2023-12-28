using FluentResults;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Mangarr.Frontend.Api;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Settings.Sources;

public partial class Content
{
    private readonly List<ProviderModel> _items = new();

    private bool _isRefreshing;

    [Inject] public BackendApi BackendApi { get; set; }

    protected override void OnInitialized() => RefreshAsync();

    private async void RefreshAsync()
    {
        _isRefreshing = true;
        await InvokeAsync(StateHasChanged);

        Result<ProviderListResponse> result = await BackendApi.GetProviderList();

        if (result.IsFailed)
        {
            // TODO: log error
        }
        else
        {
            _items.Clear();
            _items.AddRange(result.Value.Data.OrderBy(x => x.Name));
        }

        _isRefreshing = false;
        await InvokeAsync(StateHasChanged);
    }
}
