using Mangarr.Backend.Database.Documents;

namespace Mangarr.Backend.Services;

public class NotificationService
{
    private readonly AniListService _aniListService;

    public NotificationService(AniListService aniListService) => _aniListService = aniListService;

    public Task NotifyNewManga(RequestedMangaDocument requestedMangaDocument) => Task.CompletedTask;

    public Task NotifyNewChapters(
        RequestedMangaDocument requestedMangaDocument,
        IEnumerable<RequestedChapterDocument> newChapters
    ) =>
        Task.CompletedTask;

    public Task NotifyChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    ) =>
        Task.CompletedTask;

    public Task NotifyChapterDownloadSucceeded(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    ) =>
        Task.CompletedTask;
}
