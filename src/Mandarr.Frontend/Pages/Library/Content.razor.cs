using FluentResults;
using Mandarr.Frontend.Api;
using Mandarr.Shared.Models;
using Mandarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Library;

public partial class Content
{
    private readonly List<RequestedMangaModel> _items = new();

    private bool _isRefreshing = false;

    [Inject] public BackendApi BackendApi { get; set; }

    protected override void OnInitialized() => RefreshAsync();

    private async void RefreshAsync()
    {
        _isRefreshing = true;
        await InvokeAsync(StateHasChanged);

        Result<MangaListResponse> result = await BackendApi.GetMangaList();

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            _items.Clear();
            _items.AddRange(result.Value.Data.OrderBy(x => x.Title));
        }

        _isRefreshing = false;
        await InvokeAsync(StateHasChanged);
    }
}
