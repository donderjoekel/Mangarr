using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Link;

public partial class ContentSource
{
    private readonly List<ProviderMangaModel> _items = new();
    private string? _customSearchQuery;
    private bool _isSearching;
    [Parameter] public string Id { get; set; }
    [Parameter] public string? CustomSearchQuery { get; set; }
    [Parameter] public ProviderModel Item { get; set; } = null!;

    [Inject] public BackendApi BackendApi { get; set; } = null!;

    private string Identifier => Item.Identifier;
    private string Title => Item.Name;

    protected override void OnInitialized() => SearchAsync();

    protected override void OnParametersSet()
    {
        if (CustomSearchQuery != _customSearchQuery)
        {
            SearchAsync();
            _customSearchQuery = CustomSearchQuery;
        }
    }

    private async void SearchAsync()
    {
        _isSearching = true;
        await InvokeAsync(StateHasChanged);

        if (!string.IsNullOrEmpty(CustomSearchQuery))
        {
            await SearchByCustom();
        }
        else
        {
            await SearchById();
        }

        _isSearching = false;
        await InvokeAsync(StateHasChanged);
    }

    private async Task SearchByCustom()
    {
        Result<ProviderSearchResponse> result = await BackendApi.SearchProvider(Item.Identifier, CustomSearchQuery);

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            foreach (ProviderMangaModel providerMangaModel in result.Value.Data)
            {
                if (_items.Any(x => x.Id == providerMangaModel.Id))
                {
                    continue;
                }

                _items.Add(providerMangaModel);
            }
        }
    }

    private async Task SearchById()
    {
        if (!int.TryParse(Id, out int id))
        {
            // TODO: Log error
        }

        string[] titlesToSearch = Array.Empty<string>();
        Result<MangaTitlesResponse> titlesResult = await BackendApi.GetMangaTitles(id);
        if (titlesResult.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            titlesToSearch = titlesResult.Value.Data.Titles;
        }

        _items.Clear();

        foreach (string title in titlesToSearch)
        {
            Result<ProviderSearchResponse> result = await BackendApi.SearchProvider(Item.Identifier, title);

            if (result.IsFailed)
            {
                // TODO: Log error
            }
            else
            {
                foreach (ProviderMangaModel providerMangaModel in result.Value.Data)
                {
                    if (_items.Any(x => x.Id == providerMangaModel.Id))
                    {
                        continue;
                    }

                    _items.Add(providerMangaModel);
                }
            }
        }
    }
}
