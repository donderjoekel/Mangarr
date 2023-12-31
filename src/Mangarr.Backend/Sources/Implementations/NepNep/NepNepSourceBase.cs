using System.Text.RegularExpressions;
using FluentResults;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Implementations.NepNep.Data;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Newtonsoft.Json;
using Group = System.Text.RegularExpressions.Group;

namespace Mangarr.Backend.Sources.Implementations.NepNep;

internal abstract class NepNepSourceBase : SourceBase
{
    protected NepNepSourceBase(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected sealed override async Task<Result<SearchResult>> Search(string query)
    {
        Result<string> result = await GetHttpClient().Get($"{Url}/search/");

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

        items = items.Where(x => x.Title.Contains(query, StringComparison.InvariantCultureIgnoreCase)).ToArray();

        string coverUrl = string.Empty;

        try
        {
            Match match = Regex.Match(result.Value,
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

        return Result.Ok(new SearchResult(
            items.Select(x => new SearchResultItem(x.Slug.ToBase64(),
                    x.Title,
                    $"{Url}/manga/{x.Slug}",
                    coverUrl.Replace("{{Series.i}}", x.Slug)))
                .ToList()));
    }

    protected sealed override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        mangaId = mangaId.FromBase64();

        Result<string> result = await GetHttpClient().Get($"{Url}/manga/{mangaId}");

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

        List<ChapterListItem> items = [];

        foreach (ChapterData chapter in data)
        {
            string chapterString = chapter.Chapter[1..^1];

            if (int.TryParse(chapterString, out int chapterNumber))
            {
                chapterString = chapterNumber.ToString();
            }

            if (chapter.Chapter[^1] != '0')
            {
                chapterString += $".{chapter.Chapter[^1]}";
            }

            if (!double.TryParse(chapterString, out double fullChapterNumber))
            {
                fullChapterNumber = -1;
            }

            items.Add(new ChapterListItem((mangaId + "|" + chapterString).ToBase64(),
                "Chapter " + chapterString,
                fullChapterNumber,
                $"{Url}/read-online/{mangaId}-chapter-{chapterString}.html"));
        }

        items.Reverse();
        return Result.Ok(new ChapterList(items));
    }

    protected sealed override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        string[] splits = chapterId.FromBase64().Split('|');
        string mangaId = splits[0];
        string chapterNumber = splits[1];

        Result<string> result = await GetHttpClient().Get($"{Url}/read-online/{mangaId}-chapter-{chapterNumber}.html");

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

        List<PageListItem> items = [];

        string chapterString = GetChapterString(data);
        string pathName = GetPathName(result.Value);
        string directory = string.IsNullOrEmpty(data.Directory) ? string.Empty : data.Directory + "/";

        for (int i = 0; i < pageCount; i++)
        {
            string s = "000" + (i + 1);
            string page = s[^3..];
            string url = $"https://{pathName}/manga/{mangaId}/{directory}{chapterString}-{page}.png";

            items.Add(new PageListItem(url.ToBase64(), $"Page {page}", url));
        }

        return Result.Ok(new PageList(items));
    }

    protected sealed override Task<Result<byte[]>> GetImage(string pageId) =>
        GetHttpClient().GetBuffer(pageId.FromBase64());

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
