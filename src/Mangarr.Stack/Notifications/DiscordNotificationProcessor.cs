using Anilist4Net;
using Anilist4Net.Enums;
using Discord;
using Discord.Webhook;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;

namespace Mangarr.Stack.Notifications;

public class DiscordNotificationProcessor : INotificationProcessor
{
    private readonly AniListApi _aniListApi;
    private readonly DiscordWebhookClient? _client;
    private readonly MangaMetadataRepository _mangaMetadataRepository;
    private readonly SourceRepository _sourceRepository;

    public DiscordNotificationProcessor(
        DiscordWebhookClient? client,
        AniListApi aniListApi,
        SourceRepository sourceRepository,
        MangaMetadataRepository mangaMetadataRepository
    )
    {
        _client = client;
        _aniListApi = aniListApi;
        _sourceRepository = sourceRepository;
        _mangaMetadataRepository = mangaMetadataRepository;
    }

    public async Task NotifyNewManga(RequestedMangaDocument requestedMangaDocument)
    {
        if (_client == null)
        {
            return;
        }

        Result<Media?> result = await _aniListApi.GetMedia(requestedMangaDocument.SearchId);
        if (result.IsFailed)
        {
            return;
        }

        SourceDocument? source = _sourceRepository[requestedMangaDocument.SourceId];

        if (source == null)
        {
            return;
        }

        MangaMetadataDocument? metadata = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

        if (metadata == null)
        {
            // TODO: Log this?
            return;
        }

        Embed build = new EmbedBuilder()
            .WithTitle("A new manga has been added")
            .WithDescription($@"**Title**
{_aniListApi.GetPreferredTitle(requestedMangaDocument)}

**Description**
{result.Value.DescriptionMd
    .Replace("<br><br><br><br>", "<br>")
    .Replace("<br><br><br>", "<br>")
    .Replace("<br><br>", "<br>")
    .Replace("<br>", "\n")}

**Source**
{source.Name}

**Status**
{StatusToString(result.Value.Status)}")
            .WithThumbnailUrl(metadata.CoverUrl)
            .WithImageUrl(result.Value.BannerImage)
            .WithCurrentTimestamp()
            .Build();

        await _client.SendMessageAsync(embeds: new[] { build });
    }

    public Task NotifyNewChapters(
        RequestedMangaDocument requestedMangaDocument,
        IEnumerable<RequestedChapterDocument> newChapters
    )
    {
        if (_client == null)
        {
            return Task.CompletedTask;
        }

        MangaMetadataDocument? metadata = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

        if (metadata == null)
        {
            // TODO: Log this?
            return Task.CompletedTask;
        }

        Embed build = new EmbedBuilder()
            .WithTitle("New chapters have been added")
            .WithDescription($@"**Title**
{_aniListApi.GetPreferredTitle(requestedMangaDocument)}

**Chapter(s)**
{GetRequestedChapters(newChapters)}
")
            .WithColor(Color.Purple)
            .WithThumbnailUrl(metadata.CoverUrl)
            .Build();

        return _client.SendMessageAsync(embeds: new[] { build });
    }

    public Task NotifyChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        if (_client == null)
        {
            return Task.CompletedTask;
        }

        MangaMetadataDocument? metadata = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

        if (metadata == null)
        {
            // TODO: Log this?
            return Task.CompletedTask;
        }

        Embed build = new EmbedBuilder()
            .WithTitle("Failed to download a chapter")
            .WithDescription($@"**Title**
{_aniListApi.GetPreferredTitle(requestedMangaDocument)}

**Chapter**
{requestedChapterDocument.ChapterName} ({requestedChapterDocument.ChapterNumber})")
            .WithThumbnailUrl(metadata.CoverUrl)
            .WithColor(Color.Red)
            .Build();

        return _client.SendMessageAsync(embeds: new[] { build });
    }

    public Task NotifyChapterDownloadSucceeded(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        if (_client == null)
        {
            return Task.CompletedTask;
        }

        MangaMetadataDocument? metadata = _mangaMetadataRepository.GetByManga(requestedMangaDocument);

        if (metadata == null)
        {
            // TODO: Log this?
            return Task.CompletedTask;
        }

        Embed build = new EmbedBuilder()
            .WithTitle("Successfully downloaded a chapter")
            .WithDescription($@"**Title**
{_aniListApi.GetPreferredTitle(requestedMangaDocument)}

**Chapter**
{requestedChapterDocument.ChapterName} ({requestedChapterDocument.ChapterNumber})")
            .WithThumbnailUrl(metadata.CoverUrl)
            .WithColor(Color.Green)
            .Build();

        return _client.SendMessageAsync(embeds: new[] { build });
    }

    private string GetRequestedChapters(IEnumerable<RequestedChapterDocument> chapters)
    {
        List<string> sorted = chapters
            .OrderBy(x => x.ChapterNumber)
            .Select(x => x.ChapterNumber.ToString())
            .ToList();
        string joined = string.Join(", ", sorted);

        if (joined.Length <= 1000)
        {
            return joined;
        }

        string first = string.Join(", ", sorted.GetRange(0, 3));
        string last = string.Join(", ", sorted.GetRange(sorted.Count - 3, 3));

        return $"{first} ... {last}";
    }

    private static string StatusToString(MediaStatuses status) => status switch
    {
        MediaStatuses.FINISHED => "Finished",
        MediaStatuses.RELEASING => "Releasing",
        MediaStatuses.NOT_YET_RELEASED => "Not yet released",
        MediaStatuses.CANCELLED => "Cancelled",
        _ => "Unknown"
    };
}
