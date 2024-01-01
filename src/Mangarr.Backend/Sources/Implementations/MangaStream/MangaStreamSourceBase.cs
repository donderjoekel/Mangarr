using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FluentResults;
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
    protected MangaStreamSourceBase(
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
                series.all.Select(all =>
                    new SearchResultItem(
                        ConstructId(all.post_link),
                        all.post_title,
                        all.post_image)));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        DeconstructId(mangaId, out string url, out _);
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
            try
            {
                string? number = element.GetAttribute("data-num");
                double chapterNumber = double.Parse(number);
                IHtmlAnchorElement? anchorElement = element.FindDescendant<IHtmlAnchorElement>();
                IHtmlSpanElement? titleElement = element.QuerySelector<IHtmlSpanElement>(".chapternum");
                IHtmlSpanElement? dateElement = element.QuerySelector<IHtmlSpanElement>(".chapterdate");

                items.Add(new ChapterListItem(
                    ConstructId(anchorElement.Href),
                    titleElement.TextContent,
                    chapterNumber,
                    DateTime.Parse(dateElement.TextContent).Date,
                    anchorElement.Href));
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Unable to parse chapter");
            }
        }

        return Result.Ok(new ChapterList(items));
    }

    // private static double GetChapterNumber(IElement anchor)
    // {
    //     if (TryGetChapterNumberFromChapterSpan(anchor, out double fromSpan))
    //     {
    //         return fromSpan;
    //     }
    //
    //     if (TryGetChapterNumberFromParentListItem(anchor, out double fromParent))
    //     {
    //         return fromParent;
    //     }
    //
    //     return -1;
    // }
    //
    // private static bool TryGetChapterNumberFromChapterSpan(IElement anchor, out double parsed)
    // {
    //     parsed = -1;
    //     IHtmlSpanElement? chapterSpan = anchor.QuerySelector<IHtmlSpanElement>("span.chapternum");
    //     if (chapterSpan == null)
    //     {
    //         return false;
    //     }
    //
    //     if (string.IsNullOrEmpty(chapterSpan.TextContent))
    //     {
    //         return false;
    //     }
    //
    //     string number = chapterSpan.TextContent.Replace("Chapter", string.Empty).Trim();
    //     if (double.TryParse(number, out parsed))
    //     {
    //         return true;
    //     }
    //
    //     return false;
    // }
    //
    // private static bool TryGetChapterNumberFromParentListItem(IElement anchor, out double parsed)
    // {
    //     parsed = -1;
    //     IHtmlListItemElement? listItem = GetParent<IHtmlListItemElement>(anchor);
    //     if (listItem == null)
    //     {
    //         return false;
    //     }
    //
    //     string? attribute = listItem.GetAttribute("data-num");
    //     if (string.IsNullOrEmpty(attribute))
    //     {
    //         return false;
    //     }
    //
    //     return double.TryParse(attribute, out parsed);
    // }
    //
    // private static TElement? GetParent<TElement>(INode? element)
    //     where TElement : IElement
    // {
    //     if (element == null)
    //     {
    //         return default;
    //     }
    //
    //     if (element is TElement casted)
    //     {
    //         return casted;
    //     }
    //
    //     return GetParent<TElement>(element.ParentElement);
    // }

    protected override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        DeconstructId(chapterId, out string url, out _);
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
