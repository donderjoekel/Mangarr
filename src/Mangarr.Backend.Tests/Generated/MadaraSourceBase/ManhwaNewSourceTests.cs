using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaNewSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwanew";

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
        // https://manhwanew.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQv");
        // https://manhwanew.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
        // https://manhwanew.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL21lYXQtZG9sbC13b3Jrc2hvcC1pbi1hbm90aGVyLXdvcmxkLw==");
        // https://manhwanew.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
        // https://manhwanew.com/manga/we-are-101/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL3dlLWFyZS0xMDEv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwanew.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItNC8=");
        // https://manhwanew.com/manga/naughty-male-friend/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQvY2hhcHRlci0yLw==");
        // https://manhwanew.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItMS8=");
        // https://manhwanew.com/manga/starting-with-the-holy-maiden-system-bound/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC9jaGFwdGVyLTEv");
        // https://manhwanew.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FuZXcuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItMy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMS9jaGFwXzFfNS5qcGc=");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMS9jaGFwXzFfOC5qcGc=");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMS9jaGFwXzFfNC5qcGc=");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_22.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMS9jaGFwXzFfMjIuanBn");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMS9jaGFwXzFfMy5qcGc=");
    }
}

