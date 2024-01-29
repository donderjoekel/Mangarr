using Anilist4Net;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Search;

public partial class SearchResultItem
{
    [Parameter] public Media Item { get; set; } = null!;

    [Inject] public RequestedMangaRepository Repository { get; set; } = null!;

    [Inject] public AniListApi AniListApi { get; set; } = null!;

    private string Title => AniListApi.GetPreferredTitle(Item);

    private string CoverImage =>
        Item.CoverImageExtraLarge ?? Item.CoverImageLarge ?? Item.CoverImageMedium ?? string.Empty;

    private string Description => Item.DescriptionMd ?? string.Empty;
    private bool AlreadyRequested => Repository.Any(x => x.SearchId == Item.Id);

    private RequestedMangaDocument? Manga => Repository.FirstOrDefault(x => x.SearchId == Item.Id);
}
