using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Item;

public partial class Item
{
    private bool _deleteChaptersFromDisk;

    [Parameter] public string Id { get; set; } = null!;

    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    private void ToggleDeleteChaptersFromDisk() => _deleteChaptersFromDisk = !_deleteChaptersFromDisk;

    private void OnDeleteClick() => NavigationManager.NavigateTo($"/manga/{Id}/delete/{_deleteChaptersFromDisk}");
}
