using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Services.Notifications;

public class NotificationService
{
    private readonly AniListService _aniListService;
    private readonly IEnumerable<INotificationProcessor> _notificationProcessors;

    public NotificationService(
        AniListService aniListService,
        IEnumerable<INotificationProcessor> notificationProcessors
    )
    {
        _aniListService = aniListService;
        _notificationProcessors = notificationProcessors;
    }

    public Task NotifyNewManga(RequestedMangaDocument requestedMangaDocument) =>
        Task.WhenAll(_notificationProcessors.Select(p => p.NotifyNewManga(requestedMangaDocument)));

    public Task NotifyNewChapters(
        RequestedMangaDocument requestedMangaDocument,
        IEnumerable<RequestedChapterDocument> newChapters
    ) => Task.WhenAll(_notificationProcessors.Select(p => p.NotifyNewChapters(requestedMangaDocument, newChapters)));

    public Task NotifyChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    ) => Task.WhenAll(_notificationProcessors.Select(p =>
        p.NotifyChapterDownloadFailed(requestedMangaDocument, requestedChapterDocument)));

    public Task NotifyChapterDownloadSucceeded(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    ) => Task.WhenAll(_notificationProcessors.Select(p =>
        p.NotifyChapterDownloadSucceeded(requestedMangaDocument, requestedChapterDocument)));
}
