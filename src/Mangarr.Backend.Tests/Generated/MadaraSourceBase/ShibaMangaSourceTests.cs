using System.Collections;

namespace Mangarr.Backend.Tests;

public class ShibaMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "shibamanga";

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
        // https://shibamanga.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3Iv");
        // https://shibamanga.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9uYXVnaHR5LW1hbGUtZnJpZW5kLw==");
        // https://shibamanga.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC8=");
        // https://shibamanga.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
        // https://shibamanga.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ob2x5LW1haWRlbi1zeXN0ZW0tYm91bmQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://shibamanga.com/manga/dark-and-light-martial-emperor/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci0xNi8=");
        // https://shibamanga.com/manga/dark-and-light-martial-emperor/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci0xLw==");
        // https://shibamanga.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC9jaGFwdGVyLTUv");
        // https://shibamanga.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC9jaGFwdGVyLTQv");
        // https://shibamanga.com/manga/dark-and-light-martial-emperor/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9zaGliYW1hbmdhLmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci02Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_5/chap_5_2.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzUvY2hhcF81XzIuanBn");
        // https://2nd.manhuamanhwa.com/manga_4cde6da1f7a10ac294b1dbc1c1733352/chapter_4/chap_4_2.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV80Y2RlNmRhMWY3YTEwYWMyOTRiMWRiYzFjMTczMzM1Mi9jaGFwdGVyXzQvY2hhcF80XzIuanBn");
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_0/chap_0_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzAvY2hhcF8wXzE3LmpwZw==");
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_0/chap_0_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzAvY2hhcF8wXzYuanBn");
        // https://2nd.manhuamanhwa.com/manga_1eb2b3aeff88895ee55931f20b8d9e54/chapter_5/chap_5_15.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8xZWIyYjNhZWZmODg4OTVlZTU1OTMxZjIwYjhkOWU1NC9jaGFwdGVyXzUvY2hhcF81XzE1LmpwZw==");
    }
}

