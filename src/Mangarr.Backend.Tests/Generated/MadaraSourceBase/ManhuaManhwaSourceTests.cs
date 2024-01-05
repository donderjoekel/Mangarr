using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaManhwaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuamanhwa";

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
        // https://manhuamanhwa.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci8=");
        // https://manhuamanhwa.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQv");
        // https://manhuamanhwa.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
        // https://manhuamanhwa.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL21lYXQtZG9sbC13b3Jrc2hvcC1pbi1hbm90aGVyLXdvcmxkLw==");
        // https://manhuamanhwa.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuamanhwa.com/manga/dark-and-light-martial-emperor/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTcv");
        // https://manhuamanhwa.com/manga/dark-and-light-martial-emperor/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTgv");
        // https://manhuamanhwa.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItNS8=");
        // https://manhuamanhwa.com/manga/dark-and-light-martial-emperor/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTEv");
        // https://manhuamanhwa.com/manga/naughty-male-friend/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFtYW5od2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQvY2hhcHRlci0xLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://2nd.manhuamanhwa.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV85ZjM3ZDg3OTM4OTM4ZDQ3M2ZmNjQxZDQ3ODFlYTMwYy9jaGFwdGVyXzAvY2hhcF8wXzcuanBn");
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_7/chap_7_9.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzcvY2hhcF83XzkuanBn");
        // https://2nd.manhuamanhwa.com/manga_4cde6da1f7a10ac294b1dbc1c1733352/chapter_4/chap_4_2.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV80Y2RlNmRhMWY3YTEwYWMyOTRiMWRiYzFjMTczMzM1Mi9jaGFwdGVyXzQvY2hhcF80XzIuanBn");
        // https://2nd.manhuamanhwa.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_23.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV85ZjM3ZDg3OTM4OTM4ZDQ3M2ZmNjQxZDQ3ODFlYTMwYy9jaGFwdGVyXzAvY2hhcF8wXzIzLmpwZw==");
        // https://2nd.manhuamanhwa.com/manga_4cde6da1f7a10ac294b1dbc1c1733352/chapter_4/chap_4_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV80Y2RlNmRhMWY3YTEwYWMyOTRiMWRiYzFjMTczMzM1Mi9jaGFwdGVyXzQvY2hhcF80XzcuanBn");
    }
}

