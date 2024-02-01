using System.Globalization;
using System.Text.RegularExpressions;
using FluentResults;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Extensions;
using Mangarr.Stack.Sources.Implementations.NepNep.Data;
using Mangarr.Stack.Sources.Models.Chapter;
using Mangarr.Stack.Sources.Models.Page;
using Mangarr.Stack.Sources.Models.Search;
using Newtonsoft.Json;
using Group = System.Text.RegularExpressions.Group;

namespace Mangarr.Stack.Sources.Implementations.NepNep;

internal abstract class NepNepSourceBase : SourceBase
{
    private readonly CachingService _cachingService;

    protected NepNepSourceBase(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory,
        CachingService cachingService
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory) =>
        _cachingService = cachingService;

    protected override Task<Result> Initialize() => Task.FromResult(Result.Ok());

    protected override Task<Result> Cache() => Task.FromResult(Result.Ok());

    protected override Task<Result<string>> Status() => Task.FromResult(Result.Ok("OK"));

    private async Task<Result<string>> GetSearchHtml(CancellationToken ct = default)
    {
        string key = Id + "_search";

        if (_cachingService.TryGetValue(key, out string? cachedHtml))
        {
            return Result.Ok(cachedHtml);
        }

        Result<string> result = await GetHttpClient().Get($"{Url}/search/", ct);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        _cachingService.Set(key, result.Value, TimeSpan.FromHours(8));

        return Result.Ok(result.Value);
    }

    private async Task<Result<MangaData.Item[]>> GetMangaDataItems(CancellationToken ct = default)
    {
        string key = Id + "_mangadataitems";

        if (_cachingService.TryGetValue(key, out MangaData.Item[]? cachedItems))
        {
            return Result.Ok(cachedItems);
        }

        Result<string> result = await GetSearchHtml(ct);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        MangaData.Item[] items;

        try
        {
            Match match = Regex.Match(result.Value, @"vm.Directory\s*=\s*(.*?]);");

            if (!match.Success)
            {
                return Result.Fail("Unable to find directory");
            }

            Group? group = match.Groups.Values.FirstOrDefault(x => x is not Match);

            if (group == null)
            {
                return Result.Fail("Unable to find directory");
            }

            string json = group.Value;

            items = JsonConvert.DeserializeObject<MangaData.Item[]>(json)!;
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        _cachingService.Set(key, items, TimeSpan.FromHours(8));

        return Result.Ok(items);
    }

    protected sealed override async Task<Result<SearchResult>> Search(string query, CancellationToken ct)
    {
        Result<MangaData.Item[]> itemsResult = await GetMangaDataItems(ct);

        MangaData.Item[] items = itemsResult.Value
            .Where(x => x.Title.Contains(query, StringComparison.InvariantCultureIgnoreCase)).ToArray();

        string coverUrl = string.Empty;

        try
        {
            Result<string> htmlResult = await GetSearchHtml(ct);

            if (htmlResult.IsFailed)
            {
                return htmlResult.ToResult();
            }

            Match match = Regex.Match(htmlResult.Value,
                @"<a[^>]+class=['""]SeriesName['""][^>]*>\s*<img[^>]+src=['""]([^'""]+)['""]");

            if (!match.Success)
            {
                return Result.Fail("Unable to find cover url");
            }

            Group? group = match.Groups.Values.FirstOrDefault(x => x is not Match);

            if (group == null)
            {
                return Result.Fail("Unable to find cover url");
            }

            coverUrl = group.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Result.Ok(
            new SearchResult(
                items.Select(x =>
                        new SearchResultItem(
                            ConstructId($"{Url}/manga/{x.Slug}", x.Slug),
                            x.Title,
                            coverUrl.Replace("{{Series.i}}", x.Slug)))
                    .ToList()));
    }

    protected sealed override async Task<Result<ChapterList>> GetChapterList(string mangaId, CancellationToken ct)
    {
        DeconstructId(mangaId, out string mangaUrl, out string[] args);
        string slug = args[0];

        Result<string> result = await GetHttpClient().Get(mangaUrl, ct);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        ChapterData[] data;

        try
        {
            string json = result.Value;
            json = json[json.IndexOf("vm.Chapters = ", StringComparison.InvariantCultureIgnoreCase)..];
            json = json[..json.IndexOf("];", StringComparison.InvariantCultureIgnoreCase)];
            json = json.Replace("vm.Chapters = ", string.Empty) + "]";

            data = JsonConvert.DeserializeObject<ChapterData[]>(json)!;
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        List<ChapterListItem> items = new();

        foreach (ChapterData chapter in data)
        {
            // Thanks Netsky https://github.com/TheNetsky/extensions-generic-0.8/blob/54ef11e6ea4c89bf7423eba72ab31f7651080de2/src/NepNepParser.ts#L102-L110
            string chapterCode = chapter.Chapter;
            int volume = int.Parse(chapterCode[..1]);
            string index = volume != 1 ? "-index-" + volume : string.Empty;
            int n = int.Parse(chapterCode[1..^1]);
            int a = int.Parse(chapterCode[^1].ToString());
            string m = a != 0 ? "." + a : string.Empty;
            string id = slug + "-chapter-" + n + m + index + ".html";
            double chapterNumber = n + a * 0.1;
            string chapterUrl = Url + "/read-online/" + id;

            items.Add(
                new ChapterListItem(
                    ConstructId(chapterUrl, slug),
                    chapter.Type + " - " + chapterNumber.ToString(CultureInfo.InvariantCulture),
                    chapterNumber,
                    DateTime.Parse(chapter.Date).Date,
                    chapterUrl));
        }

        return Result.Ok(new ChapterList(items));
    }

    protected sealed override async Task<Result<PageList>> GetPageList(string chapterId, CancellationToken ct)
    {
        DeconstructId(chapterId, out string chapterUrl, out string[] args);
        string slug = args[0];

        Result<string> result = await GetHttpClient().Get(chapterUrl, ct);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        PageData data;

        try
        {
            string json = result.Value;
            json = json[json.IndexOf("vm.CurChapter = ", StringComparison.InvariantCultureIgnoreCase)..];
            json = json[..json.IndexOf("};", StringComparison.InvariantCultureIgnoreCase)];
            json = json.Replace("vm.CurChapter = ", string.Empty) + "}";

            data = JsonConvert.DeserializeObject<PageData>(json)!;
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        if (!int.TryParse(data.Page, out int pageCount))
        {
            return Result.Fail("Unable to parse page count");
        }

        List<PageListItem> items = new();

        string chapterString = GetChapterString(data);
        string pathName = GetPathName(result.Value);
        string directory = string.IsNullOrEmpty(data.Directory) ? string.Empty : data.Directory + "/";

        for (int i = 0; i < pageCount; i++)
        {
            string s = "000" + (i + 1);
            string page = s[^3..];
            string url = $"https://{pathName}/manga/{slug}/{directory}{chapterString}-{page}.png";

            items.Add(new PageListItem(ConstructId(url), url));
        }

        return Result.Ok(new PageList(items));
    }

    protected sealed override Task<Result<byte[]>> GetImage(string pageId, CancellationToken ct) =>
        GetHttpClient().GetBuffer(pageId.FromBase64(), ct);

    private static string GetChapterString(PageData data)
    {
        string chapterString = data.Chapter[1..^1];

        if (data.Chapter[^1] != '0')
        {
            chapterString += $".{data.Chapter[^1]}";
        }

        return chapterString;
    }

    private static string GetPathName(string body)
    {
        string pathName = body;
        pathName = pathName[pathName.IndexOf("vm.CurPathName = ", StringComparison.InvariantCultureIgnoreCase)..];
        pathName = pathName[..pathName.IndexOf(";", StringComparison.InvariantCultureIgnoreCase)];
        pathName = pathName.Replace("vm.CurPathName = ", string.Empty).Trim('"');
        return pathName;
    }
}
