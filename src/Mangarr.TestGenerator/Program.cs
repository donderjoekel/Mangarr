// See https://aka.ms/new-console-template for more information

using System.Text;
using FluentResults;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Cloudflare;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Mangarr.TestGenerator;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using StackExchange.Redis;

ServiceCollection collection = new();

collection.AddSerilog(configuration => { configuration.WriteTo.Console().MinimumLevel.Debug(); });
collection.AddSingleton<CachingService>();
// collection.AddTransient<CachingHandler>(provider => new CachingHandler(provider.GetRequiredService<CachingService>()));
collection.AddSingleton<IConnectionMultiplexer>(_ =>
    ConnectionMultiplexer.Connect("localhost:6379", options => { options.Password = "password"; }));
collection.AddTransient<IDatabase>(provider => provider.GetRequiredService<IConnectionMultiplexer>().GetDatabase());

collection.AddHttpClient("Generic").AddRetryPolicy();
// .AddHttpMessageHandler<CachingHandler>();
collection.AddTransient<CustomClearanceHandler>(_ => new CustomClearanceHandler("http://localhost:8191"));
collection.AddHttpClient("Cloudflare").AddRetryPolicy()
    // .AddHttpMessageHandler<CachingHandler>()
    .AddHttpMessageHandler<CustomClearanceHandler>();
collection.AddMangarrBackend();
ServiceProvider provider = collection.BuildServiceProvider();

List<ISource> sources = provider.GetRequiredService<IEnumerable<ISource>>().OrderBy(x => x.Name).ToList();

const string path = "../../../../Mangarr.Backend.Tests/Generated/";

foreach (ISource source in sources)
{
    StringBuilder builder = new();

    if (File.Exists(GetSourcePath(source)) || File.Exists(GetErrorPath(source)))
    {
        continue;
    }

    builder.AppendLine("using System.Collections;");
    builder.AppendLine();
    builder.AppendLine("namespace Mangarr.Backend.Tests;");
    builder.AppendLine();
    builder.AppendLine($"public class {source.Name.Replace(" ", string.Empty)}SourceTests : SourceTestBase");
    builder.AppendLine("{");
    builder.AppendLine($"    protected override string SourceIdentifier => \"{source.Identifier}\";");
    builder.AppendLine();
    builder.AppendLine("    public static IEnumerable ValidSearchResults()");
    builder.AppendLine("    {");

    string[] searchQueries = { "a", "e", "i", "o", "u" };
    List<SearchResultItem> searchResultItems = new();

    foreach (string searchQuery in searchQueries)
    {
        Result<SearchResult> search = await source.Search(searchQuery);

        if (search.IsFailed)
        {
            continue;
        }

        if (search.Value.Items.Count == 0)
        {
            continue;
        }

        searchResultItems.AddRange(search.Value.Items);
        builder.AppendLine($"        yield return new TestCaseData(\"{searchQuery}\");");
    }

    builder.AppendLine("    }");
    builder.AppendLine();
    builder.AppendLine("    public static IEnumerable ValidChapterLists()");
    builder.AppendLine("    {");

    searchResultItems = searchResultItems.Distinct().ToList();
    // searchResultItems.Shuffle();

    if (searchResultItems.Count == 0)
    {
        WriteErrorForSource(source);
        continue;
    }

    int min = Math.Min(searchResultItems.Count, 5);
    List<ChapterListItem> chapterListItems = new();

    for (int i = 0; i < min; i++)
    {
        SearchResultItem searchResultItem = searchResultItems[i];
        Result<ChapterList> chapterList = await source.GetChapterList(searchResultItem.Id);

        if (chapterList.IsFailed)
        {
            continue;
        }

        if (chapterList.Value.Items.Count == 0)
        {
            continue;
        }

        chapterListItems.AddRange(chapterList.Value.Items);
        DeconstructId(searchResultItem.Id, out string url, out _);
        builder.AppendLine($"        // {url}");
        builder.AppendLine($"        yield return new TestCaseData(\"{searchResultItem.Id}\");");
    }

    builder.AppendLine("    }");
    builder.AppendLine();
    builder.AppendLine("    public static IEnumerable ValidPageLists()");
    builder.AppendLine("    {");

    chapterListItems = chapterListItems.Distinct().ToList();
    chapterListItems.Shuffle();

    if (chapterListItems.Count == 0)
    {
        WriteErrorForSource(source);
        continue;
    }

    min = Math.Min(chapterListItems.Count, 5);
    List<PageListItem> pageListItems = new();

    for (int i = 0; i < min; i++)
    {
        ChapterListItem chapterListItem = chapterListItems[i];
        Result<PageList> pageList = await source.GetPageList(chapterListItem.Id);

        if (pageList.IsFailed)
        {
            continue;
        }

        if (pageList.Value.Items.Count == 0)
        {
            continue;
        }

        pageListItems.AddRange(pageList.Value.Items);
        DeconstructId(chapterListItem.Id, out string url, out _);
        builder.AppendLine($"        // {url}");
        builder.AppendLine($"        yield return new TestCaseData(\"{chapterListItem.Id}\");");
    }

    builder.AppendLine("    }");
    builder.AppendLine();
    builder.AppendLine("    public static IEnumerable ValidImages()");
    builder.AppendLine("    {");

    pageListItems = pageListItems.Distinct().ToList();
    pageListItems.Shuffle();

    if (pageListItems.Count == 0)
    {
        WriteErrorForSource(source);
        // File.WriteAllText("out/" + source.Name.Replace(" ", string.Empty) + "SourceTests.cs.Error", string.Empty);
        continue;
    }

    min = Math.Min(pageListItems.Count, 5);
    List<string> imageUrls = new();

    for (int i = 0; i < min; i++)
    {
        PageListItem pageListItem = pageListItems[i];
        Result<byte[]> image = await source.GetImage(pageListItem.Id);

        if (image.IsFailed)
        {
            continue;
        }

        if (image.Value.Length == 0)
        {
            continue;
        }

        imageUrls.Add(pageListItem.Url);
        DeconstructId(pageListItem.Id, out string url, out _);
        builder.AppendLine($"        // {url}");
        builder.AppendLine($"        yield return new TestCaseData(\"{pageListItem.Id}\");");
    }

    builder.AppendLine("    }");
    builder.AppendLine("}");
    builder.AppendLine();

    if (imageUrls.Count == 0)
    {
        WriteErrorForSource(source);
    }
    else
    {
        WriteForSource(source, builder.ToString());
    }
}

// Yoinked from SourceBase.Utilities.cs
static void DeconstructId(string id, out string url, out string[] args)
{
    string[] splits = id.FromBase64().Split('|', StringSplitOptions.RemoveEmptyEntries);
    url = splits[0];
    args = splits.Skip(1).ToArray();
}

static string GetSourcePath(ISource source)
{
    string sourceName = source.Name
        .Replace(" ", string.Empty)
        .Replace("-", "Dash");

    return path + sourceName + "SourceTests.cs";
}

static string GetErrorPath(ISource source)
{
    string sourceName = source.Name
        .Replace(" ", string.Empty)
        .Replace("-", "Dash");

    return path + sourceName + "SourceTests.cs.Error";
}

static void WriteForSource(ISource source, string content)
{
    string fullPath = Path.GetFullPath(path);

    File.WriteAllText(GetSourcePath(source), content);
}

static void WriteErrorForSource(ISource source)
{
    File.WriteAllText(GetErrorPath(source), string.Empty);
}
