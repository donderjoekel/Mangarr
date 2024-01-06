using System.Collections;

namespace Mangarr.Backend.Tests;

public class AnimatedGlitchedComicsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "animatedglitchedcomics";

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
        // https://agscomics.com?p=2298
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjI5OHwyMjk4");
        // https://agscomics.com?p=2249
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjI0OXwyMjQ5");
        // https://agscomics.com?p=2226
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjIyNnwyMjI2");
        // https://agscomics.com?p=2106
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjEwNnwyMTA2");
        // https://agscomics.com?p=1676
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTY3NnwxNjc2");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://agscomics.com?p=2075
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjA3NXwyMDc1");
        // https://agscomics.com?p=1906
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTkwNnwxOTA2");
        // https://agscomics.com?p=1735
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTczNXwxNzM1");
        // https://agscomics.com?p=1875
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTg3NXwxODc1");
        // https://agscomics.com?p=1678
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTY3OHwxNjc4");
    }

    public static IEnumerable ValidImages()
    {
        // http://agscomics.com/wp-content/uploads/2023/12/006-1.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDA2LTEuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/013-4.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEzLTQuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/020-1.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDIwLTEuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/010-3.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEwLTMuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/005-6.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDA1LTYuanBn");
    }
}

