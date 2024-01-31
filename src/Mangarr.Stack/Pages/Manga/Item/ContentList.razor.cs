using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Item;

public partial class ContentList
{
    private List<RequestedChapterDocument> _items = new();
    private RequestedMangaDocument _requestedMangaDocument = null!;

    [Parameter] public string Id { get; set; } = null!;

    [Inject] public RequestedMangaRepository RequestedMangaRepository { get; set; } = null!;
    [Inject] public RequestedChapterRepository RequestedChapterRepository { get; set; } = null!;

    protected override void OnInitialized()
    {
        _requestedMangaDocument = RequestedMangaRepository[Id]!;
        _items = RequestedChapterRepository.GetByMangaId(Id)
            .OrderByDescending(x => x.ChapterNumber)
            .ToList();
    }

    private Task EnableMonitoring() => SetMonitoring(true);

    private Task DisableMonitoring() => SetMonitoring(false);

    private async Task SetMonitoring(bool value)
    {
        _requestedMangaDocument.Monitor = value;
        (_requestedMangaDocument, _) = await RequestedMangaRepository.UpdateAsync(_requestedMangaDocument);
    }
}
