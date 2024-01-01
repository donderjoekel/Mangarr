using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class ContentHeader
{
    [Parameter] public MangaDetailsModel? Item { get; set; }

    private string Title => Item!.Title;
    private string SourceName => Item!.SourceName;
    private string SourceUrl => Item!.SourceUrl;
    private string Description => Item!.Description;
    private string CoverImage => Item!.CoverImage;
    private string BannerImage => Item!.BannerImage;
}
