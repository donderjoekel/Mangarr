using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;
using Timer = System.Timers.Timer;

namespace Mangarr.Frontend.Pages.Activity;

public partial class Content : IDisposable
{
    private readonly List<ChapterProgressModel> _items = new();

    private bool _isRefreshing;

    private Timer? _timer;

    [Inject] public BackendApi BackendApi { get; set; }

    public void Dispose()
    {
        _timer?.Stop();
        _timer?.Dispose();
    }

    protected override void OnInitialized()
    {
        _timer = new Timer(2500);
        _timer.Elapsed += (_, _) => RefreshAsync();
        _timer.Start();

        RefreshAsync();
    }

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
            // _items.Sort((lhs, rhs) =>
            // {
            //     int comparison = rhs.IsActive.CompareTo(lhs.IsActive);
            //     if (comparison != 0)
            //     {
            //         return comparison;
            //     }
            //
            //     comparison = string.Compare(lhs.MangaTitle, rhs.MangaTitle, StringComparison.Ordinal);
            //     if (comparison != 0)
            //     {
            //         return comparison;
            //     }
            //
            //     return lhs.ChapterNumber.CompareTo(rhs.ChapterNumber);
            // });
        }

        _isRefreshing = false;
        await InvokeAsync(StateHasChanged);
    }
}
