using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Exporting;
using Mangarr.Stack.Sources;
using Microsoft.AspNetCore.Components;

namespace Mangarr.Stack.Pages.Manga.Item;

public partial class ContentHeader
{
    private RequestedMangaDocument? _manga;
    private MangaMetadataDocument? _metadata;
    private SourceDocument? _source;
    private string? _sourceUrl;

    private string DestinationFolder
    {
        get
        {
            Result<string> result = ExportService.GetDestinationFolder(_manga!);
            return result.IsSuccess ? result.Value : "Missing folder";
        }
    }

    [Parameter] public string Id { get; set; } = null!;

    [Inject] public AniListApi AniListApi { get; set; } = null!;
    [Inject] public RequestedMangaRepository RequestedMangaRepository { get; set; } = null!;
    [Inject] public MangaMetadataRepository MangaMetadataRepository { get; set; } = null!;
    [Inject] public SourceRepository SourceRepository { get; set; } = null!;
    [Inject] public RootFolderRepository RootFolderRepository { get; set; } = null!;
    [Inject] public ExportService ExportService { get; set; } = null!;

    protected override void OnInitialized() => LoadDataAsync();

    private async void LoadDataAsync()
    {
        _manga = RequestedMangaRepository[Id];

        if (_manga == null)
        {
            // TODO: Handle
            return;
        }

        _metadata = MangaMetadataRepository.GetByManga(_manga);

        if (_metadata == null)
        {
            // TODO: Handle
            return;
        }

        _source = SourceRepository[_manga.SourceId];

        if (_source == null)
        {
            // TODO: Handle
            return;
        }

        SourceBase.DeconstructId(_manga.MangaId, out _sourceUrl, out _);
        await InvokeAsync(StateHasChanged);
    }
}
