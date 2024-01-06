using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaLoverSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwalover";

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
        // https://manhwalover.com?p=282206
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIyMDZ8MjgyMjA2");
        // https://manhwalover.com?p=282164
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIxNjR8MjgyMTY0");
        // https://manhwalover.com?p=282161
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIxNjF8MjgyMTYx");
        // https://manhwalover.com?p=282073
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIwNzN8MjgyMDcz");
        // https://manhwalover.com?p=281799
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODE3OTl8MjgxNzk5");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwalover.com?p=282172
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIxNzJ8MjgyMTcy");
        // https://manhwalover.com?p=282011
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIwMTF8MjgyMDEx");
        // https://manhwalover.com?p=281902
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODE5MDJ8MjgxOTAy");
        // https://manhwalover.com?p=281937
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODE5Mzd8MjgxOTM3");
        // https://manhwalover.com?p=282189
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIxODl8MjgyMTg5");
    }

    public static IEnumerable ValidImages()
    {
        // https://img03.imgfx01.xyz/uploads/4098/6/99-cd650.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcwMy5pbWdmeDAxLnh5ei91cGxvYWRzLzQwOTgvNi85OS1jZDY1MC5qcGc=");
        // https://img03.imgfx01.xyz/uploads/4098/6/15-cd650.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcwMy5pbWdmeDAxLnh5ei91cGxvYWRzLzQwOTgvNi8xNS1jZDY1MC5qcGc=");
        // https://img03.imgfx01.xyz/uploads/4098/6/97-cd650.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcwMy5pbWdmeDAxLnh5ei91cGxvYWRzLzQwOTgvNi85Ny1jZDY1MC5qcGc=");
        // https://img03.imgfx01.xyz/uploads/4098/14/83-cd88e.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcwMy5pbWdmeDAxLnh5ei91cGxvYWRzLzQwOTgvMTQvODMtY2Q4OGUuanBn");
        // https://img03.imgfx01.xyz/uploads/4098/14/137-cd88e.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcwMy5pbWdmeDAxLnh5ei91cGxvYWRzLzQwOTgvMTQvMTM3LWNkODhlLmpwZw==");
    }
}

