using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Activity;

public partial class Activity
{
    private readonly List<ChapterProgressDocument> _items = new();

    [Inject] public ChapterProgressRepository Repository { get; set; } = null!;

    protected override void OnInitialized() => Refresh();

    private void Refresh()
    {
        _items.Clear();
        _items.AddRange(Repository.Items.OrderByDescending(x => x.IsActive));
        InvokeAsync(StateHasChanged);
    }
}
