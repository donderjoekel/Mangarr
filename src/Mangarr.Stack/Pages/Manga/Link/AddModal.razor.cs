using System.Web;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Extensions;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Link;

public partial class AddModal
{
    private bool _monitorNewChaptersOnly;
    private string? _rootFolderId;

    [Parameter] public int SearchId { get; set; }
    [Parameter] public string SourceId { get; set; } = null!;
    [Parameter] public string MangaId { get; set; } = null!;

    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public RootFolderRepository RootFolderRepository { get; set; } = null!;

    private string SafeMangaId => MangaId.ReplaceAll(string.Empty, "+", "/", "=");

    protected override void OnInitialized() => _rootFolderId = RootFolderRepository.First().Id;

    private void ToggleMonitorNewChaptersOnly() => _monitorNewChaptersOnly = !_monitorNewChaptersOnly;

    private void OnAddClick() =>
        NavigationManager.NavigateTo(
            $"/manga/{SearchId}/add/{SourceId}/{HttpUtility.UrlEncode(MangaId)}/{_rootFolderId}/{_monitorNewChaptersOnly}");

    private void OnRootFolderSelectionChanged(ChangeEventArgs obj) => _rootFolderId = obj.Value?.ToString();
}
