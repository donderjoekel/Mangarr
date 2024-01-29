using Mangarr.Stack.AniList;
using RequestedChapterDocument = Mangarr.Stack.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Stack.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Stack.Notifications;

public class NotificationService
{
    private readonly AniListApi _aniListApi;
    private readonly IEnumerable<INotificationProcessor> _notificationProcessors;

    public NotificationService(
        AniListApi aniListApi,
        IEnumerable<INotificationProcessor> notificationProcessors
    )
    {
        _aniListApi = aniListApi;
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
