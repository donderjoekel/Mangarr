using FluentResults;
using Mangarr.Frontend.Api;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class ContentList
{
    [Inject] public BackendApi BackendApi { get; set; } = null!;

    [Parameter] public string? Id { get; set; }
    [Parameter] public List<MangaChapterModel> Items { get; set; } = new();

    private async Task EnableChapters()
    {
        Result<MangaEnableChaptersResponse> result = await BackendApi.EnableMangaChapters(Id);

        if (result.IsFailed)
        {
            // TODO: Log error
        }

        await UpdateChapters();
    }

    private async Task DisableChapters()
    {
        Result<MangaDisableChaptersResponse> result = await BackendApi.DisableMangaChapters(Id);

        if (result.IsFailed)
        {
            // TODO: Log error
        }

        await UpdateChapters();
    }

    private async Task UpdateChapters()
    {
        Result<MangaChaptersResponse> result = await BackendApi.GetMangaChapters(Id);

        if (result.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            Items = result.Value.Data;
        }

        await InvokeAsync(StateHasChanged);
    }
}
