using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;
using Timer = System.Timers.Timer;

namespace Mangarr.Stack.Pages.Manga.Link;

public partial class Content
{
    private readonly List<SourceDocument> _items = new();
    [Notify] private bool _isSearching;
    private string _query = string.Empty;
    private Timer _timer = null!;

    [Inject] public SourceRepository SourceRepository { get; set; } = null!;

    [Parameter] public int SearchId { get; set; }
    [Parameter] public string? CustomSearchQuery { get; set; }

    protected override void OnInitialized()
    {
        _timer = new Timer(500);
        _timer.Elapsed += async (sender, args) => await SearchAsync();

        _items.AddRange(SourceRepository.Where(x => x.Enabled).OrderBy(x => x.Name));
    }

    private void SearchQueryChanged(ChangeEventArgs args)
    {
        IsSearching = true;

        _query = args.Value?.ToString() ?? string.Empty;

        if (_timer.Enabled)
        {
            _timer.Stop();
        }

        _timer.Start();
    }

    private async Task SearchAsync()
    {
        _timer.Stop();
        CustomSearchQuery = _query;
        IsSearching = false;
        await InvokeAsync(StateHasChanged);
    }
}
