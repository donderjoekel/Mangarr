using System.Collections;

namespace Mangarr.Backend.Tests;

public class FlameComicsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "flamecomics";

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
        // https://flamecomics.com?p=149764
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDk3NjR8MTQ5NzY0");
        // https://flamecomics.com?p=148701
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDg3MDF8MTQ4NzAx");
        // https://flamecomics.com?p=147024
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDcwMjR8MTQ3MDI0");
        // https://flamecomics.com?p=143300
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDMzMDB8MTQzMzAw");
        // https://flamecomics.com?p=143136
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDMxMzZ8MTQzMTM2");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://flamecomics.com?p=161110
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNjExMTB8MTYxMTEw");
        // https://flamecomics.com?p=156661
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNTY2NjF8MTU2NjYx");
        // https://flamecomics.com?p=148600
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDg2MDB8MTQ4NjAw");
        // https://flamecomics.com?p=147042
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDcwNDJ8MTQ3MDQy");
        // https://flamecomics.com?p=160639
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNjA2Mzl8MTYwNjM5");
    }

    public static IEnumerable ValidImages()
    {
        // https://flamecomics.com/wp-content/uploads/2023/12/AGS_29_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQUdTXzI5XzE0LmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2023/12/AGS_29_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQUdTXzI5XzEwLmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2023/08/BCTIYM1-04-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDgvQkNUSVlNMS0wNC0xLmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2023/12/BTYIM_23_07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQlRZSU1fMjNfMDcuanBn");
        // https://flamecomics.com/wp-content/uploads/2023/09/AGS_00-2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvQUdTXzAwLTIuanBn");
    }
}

