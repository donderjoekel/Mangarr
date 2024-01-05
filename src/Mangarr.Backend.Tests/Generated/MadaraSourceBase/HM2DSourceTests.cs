using System.Collections;

namespace Mangarr.Backend.Tests;

public class HM2DSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hm2d";

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
        // https://mangadistrict.com/hdoujin/read/otouto-omochikaeru/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvb3RvdXRvLW9tb2NoaWthZXJ1Lw==");
        // https://mangadistrict.com/hdoujin/read/onee-chan-ni-josou-saserareru-manga/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvb25lZS1jaGFuLW5pLWpvc291LXNhc2VyYXJlcnUtbWFuZ2Ev");
        // https://mangadistrict.com/hdoujin/read/yami-no-serva-fes-kindan-no-rakuen-ni-youkoso/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQveWFtaS1uby1zZXJ2YS1mZXMta2luZGFuLW5vLXJha3Vlbi1uaS15b3Vrb3NvLw==");
        // https://mangadistrict.com/hdoujin/read/mezase-nii-chan-senyou-bitch-gal/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvbWV6YXNlLW5paS1jaGFuLXNlbnlvdS1iaXRjaC1nYWwv");
        // https://mangadistrict.com/hdoujin/read/shita-to-sara/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvc2hpdGEtdG8tc2FyYS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangadistrict.com/hdoujin/read/mezase-nii-chan-senyou-bitch-gal/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvbWV6YXNlLW5paS1jaGFuLXNlbnlvdS1iaXRjaC1nYWwvY2hhcHRlci0xLw==");
        // https://mangadistrict.com/hdoujin/read/otouto-omochikaeru/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvb3RvdXRvLW9tb2NoaWthZXJ1L2NoYXB0ZXItMS8=");
        // https://mangadistrict.com/hdoujin/read/yami-no-serva-fes-kindan-no-rakuen-ni-youkoso/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQveWFtaS1uby1zZXJ2YS1mZXMta2luZGFuLW5vLXJha3Vlbi1uaS15b3Vrb3NvL2NoYXB0ZXItMS8=");
        // https://mangadistrict.com/hdoujin/read/onee-chan-ni-josou-saserareru-manga/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvb25lZS1jaGFuLW5pLWpvc291LXNhc2VyYXJlcnUtbWFuZ2EvY2hhcHRlci0xLw==");
        // https://mangadistrict.com/hdoujin/read/shita-to-sara/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9oZG91amluL3JlYWQvc2hpdGEtdG8tc2FyYS9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://3r21zkocdpp9f.mangadistrict.com/book/manga_608d9542941bd/chapter-1/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly8zcjIxemtvY2RwcDlmLm1hbmdhZGlzdHJpY3QuY29tL2Jvb2svbWFuZ2FfNjA4ZDk1NDI5NDFiZC9jaGFwdGVyLTEvMDYuanBn");
        // https://3r21zkocdpp9f.mangadistrict.com/book/manga_608d9542941bb/chapter-1/21.jpg
        yield return new TestCaseData("aHR0cHM6Ly8zcjIxemtvY2RwcDlmLm1hbmdhZGlzdHJpY3QuY29tL2Jvb2svbWFuZ2FfNjA4ZDk1NDI5NDFiYi9jaGFwdGVyLTEvMjEuanBn");
        // https://3r21zkocdpp9f.mangadistrict.com/book/manga_608d9542941ba/chapter-1/27.jpg
        yield return new TestCaseData("aHR0cHM6Ly8zcjIxemtvY2RwcDlmLm1hbmdhZGlzdHJpY3QuY29tL2Jvb2svbWFuZ2FfNjA4ZDk1NDI5NDFiYS9jaGFwdGVyLTEvMjcuanBn");
        // https://3r21zkocdpp9f.mangadistrict.com/book/manga_608d9542941bb/chapter-1/18.jpg
        yield return new TestCaseData("aHR0cHM6Ly8zcjIxemtvY2RwcDlmLm1hbmdhZGlzdHJpY3QuY29tL2Jvb2svbWFuZ2FfNjA4ZDk1NDI5NDFiYi9jaGFwdGVyLTEvMTguanBn");
        // https://3r21zkocdpp9f.mangadistrict.com/book/manga_608d9542941bc/chapter-1/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly8zcjIxemtvY2RwcDlmLm1hbmdhZGlzdHJpY3QuY29tL2Jvb2svbWFuZ2FfNjA4ZDk1NDI5NDFiYy9jaGFwdGVyLTEvMDMuanBn");
    }
}

