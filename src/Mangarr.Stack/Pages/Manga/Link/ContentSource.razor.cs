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

        SearchAsync();
        _customSearchQuery = CustomSearchQuery;
    }

    private async void SearchAsync()
    {
        IsSearching = true;

        if (!string.IsNullOrEmpty(CustomSearchQuery))
        {
            await SearchByCustom();
        }
        else
        {
            await SearchById();
        }

        IsSearching = false;
    }

    private async Task SearchByCustom()
    {
        ISource? source = SourceProvider.GetById(Item.Id);

        if (source == null)
        {
            // TODO: Handle
            return;
        }

        Result<SearchResult> result = await source.Search(CustomSearchQuery!);

        if (result.IsFailed)
        {
            // TODO: Handle
            return;
        }

        _items.Clear();
        _items.AddRange(result.Value.Items);
    }

    private async Task SearchById()
    {
        ISource? source = SourceProvider.GetById(Item.Id);

        if (source == null)
        {
            // TODO: Handle
            return;
        }

        List<string> titlesToSearch = new();

        Result<Media?> mediaResult = await AniListApi.GetMedia(SearchId);

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
        titlesToSearch = titlesToSearch.Distinct().ToList();

        List<SearchResultItem> allSearchResults = new();

        foreach (string title in titlesToSearch)
        {
            Result<SearchResult> searchResult = await source.Search(title);

            if (searchResult.IsFailed)
            {
                // TODO: Handle
                continue;
            }

            allSearchResults.AddRange(searchResult.Value.Items);
        }

        _items.Clear();
        _items.AddRange(allSearchResults.Distinct());
    }
}
