using FluentResults;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Mangarr.Frontend.Api;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Activity;

public partial class Content
{
    private readonly List<ChapterProgressModel> _items = new();

    private bool _isRefreshing;

    [Inject] public BackendApi BackendApi { get; set; }

    protected override void OnInitialized() => RefreshAsync();

    private async void RefreshAsync()
    {
        _isRefreshing = true;
        await InvokeAsync(StateHasChanged);

        Result<ChapterProgressResponse> result = await BackendApi.GetChapterProgress();

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
