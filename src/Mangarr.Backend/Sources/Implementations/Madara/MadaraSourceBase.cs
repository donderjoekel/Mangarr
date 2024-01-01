using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FluentResults;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;

namespace Mangarr.Backend.Sources.Implementations.Madara;

internal abstract class MadaraSourceBase : SourceBase
{
    protected virtual bool UseAjaxChapterListMethod => false;
    protected virtual bool UseIdChapterListMethod => false;

    protected MadaraSourceBase(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected override Task<Result> Initialize()
    {
        Task<Result> fromResult = Task.FromResult(Result.Ok());
        return fromResult;
    }

    protected override Task<Result> Cache() => Task.FromResult(Result.Ok());

    protected override Task<Result<string>> Status() => Task.FromResult(Result.Ok("OK"));

    protected override async Task<Result<SearchResult>> Search(string query)
    {
        Result<string> result = await GetHttpClient().Get(Url + $"?s={query}&post_type=wp-manga");

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<SearchResultItem> items = new();

        IDocument document = CreateDocument(result.Value);
        IEnumerable<IHtmlDivElement> elements = document.QuerySelectorAll<IHtmlDivElement>("div.c-tabs-item__content");

        foreach (IHtmlDivElement element in elements)
        {
            IHtmlAnchorElement? anchor = element.FindDescendant<IHtmlAnchorElement>();
            IHtmlImageElement? image = element.FindDescendant<IHtmlImageElement>();
            string coverUrl = image.GetAttribute("data-src") ?? image.Source;

            items.Add(new SearchResultItem(anchor.Href.ToBase64(),
                anchor.GetAttribute("title"),
                anchor.Href,
                coverUrl));
        }

        return Result.Ok(new SearchResult(items));
    }

    private async Task<Result<string>> GetChapterId(string url)
    {
        Result<string> result = await GetHttpClient().Get(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        IDocument idDocument = CreateDocument(result.Value);

        IHtmlDivElement? element = idDocument.QuerySelector<IHtmlDivElement>("#manga-chapters-holder");
        if (element == null)
        {
            return Result.Fail("Unable to find chapters holder");
        }

        string? dataId = element.GetAttribute("data-id");
        if (string.IsNullOrEmpty(dataId))
        {
            return Result.Fail("Unable to get data-id");
        }

        return Result.Ok(dataId);
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        string url = mangaId.FromBase64();
        Result<string> result = await GetPageContent(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<ChapterListItem> items = new();

        IDocument document = CreateDocument(result.Value);
        List<IHtmlListItemElement> elements = document
            .QuerySelectorAll<IHtmlListItemElement>(".wp-manga-chapter")
            .ToList();

        foreach (IHtmlListItemElement element in elements)
        {
            IHtmlAnchorElement? anchorElement = element.FindDescendant<IHtmlAnchorElement>();
            string chapterUrl = anchorElement.Href;
            string chapterId = chapterUrl.Trim(' ', '/', '\\').Split('/').Last();
            double chapterNumber = GetNumberOfChapter(chapterId);
            DateTime dateTime = GetPostDateOfChapter(element);

            items.Add(
                new ChapterListItem(
                    chapterUrl.ToBase64(),
                    anchorElement.TextContent.Trim(),
                    chapterNumber,
                    dateTime.Date,
                    chapterUrl));
        }

        return Result.Ok(new ChapterList(items));
    }

    private static double GetNumberOfChapter(string chapterId)
    {
        Regex chapNumRegex = new("(?:chapter|ch.*?)(\\d+\\.?\\d?(?:[-_]\\d+)?)|(\\d+\\.?\\d?(?:[-_]\\d+)?)$");
        Match chapNumMatch = chapNumRegex.Match(chapterId);
        string chapNum = "0";

        if (chapNumMatch.Success)
        {
            if (!string.IsNullOrEmpty(chapNumMatch.Groups[1].Value))
            {
                chapNum = chapNumMatch.Groups[1].Value.Replace("-", ".").Replace("_", ".");
            }
            else if (!string.IsNullOrEmpty(chapNumMatch.Groups[2].Value))
            {
                chapNum = chapNumMatch.Groups[2].Value;
            }
        }

        if (double.TryParse(chapNum, out double chapterNumber))
        {
            return chapterNumber;
        }

        return 0;
    }

    private DateTime GetPostDateOfChapter(IHtmlListItemElement element)
    {
        IHtmlSpanElement? dateElement = element.QuerySelector<IHtmlSpanElement>(".chapter-release-date");
        string? dateText = dateElement?.TextContent.Trim();

        if (!DateTime.TryParse(dateText, out DateTime dateTime))
        {
            dateTime = ParseRelativeDate(dateText);
        }

        return dateTime;
    }

    private async Task<Result<string>> GetPageContent(string url)
    {
        Result<string> result;

        if (UseIdChapterListMethod)
        {
            Result<string> chapterIdResult = await GetChapterId(url);

            if (chapterIdResult.IsFailed)
            {
                return chapterIdResult.ToResult();
            }

            result = await GetHttpClient().PostAsForm(Url + "/wp-admin/admin-ajax.php",
                new { action = "manga_get_chapters", manga = chapterIdResult.Value });
        }
        else if (UseAjaxChapterListMethod)
        {
            result = await GetHttpClient().Post(url.EndsWith('/')
                ? url + "ajax/chapters/"
                : url + "/ajax/chapters/");
        }
        else
        {
            result = await GetHttpClient().Get(url);
        }

        return result;
    }

    protected override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        Result<string> result = await GetHttpClient().Get(chapterId.FromBase64());

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<PageListItem> items = new();

        IDocument document = CreateDocument(result.Value);
        IEnumerable<IHtmlImageElement> elements = document.QuerySelectorAll<IHtmlImageElement>(".wp-manga-chapter-img");

        foreach (IHtmlImageElement element in elements)
        {
            string source = element.GetAttribute("data-src")?.Trim() ??
                            element.GetAttribute("src")?.Trim() ??
                            string.Empty;

            items.Add(new PageListItem(source.ToBase64(), source));
        }

        return Result.Ok(new PageList(items));
    }

    protected override Task<Result<byte[]>> GetImage(string pageId) => GetHttpClient().GetBuffer(pageId.FromBase64());
}
