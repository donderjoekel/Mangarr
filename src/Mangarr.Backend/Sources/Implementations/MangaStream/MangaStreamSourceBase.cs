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
                series.all.Select(x =>
                    new SearchResultItem(
                        ConstructId(Url + "?p=" + x.ID, x.ID.ToString()),
                        x.post_title,
                        x.post_image)));
        }

        return Result.Ok(new SearchResult(items));
    }

    protected override async Task<Result<ChapterList>> GetChapterList(string mangaId)
    {
        DeconstructId(mangaId, out string url, out string[] args);
        string chapterId = args[0];

        Result<string> result = await GetHttpClient().PostAsForm(Url + "/wp-admin/admin-ajax.php",
            new { action = "get_chapters", id = chapterId });

        if (result.IsFailed)
        {
            return result.ToResult();
        }

        List<ChapterListItem> items = new();
        IDocument document = CreateDocument(result.Value);

        IEnumerable<IHtmlOptionElement> elements = document.QuerySelectorAll<IHtmlOptionElement>("option");

        foreach (IHtmlOptionElement element in elements)
        {
            string? id = element.GetAttribute("data-id");
            string title = element.TextContent.Trim();
            double number = double.Parse(Regex.Replace(title, "[^0-9.]", string.Empty));
            string chapterUrl = Url + "?p=" + id;

            items.Add(new ChapterListItem(ConstructId(chapterUrl, id),
                title,
                number,
                DateTime.UtcNow,
                chapterUrl));
        }

        return Result.Ok(new ChapterList(items));
    }

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
