using FluentResults;
using Mandarr.Backend.Database.Documents;
using Mandarr.Backend.Services;
using Mandarr.Sources;
using Mandarr.Sources.Models.Chapter;
using MongoDB.Driver;

namespace Mandarr.Backend.Workers.Processors;

public class MangaProcessor
{
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;
    private readonly IMongoCollection<RequestedChapterDocument> _requestedChapterCollection;
    private readonly IMongoCollection<ChapterProgressDocument> _chapterProgressCollection;
    private readonly NotificationService _notificationService;
    private readonly IEnumerable<ISource> _providers;
    private readonly ILogger<MangaProcessor> _logger;

    public MangaProcessor(
        IMongoCollection<RequestedMangaDocument> requestedMangaCollection,
        IMongoCollection<RequestedChapterDocument> requestedChapterCollection,
        IEnumerable<ISource> providers,
        ILogger<MangaProcessor> logger,
        NotificationService notificationService,
        IMongoCollection<ChapterProgressDocument> chapterProgressCollection
    )
    {
        _requestedMangaCollection = requestedMangaCollection;
        _requestedChapterCollection = requestedChapterCollection;
        _providers = providers;
        _logger = logger;
        _notificationService = notificationService;
        _chapterProgressCollection = chapterProgressCollection;
    }

    public async Task Run(CancellationToken stoppingToken)
    {
        List<RequestedMangaDocument> requestedMangaDocuments = await _requestedMangaCollection
            .Find(_ => true)
            .ToListAsync(stoppingToken);

        foreach (RequestedMangaDocument requestedMangaDocument in requestedMangaDocuments)
        {
            await ProcessManga(requestedMangaDocument, stoppingToken);
        }
    }

    private async Task ProcessManga(RequestedMangaDocument requestedMangaDocument, CancellationToken ct)
    {
        ISource? provider = _providers.FirstOrDefault(x => x.Identifier == requestedMangaDocument.ProviderId);
        if (provider == null)
        {
            _logger.LogError("Provider {ProviderId} not found", requestedMangaDocument.ProviderId);
            return;
        }

        Result<ChapterList> chapterListResult = await provider.GetChapterList(requestedMangaDocument.MangaId);
        if (chapterListResult.IsFailed)
        {
            _logger.LogError("Unable to get chapter list for {MangaId} from {ProviderId}: {Result}",
                requestedMangaDocument.MangaId,
                requestedMangaDocument.ProviderId,
                chapterListResult.ToString());

            return;
        }

        List<RequestedChapterDocument> requestedChapterDocuments = await _requestedChapterCollection
            .Find(x => x.RequestedMangaId == requestedMangaDocument.Id)
            .ToListAsync(ct);

        List<RequestedChapterDocument> newChapters = [];

        foreach (ChapterListItem chapterListItem in chapterListResult.Value.Items)
        {
            RequestedChapterDocument? existingChapter = requestedChapterDocuments
                .FirstOrDefault(x => x.ChapterId == chapterListItem.Id);

            if (existingChapter != null)
            {
                continue;
            }

            bool markedForDownload = true;

            if (requestedMangaDocument.NewChaptersOnly)
            {
                markedForDownload = requestedMangaDocument.LastScanDate != null;
            }

            RequestedChapterDocument requestedChapterDocument = new()
            {
                RequestedMangaId = requestedMangaDocument.Id,
                ChapterId = chapterListItem.Id,
                ChapterNumber = chapterListItem.Number,
                MarkedForDownload = markedForDownload,
                Downloaded = false
            };

            await _requestedChapterCollection.InsertOneAsync(requestedChapterDocument, null, ct);

            if (!markedForDownload)
            {
                continue;
            }

            ChapterProgressDocument chapterProgressDocument = new()
            {
                MangaId = requestedMangaDocument.Id,
                MangaTitle = requestedMangaDocument.Title,
                ChapterId = requestedChapterDocument.Id,
                ChapterNumber = requestedChapterDocument.ChapterNumber,
                Progress = 0
            };

            await _chapterProgressCollection.InsertOneAsync(chapterProgressDocument, null, ct);

            newChapters.Add(requestedChapterDocument);
        }

        if (newChapters.Any())
        {
            await _notificationService.NotifyNewChapters(requestedMangaDocument, newChapters);
        }

        await _requestedMangaCollection.UpdateOneAsync(
            RequestedMangaDocument.Filter.Eq(x => x.Id, requestedMangaDocument.Id),
            RequestedMangaDocument.Update.Set(x => x.LastScanDate, DateTime.UtcNow),
            cancellationToken: ct);
    }
}
