using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class ContentListItem
{
    [Inject] public BackendApi BackendApi { get; set; } = null!;

    [Parameter] public MangaChapterModel? Item { get; set; }
    [Parameter] public int Index { get; set; }

    private string ChapterUrl => Item!.ChapterUrl;
    private string ChapterName => Item!.ChapterName;
    private double ChapterNumber => Item!.ChapterNumber;
    private DateTime ReleaseDate => Item!.ReleaseDate;
    private bool MarkedForDownload => Item!.MarkedForDownload;
    private bool Downloaded => Item!.Downloaded;

    private async Task EnableChapter()
    {
        Result<ChapterEnableResponse> result = await BackendApi.EnableChapter(Item!.Id);

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            Item = result.Value.Data;
        }

        await InvokeAsync(StateHasChanged);
    }

    private async Task DisableChapter()
    {
        Result<ChapterDisableResponse> result = await BackendApi.DisableChapter(Item!.Id);

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            Item = result.Value.Data;
        }

        await InvokeAsync(StateHasChanged);
    }
}
