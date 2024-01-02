using System.Web;
using Mangarr.Frontend.Extensions;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Link;

public partial class AddModal
{
    private bool _monitorNewChaptersOnly;
    [Parameter] public string Id { get; set; } = null!;
    [Parameter] public string Identifier { get; set; } = null!;
    [Parameter] public string MangaId { get; set; } = null!;

    private string SafeMangaId => MangaId.ReplaceAll(string.Empty, "+", "/", "=");

    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    private void ToggleMonitorNewChaptersOnly() => _monitorNewChaptersOnly = !_monitorNewChaptersOnly;

    private void OnAddClick() =>
        NavigationManager.NavigateTo(
            $"/manga/{Id}/add/{Identifier}/{HttpUtility.UrlEncode(MangaId)}/{_monitorNewChaptersOnly}");
}
