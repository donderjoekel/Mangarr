using System.Collections;

namespace Mangarr.Backend.Tests;

public class PianMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "pianmanga";

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
        // https://pianmanga.me/manga/24-hours-of-my-secretarys-wild-desires/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2EvMjQtaG91cnMtb2YtbXktc2VjcmV0YXJ5cy13aWxkLWRlc2lyZXMv");
        // https://pianmanga.me/manga/forget-cleaning/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2EvZm9yZ2V0LWNsZWFuaW5nLw==");
        // https://pianmanga.me/manga/omega-bite/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2Evb21lZ2EtYml0ZS8=");
        // https://pianmanga.me/manga/spectrophilia/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2Evc3BlY3Ryb3BoaWxpYS8=");
        // https://pianmanga.me/manga/brother-and-brother/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2EvYnJvdGhlci1hbmQtYnJvdGhlci8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://pianmanga.me/manga/24-hours-of-my-secretarys-wild-desires/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2EvMjQtaG91cnMtb2YtbXktc2VjcmV0YXJ5cy13aWxkLWRlc2lyZXMvY2hhcHRlci0xLw==");
        // https://pianmanga.me/manga/spectrophilia/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2Evc3BlY3Ryb3BoaWxpYS9jaGFwdGVyLTYv");
        // https://pianmanga.me/manga/spectrophilia/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2Evc3BlY3Ryb3BoaWxpYS9jaGFwdGVyLTIv");
        // https://pianmanga.me/manga/omega-bite/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2Evb21lZ2EtYml0ZS9jaGFwdGVyLTEv");
        // https://pianmanga.me/manga/spectrophilia/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvbWFuZ2Evc3BlY3Ryb3BoaWxpYS9jaGFwdGVyLTMv");
    }

    public static IEnumerable ValidImages()
    {
        // https://pianmanga.me/wp-content/uploads/WP-manga/data/spectrophilia-12011/chapter-2/21.jpg
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvc3BlY3Ryb3BoaWxpYS0xMjAxMS9jaGFwdGVyLTIvMjEuanBn");
        // https://pianmanga.me/wp-content/uploads/WP-manga/data/spectrophilia-12011/chapter-2/27.jpg
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvc3BlY3Ryb3BoaWxpYS0xMjAxMS9jaGFwdGVyLTIvMjcuanBn");
        // https://pianmanga.me/wp-content/uploads/WP-manga/data/spectrophilia-12011/chapter-3/56.jpg
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvc3BlY3Ryb3BoaWxpYS0xMjAxMS9jaGFwdGVyLTMvNTYuanBn");
        // https://pianmanga.me/wp-content/uploads/WP-manga/data/spectrophilia-12011/chapter-3/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvc3BlY3Ryb3BoaWxpYS0xMjAxMS9jaGFwdGVyLTMvMTAuanBn");
        // https://pianmanga.me/wp-content/uploads/WP-manga/data/spectrophilia-12011/chapter-2/22.jpg
        yield return new TestCaseData("aHR0cHM6Ly9waWFubWFuZ2EubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvc3BlY3Ryb3BoaWxpYS0xMjAxMS9jaGFwdGVyLTIvMjIuanBn");
    }
}

