using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Item;

public partial class DeleteModal
{
    [Parameter] public string Id { get; set; } = null!;

    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    private bool _deleteChaptersFromDisk;

    private void ToggleDeleteChaptersFromDisk() => _deleteChaptersFromDisk = !_deleteChaptersFromDisk;

    private void OnDeleteClick() => NavigationManager.NavigateTo($"/manga/{Id}/delete/{_deleteChaptersFromDisk}");
}
