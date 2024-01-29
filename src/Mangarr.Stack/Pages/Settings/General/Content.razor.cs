using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Settings.General;

public partial class Content
{
    private string _rootFolderPath = string.Empty;

    [Inject] public RootFolderRepository RootFolderRepository { get; set; } = null!;

    private async Task OnAddRootFolderClicked()
    {
        if (string.IsNullOrEmpty(_rootFolderPath))
        {
            return;
        }

        await RootFolderRepository.AddAsync(new RootFolderDocument
        {
            Version = RootFolderDocument.CurrentVersion, Path = _rootFolderPath
        });
        _rootFolderPath = string.Empty;
        await InvokeAsync(StateHasChanged);
    }

    private async Task OnRemoveRootFolderClicked(string id)
    {
        await RootFolderRepository.DeleteAsync(id);
        await InvokeAsync(StateHasChanged);
    }
}
