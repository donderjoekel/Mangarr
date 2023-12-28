using Mangarr.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class ContentList
{
    [Parameter] public List<MangaChapterModel> Items { get; set; } = new();
}
