using FluentResults;
using Mangarr.Backend.Sources;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Cloudflare;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Microsoft.Extensions.DependencyInjection;

namespace Mangarr.Backend.Tests;

[TestFixture("anigliscans")]
[TestFixture("aquamanga")]
[TestFixture("arthurscans")]
[TestFixture("asurascans")]
[TestFixture("bibimanga")]
[TestFixture("coffeemanga")]
[TestFixture("cosmicscans")]
[TestFixture("darkscans")]
[TestFixture("elarcpage")]
[TestFixture("flamecomics")]
[TestFixture("freakscans")]
[TestFixture("hiperdex")]
[TestFixture("immortalupdates")]
[TestFixture("knightnoscanlation")]
[TestFixture("kunmanga")]
[TestFixture("lilymanga")]
[TestFixture("lhtranslation")]
[TestFixture("lscomic")]
[TestFixture("luminousscans")]
[TestFixture("madaradex")]
[TestFixture("mangabob")]
[TestFixture("mangalife")]
[TestFixture("mangasee")]
[TestFixture("manhuafast")]
[TestFixture("manhuaus")]
[TestFixture("manhwafull")]
[TestFixture("manhwatop")]
[TestFixture("manhwax")]
[TestFixture("novelmic")]
[TestFixture("pianmanga")]
[TestFixture("platinumscans")]
[TestFixture("rawkuma")]
[TestFixture("reaper-scans")]
[TestFixture("reaperscans")]
[TestFixture("resetscans")]
[TestFixture("setsuscans")]
[TestFixture("sinensisscans")]
[TestFixture("teenmanhua")]
[TestFixture("toongod")]
[TestFixture("voidscans")]
[TestFixture("webtoon")]
[TestFixture("webtoons")]
[TestFixture("xcalibr")]
[TestFixture("zeroscans")]
[TestFixture("zinmanga")]
public class SourceTests
{
    [SetUp]
    public void Setup()
    {
        ServiceCollection serviceCollection = new();
        serviceCollection.AddHttpClient("Generic")
            .AddRetryPolicy();
        serviceCollection.AddTransient<CustomClearanceHandler>(_ =>
            new CustomClearanceHandler("http://localhost:8191"));
        serviceCollection.AddHttpClient("Cloudflare")
            .AddHttpMessageHandler<CustomClearanceHandler>()
            .AddRetryPolicy();
        serviceCollection.AddMangarrBackend();
        _provider = serviceCollection.BuildServiceProvider();
    }

    private readonly string _source;
    private readonly List<SearchResultItem> _searchResultItems = new();
    private readonly List<ChapterListItem> _chapterListItems = new();
    private readonly List<PageListItem> _pageListItems = new();

    private IServiceProvider? _provider;

    private ISource? Source => _provider?
        .GetRequiredService<IEnumerable<ISource>>()
        .FirstOrDefault(x => x.Identifier == _source);

    public SourceTests(string source) => _source = source;

    [Test]
    [TestCase("a")]
    [TestCase("e")]
    [TestCase("o")]
    [TestCase("u")]
    [TestCase("i")]
    [Order(1)]
    public async Task SearchSourceTest(string query)
    {
        ISource? source = Source;

        if (source == null)
        {
            Assert.Fail("Cannot find source");
        }

        Result<SearchResult> result = await source!.Search(query);

        if (result.IsFailed)
        {
            Assert.Fail("Failed to search: {0}", result);
        }

        if (result.Value.Items.Count == 0)
        {
            Assert.Fail("No search results found");
        }
        else
        {
            SearchResultItem item;
            int i = -1;
            do
            {
                i++;
                int r = TestContext.CurrentContext.Random.Next(0, result.Value.Items.Count);
                item = result.Value.Items[r];
            } while (_searchResultItems.Any(x => x.Id == item.Id) && i < 10);

            if (_searchResultItems.All(x => x.Id != item.Id))
            {
                _searchResultItems.Add(item);
            }
        }

        Assert.Pass();
    }

    [Test]
    [Order(2)]
    public async Task GetChapters()
    {
        Assert.That(_searchResultItems, Is.Not.Empty);
        Warn.If(_searchResultItems, Has.Count.LessThan(5));

        foreach (SearchResultItem searchResultItem in _searchResultItems)
        {
            Result<ChapterList> result = await Source!.GetChapterList(searchResultItem.Id);

            if (result.IsFailed)
            {
                Assert.Fail("Failed to get chapter list: {0}", result);
            }

            if (result.Value.Items.Count == 0)
            {
                Assert.Fail("No chapters found");
            }
            else
            {
                ChapterListItem item;
                int i = -1;

                do
                {
                    i++;
                    int r = TestContext.CurrentContext.Random.Next(0, result.Value.Items.Count);
                    item = result.Value.Items[r];
                } while (_chapterListItems.Any(x => x.Id == item.Id) && i < 10);

                if (_chapterListItems.All(x => x.Id != item.Id))
                {
                    _chapterListItems.Add(item);
                }
            }
        }

        Assert.Pass();
    }

    [Test]
    [Order(3)]
    public async Task GetPages()
    {
        Assert.That(_chapterListItems, Is.Not.Empty);
        Warn.If(_chapterListItems, Has.Count.LessThan(5));

        foreach (ChapterListItem chapterListItem in _chapterListItems)
        {
            Result<PageList> result = await Source!.GetPageList(chapterListItem.Id);

            if (result.IsFailed)
            {
                Assert.Fail("Failed to get page list: {0}", result);
            }

            if (result.Value.Items.Count == 0)
            {
                Assert.Fail("No pages found");
            }
            else
            {
                PageListItem item;
                int i = -1;

                do
                {
                    i++;
                    int r = TestContext.CurrentContext.Random.Next(0, result.Value.Items.Count);
                    item = result.Value.Items[r];
                } while (_pageListItems.Any(x => x.Id == item.Id) && i < 10);

                if (_pageListItems.All(x => x.Id != item.Id))
                {
                    _pageListItems.Add(item);
                }
            }
        }

        Assert.Pass();
    }

    [Test]
    [Order(4)]
    public async Task GetImages()
    {
        Assert.That(_pageListItems, Is.Not.Empty);
        Warn.If(_pageListItems, Has.Count.LessThan(5));

        foreach (PageListItem pageListItem in _pageListItems)
        {
            Result<byte[]> result = await Source!.GetImage(pageListItem.Id);

            if (result.IsFailed)
            {
                Assert.Fail("Failed to download image: {0}", result);
            }
        }

        Assert.Pass();
    }
}
