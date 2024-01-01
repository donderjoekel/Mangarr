using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FluentResults;
using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Implementations.Custom.Webtoons.Data;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;

namespace Mangarr.Backend.Sources.Implementations.Custom.Webtoons;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class WebtoonsSource : SourceBase
{
    protected override string Id => "webtoons";
    protected override string Name => "LINE Webtoon";
    protected override string Url => "https://www.webtoons.com/en/";

    public WebtoonsSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected override Task<Result> Initialize() => Task.FromResult(Result.Ok());

    protected override Task<Result> Cache() => Task.FromResult(Result.Ok());

    protected override Task<Result<string>> Status() => Task.FromResult(Result.Ok("OK"));

    protected override async Task<Result<SearchResult>> Search(string query)
    {
        Result<SearchResultData> result =
            await GetHttpClient().Get<SearchResultData>(Url + "search/immediate?keyword=" + query);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<SearchResultItem> items = new();

        List<SearchResultData.Result.Item> list = result.Value.result.searchedList
            .Where(x => x.searchMode == "TITLE")
            .ToList();

        foreach (SearchResultData.Result.Item item in list)
        {
            string url = "https://webtoons.com/episodeList?titleNo=" + item.titleNo;

            items.Add(new SearchResultItem(url.ToBase64(),
                item.title,
                url,
                "https://webtoon-phinf.pstatic.net" + item.thumbnailMobile));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        Result<string> result = await GetHttpClient().Get(mangaId.FromBase64());

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<ChapterListItem> items = new();

        IDocument document = CreateDocument(result.Value);
        string? mangaUrl = document.QuerySelector<IHtmlLinkElement>("link[rel='canonical']")?.Href;

        if (mangaUrl is null)
        {
            return Result.Fail("Manga URL not found");
        }

        int page = 1;

        while (true)
        {
            result = await GetHttpClient().Get(mangaUrl + "&page=" + page);

            if (result.IsFailed)
            {
                return result.ToResult();
            }

            document = CreateDocument(result.Value);

            IEnumerable<IHtmlListItemElement> elements =
                document.QuerySelectorAll<IHtmlListItemElement>("li._episodeItem");

            bool foundExistingItem = false;

            foreach (IHtmlListItemElement element in elements)
            {
                string? episodeNumber = element.GetAttribute("data-episode-no");
                double chapterNumber = double.Parse(episodeNumber);
                IHtmlAnchorElement? anchor = element.FindDescendant<IHtmlAnchorElement>();
                IHtmlSpanElement? titleElement = element.QuerySelector<IHtmlSpanElement>(".subj");
                IHtmlSpanElement? dateElement = element.QuerySelector<IHtmlSpanElement>(".date");

                if (items.Any(x => x.Url == anchor.Href))
                {
                    foundExistingItem = true;
                    break;
                }

                items.Add(
                    new ChapterListItem(
                        anchor.Href.ToBase64(),
                        titleElement.TextContent,
                        chapterNumber,
                        DateTime.Parse(dateElement.TextContent).Date,
                        anchor.Href));
            }

            if (foundExistingItem)
            {
                break;
            }

            page++;
        }

        return Result.Ok(new ChapterList(items));
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

        IEnumerable<IHtmlImageElement> elements = document.QuerySelectorAll<IHtmlImageElement>("#_imageList img");

        foreach (IHtmlImageElement element in elements)
        {
            string? url = element.GetAttribute("data-url");
            if (string.IsNullOrEmpty(url))
            {
                return Result.Fail("Image URL not found");
            }

            items.Add(new PageListItem(url.ToBase64(), url));
        }

        return Result.Ok(new PageList(items));
    }

    protected override Task<Result<byte[]>> GetImage(string pageId) => GetHttpClient().GetBuffer(pageId.FromBase64());
}
