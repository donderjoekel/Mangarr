using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Settings.Sources;

public partial class Content
{
    private readonly List<SourceDocument> _items = new();

    private string? _filter;

    [Inject] public SourceRepository SourceRepository { get; set; } = null!;

    protected override void OnInitialized() => _items.AddRange(SourceRepository.OrderBy(x => x.Name));

    private void FilterChanged(ChangeEventArgs args)
    {
        _filter = args.Value?.ToString() ?? string.Empty;

        _items.Clear();

        if (string.IsNullOrEmpty(_filter))
        {
            _items.AddRange(SourceRepository.OrderBy(x => x.Name));
        }
        else
        {
            _items.AddRange(SourceRepository
                .Where(x => x.Name.Contains(_filter, StringComparison.OrdinalIgnoreCase) ||
                            x.Identifier.Contains(_filter, StringComparison.OrdinalIgnoreCase) ||
                            x.Url.Contains(_filter, StringComparison.OrdinalIgnoreCase))
                .OrderBy(x => x.Name));
        }

        InvokeAsync(StateHasChanged);
    }
}
