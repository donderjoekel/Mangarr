using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using FluentResults;
using Mangarr.Backend.Sources;
using Mangarr.Backend.Sources.Clients;
using Mangarr.Backend.Sources.Cloudflare;
using Mangarr.Backend.Sources.Extensions;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable NotResolvedInText

namespace Mangarr.Backend.Tests;

[SuppressMessage("Structure", "NUnit1011:The TestCaseSource argument does not specify an existing member")]
public abstract class SourceTestBase
{
    private IServiceProvider _provider = null!;

    protected abstract string SourceIdentifier { get; }

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

    private ISource CreateSource() => _provider
        .GetRequiredService<IEnumerable<ISource>>()
        .First(x => x.Identifier == SourceIdentifier);

    [TestCaseSource("ValidSearchResults")]
    public async Task Search_Should_Return_SearchResult(string query)
    {
        // Arrange
        ISource source = CreateSource();

        // Act
        Result<SearchResult> result = await source.Search(query);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Items.Should().NotBeEmpty();
    }

    [TestCaseSource("ValidChapterLists")]
    public async Task GetChapterList_Should_Return_ChapterList(string mangaId)
    {
        // Arrange
        ISource source = CreateSource();

        // Act
        Result<ChapterList> result = await source.GetChapterList(mangaId);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Items.Should().NotBeEmpty();
    }

    [TestCaseSource("ValidPageLists")]
    public async Task GetPageList_Should_Return_PageList(string chapterId)
    {
        // Arrange
        ISource source = CreateSource();

        // Act
        Result<PageList> result = await source.GetPageList(chapterId);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Items.Should().NotBeEmpty();
    }

    [TestCaseSource("ValidImages")]
    public async Task GetImage_Should_Return_Image(string pageId)
    {
        // Arrange
        ISource source = CreateSource();

        // Act
        Result<byte[]> result = await source.GetImage(pageId);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeEmpty();
    }

    // Yoinked from SourceBase.Utilities.cs
    protected static string ConstructId(string url, params string[] args)
    {
        if (args.Length == 0)
        {
            return url.ToBase64();
        }

        string[] segments = { url, string.Join("|", args) };
        return string.Join("|", segments).ToBase64();
    }
}
