using System.Text.RegularExpressions;
using FluentResults;
using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Implementations.Custom.ZeroScans.Data;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Newtonsoft.Json;
using Group = System.Text.RegularExpressions.Group;

namespace Mangarr.Backend.Sources.Implementations.Custom.ZeroScans;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ZeroScansSource : SourceBase
{
    protected override string Id => "zeroscans";
    protected override string Name => "Zero Scans";
    protected override string Url => "https://zeroscans.com";

    public ZeroScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected override Task Initialize() => Task.CompletedTask;

    protected override Task<Result> Cache() => Task.FromResult(Result.Ok());

    protected override Task<Result<string>> Status() => Task.FromResult(Result.Ok("OK"));

    protected override async Task<Result<SearchResult>> Search(string query)
    {
        Result<DirectoryResult> result = await GetHttpClient().Get<DirectoryResult>(Url + "/swordflake/comics");

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        if (!result.Value.success)
        {
            return Result.Fail("Website says request failed");
        }

        List<SearchResultItem> items = [];

        foreach (DirectoryResult.Data.Comic comic in result.Value.data.comics)
        {
            if (!comic.name.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            items.Add(new SearchResultItem(
                (comic.slug + "|" + comic.id).ToBase64(),
                comic.name,
                Url + "/comics/" + comic.slug,
                comic.cover.horizontal ?? comic.cover.vertical ?? string.Empty));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        string[] splits = mangaId.FromBase64().Split('|');
        string slug = splits[0];
        string id = splits[1];

        List<ChapterListItem> items = [];

        int page = 1;
        int maxPage = 1;
        bool hasSetMaxPage = false;

        while (page <= maxPage)
        {
            string url = $"{Url}/swordflake/comic/{id}/chapters?sort=desc&page={page}";
            Result<ChapterResult> result = await GetHttpClient().Get<ChapterResult>(url);

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
                items.Add(new ChapterListItem(
                    (slug + "/" + item.id).ToBase64(),
                    "Chapter " + item.name,
                    item.name,
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

    protected override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        Result<string> result = await GetHttpClient().Get(Url + "/comics/" + chapterId.FromBase64());

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

        List<PageListItem> items = [];

        foreach (string image in images)
        {
            items.Add(new PageListItem(image.ToBase64(), string.Empty, image));
        }

        return Result.Ok(new PageList(items));
    }

    protected override Task<Result<byte[]>> GetImage(string pageId) => GetHttpClient().GetBuffer(pageId.FromBase64());
}
