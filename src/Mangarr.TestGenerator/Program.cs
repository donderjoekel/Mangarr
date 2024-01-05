// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Text;
using FluentResults;
using Mangarr.Backend.Services;
using Mangarr.Backend.Sources;
using Mangarr.Backend.Sources.Cloudflare;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.FluentResults;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using StackExchange.Redis;
using ServiceCollection = Microsoft.Extensions.DependencyInjection.ServiceCollection;
using ServiceProvider = Microsoft.Extensions.DependencyInjection.ServiceProvider;

namespace Mangarr.TestGenerator;

internal class Program
{
    private static string path = "../../../../Mangarr.Backend.Tests/Generated/";

    public static async Task Main(string[] args)
    {
        ServiceCollection collection = new();

        collection.AddSerilog(configuration => { configuration.WriteTo.Console().MinimumLevel.Debug(); });
        collection.AddSingleton<CachingService>();
        collection.AddSingleton<IConnectionMultiplexer>(_ =>
            ConnectionMultiplexer.Connect("localhost:6379", options => { options.Password = "password"; }));
        collection.AddTransient<IDatabase>(provider =>
            provider.GetRequiredService<IConnectionMultiplexer>().GetDatabase());

        collection.AddHttpClient("Generic");
        collection.AddTransient<CustomClearanceHandler>(_ => new CustomClearanceHandler("http://localhost:8191"));
        collection.AddHttpClient("Cloudflare").AddHttpMessageHandler<CustomClearanceHandler>();
        collection.AddMangarrBackend();
        ServiceProvider provider = collection.BuildServiceProvider();

        List<ISource> sources = provider.GetRequiredService<IEnumerable<ISource>>()
            .OrderBy(x => x.Name).ToList();

        foreach (ISource source in sources)
        {
            path = "../../../../Mangarr.Backend.Tests/Generated/" + source.GetType().BaseType!.Name + "/";
            StringBuilder builder = new();

            if (File.Exists(GetSourcePath(source)) || File.Exists(GetErrorPath(source)))
            {
                continue;
            }

            builder.AppendLine("using System.Collections;");
            builder.AppendLine();
            builder.AppendLine("namespace Mangarr.Backend.Tests;");
            builder.AppendLine();
            builder.AppendLine(
                $"public class {source.Name.Replace(" ", string.Empty).Replace("-", "Dash").Replace(".", "Dot")}SourceTests : SourceTestBase");
            builder.AppendLine("{");
            builder.AppendLine($"    protected override string SourceIdentifier => \"{source.Identifier}\";");
            builder.AppendLine();
            builder.AppendLine("    public static IEnumerable ValidSearchResults()");
            builder.AppendLine("    {");

            string[] searchQueries = { "a", "e", "i", "o", "u" };
            List<SearchResultItem> searchResultItems = new();

            List<Result> failures = new();

            foreach (string searchQuery in searchQueries)
            {
                Result<SearchResult> search = await source.Search(searchQuery);

                if (search.IsFailed)
                {
                    if (search.TryGetReason(out StatusCodeReason? statusCodeReason))
                    {
                        if (statusCodeReason.StatusCode == HttpStatusCode.Forbidden)
                        {
                            failures.Add(Result.Fail("Cloudflare protection"));
                            break;
                        }

                        if ((int)statusCodeReason.StatusCode >= 500)
                        {
                            failures.Add(Result.Fail("Server error, just remove it"));
                            break;
                        }
                    }

                    failures.Add(search.ToResult());
                    continue;
                }

                if (search.Value.Items.Count == 0)
                {
                    failures.Add(Result.Fail("Search result is empty"));
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
                WriteErrorForSource(source, failures);
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
                    failures.Add(chapterList.ToResult());
                    continue;
                }

                if (chapterList.Value.Items.Count == 0)
                {
                    failures.Add(Result.Fail("Try Ajax or Id chapter list method"));
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
                WriteErrorForSource(source, failures);
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
                    failures.Add(pageList.ToResult());
                    continue;
                }

                if (pageList.Value.Items.Count == 0)
                {
                    failures.Add(Result.Fail("Page list is empty"));
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
                WriteErrorForSource(source, failures);
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
                    failures.Add(image.ToResult());
                    continue;
                }

                if (image.Value.Length == 0)
                {
                    failures.Add(Result.Fail("Image is empty"));
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
                WriteErrorForSource(source, failures);
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
                .Replace("-", "Dash")
                .Replace(".", "Dot");

            return path + sourceName + "SourceTests.cs";
        }

        static string GetErrorPath(ISource source)
        {
            return GetSourcePath(source) + ".Error";
        }

        static void WriteForSource(ISource source, string content)
        {
            string sourcePath = GetSourcePath(source);

            string directory = Path.GetDirectoryName(sourcePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(sourcePath, content);
        }

        static void WriteErrorForSource(ISource source, List<Result> failures)
        {
            Result result = Result.Merge(failures.ToArray());

            string errorPath = GetErrorPath(source);

            string directory = Path.GetDirectoryName(errorPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(errorPath, result.ToString());
        }
    }
}
