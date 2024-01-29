﻿using Mangarr.Stack.Database.Documents;

namespace Mangarr.Stack.Notifications;

public interface INotificationProcessor
{
    Task NotifyNewManga(RequestedMangaDocument requestedMangaDocument);

    Task NotifyNewChapters(
        RequestedMangaDocument requestedMangaDocument,
        IEnumerable<RequestedChapterDocument> newChapters
    );

    Task NotifyChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    );

    Task NotifyChapterDownloadSucceeded(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    );
}
