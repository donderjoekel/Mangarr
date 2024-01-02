using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class ContentListItem
{
    [Parameter] public MangaChapterModel? Item { get; set; }

    private string ChapterUrl => Item!.ChapterUrl;
    private string ChapterName => Item!.ChapterName;
    private double ChapterNumber => Item!.ChapterNumber;
    private DateTime ReleaseDate => Item!.ReleaseDate;
    private bool MarkedForDownload => Item!.MarkedForDownload;
    private bool Downloaded => Item!.Downloaded;
}
