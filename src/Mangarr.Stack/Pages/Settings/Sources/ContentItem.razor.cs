using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;

namespace Mangarr.Stack.Pages.Settings.Sources;

public partial class ContentItem
{
    [Notify] private bool _isUpdating;

    [Parameter] public SourceDocument Item { get; set; } = null!;

    [Inject] public SourceRepository SourceRepository { get; set; } = null!;

    private async Task ToggleEnabledAsync()
    {
        IsUpdating = true;
        await SetEnabled(!Item.Enabled);
        IsUpdating = false;
    }

    private async Task SetEnabled(bool value)
    {
        Item.Enabled = value;
        (Item, _) = await SourceRepository.UpdateAsync(Item);
        await InvokeAsync(StateHasChanged);
    }
}
