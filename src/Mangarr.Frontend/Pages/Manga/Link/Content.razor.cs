using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Link;

public partial class Content
{
    private readonly List<ProviderModel> _items = new();
    private CancellationTokenSource _cancellationTokenSource = new();

    private bool _isSearching;
    [Parameter] public string Id { get; set; }
    [Parameter] public string? CustomSearchQuery { get; set; }
    [Inject] public BackendApi BackendApi { get; set; } = null!;

    protected override void OnInitialized() => SearchAsync();

    private async void SearchAsync()
    {
        _isSearching = true;
        await InvokeAsync(StateHasChanged);

        Result<ProviderListResponse> result = await BackendApi.GetProviderList();

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            _items.Clear();
            _items.AddRange(result.Value.Data.Where(x => x.Enabled).OrderBy(x => x.Name));
        }

        _isSearching = false;
        await InvokeAsync(StateHasChanged);
    }

    private Task SearchQueryChanged(ChangeEventArgs args)
    {
        string query = args.Value?.ToString() ?? string.Empty;
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        return UpdateSearch(query, _cancellationTokenSource.Token);
    }

    private async Task UpdateSearch(string query, CancellationToken ct)
    {
        _isSearching = true;
        await InvokeAsync(StateHasChanged);

        // Capture the cancellation of the search in case other keys are pressed
        try
        {
            await Task.Delay(500, ct);
        }
        catch (TaskCanceledException)
        {
            return;
        }

        // In case we're slipping through
        if (ct.IsCancellationRequested)
        {
            return;
        }

        CustomSearchQuery = query;

        _isSearching = false;
        await InvokeAsync(StateHasChanged);
    }
}
