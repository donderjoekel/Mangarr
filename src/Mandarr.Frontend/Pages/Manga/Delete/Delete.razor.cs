using FluentResults;
using Mandarr.Frontend.Api;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Delete;

public partial class Delete
{
    [Parameter] public string Id { get; set; } = null!;
    [Parameter] public bool DeleteChaptersFromDisk { get; set; }

    [Inject] public BackendApi BackendApi { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    protected override void OnInitialized() => DeleteAsync();

    private async void DeleteAsync()
    {
        Result result = await BackendApi.DeleteManga(Id, DeleteChaptersFromDisk);

        if (result.IsFailed)
        {
            // TODO: Log error
        }

        NavigationManager.NavigateTo("/");
    }
}
