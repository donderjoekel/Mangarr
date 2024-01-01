using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using FluentResults;
using Injectio.Attributes;
using Mangarr.Backend.Sources.Caching;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Newtonsoft.Json.Linq;

namespace Mangarr.Backend.Sources.Implementations.Custom.ReaperScans;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ReaperScansSource : SourceBase
{
    protected override string Id => "reaperscans";
    protected override string Name => "Reaper Scans";
    protected override string Url => "https://reaperscans.com";
    protected override bool HasCloudflareProtection => true;

    public ReaperScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected override Task<Result> Initialize() => Cache();

    protected override Task<Result> Cache() => Task.FromResult(Result.Ok());

    protected override Task<Result<string>> Status() => Task.FromResult(Result.Ok("OK"));

    private string GenerateId()
    {
        byte[] buffer = new byte[8];
        Random.Shared.NextBytes(buffer);
        return Convert.ToBase64String(buffer);
    }

    protected override async Task<Result<SearchResult>> Search(string query)
    {
        CustomHttpClient httpClient = GetHttpClient();
        httpClient.AddHeader(CachingHandler.BypassCacheKey, "true");

        Result<string> result = await httpClient.Get(Url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        IDocument document = CreateDocument(result.Value);
        string? csrf = document.QuerySelector<IHtmlMetaElement>("meta[name=csrf-token]")?.GetAttribute("content");

        if (string.IsNullOrEmpty(csrf))
        {
            return Result.Fail("Unable to acquire CSRF token");
        }

        string? requestInfo = document.QuerySelector("[wire\\:initial-data]")?.GetAttribute("wire:initial-data");

        if (string.IsNullOrEmpty(requestInfo))
        {
            return Result.Fail("Unable to acquire request info");
        }

        JObject jsonRequestInfo = JObject.Parse(requestInfo);

        JObject body = new();
        body.Add("fingerprint", jsonRequestInfo["fingerprint"]);
        body.Add("serverMemo", jsonRequestInfo["serverMemo"]);
        body.Add("updates",
            new JArray
            {
                new JObject
                {
                    new JProperty("type", "syncInput"),
                    new JProperty("payload",
                        new JObject
                        {
                            new JProperty("id", GenerateId()),
                            new JProperty("name", "query"),
                            new JProperty("value", query)
                        })
                }
            });

        httpClient.AddHeader("X-Livewire", "true");
        httpClient.AddHeader("X-CSRF-TOKEN", csrf);

        string fingerprintName = jsonRequestInfo["fingerprint"]["name"].Value<string>() ?? "fingerprint.was_none";
        result = await httpClient.PostAsJson(Url + "/livewire/message/" + fingerprintName, body);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        JObject jObject = JObject.Parse(result.Value);
        string? html = jObject["effects"]?["html"]?.Value<string>();

        if (string.IsNullOrEmpty(html))
        {
            return Result.Fail("Unable to acquire HTML");
        }

        IDocument document1 = CreateDocument(html);
        IEnumerable<IHtmlImageElement> elements = document1.QuerySelectorAll<IHtmlImageElement>("ul li a img");

        List<SearchResultItem> items = [];

        foreach (IHtmlImageElement element in elements)
        {
            string cover = element.Source!;
            string title = element.AlternativeText!;

            if (!element.TryGetParentElement(out IHtmlAnchorElement? anchor))
            {
                // TODO: Handle properly
                continue;
            }

            string url = anchor.Href;

            if (!url.Contains("/comics/"))
            {
                continue;
            }

            items.Add(new SearchResultItem(url.ToBase64(), title, url, cover));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        string url = mangaId.FromBase64();

        CustomHttpClient httpClient = GetHttpClient();
        httpClient.AddHeader(CachingHandler.BypassCacheKey, "true");

        Result<string> result = await httpClient.Get(url);

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        IDocument document = CreateDocument(result.Value);
        string? csrf = document.QuerySelector<IHtmlMetaElement>("meta[name=csrf-token]")?.GetAttribute("content");

        if (string.IsNullOrEmpty(csrf))
        {
            return Result.Fail("Unable to acquire CSRF token");
        }

        string? requestInfo = document.QuerySelector("div.pb-4 div")?.GetAttribute("wire:initial-data");

        if (string.IsNullOrEmpty(requestInfo))
        {
            return Result.Fail("Unable to acquire request info");
        }

        List<ChapterListItem> items = [];
        items.AddRange(GetChaptersFromPage(document));

        int page = 2;
        while (true)
        {
            JObject jsonRequestInfo = JObject.Parse(requestInfo);

            JObject body = new();
            body.Add("fingerprint", jsonRequestInfo["fingerprint"]);
            body.Add("serverMemo", jsonRequestInfo["serverMemo"]);
            body.Add("updates",
                new JArray
                {
                    new JObject
                    {
                        new JProperty("type", "callMethod"),
                        new JProperty("payload",
                            new JObject
                            {
                                new JProperty("id", GenerateId()),
                                new JProperty("method", "gotoPage"),
                                new JProperty("params", new JArray { page.ToString(), "page" })
                            })
                    }
                });

            httpClient.AddHeader("X-Livewire", "true");
            httpClient.AddHeader("X-CSRF-TOKEN", csrf);

            string fingerprintName = jsonRequestInfo["fingerprint"]["name"].Value<string>() ?? "fingerprint.was_none";
            result = await httpClient.PostAsJson(Url + "/livewire/message/" + fingerprintName, body);

            if (result.IsFailed)
            {
                return result.ToResult();
            }

            JObject jObject = JObject.Parse(result.Value);
            string? html = jObject["effects"]?["html"]?.Value<string>();

            if (string.IsNullOrEmpty(html))
            {
                return Result.Fail("Unable to acquire HTML");
            }

            List<ChapterListItem> chapterListItems = GetChaptersFromPage(CreateDocument(html));
            items.AddRange(chapterListItems);

            if (chapterListItems.Count < 32)
            {
                break;
            }

            page++;
        }

        return Result.Ok(new ChapterList(items));
    }

    private static List<ChapterListItem> GetChaptersFromPage(IDocument document)
    {
        List<ChapterListItem> items = [];

        List<IHtmlAnchorElement> elements = document
            .QuerySelectorAll<IHtmlAnchorElement>("ul[role=list] li a")
            .ToList();

        foreach (IHtmlAnchorElement element in elements)
        {
            string url = element.Href;
            if (string.IsNullOrEmpty(url))
            {
                continue;
            }

            if (!url.Contains("-chapter-"))
            {
                continue;
            }

            string name = element.QuerySelector<IHtmlParagraphElement>(".font-medium")?.TextContent.Trim() ??
                          string.Empty;

            string number = name.Split(' ').ElementAtOrDefault(1) ?? "-1";
            double chapterNumber = double.Parse(number);

            items.Add(new ChapterListItem(url.ToBase64(), "Chapter " + number, chapterNumber, url));
        }

        return items;
    }

    protected override async Task<Result<PageList>> GetPageList(string chapterId)
    {
        Result<string> result = await GetHttpClient().Get(chapterId.FromBase64());

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        IDocument document = CreateDocument(result.Value);

        List<PageListItem> items = [];

        IEnumerable<IHtmlImageElement> elements = document.QuerySelectorAll<IHtmlImageElement>("main noscript img");

        items.AddRange(elements.Select(element => element.Source!)
            .Select(url => new PageListItem(url.ToBase64(), url)));

        return Result.Ok(new PageList(items));
    }

    protected override Task<Result<byte[]>> GetImage(string pageId) => GetHttpClient().GetBuffer(pageId.FromBase64());
}
