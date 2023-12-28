using FluentResults;
using Mandarr.Frontend.Api;
using Mandarr.Shared.Models;
using Mandarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Link;

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
