using Anilist4Net;
using Anilist4Net.Enums;
using Discord;
using Discord.Webhook;
using FluentResults;
using MongoDB.Driver;

namespace Mangarr.Backend.Services.Notifications;

public class DiscordNotificationProcessor : INotificationProcessor
{
    private readonly AniListService _aniListService;
    private readonly DiscordWebhookClient _client;
    private readonly IMongoCollection<SourceDocument> _sourceCollection;

    public DiscordNotificationProcessor(
        DiscordWebhookClient client,
        AniListService aniListService,
        IMongoCollection<SourceDocument> sourceCollection
    )
    {
        _client = client;
        _aniListService = aniListService;
        _sourceCollection = sourceCollection;
    }

    public async Task NotifyNewManga(RequestedMangaDocument requestedMangaDocument)
    {
        Result<Media?> result = await _aniListService.GetMedia(requestedMangaDocument.SearchId);
        if (result.IsFailed)
        {
            return;
        }

        SourceDocument? source = await _sourceCollection
            .Find(x => x.Identifier == requestedMangaDocument.SourceId)
            .FirstOrDefaultAsync();

        if (source == null)
        {
            return;
        }

        Embed build = new EmbedBuilder()
            .WithTitle("A new manga has been added")
            .WithDescription($@"**Title**
{requestedMangaDocument.Title}

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
            .WithThumbnailUrl(requestedMangaDocument.CoverUrl)
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
        Embed build = new EmbedBuilder()
            .WithTitle("New chapters have been added")
            .WithDescription($@"**Title**
{requestedMangaDocument.Title}

**Chapter(s)**
{GetRequestedChapters(newChapters)}
")
            .WithColor(Color.Purple)
            .WithThumbnailUrl(requestedMangaDocument.CoverUrl)
            .Build();

        return _client.SendMessageAsync(embeds: new[] { build });
    }

    public Task NotifyChapterDownloadFailed(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        Embed build = new EmbedBuilder()
            .WithTitle("Failed to download a chapter")
            .WithDescription($@"**Title**
{requestedMangaDocument.Title}

**Chapter**
{requestedChapterDocument.ChapterName} ({requestedChapterDocument.ChapterNumber})")
            .WithThumbnailUrl(requestedMangaDocument.CoverUrl)
            .WithColor(Color.Red)
            .Build();

        return _client.SendMessageAsync(embeds: new[] { build });
    }

    public Task NotifyChapterDownloadSucceeded(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        Embed build = new EmbedBuilder()
            .WithTitle("Successfully downloaded a chapter")
            .WithDescription($@"**Title**
{requestedMangaDocument.Title}

**Chapter**
{requestedChapterDocument.ChapterName} ({requestedChapterDocument.ChapterNumber})")
            .WithThumbnailUrl(requestedMangaDocument.CoverUrl)
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
