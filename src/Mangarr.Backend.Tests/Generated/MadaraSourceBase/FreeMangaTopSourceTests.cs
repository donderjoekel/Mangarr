using System.Collections;

namespace Mangarr.Backend.Tests;

public class FreeMangaTopSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "freemangatop";

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
        // https://freemangatop.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci8=");
        // https://freemangatop.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQv");
        // https://freemangatop.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
        // https://freemangatop.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL21lYXQtZG9sbC13b3Jrc2hvcC1pbi1hbm90aGVyLXdvcmxkLw==");
        // https://freemangatop.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://freemangatop.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItMy8=");
        // https://freemangatop.com/manga/starting-with-the-holy-maiden-system-bound/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC9jaGFwdGVyLTAv");
        // https://freemangatop.com/manga/dark-and-light-martial-emperor/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTEwLw==");
        // https://freemangatop.com/manga/starting-with-the-holy-maiden-system-bound/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC9jaGFwdGVyLTIv");
        // https://freemangatop.com/manga/starting-with-the-holy-maiden-system-bound/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2F0b3AuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_9/chap_9_15.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzkvY2hhcF85XzE1LmpwZw==");
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_9/chap_9_13.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzkvY2hhcF85XzEzLmpwZw==");
        // https://2nd.manhuamanhwa.com/manga_174bb3aa57fd6c6fb601a6d26ffb1bcd/chapter_2/chap_2_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xNzRiYjNhYTU3ZmQ2YzZmYjYwMWE2ZDI2ZmZiMWJjZC9jaGFwdGVyXzIvY2hhcF8yXzEuanBn");
        // https://2nd.manhuamanhwa.com/manga_4cde6da1f7a10ac294b1dbc1c1733352/chapter_2/chap_2_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV80Y2RlNmRhMWY3YTEwYWMyOTRiMWRiYzFjMTczMzM1Mi9jaGFwdGVyXzIvY2hhcF8yXzQuanBn");
        // https://2nd.manhuamanhwa.com/manga_4cde6da1f7a10ac294b1dbc1c1733352/chapter_2/chap_2_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV80Y2RlNmRhMWY3YTEwYWMyOTRiMWRiYzFjMTczMzM1Mi9jaGFwdGVyXzIvY2hhcF8yXzEuanBn");
    }
}

