using Anilist4Net;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Messaging;
using Mangarr.Stack.Sources;
using Mangarr.Stack.Sources.Models.Search;
using Microsoft.AspNetCore.Components;
using PropertyChanged.SourceGenerator;

namespace Mangarr.Stack.Pages.Manga.Link;

public sealed partial class ContentSource : IDisposable, IMessageReceiver<SubmitSearchQueryMessage>
{
    private readonly List<SearchResultItem> _items = new();
    private CancellationTokenSource? _cts;
    private string? _customSearchQuery = string.Empty;
    [Notify] private bool _isSearching;
    private ISubscriptionToken? _subscriptionToken;

    [Inject] public AniListApi AniListApi { get; set; } = null!;
    [Inject] public SourceProvider SourceProvider { get; set; } = null!;
    [Inject] public IMessageBus MessageBus { get; set; } = null!;

    [Parameter] public int SearchId { get; set; }
    [Parameter] public SourceDocument Source { get; set; } = null!;

    void IDisposable.Dispose()
    {
        _cts?.Cancel();
        MessageBus.Unsubscribe(_subscriptionToken!);
        _subscriptionToken = null;
    }

    void IMessageReceiver<SubmitSearchQueryMessage>.Receive(SubmitSearchQueryMessage message)
    {
        _customSearchQuery = message.Query;
        SearchAsync();
    }

    protected override void OnInitialized()
    {
        _subscriptionToken = MessageBus.Subscribe(this);
        SearchAsync();
    }

    private async void SearchAsync()
    {
        _cts?.Cancel();
        _cts = new CancellationTokenSource();
        await SearchAsync(_cts.Token);
    }

    private async Task SearchAsync(CancellationToken ct)
    {
        _items.Clear();
        IsSearching = true;

        await InvokeAsync(StateHasChanged);

        if (!string.IsNullOrEmpty(_customSearchQuery))
        {
            await SearchByCustom(ct);
        }
        else
        {
            await SearchById(ct);
        }

        if (ct.IsCancellationRequested)
        {
            return;
        }

        IsSearching = false;
    }

    private async Task SearchByCustom(CancellationToken ct = default)
    {
        ISource? source = SourceProvider.GetById(Source.Id);

        if (source == null)
        {
            // TODO: Handle
            return;
        }

        Result<SearchResult> result = await source.Search(_customSearchQuery!, ct);

        if (ct.IsCancellationRequested)
        {
            return;
        }

        if (result.IsFailed)
        {
            // TODO: Handle
            return;
        }

        _items.Clear();
        _items.AddRange(result.Value.Items);
    }

    private async Task SearchById(CancellationToken ct = default)
    {
        ISource? source = SourceProvider.GetById(Source.Id);

        if (source == null)
        {
            // TODO: Handle
            return;
        }

        List<string> titlesToSearch = new();

        Result<Media?> mediaResult = await AniListApi.GetMedia(SearchId);

        if (_cts!.IsCancellationRequested)
        {
            return;
        }

        if (mediaResult.IsFailed)
        {
            // TODO: Handle
            return;
        }

        Media? media = mediaResult.Value;

        titlesToSearch.Add(media!.Title.English);
        titlesToSearch.Add(media.Title.Romaji);
        titlesToSearch.Add(media.Title.Native);
        titlesToSearch.AddRange(media.Synonyms);
        titlesToSearch = titlesToSearch.Distinct().Where(x => !string.IsNullOrEmpty(x)).ToList();

        List<SearchResultItem> allSearchResults = new();

        foreach (string title in titlesToSearch)
        {
            Result<SearchResult> searchResult = await source.Search(title, ct);

            if (ct.IsCancellationRequested)
            {
                return;
            }

            if (searchResult.IsFailed)
            {
                // TODO: Handle
                continue;
            }

            allSearchResults.AddRange(searchResult.Value.Items);
            _items.Clear();
            _items.AddRange(allSearchResults.Distinct());
            await InvokeAsync(StateHasChanged);
        }
    }
}
