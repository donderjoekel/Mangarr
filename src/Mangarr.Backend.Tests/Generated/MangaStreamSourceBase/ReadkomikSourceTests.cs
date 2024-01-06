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
        // https://readkomik.com?p=576932
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2OTMyfDU3NjkzMg==");
        // https://readkomik.com?p=576872
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2ODcyfDU3Njg3Mg==");
        // https://readkomik.com?p=576905
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2OTA1fDU3NjkwNQ==");
        // https://readkomik.com?p=576909
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2OTA5fDU3NjkwOQ==");
        // https://readkomik.com?p=576918
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tP3A9NTc2OTE4fDU3NjkxOA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-30__14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTMwX18xNC5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-27__12.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTI3X18xMi5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-30__7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTMwX183LmpwZw==");
        // https://rkscans.com/wp-content/uploads/2024/01/RTCM-05__5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9SVENNLTA1X181LmpwZw==");
        // https://rkscans.com/wp-content/uploads/2024/01/RTCM-05__6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9SVENNLTA1X182LmpwZw==");
    }
}

