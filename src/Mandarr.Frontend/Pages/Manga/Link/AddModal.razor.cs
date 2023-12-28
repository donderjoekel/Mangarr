using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Link;

public partial class AddModal
{
    [Parameter] public string Id { get; set; } = null!;
    [Parameter] public string Identifier { get; set; } = null!;
    [Parameter] public string MangaId { get; set; } = null!;

    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    private bool _monitorNewChaptersOnly;

    private void ToggleMonitorNewChaptersOnly()
    {
        _monitorNewChaptersOnly = !_monitorNewChaptersOnly;
    }

    private void OnAddClick()
    {
        NavigationManager.NavigateTo($"/manga/{Id}/add/{Identifier}/{MangaId}/{_monitorNewChaptersOnly}");
    }
}
