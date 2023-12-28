using Mandarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Search;

public partial class ContentItem
{
    [Parameter] public SearchResultModel? Item { get; set; }
    [Parameter] public bool AlreadyRequested { get; set; }

    private int Id => Item!.Id;
    private string Title => Item!.Title;
    private string Description => Item!.Description ?? string.Empty;
    private string CoverImage => Item!.CoverImage;
}
