using Mandarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Library;

public partial class ContentItem
{
    [Parameter] public RequestedMangaModel? Item { get; set; }

    private string Id => Item!.Id;
    private string ImageUrl => Item!.CoverUrl;
    private string Title => Item!.Title;
}
