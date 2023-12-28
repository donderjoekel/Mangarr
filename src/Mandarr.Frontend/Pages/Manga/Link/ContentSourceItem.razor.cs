using Mandarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Link;

public partial class ContentSourceItem
{
    [Parameter] public string Id { get; set; }
    [Parameter] public string Identifier { get; set; }
    [Parameter] public ProviderMangaModel Item { get; set; } = null!;

    private string Title => Item.Name;
    private string CoverImage => Item.CoverUrl;

    private string MangaId => Item.Id;
}
