using Anilist4Net;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Sources;
using Mangarr.Stack.Sources.Models.Search;
using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;

namespace Mangarr.Stack.Pages.Manga.Link;

public partial class ContentSource
{
    private static Dictionary<string, CancellationTokenSource> _cancellationTokens = new();
    private readonly List<SearchResultItem> _items = new();
    private string? _customSearchQuery = string.Empty;
    [Notify] private bool _isSearching;

    [Inject] public AniListApi AniListApi { get; set; } = null!;
    [Inject] public SourceProvider SourceProvider { get; set; } = null!;

    [Parameter] public int SearchId { get; set; }
    [Parameter] public string? CustomSearchQuery { get; set; }
    [Parameter] public SourceDocument Item { get; set; } = null!;

    protected override void OnInitialized() => SearchAsync();

    protected override void OnParametersSet()
    {
        if (CustomSearchQuery == _customSearchQuery)
        {
            return;
        }

        if (!_cancellationTokens.TryGetValue(Item.Id, out CancellationTokenSource? _cts))
        {
            _cts = new CancellationTokenSource();
            _cancellationTokens.Add(Item.Id, _cts);
        }

        _cts.Cancel();
        _cts = new CancellationTokenSource();
        SearchAsync(_cts.Token);
        _customSearchQuery = CustomSearchQuery;
    }

    private async void SearchAsync(CancellationToken ct = default)
    {
        IsSearching = true;

        if (!string.IsNullOrEmpty(CustomSearchQuery))
        {
            await SearchByCustom(ct);
        }
        else
        {
            await SearchById(ct);
        }

        IsSearching = false;
    }

    private async Task SearchByCustom(CancellationToken ct = default)
    {
        ISource? source = SourceProvider.GetById(Item.Id);

        if (source == null)
        {
            // TODO: Handle
            return;
        }

        Result<SearchResult> result = await source.Search(CustomSearchQuery!, ct);

        if (ct.IsCancellationRequested)
        {
            return;
        }

        if (result.IsFailed)
        {
            // TODO: Handle
            return;
        }

        _items.Clear();
        _items.AddRange(result.Value.Items);
    }

    private async Task SearchById(CancellationToken ct = default)
    {
        ISource? source = SourceProvider.GetById(Item.Id);

        if (source == null)
        {
            // TODO: Handle
            return;
        }

        List<string> titlesToSearch = new();

        Result<Media?> mediaResult = await AniListApi.GetMedia(SearchId);

        if (ct.IsCancellationRequested)
        {
            return;
        }

        if (mediaResult.IsFailed)
        {
            // TODO: Handle
            return;
        }

        Media? media = mediaResult.Value;

        titlesToSearch.Add(media!.Title.English);
        titlesToSearch.Add(media.Title.Romaji);
        titlesToSearch.Add(media.Title.Native);
        titlesToSearch.AddRange(media.Synonyms);
        titlesToSearch = titlesToSearch.Distinct().Where(x => !string.IsNullOrEmpty(x)).ToList();

        List<SearchResultItem> allSearchResults = new();

        foreach (string title in titlesToSearch)
        {
            Result<SearchResult> searchResult = await source.Search(title, ct);

            if (searchResult.IsFailed)
            {
                // TODO: Handle
                continue;
            }

            if (ct.IsCancellationRequested)
            {
                break;
            }

            allSearchResults.AddRange(searchResult.Value.Items);
            _items.Clear();
            _items.AddRange(allSearchResults.Distinct());
            await InvokeAsync(StateHasChanged);
        }
    }
}
