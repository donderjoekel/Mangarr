using FluentResults;
using Mangarr.Shared.Models;
using Mangarr.Shared.Responses;
using Mangarr.Frontend.Api;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Frontend.Pages.Manga.Item;

public partial class Content
{
    [Parameter] public string? Id { get; set; }
    [Inject] public BackendApi BackendApi { get; set; }

    private bool _isRefreshing;
    private MangaDetailsModel? _mangaDetails;
    private List<MangaChapterModel>? _mangaChapters;

    protected override void OnInitialized() => RefreshAsync();

    private async void RefreshAsync()
    {
        _isRefreshing = true;
        await InvokeAsync(StateHasChanged);

        Result<MangaDetailsResponse> mangaDetailsResult = await BackendApi.GetMangaDetails(Id!);
        if (mangaDetailsResult.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            _mangaDetails = mangaDetailsResult.Value.Data;
        }

        Result<MangaChaptersResponse> mangaChaptersResult = await BackendApi.GetMangaChapters(Id!);
        if (mangaChaptersResult.IsFailed)
        {
            // TODO: Log error
        }
        else
        {
            _mangaChapters = mangaChaptersResult.Value.Data;
        }

        _isRefreshing = false;
        await InvokeAsync(StateHasChanged);
    }
}
