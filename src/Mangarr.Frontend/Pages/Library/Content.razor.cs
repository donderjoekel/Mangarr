using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Library;

public partial class Content
{
    public enum DisplayMode
    {
        Cards,
        List
    }

    private readonly List<MangaListDetailsModel> _items = new();

    private DisplayMode _displayMode = DisplayMode.Cards;

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
