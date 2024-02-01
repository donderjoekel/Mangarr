using System.Text.RegularExpressions;
using FluentResults;
using Injectio.Attributes;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Extensions;
using Mangarr.Stack.Sources.Implementations.Custom.ZeroScans.Data;
using Mangarr.Stack.Sources.Models.Chapter;
using Mangarr.Stack.Sources.Models.Page;
using Mangarr.Stack.Sources.Models.Search;
using Newtonsoft.Json;
using Group = System.Text.RegularExpressions.Group;

namespace Mangarr.Stack.Sources.Implementations.Custom.ZeroScans;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ZeroScansSource : SourceBase
{
    protected override string Id => "zeroscans";
    protected override string Name => "Zero Scans";
    protected override string Url => "https://zeroscans.com";

    public ZeroScansSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }

    protected override Task<Result> Initialize() => Task.FromResult(Result.Ok());

    protected override Task<Result> Cache() => Task.FromResult(Result.Ok());

    protected override Task<Result<string>> Status() => Task.FromResult(Result.Ok("OK"));

    protected override async Task<Result<SearchResult>> Search(string query, CancellationToken ct)
    {
        Result<DirectoryResult> result = await GetHttpClient().Get<DirectoryResult>(Url + "/swordflake/comics", ct);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        if (!result.Value.success)
        {
            return Result.Fail("Website says request failed");
        }

        List<SearchResultItem> items = new();

        foreach (DirectoryResult.Data.Comic comic in result.Value.data.comics)
        {
            if (!comic.name.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            items.Add(new SearchResultItem(
                (Url + "/comics/" + comic.slug + "|" + comic.slug + "|" + comic.id).ToBase64(),
                comic.name,
                comic.cover.horizontal ?? comic.cover.vertical ?? string.Empty));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId, CancellationToken ct)
    {
        string[] splits = mangaId.FromBase64().Split('|');
        string chapterUrl = splits[0];
        string slug = splits[1];
        string id = splits[2];

        List<ChapterListItem> items = new();

        int page = 1;
        int maxPage = 1;
        bool hasSetMaxPage = false;

        while (page <= maxPage)
        {
            string url = $"{Url}/swordflake/comic/{id}/chapters?sort=desc&page={page}";
            Result<ChapterResult> result = await GetHttpClient().Get<ChapterResult>(url, ct);

            if (result.IsFailed)
            {
                return result.ToResult();
            }

            if (!result.Value.success)
            {
                return Result.Fail("Website says request failed");
            }

            foreach (ChapterResult.Data.Item item in result.Value.data.data)
            {
                if (!TryParseRelativeDate(item.created_at, out DateTime dateTime))
                {
                    dateTime = DateTime.MinValue;
                }

                items.Add(new ChapterListItem(
                    (slug + "/" + item.id).ToBase64(),
                    "Chapter " + item.name,
                    item.name,
                    dateTime.Date,
                    Url + "/comics/" + slug + "/" + item.id));
            }

            if (!hasSetMaxPage && result.Value.data.to.HasValue)
            {
                hasSetMaxPage = true;
                maxPage = result.Value.data.to.Value;
            }

            page++;
        }

        return Result.Ok(new ChapterList(items));
    }

    protected override async Task<Result<PageList>> GetPageList(string chapterId, CancellationToken ct)
    {
        Result<string> result = await GetHttpClient().Get(Url + "/comics/" + chapterId.FromBase64(), ct);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        Match match = Regex.Match(result.Value, "current_chapter:({.+?}),");

        if (!match.Success)
        {
            return Result.Fail("Unable to find current chapter data");
        }

        Group? group = match.Groups.Values.FirstOrDefault(x => x is not Match);

        if (group == null)
        {
            return Result.Fail("Unable to find matching group");
        }

        // The JSON is invalid, so we need to fix it
        string replaced = Regex.Replace(group.Value,
            @":(\w+)",
            m => ":\"" + m.Groups[1].Value + "\"");

        CurrentChapterData currentChapterData;

        try
        {
            currentChapterData = JsonConvert.DeserializeObject<CurrentChapterData>(replaced)!;
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        string[] images = currentChapterData.high_quality.Length != 0
            ? currentChapterData.high_quality
            : currentChapterData.good_quality;

        List<PageListItem> items = new();

        foreach (string image in images)
        {
            items.Add(new PageListItem(image.ToBase64(), image));
        }

        return Result.Ok(new PageList(items));
    }

    protected override Task<Result<byte[]>> GetImage(string pageId, CancellationToken ct) =>
        GetHttpClient().GetBuffer(pageId.FromBase64(), ct);
}
