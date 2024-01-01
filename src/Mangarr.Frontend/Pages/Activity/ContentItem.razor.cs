using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Activity;

public partial class ContentItem
{
    [Parameter] public ChapterProgressModel? Item { get; set; }
    [Parameter] public int Index { get; set; }

    private bool IsActive => Item!.IsActive;
    private string MangaId => Item!.MangaId;
    private string MangaTitle => Item!.MangaTitle;
    private string ChapterId => Item!.ChapterId;
    private string ChapterTitle => Item!.ChapterTitle;
    private double ChapterNumber => Item!.ChapterNumber;
    private int Progress => Item!.Progress;
}
