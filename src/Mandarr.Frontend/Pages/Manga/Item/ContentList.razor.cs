using Mandarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Manga.Item;

public partial class ContentList
{
    [Parameter] public List<MangaChapterModel> Items { get; set; } = new();
}
