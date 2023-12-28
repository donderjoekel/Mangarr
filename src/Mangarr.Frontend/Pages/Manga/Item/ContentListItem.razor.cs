using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class ContentListItem
{
    [Parameter] public MangaChapterModel? Item { get; set; }
    [Parameter] public int Index { get; set; }

    private double ChapterNumber => Item!.ChapterNumber;
    private bool MarkedForDownload => Item!.MarkedForDownload;
    private bool Downloaded => Item!.Downloaded;
}
