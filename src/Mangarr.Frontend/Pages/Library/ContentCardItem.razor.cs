using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Library;

public partial class ContentCardItem
{
    [Parameter] public MangaListDetailsModel? Item { get; set; }

    private string Id => Item!.Id;
    private string ImageUrl => Item!.CoverUrl;
    private string Title => Item!.Title;
}
