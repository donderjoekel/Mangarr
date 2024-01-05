using System.Collections;

namespace Mangarr.Backend.Tests;

public class TeenManhuaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "teenmanhua";

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
        // https://teenmanhua.com/manga/terror-vs-revival/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS90ZXJyb3ItdnMtcmV2aXZhbC8=");
        // https://teenmanhua.com/manga/without-parallel/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS93aXRob3V0LXBhcmFsbGVsLw==");
        // https://teenmanhua.com/manga/only-want-it-with-you/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS9vbmx5LXdhbnQtaXQtd2l0aC15b3Uv");
        // https://teenmanhua.com/manga/that-man-s-secret-day/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS90aGF0LW1hbi1zLXNlY3JldC1kYXkv");
        // https://teenmanhua.com/manga/white-scandal/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS93aGl0ZS1zY2FuZGFsLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://teenmanhua.com/manga/terror-vs-revival/chapter-76/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS90ZXJyb3ItdnMtcmV2aXZhbC9jaGFwdGVyLTc2Lw==");
        // https://teenmanhua.com/manga/without-parallel/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS93aXRob3V0LXBhcmFsbGVsL2NoYXB0ZXItNy8=");
        // https://teenmanhua.com/manga/terror-vs-revival/chapter-50/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS90ZXJyb3ItdnMtcmV2aXZhbC9jaGFwdGVyLTUwLw==");
        // https://teenmanhua.com/manga/without-parallel/chapter-68/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS93aXRob3V0LXBhcmFsbGVsL2NoYXB0ZXItNjgv");
        // https://teenmanhua.com/manga/only-want-it-with-you/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly90ZWVubWFuaHVhLmNvbS9tYW5nYS9vbmx5LXdhbnQtaXQtd2l0aC15b3UvY2hhcHRlci0xNS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://storage.manhwateen.com///manga_bbd8868eca7887ccf0eeff149c0352ce/chapter_14/chap_14_59.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfYmJkODg2OGVjYTc4ODdjY2YwZWVmZjE0OWMwMzUyY2UvY2hhcHRlcl8xNC9jaGFwXzE0XzU5LmpwZw==");
        // https://storage.manhwateen.com///manga_87afb552b523238f50e7675be0ed5400/chapter_76/chap_76_41.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfODdhZmI1NTJiNTIzMjM4ZjUwZTc2NzViZTBlZDU0MDAvY2hhcHRlcl83Ni9jaGFwXzc2XzQxLmpwZw==");
        // https://storage.manhwateen.com///manga_87afb552b523238f50e7675be0ed5400/chapter_76/chap_76_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfODdhZmI1NTJiNTIzMjM4ZjUwZTc2NzViZTBlZDU0MDAvY2hhcHRlcl83Ni9jaGFwXzc2XzEwLmpwZw==");
        // https://storage.manhwateen.com///manga_bbd8868eca7887ccf0eeff149c0352ce/chapter_14/chap_14_15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfYmJkODg2OGVjYTc4ODdjY2YwZWVmZjE0OWMwMzUyY2UvY2hhcHRlcl8xNC9jaGFwXzE0XzE1LmpwZw==");
        // https://storage.manhwateen.com///manga_87afb552b523238f50e7675be0ed5400/chapter_76/chap_76_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfODdhZmI1NTJiNTIzMjM4ZjUwZTc2NzViZTBlZDU0MDAvY2hhcHRlcl83Ni9jaGFwXzc2XzE0LmpwZw==");
    }
}

