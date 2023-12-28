using FluentResults;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Mangarr.Frontend.Api;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Link;

public partial class Content
{
    [Parameter] public string Id { get; set; }
    [Inject] public BackendApi BackendApi { get; set; } = null!;

    private readonly List<ProviderModel> _items = new();

    private bool _isSearching;

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
            _items.AddRange(result.Value.Data.Where(x => x.Enabled));
        }

        _isSearching = false;
        await InvokeAsync(StateHasChanged);
    }
}
