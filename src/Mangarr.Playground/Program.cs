// See https://aka.ms/new-console-template for more information

using System.Text;
using FluentResults;
using Mangarr.Backend.Sources;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Cloudflare;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection collection = new();

collection.AddHttpClient("Generic")
    .AddRetryPolicy();
collection.AddTransient<CustomClearanceHandler>(_ =>
    new CustomClearanceHandler("http://localhost:8191"));
collection.AddHttpClient("Cloudflare")
    .AddHttpMessageHandler<CustomClearanceHandler>()
    .AddRetryPolicy();
collection.AddMangarrBackend();
ServiceProvider provider = collection.BuildServiceProvider();

List<ISource> sources = provider.GetRequiredService<IEnumerable<ISource>>().ToList();

{
    StringBuilder sb = new();

    foreach (ISource source in sources.OrderBy(x => x.Identifier))
    {
        sb.AppendLine("[TestFixture(\"" + source.Identifier + "\")]");
    }

    Console.WriteLine(sb.ToString());
}

{
    ISource source = sources.FirstOrDefault(x => x.Identifier == "webtoon")!;
    Result<SearchResult> searchResult = await source.Search("am i actually the strongest");
    Result<ChapterList> chapterResult = await source.GetChapterList(searchResult.Value.Items.First().Id);
    Result<PageList> pageResult = await source.GetPageList(chapterResult.Value.Items.Last().Id);
    Result<byte[]> imageResult = await source.GetImage(pageResult.Value.Items.First().Id);

    File.WriteAllBytes(source.Identifier + "-page.jpg", imageResult.Value);
}
