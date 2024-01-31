using Mangarr.Stack.AniList;
using Mangarr.Stack.Data;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Settings;

namespace Mangarr.Stack.Library;

public class LibraryApi
{
    private readonly AniListApi _aniListApi;
    private readonly MangaMetadataRepository _mangaMetadataRepository;
    private readonly RequestedChapterRepository _requestedChapterRepository;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly SettingsApi _settingsApi;
    private readonly SourceRepository _sourceRepository;

    public LibraryApi(
        RequestedChapterRepository requestedChapterRepository,
        RequestedMangaRepository requestedMangaRepository,
        SourceRepository sourceRepository,
        AniListApi aniListApi,
        SettingsApi settingsApi,
        MangaMetadataRepository mangaMetadataRepository
    )
    {
        _requestedChapterRepository = requestedChapterRepository;
        _requestedMangaRepository = requestedMangaRepository;
        _sourceRepository = sourceRepository;
        _aniListApi = aniListApi;
        _settingsApi = settingsApi;
        _mangaMetadataRepository = mangaMetadataRepository;
    }

    public List<ContentItemModel> GetSortedLibrary()
    {
        Dictionary<string, SourceDocument> sourcesById = _sourceRepository.ToDictionary(x => x.Id, y => y);

        List<ContentItemModel> items = new();

        foreach (RequestedMangaDocument requestedMangaDocument in _requestedMangaRepository.Where(x => !x.Deleted))
        {
            MangaMetadataDocument? mangaMetadataDocument = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

            List<RequestedChapterDocument> requestedChapterDocuments = _requestedChapterRepository
                .Where(x => x.RequestedMangaId == requestedMangaDocument.Id)
                .ToList();

            items.Add(new ContentItemModel(
                requestedMangaDocument,
                mangaMetadataDocument!,
                requestedChapterDocuments,
                sourcesById.GetValueOrDefault(requestedMangaDocument.SourceId)));
        }

        IEnumerable<ContentItemModel> orderedItems;

        switch (_settingsApi.Library.SortMode)
        {
            case LibrarySortMode.Title:
                orderedItems = items.OrderBy(x => _aniListApi.GetPreferredTitle(x.Manga));
                break;
            case LibrarySortMode.Added:
                orderedItems = items.OrderBy(x => x.Manga.DateCreated);
                break;
            case LibrarySortMode.Updated:
                orderedItems = items.OrderBy(x => x.Chapters.OrderBy(y => y.DateCreated).Last());
                break;
            case LibrarySortMode.Source:
                orderedItems = items.OrderBy(x => x.Source?.Name ?? string.Empty);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (!_settingsApi.Library.Ascending)
        {
            orderedItems = orderedItems.Reverse();
        }

        return orderedItems.ToList();
    }
}
