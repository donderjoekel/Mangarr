using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaGGSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangagg";

    public static IEnumerable ValidSearchResults()
    {
        yield return new TestCaseData("a");
        yield return new TestCaseData("e");
        yield return new TestCaseData("i");
        yield return new TestCaseData("o");
        yield return new TestCaseData("u");
    }

    public static IEnumerable ValidChapterLists()
    {
        // https://mangagg.com/comic/we-are-101/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy93ZS1hcmUtMTAxLw==");
        // https://mangagg.com/comic/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9zdGFydGluZy13aXRoLXRoZS1ob2x5LW1haWRlbi1zeXN0ZW0tYm91bmQv");
        // https://mangagg.com/comic/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
        // https://mangagg.com/comic/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC8=");
        // https://mangagg.com/comic/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9uYXVnaHR5LW1hbGUtZnJpZW5kLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangagg.com/comic/starting-with-the-holy-maiden-system-bound/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9zdGFydGluZy13aXRoLXRoZS1ob2x5LW1haWRlbi1zeXN0ZW0tYm91bmQvY2hhcHRlci0wLw==");
        // https://mangagg.com/comic/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC9jaGFwdGVyLTIv");
        // https://mangagg.com/comic/we-are-101/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy93ZS1hcmUtMTAxL2NoYXB0ZXItMi8=");
        // https://mangagg.com/comic/naughty-male-friend/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9uYXVnaHR5LW1hbGUtZnJpZW5kL2NoYXB0ZXItMS8=");
        // https://mangagg.com/comic/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdnLmNvbS9jb21pYy9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC9jaGFwdGVyLTMv");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn2.mangagg.com/manga_5947402af654dffd7d0e214eb3086818/chapter_1/chap_1_80.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzU5NDc0MDJhZjY1NGRmZmQ3ZDBlMjE0ZWIzMDg2ODE4L2NoYXB0ZXJfMS9jaGFwXzFfODAuanBn");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_39.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMC9jaGFwXzBfMzkuanBn");
        // https://cdn2.mangagg.com/manga_5947402af654dffd7d0e214eb3086818/chapter_1/chap_1_123.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzU5NDc0MDJhZjY1NGRmZmQ3ZDBlMjE0ZWIzMDg2ODE4L2NoYXB0ZXJfMS9jaGFwXzFfMTIzLmpwZw==");
        // https://cdn2.mangagg.com/manga_5947402af654dffd7d0e214eb3086818/chapter_1/chap_1_61.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzU5NDc0MDJhZjY1NGRmZmQ3ZDBlMjE0ZWIzMDg2ODE4L2NoYXB0ZXJfMS9jaGFwXzFfNjEuanBn");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMC9jaGFwXzBfMTAuanBn");
    }
}

