using Anilist4Net;
using Anilist4Net.Enums;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Settings;
using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;
using Timer = System.Timers.Timer;

namespace Mangarr.Stack.Pages.Manga.Search;

public partial class Search
{
    private readonly List<Media> _searchResults = new();

    private Result? _failureResult;
    [Notify] private bool _hasSearched;
    [Notify] private bool _isSearching;
    private string _query = string.Empty;
    [Notify] private bool _searchFailed;
    private Timer _timer = null!;

    [Inject] public AniListApi AniListApi { get; set; } = null!;
    [Inject] public SettingsApi SettingsApi { get; set; } = null!;

    protected override void OnInitialized()
    {
        _timer = new Timer(500);
        _timer.Elapsed += async (sender, args) => await SearchAsync();
    }

    private void SearchQueryChanged(ChangeEventArgs args)
    {
        IsSearching = true;
        HasSearched = true;
        SearchFailed = false;
        _failureResult = null;

        _query = args.Value?.ToString() ?? string.Empty;

        if (_timer.Enabled)
        {
            _timer.Stop();
        }

        _timer.Start();
    }

    private async Task SearchAsync()
    {
        _timer.Stop();

        if (string.IsNullOrEmpty(_query))
        {
            _searchResults.Clear();
            HasSearched = false;
            IsSearching = false;
            return;
        }

        Result<Page?> searchResult = await AniListApi.Search(_query, 1);

        if (searchResult.IsFailed)
        {
            // TODO: Log error

            _searchResults.Clear();
            _failureResult = searchResult.ToResult();
            HasSearched = false;
            IsSearching = false;
            SearchFailed = true;
            return;
        }

        if (searchResult.Value == null)
        {
            _searchResults.Clear();
            IsSearching = false;
            return;
        }

        _searchResults.Clear();
        _searchResults.AddRange(searchResult.Value.Media
            .Where(x => x.Format == MediaFormats.MANGA)
            .Where(FilterAdult));

        IsSearching = false;
    }

    private bool FilterAdult(Media media) => SettingsApi.AniList.AllowAdult || !media.IsAdult;

    private async void ToggleAdult()
    {
        SettingsApi.AniList.AllowAdult = !SettingsApi.AniList.AllowAdult;
        await SearchAsync();
    }
}
