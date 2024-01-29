using Mangarr.Stack.Extensions;
using Mangarr.Stack.Sources.Models.Search;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Link;

public partial class ContentSourceItem
{
    [Parameter] public int SearchId { get; set; }
    [Parameter] public string SourceId { get; set; } = null!;
    [Parameter] public SearchResultItem Item { get; set; } = null!;

    private string SafeMangaId => Item.Id.ReplaceAll(string.Empty, "+", "/", "=");
}
