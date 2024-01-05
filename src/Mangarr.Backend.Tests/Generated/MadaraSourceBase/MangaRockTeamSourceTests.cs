using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaRockTeamSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangarockteam";

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
        // https://mangarockteam.com/manga/look-alike-daughter/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS9sb29rLWFsaWtlLWRhdWdodGVyLw==");
        // https://mangarockteam.com/manga/time-retrograde/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS90aW1lLXJldHJvZ3JhZGUv");
        // https://mangarockteam.com/manga/starting-with-the-guhuo-bird/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ndWh1by1iaXJkLw==");
        // https://mangarockteam.com/manga/the-knight-king-who-returned-with-a-god/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS90aGUta25pZ2h0LWtpbmctd2hvLXJldHVybmVkLXdpdGgtYS1nb2Qv");
        // https://mangarockteam.com/manga/master-of-the-martial-arts-library/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS9tYXN0ZXItb2YtdGhlLW1hcnRpYWwtYXJ0cy1saWJyYXJ5Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangarockteam.com/manga/time-retrograde/chapter-88/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS90aW1lLXJldHJvZ3JhZGUvY2hhcHRlci04OC8=");
        // https://mangarockteam.com/manga/starting-with-the-guhuo-bird/chapter-188/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ndWh1by1iaXJkL2NoYXB0ZXItMTg4Lw==");
        // https://mangarockteam.com/manga/starting-with-the-guhuo-bird/chapter-115/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ndWh1by1iaXJkL2NoYXB0ZXItMTE1Lw==");
        // https://mangarockteam.com/manga/time-retrograde/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS90aW1lLXJldHJvZ3JhZGUvY2hhcHRlci03Lw==");
        // https://mangarockteam.com/manga/starting-with-the-guhuo-bird/chapter-51/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvY2t0ZWFtLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ndWh1by1iaXJkL2NoYXB0ZXItNTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://s1.cdn-manga.com/files/WP-manga/data/5205/48b378730f46f320324b62aef5d93995/103b.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNTIwNS80OGIzNzg3MzBmNDZmMzIwMzI0YjYyYWVmNWQ5Mzk5NS8xMDNiLmpwZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/5205/beb0bcd864c56821d182051313112a88/36b.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNTIwNS9iZWIwYmNkODY0YzU2ODIxZDE4MjA1MTMxMzExMmE4OC8zNmIuanBn");
        // https://s1.cdn-manga.com/files/WP-manga/data/5205/48b378730f46f320324b62aef5d93995/76.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNTIwNS80OGIzNzg3MzBmNDZmMzIwMzI0YjYyYWVmNWQ5Mzk5NS83Ni5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/5205/beb0bcd864c56821d182051313112a88/56a.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNTIwNS9iZWIwYmNkODY0YzU2ODIxZDE4MjA1MTMxMzExMmE4OC81NmEuanBn");
        // https://s1.cdn-manga.com/files/WP-manga/data/4835/1e4127029a2815889cd7a85dcf394a30/15.webp
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDgzNS8xZTQxMjcwMjlhMjgxNTg4OWNkN2E4NWRjZjM5NGEzMC8xNS53ZWJw");
    }
}

