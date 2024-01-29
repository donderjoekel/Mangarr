using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FluentResults;
using Mangarr.Stack.Sources.Clients;
using Mangarr.Stack.Sources.Extensions;
using Mangarr.Stack.Sources.Models.Chapter;
using Mangarr.Stack.Sources.Models.Page;
using Mangarr.Stack.Sources.Models.Search;
using Group = System.Text.RegularExpressions.Group;

namespace Mangarr.Stack.Sources.Implementations.BuddyComplex;

internal abstract class BuddyComplexSourceBase : SourceBase
{
    public BuddyComplexSourceBase(
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

    protected override async Task<Result<SearchResult>> Search(string query)
    {
        Result<IDocument> result = await GetHttpClient().GetDocument(Url + "/search?status=all&sort=views&q=" + query);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<SearchResultItem> items = new();

        IEnumerable<IHtmlDivElement> elements =
            result.Value.QuerySelectorAll<IHtmlDivElement>("div.list div.book-item");

        foreach (IHtmlDivElement element in elements)
        {
            IHtmlAnchorElement? urlElement = element.FindDescendant<IHtmlAnchorElement>();
            string url = Url + urlElement.PathName;
            string id = url.TrimEnd('/').Split('/').Last();

            IHtmlDivElement? titleElement = element.QuerySelector<IHtmlDivElement>("div.title");
            string title = titleElement.TextContent.Trim();

            IHtmlImageElement? imageElement = element.FindDescendant<IHtmlImageElement>();
            string coverUrl = imageElement.GetAttribute("data-src");

            items.Add(new SearchResultItem(ConstructId(url, id), title, coverUrl));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        DeconstructId(mangaId, out string url, out string[] args);
        string id = args[0];

        Result<IDocument> documentResult =
            await GetHttpClient().GetDocument(Url + "/api/manga/" + id + "/chapters?source=detail");

        if (documentResult.IsFailed)
        {
            return documentResult.ToResult();
        }

        List<ChapterListItem> items = new();

        IEnumerable<IHtmlListItemElement> elements =
            documentResult.Value.QuerySelectorAll<IHtmlListItemElement>("ul.chapter-list li");

        foreach (IHtmlListItemElement element in elements)
        {
            IHtmlElement? titleElement = element.QuerySelector<IHtmlElement>("strong.chapter-title");
            string title = titleElement?.TextContent.Trim();

            IHtmlElement? dateElement = element.QuerySelector<IHtmlElement>("time.chapter-update");
            string date = dateElement.TextContent.Trim();
            DateTime parsedDate = DateTime.MinValue;

            try
            {
                parsedDate = string.IsNullOrEmpty(date) ? DateTime.MinValue : DateTime.Parse(date);
            }
            catch (Exception e)
            {
                Logger.LogWarning(e, "Unable to parse date, input: {Input}", date);
            }

            IHtmlAnchorElement? urlElement = element.FindChild<IHtmlAnchorElement>();
            string chapterUrl = Url + urlElement.PathName;

            Match byChapter = Regex.Match(chapterUrl, "(?:chapter|ch)-((\\d+)(?:[-.]\\d+)?)");
            string lastPartOfId = chapterUrl.Split('-')[^1];
            Match byNumber = Regex.Match(lastPartOfId, "(\\d+)(?:[-.]\\d+)?");

            string chapterNumberRegex = byChapter.Success && byChapter.Groups[1].Value != null
                ? byChapter.Groups[1].Value
                : byNumber.Success
                    ? byNumber.Groups[0].Value
                    : "0";

            bool isNumeric = double.TryParse(chapterNumberRegex.Replace("-", "."), out double chapterNumber);

            chapterNumber = isNumeric ? chapterNumber : 0;

            items.Add(
                new ChapterListItem(
                    ConstructId(chapterUrl),
                    title,
                    chapterNumber,
                    parsedDate,
                    chapterUrl));
        }

        return Result.Ok(new ChapterList(items));
    }

    private async Task<Result<string>> ChapterList(string url)
    {
        Result<string> result = await GetHttpClient().Get(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        Match match = Regex.Match(result.Value, "bookId = (\\d+);");

        if (!match.Success)
        {
            return Result.Fail("Unable to find book id");
        }

        Group? group = match.Groups.Values.FirstOrDefault(x => x is not Match);

        if (group == null)
        {
            return Result.Fail("Unable to find group");
        }

        return group.Value;
    }

    protected override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        DeconstructId(chapterId, out string url, out _);

        Result<string> result = await GetHttpClient().Get(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        Match match = Regex.Match(result.Value, "chapImages\\s=\\s'(.+)(?=')");

        if (match.Success)
        {
            Group? group = match.Groups.Values.FirstOrDefault(x => x is not Match);

            if (group == null)
            {
                return Result.Fail("Unable to find group");
            }

            string[] chapImages = group.Value.Split(',');

            List<PageListItem> items = chapImages
                .Select(chapImage =>
                    new PageListItem(
                        ConstructId(chapImage),
                        chapImage))
                .ToList();

            return Result.Ok(new PageList(items));
        }
        else
        {
            IDocument document = CreateDocument(result.Value);

            IEnumerable<IHtmlImageElement> elements =
                document.QuerySelectorAll<IHtmlImageElement>("#chapter-images .chapter-image img");

            List<PageListItem> items = elements
                .Select(GetImageSource)
                .Select(source =>
                    new PageListItem(
                        ConstructId(source),
                        source))
                .ToList();

            return Result.Ok(new PageList(items));
        }

        string GetImageSource(IHtmlImageElement element)
        {
            string image = "";
            string? dataLazy = element.GetAttribute("data-lazy-src");
            string? dataSrc = element.GetAttribute("data-src");
            string? srcSet = element.GetAttribute("srcset");

            if (!string.IsNullOrEmpty(dataLazy) && !dataLazy.StartsWith("data"))
            {
                image = dataLazy;
            }
            else if (!string.IsNullOrEmpty(dataSrc) && !dataSrc.StartsWith("data"))
            {
                image = dataSrc;
            }
            else if (!string.IsNullOrEmpty(srcSet) && !srcSet.StartsWith("data"))
            {
                image = srcSet.Split(' ').First();
            }

            string wpRegexPattern = @"(https://i\d.wp.com/)";
            if (Regex.IsMatch(image, wpRegexPattern))
            {
                image = Regex.Replace(image, wpRegexPattern, string.Empty);
            }

            if (image.StartsWith("//"))
            {
                image = "https:" + image;
            }

            if (!image.StartsWith("http"))
            {
                image = "https://" + image;
            }

            return image;
        }
    }

    protected override Task<Result<byte[]>> GetImage(string pageId) => GetHttpClient().GetBuffer(pageId.FromBase64());
}
