using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaManhuaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwamanhua";

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
        // https://manhwamanhua.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci8=");
        // https://manhwamanhua.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQv");
        // https://manhwamanhua.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
        // https://manhwamanhua.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL21lYXQtZG9sbC13b3Jrc2hvcC1pbi1hbm90aGVyLXdvcmxkLw==");
        // https://manhwamanhua.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwamanhua.com/manga/dark-and-light-martial-emperor/chapter-14/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTE0Lw==");
        // https://manhwamanhua.com/manga/naughty-male-friend/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQvY2hhcHRlci0yLw==");
        // https://manhwamanhua.com/manga/dark-and-light-martial-emperor/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTE1Lw==");
        // https://manhwamanhua.com/manga/dark-and-light-martial-emperor/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTcv");
        // https://manhwamanhua.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FtYW5odWEuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItNC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://2nd.manhwamanhua.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHdhbWFuaHVhLmNvbS9tYW5nYV85ZjM3ZDg3OTM4OTM4ZDQ3M2ZmNjQxZDQ3ODFlYTMwYy9jaGFwdGVyXzEvY2hhcF8xXzQuanBn");
        // https://2nd.manhwamanhua.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_22.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHdhbWFuaHVhLmNvbS9tYW5nYV85ZjM3ZDg3OTM4OTM4ZDQ3M2ZmNjQxZDQ3ODFlYTMwYy9jaGFwdGVyXzEvY2hhcF8xXzIyLmpwZw==");
        // https://2nd.manhwamanhua.com/manga_4cde6da1f7a10ac294b1dbc1c1733352/chapter_3/chap_3_3.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHdhbWFuaHVhLmNvbS9tYW5nYV80Y2RlNmRhMWY3YTEwYWMyOTRiMWRiYzFjMTczMzM1Mi9jaGFwdGVyXzMvY2hhcF8zXzMuanBn");
        // https://2nd.manhwamanhua.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_14/chap_14_8.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHdhbWFuaHVhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzE0L2NoYXBfMTRfOC5qcGc=");
        // https://2nd.manhwamanhua.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_1/chap_1_12.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHdhbWFuaHVhLmNvbS9tYW5nYV85ZjM3ZDg3OTM4OTM4ZDQ3M2ZmNjQxZDQ3ODFlYTMwYy9jaGFwdGVyXzEvY2hhcF8xXzEyLmpwZw==");
    }
}

