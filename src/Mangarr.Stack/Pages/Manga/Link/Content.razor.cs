using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Messaging;
using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;

namespace Mangarr.Stack.Pages.Manga.Link;

public partial class Content
{
    private readonly List<SourceDocument> _sources = new();
    [Notify] private bool _isSearching;
    private string _query = string.Empty;

    [Inject] public SourceRepository SourceRepository { get; set; } = null!;
    [Inject] public IMessageBus MessageBus { get; set; } = null!;

    [Parameter] public int SearchId { get; set; }
    [Parameter] public string? CustomSearchQuery { get; set; }

    protected override void OnInitialized() =>
        _sources.AddRange(SourceRepository.Where(x => x.Enabled).OrderBy(x => x.Name));

    private void SearchQueryChanged(ChangeEventArgs args) => _query = args.Value?.ToString() ?? string.Empty;

    private void SubmitCustomSearch() => MessageBus.Publish(new SubmitSearchQueryMessage(_query));
}
