using System.Collections;

namespace Mangarr.Backend.Tests;

public class HentaiXYuriSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hentaixyuri";

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
        // https://hentaixdickgirl.com/manga/shasei-shitara-owari-ts-mesu-pet-ka-no-noroi/#new_tab
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL3NoYXNlaS1zaGl0YXJhLW93YXJpLXRzLW1lc3UtcGV0LWthLW5vLW5vcm9pLyNuZXdfdGFi");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hentaixdickgirl.com/manga/shasei-shitara-owari-ts-mesu-pet-ka-no-noroi/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL3NoYXNlaS1zaGl0YXJhLW93YXJpLXRzLW1lc3UtcGV0LWthLW5vLW5vcm9pL29uZXNob3Qv");
    }

    public static IEnumerable ValidImages()
    {
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_659330e406926/871460a6a1a9eaf766dd09b08098abd5/PG_08_TS_009.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTMzMGU0MDY5MjYvODcxNDYwYTZhMWE5ZWFmNzY2ZGQwOWIwODA5OGFiZDUvUEdfMDhfVFNfMDA5LndlYnA=");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_659330e406926/871460a6a1a9eaf766dd09b08098abd5/PG_27_TS_028.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTMzMGU0MDY5MjYvODcxNDYwYTZhMWE5ZWFmNzY2ZGQwOWIwODA5OGFiZDUvUEdfMjdfVFNfMDI4LndlYnA=");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_659330e406926/871460a6a1a9eaf766dd09b08098abd5/PG_09_TS_010.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTMzMGU0MDY5MjYvODcxNDYwYTZhMWE5ZWFmNzY2ZGQwOWIwODA5OGFiZDUvUEdfMDlfVFNfMDEwLndlYnA=");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_659330e406926/871460a6a1a9eaf766dd09b08098abd5/PG_34_99999999999999999999.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTMzMGU0MDY5MjYvODcxNDYwYTZhMWE5ZWFmNzY2ZGQwOWIwODA5OGFiZDUvUEdfMzRfOTk5OTk5OTk5OTk5OTk5OTk5OTkud2VicA==");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_659330e406926/871460a6a1a9eaf766dd09b08098abd5/PG_03_TS_004.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTMzMGU0MDY5MjYvODcxNDYwYTZhMWE5ZWFmNzY2ZGQwOWIwODA5OGFiZDUvUEdfMDNfVFNfMDA0LndlYnA=");
    }
}

