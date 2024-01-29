using Mangarr.Stack.Data;
using Mangarr.Stack.Library;
using Mangarr.Stack.Settings;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Library;

public partial class Library : ComponentBase
{
    private readonly List<ContentItemModel> _items = new();

    [Inject] public LibraryApi LibraryApi { get; set; } = null!;
    [Inject] public SettingsApi SettingsApi { get; set; } = null!;

    protected override void OnInitialized() => UpdateItems();

    private void UpdateItems()
    {
        _items.Clear();
        _items.AddRange(LibraryApi.GetSortedLibrary());
        InvokeAsync(StateHasChanged);
    }

    private void ToggleAscending()
    {
        SettingsApi.Library.Ascending = !SettingsApi.Library.Ascending;
        UpdateItems();
    }

    private void SetDisplayMode(LibraryDisplayMode value)
    {
        SettingsApi.Library.DisplayMode = value;
        UpdateItems();
    }

    private void SetSortMode(LibrarySortMode value)
    {
        SettingsApi.Library.SortMode = value;
        UpdateItems();
    }
}
