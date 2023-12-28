using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Item;

public partial class Item
{
    [Parameter] public string? Id { get; set; }
}
