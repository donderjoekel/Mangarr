using System.Collections;

namespace Mangarr.Backend.Tests;

public class Manhwa68SourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwa68";

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
        // https://manhwa68.com/manga/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://manhwa68.com/manga/you-came-during-the-massage-earlier-didn-t-you/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbi10LXlvdS8=");
        // https://manhwa68.com/manga/24-hours-of-my-secretary-s-wild-desires/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EvMjQtaG91cnMtb2YtbXktc2VjcmV0YXJ5LXMtd2lsZC1kZXNpcmVzLw==");
        // https://manhwa68.com/manga/forget-cleaning/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EvZm9yZ2V0LWNsZWFuaW5nLw==");
        // https://manhwa68.com/manga/spectrophilia/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2Evc3BlY3Ryb3BoaWxpYS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwa68.com/manga/you-came-during-the-massage-earlier-didn-t-you/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbi10LXlvdS9jaGFwdGVyLTIv");
        // https://manhwa68.com/manga/spectrophilia/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2Evc3BlY3Ryb3BoaWxpYS9jaGFwdGVyLTYv");
        // https://manhwa68.com/manga/you-came-during-the-massage-earlier-didn-t-you/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbi10LXlvdS9jaGFwdGVyLTgv");
        // https://manhwa68.com/manga/you-came-during-the-massage-earlier-didn-t-you/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbi10LXlvdS9jaGFwdGVyLTE4Lw==");
        // https://manhwa68.com/manga/you-came-during-the-massage-earlier-didn-t-you/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2E2OC5jb20vbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbi10LXlvdS9jaGFwdGVyLTE3Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.manhwa68.com/manga_f6bc7e9dc18cfe3bbacd3dc594cef296/chapter_17/ch_17_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHdhNjguY29tL21hbmdhX2Y2YmM3ZTlkYzE4Y2ZlM2JiYWNkM2RjNTk0Y2VmMjk2L2NoYXB0ZXJfMTcvY2hfMTdfMS5qcGc=");
        // https://yaoi.manhwa68.com/manga_2e976ab88a42d723d9f2ee6027b707f5/chapter_5/ch_5_34.jpg
        yield return new TestCaseData("aHR0cHM6Ly95YW9pLm1hbmh3YTY4LmNvbS9tYW5nYV8yZTk3NmFiODhhNDJkNzIzZDlmMmVlNjAyN2I3MDdmNS9jaGFwdGVyXzUvY2hfNV8zNC5qcGc=");
        // https://cdn.manhwa68.com/manga_f6bc7e9dc18cfe3bbacd3dc594cef296/chapter_1/ch_1_3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHdhNjguY29tL21hbmdhX2Y2YmM3ZTlkYzE4Y2ZlM2JiYWNkM2RjNTk0Y2VmMjk2L2NoYXB0ZXJfMS9jaF8xXzMuanBn");
        // https://yaoi.manhwa68.com/manga_2e976ab88a42d723d9f2ee6027b707f5/chapter_5/ch_5_33.jpg
        yield return new TestCaseData("aHR0cHM6Ly95YW9pLm1hbmh3YTY4LmNvbS9tYW5nYV8yZTk3NmFiODhhNDJkNzIzZDlmMmVlNjAyN2I3MDdmNS9jaGFwdGVyXzUvY2hfNV8zMy5qcGc=");
        // https://yaoi.manhwa68.com/manga_2e976ab88a42d723d9f2ee6027b707f5/chapter_5/ch_5_16.jpg
        yield return new TestCaseData("aHR0cHM6Ly95YW9pLm1hbmh3YTY4LmNvbS9tYW5nYV8yZTk3NmFiODhhNDJkNzIzZDlmMmVlNjAyN2I3MDdmNS9jaGFwdGVyXzUvY2hfNV8xNi5qcGc=");
    }
}

