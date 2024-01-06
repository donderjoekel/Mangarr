using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FluentResults;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Implementations.MangaStream.Data;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Newtonsoft.Json;
using Group = System.Text.RegularExpressions.Group;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

internal abstract class MangaStreamSourceBase : SourceBase
{
    private readonly CachingService _cachingService;

    protected virtual bool UsePostIds => false;

    protected MangaStreamSourceBase(
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

    protected override async Task<Result<SearchResult>> Search(string query)
    {
        Result<SearchResponse> result = await GetHttpClient().PostAsForm<SearchResponse>(
            Url + "/wp-admin/admin-ajax.php",
            new SearchRequest(query));

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        if (result.Value.series.Length == 0)
        {
            return Result.Ok(new SearchResult(new List<SearchResultItem>()));
        }

        List<SearchResultItem> items = new();

        foreach (SearchResponse.Series series in result.Value.series)
        {
            items.AddRange(
                series.all.Select(x =>
                    new SearchResultItem(
                        ConstructId(Url + "?p=" + x.ID, x.ID.ToString()), // Always use shorthand url
                        x.post_title,
                        x.post_image)));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        DeconstructId(mangaId, out string url, out string[] _);

        Result<string> result = await GetHttpClient().Get(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<ChapterListItem> items = new();
        IDocument document = CreateDocument(result.Value);

        IEnumerable<IHtmlListItemElement> elements = document.QuerySelectorAll<IHtmlListItemElement>("#chapterlist li");

        foreach (IHtmlListItemElement element in elements)
        {
            Match match = Regex.Match(element.GetAttribute("data-num"), @"(\d+\.?\d?)+");
            double chapterNumber = 0;
            if (match.Success && match.Groups.Count > 1)
            {
                chapterNumber = double.Parse(match.Groups[1].Value);
            }

            IHtmlAnchorElement? anchorElement = element.FindDescendant<IHtmlAnchorElement>();
            IHtmlSpanElement? titleElement = element.QuerySelector<IHtmlSpanElement>(".chapternum");
            IHtmlSpanElement? dateElement = element.QuerySelector<IHtmlSpanElement>(".chapterdate");

            items.Add(new ChapterListItem(
                ConstructId(anchorElement.Href, url, chapterNumber.ToString()),
                titleElement.TextContent,
                chapterNumber,
                DateTime.Parse(dateElement.TextContent).Date,
                anchorElement.Href));
        }

        return Result.Ok(new ChapterList(items));
    }

    protected override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        DeconstructId(chapterId, out string url, out string[] args);

        string mangaUrl = args[0];
        string chapterNumber = args[1];
        double parsedChapterNumber = double.Parse(chapterNumber);

        {
            Result<IDocument> mangaResult = await GetHttpClient().GetDocument(mangaUrl);

            if (mangaResult.IsFailed)
            {
                return mangaResult.ToResult();
            }

            IHtmlListItemElement? element = mangaResult.Value.QuerySelectorAll<IHtmlListItemElement>("#chapterlist li")
                .FirstOrDefault(x =>
                {
                    if (double.TryParse(x.GetAttribute("data-num"), out double y))
                    {
                        return y == parsedChapterNumber;
                    }

                    return false;
                });

            if (element == null)
            {
                return Result.Fail("Unable to find the chapter");
            }

            IHtmlAnchorElement? anchor = element.FindDescendant<IHtmlAnchorElement>();

            if (anchor == null)
            {
                return Result.Fail("Unable to find the chapter");
            }

            url = anchor.Href;
        }

        Result<string> result = await GetHttpClient().Get(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        Match match = Regex.Match(result.Value, "ts_reader.run\\(({.+?})\\)");

        if (!match.Success)
        {
            return Result.Fail("Unable to find loader element");
        }

        Group? group = match.Groups.Values.FirstOrDefault(x => x is not Match);

        if (group == null)
        {
            return Result.Fail("Unable to find loader element");
        }

        LoaderData loaderData;

        try
        {
            string fixedJson = group.Value.Replace(":!", ":");
            loaderData = JsonConvert.DeserializeObject<LoaderData>(fixedJson)!;
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }

        LoaderData.Source? source = loaderData.sources.FirstOrDefault();

        if (source == null)
        {
            return Result.Fail("Unable to find source");
        }

        List<PageListItem> items = new();
        items.AddRange(source.images.Select(image => new PageListItem(image.ToBase64(), image)));

        return Result.Ok(new PageList(items));
    }

    protected override Task<Result<byte[]>> GetImage(string pageId) =>
        GetHttpClient().GetBuffer(pageId.FromBase64());
}
