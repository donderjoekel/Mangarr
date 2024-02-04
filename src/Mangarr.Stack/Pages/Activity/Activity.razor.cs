using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;
using Timer = System.Timers.Timer;

namespace Mangarr.Stack.Pages.Activity;

public sealed partial class Activity : IDisposable
{
    private readonly List<ChapterProgressDocument> _items = new();
    private Timer _timer = null!;

    [Inject] public ChapterProgressRepository Repository { get; set; } = null!;

    void IDisposable.Dispose()
    {
        _timer.Stop();
        _timer.Dispose();
    }

    protected override void OnInitialized()
    {
        _timer = new Timer(2500);
        _timer.Elapsed += (sender, args) => Refresh();
        _timer.Start();

        Refresh();
    }

    private void Refresh()
    {
        _items.Clear();
        _items.AddRange(Repository.Items.OrderByDescending(x => x.IsActive).ThenBy(x => x.DateCreated).ToList());
        InvokeAsync(StateHasChanged);
    }
}
