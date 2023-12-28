using FluentResults;
using Mangarr.Shared.Responses;
using Mangarr.Frontend.Api;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Add;

public partial class Add
{
    [Parameter] public string Id { get; set; } = null!;
    [Parameter] public string Source { get; set; } = null!;
    [Parameter] public string MangaId { get; set; } = null!;
    [Parameter] public bool MonitorNewChaptersOnly { get; set; }

    [Inject] public BackendApi BackendApi { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    protected override void OnInitialized() => AddAsync();

    private async void AddAsync()
    {
        Result<MangaRequestResponse> result =
            await BackendApi.RequestManga(int.Parse(Id), Source, MangaId, MonitorNewChaptersOnly);

        if (result.IsSuccess)
        {
            NavigationManager.NavigateTo("/manga/" + result.Value.Id);
        }
        else
        {
            // TODO: Log error
        }
    }
}
