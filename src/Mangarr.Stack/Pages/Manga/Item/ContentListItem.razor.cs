using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Sources;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Item;

public partial class ContentListItem
{
    [Inject] public RequestedChapterRepository RequestedChapterRepository { get; set; } = null!;

    [Parameter] public RequestedChapterDocument Item { get; set; } = null!;
    [Parameter] public int Index { get; set; }

    private string ChapterUrl
    {
        get
        {
            SourceBase.DeconstructId(Item!.ChapterId, out string url, out _);
            return url;
        }
    }

    private Task EnableChapter() => SetMarkedForDownload(true);

    private Task DisableChapter() => SetMarkedForDownload(false);

    private async Task SetMarkedForDownload(bool value)
    {
        Item.MarkedForDownload = value;
        Item = await RequestedChapterRepository.UpdateAsync(Item);
        await InvokeAsync(StateHasChanged);
    }
}
