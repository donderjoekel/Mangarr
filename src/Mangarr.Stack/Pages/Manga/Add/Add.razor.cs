using FluentResults;
using Mangarr.Stack.Manga;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Add;

public partial class Add
{
    [Parameter] public int Id { get; set; }
    [Parameter] public string SourceId { get; set; } = null!;
    [Parameter] public string MangaId { get; set; } = null!;
    [Parameter] public string RootFolderId { get; set; } = null!;
    [Parameter] public bool MonitorNewChaptersOnly { get; set; }

    [Inject] public MangaApi MangaApi { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        Result<string> result =
            await MangaApi.AddMangaAsync(Id, SourceId, MangaId, RootFolderId, MonitorNewChaptersOnly);

        if (result.IsSuccess)
        {
            NavigationManager.NavigateTo("/manga/" + result.Value);
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
