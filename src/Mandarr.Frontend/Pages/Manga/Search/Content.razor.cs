using FluentResults;
using Mandarr.Frontend.Api;
using Mandarr.Shared.Models;
using Mandarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Search;

public partial class Content
{
    [Inject] public BackendApi BackendApi { get; set; } = null!;

    private readonly HashSet<int> _existingMangaIds = new();
    private readonly List<SearchResultModel> _searchResults = new();
    private CancellationTokenSource _cancellationTokenSource = new();
    private bool _initialized;
    private bool _hasSearched;
    private bool _isSearching;

    protected override void OnInitialized() => GetRequestedMangasAsync();

    private async void GetRequestedMangasAsync()
    {
        _initialized = false;
        await InvokeAsync(StateHasChanged);

        Result<MangaListResponse> result = await BackendApi.GetMangaList();

        if (result.IsSuccess)
        {
            _existingMangaIds.Clear();
            foreach (RequestedMangaModel requestedMangaModel in result.Value.Data)
            {
                _existingMangaIds.Add(requestedMangaModel.SearchId);
            }
        }
        else
        {
            // TODO: Log error
        }

        _initialized = true;
        await InvokeAsync(StateHasChanged);
    }

    private Task SearchQueryChanged(ChangeEventArgs args)
    {
        string query = args.Value?.ToString() ?? string.Empty;
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        return Search(query, _cancellationTokenSource.Token);
    }

    private async Task Search(string query, CancellationToken ct)
    {
        if (string.IsNullOrEmpty(query))
        {
            _isSearching = false;
            _hasSearched = false;
            _searchResults.Clear();
            await InvokeAsync(StateHasChanged);
            return;
        }

        _isSearching = true;
        _hasSearched = true;
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

        Result<MangaSearchResponse> result = await BackendApi.Search(query);

        if (ct.IsCancellationRequested)
        {
            return;
        }

        if (result.IsSuccess)
        {
            _searchResults.Clear();
            _searchResults.AddRange(result.Value.Data);
        }
        else
        {
            // TODO: Log error
        }

        _isSearching = false;
        await InvokeAsync(StateHasChanged);
    }
}
