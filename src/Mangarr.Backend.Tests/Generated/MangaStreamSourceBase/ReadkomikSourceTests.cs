using System.Collections;

namespace Mangarr.Backend.Tests;

public class ReadkomikSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "readkomik";

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
        // https://readkomik.com?p=577037
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc3MDM3fDU3NzAzNw==");
        // https://readkomik.com?p=576922
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2OTIyfDU3NjkyMg==");
        // https://readkomik.com?p=576856
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2ODU2fDU3Njg1Ng==");
        // https://readkomik.com?p=576407
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2NDA3fDU3NjQwNw==");
        // https://readkomik.com?p=576368
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2MzY4fDU3NjM2OA==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://readkomik.com/i-rely-on-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2ktcmVseS1vbi1jaGFwdGVyLTMvfGh0dHBzOi8vcmVhZGtvbWlrLmNvbT9wPTU3NzAzN3wz");
        // https://readkomik.com/i-rely-on-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2ktcmVseS1vbi1jaGFwdGVyLTUvfGh0dHBzOi8vcmVhZGtvbWlrLmNvbT9wPTU3NzAzN3w1");
        // https://readkomik.com/ibnr-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2libnItY2hhcHRlci02L3xodHRwczovL3JlYWRrb21pay5jb20/cD01NzY4NTZ8Ng==");
        // https://readkomik.com/ibnr-chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2libnItY2hhcHRlci0xOC98aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2ODU2fDE4");
        // https://readkomik.com/ibnr-chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2libnItY2hhcHRlci0xNi98aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2ODU2fDE2");
    }

    public static IEnumerable ValidImages()
    {
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-18__53.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTE4X181My5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-18__18.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTE4X18xOC5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-18__46.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTE4X180Ni5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-18__70.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTE4X183MC5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-06__019.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTA2X18wMTkuanBn");
    }
}

