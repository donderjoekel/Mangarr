using System.Collections;

namespace Mangarr.Backend.Tests;

public class BoysLoveSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "boyslove";

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
        // https://boyslove.me/boyslove/shiboritoranaide-onna-shounin-san-2/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4tMi8=");
        // https://boyslove.me/boyslove/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS90aGUtc3Rvcnktb2YtaG93LWktZ290LXRvZ2V0aGVyLXdpdGgtdGhlLW1hbmFnZXItb24tY2hyaXN0bWFzLw==");
        // https://boyslove.me/boyslove/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS90aGUtZXh0cmFzLWFjYWRlbXktc3Vydml2YWwtZ3VpZGUv");
        // https://boyslove.me/boyslove/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS90aGUtY3Jvd24tcHJpbmNlLXRoYXQtc2VsbHMtbWVkaWNpbmUv");
        // https://boyslove.me/boyslove/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://boyslove.me/boyslove/shiboritoranaide-onna-shounin-san-2/chapter-42-5/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4tMi9jaGFwdGVyLTQyLTUv");
        // https://boyslove.me/boyslove/shiboritoranaide-onna-shounin-san-2/chapter-14-5/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4tMi9jaGFwdGVyLTE0LTUv");
        // https://boyslove.me/boyslove/shiboritoranaide-onna-shounin-san-2/chapter-43-5/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4tMi9jaGFwdGVyLTQzLTUv");
        // https://boyslove.me/boyslove/shiboritoranaide-onna-shounin-san-2/chapter-32-1/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4tMi9jaGFwdGVyLTMyLTEv");
        // https://boyslove.me/boyslove/shiboritoranaide-onna-shounin-san-2/chapter-06/
        yield return new TestCaseData("aHR0cHM6Ly9ib3lzbG92ZS5tZS9ib3lzbG92ZS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4tMi9jaGFwdGVyLTA2Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-14-5/4.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTQtNS80LmpwZw==");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-32-1/01.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMzItMS8wMS5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-14-5/1.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTQtNS8xLmpwZw==");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-42-5/5.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItNDItNS81LmpwZw==");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-14-5/3.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTQtNS8zLmpwZw==");
    }
}

