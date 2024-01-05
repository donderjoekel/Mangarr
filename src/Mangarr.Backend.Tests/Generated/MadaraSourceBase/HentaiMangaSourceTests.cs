using System.Collections;

namespace Mangarr.Backend.Tests;

public class HentaiMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hentaimanga";

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
        // https://hentaimanga.me/manga/shiboritoranaide-onna-shounin-san/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4v");
        // https://hentaimanga.me/manga/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS90aGUtc3Rvcnktb2YtaG93LWktZ290LXRvZ2V0aGVyLXdpdGgtdGhlLW1hbmFnZXItb24tY2hyaXN0bWFzLw==");
        // https://hentaimanga.me/manga/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS90aGUtZXh0cmFzLWFjYWRlbXktc3Vydml2YWwtZ3VpZGUv");
        // https://hentaimanga.me/manga/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS90aGUtY3Jvd24tcHJpbmNlLXRoYXQtc2VsbHMtbWVkaWNpbmUv");
        // https://hentaimanga.me/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hentaimanga.me/manga/shiboritoranaide-onna-shounin-san/chapter-19-1/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0xOS0xLw==");
        // https://hentaimanga.me/manga/the-story-of-how-i-got-together-with-the-manager-on-christmas/chapter-01/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS90aGUtc3Rvcnktb2YtaG93LWktZ290LXRvZ2V0aGVyLXdpdGgtdGhlLW1hbmFnZXItb24tY2hyaXN0bWFzL2NoYXB0ZXItMDEv");
        // https://hentaimanga.me/manga/shiboritoranaide-onna-shounin-san/chapter-11-5/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0xMS01Lw==");
        // https://hentaimanga.me/manga/shiboritoranaide-onna-shounin-san/chapter-11-1/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0xMS0xLw==");
        // https://hentaimanga.me/manga/shiboritoranaide-onna-shounin-san/chapter-34-1/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS9tYW5nYS9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0zNC0xLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://hentaimanga.me/wp-content/uploads/WP-manga/data/manga_659092f216e07/chapter-11-1/19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTEtMS8xOS5qcGc=");
        // https://hentaimanga.me/wp-content/uploads/WP-manga/data/manga_659092f216e07/chapter-11-1/15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTEtMS8xNS5qcGc=");
        // https://hentaimanga.me/wp-content/uploads/WP-manga/data/manga_659092f216e07/chapter-11-1/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTEtMS8wNC5qcGc=");
        // https://hentaimanga.me/wp-content/uploads/WP-manga/data/manga_659092f216e07/chapter-19-1/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTktMS8wMS5qcGc=");
        // https://hentaimanga.me/wp-content/uploads/WP-manga/data/manga_658ed1186a77f/chapter-01/12.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWltYW5nYS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NThlZDExODZhNzdmL2NoYXB0ZXItMDEvMTIuanBn");
    }
}

