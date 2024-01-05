using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaWeebsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaweebs";

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
        // https://mangaweebs.org/manga/the-star-of-a-supreme-ruler/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS90aGUtc3Rhci1vZi1hLXN1cHJlbWUtcnVsZXIv");
        // https://mangaweebs.org/manga/emperors-domination/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9lbXBlcm9ycy1kb21pbmF0aW9uLw==");
        // https://mangaweebs.org/manga/maxed-out-leveling/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9tYXhlZC1vdXQtbGV2ZWxpbmcv");
        // https://mangaweebs.org/manga/a-comic-artists-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9hLWNvbWljLWFydGlzdHMtc3Vydml2YWwtZ3VpZGUv");
        // https://mangaweebs.org/manga/demon-in-mount-hua/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9kZW1vbi1pbi1tb3VudC1odWEv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaweebs.org/manga/the-star-of-a-supreme-ruler/chapter-81/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS90aGUtc3Rhci1vZi1hLXN1cHJlbWUtcnVsZXIvY2hhcHRlci04MS8=");
        // https://mangaweebs.org/manga/emperors-domination/chapter-36/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9lbXBlcm9ycy1kb21pbmF0aW9uL2NoYXB0ZXItMzYv");
        // https://mangaweebs.org/manga/the-star-of-a-supreme-ruler/chapter-72/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS90aGUtc3Rhci1vZi1hLXN1cHJlbWUtcnVsZXIvY2hhcHRlci03Mi8=");
        // https://mangaweebs.org/manga/emperors-domination/chapter-100/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9lbXBlcm9ycy1kb21pbmF0aW9uL2NoYXB0ZXItMTAwLw==");
        // https://mangaweebs.org/manga/maxed-out-leveling/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXdlZWJzLm9yZy9tYW5nYS9tYXhlZC1vdXQtbGV2ZWxpbmcvY2hhcHRlci04Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.mangaweebs.in/data_2/manga_658fc33e51657/chapter-72/43.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2F3ZWVicy5pbi9kYXRhXzIvbWFuZ2FfNjU4ZmMzM2U1MTY1Ny9jaGFwdGVyLTcyLzQzLmpwZw==");
        // https://cdn.mangaweebs.in/data_2/manga_658fc3141a196/chapter-36/7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2F3ZWVicy5pbi9kYXRhXzIvbWFuZ2FfNjU4ZmMzMTQxYTE5Ni9jaGFwdGVyLTM2LzcuanBn");
        // https://cdn.mangaweebs.in/data_2/manga_658fc33e51657/chapter-81/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2F3ZWVicy5pbi9kYXRhXzIvbWFuZ2FfNjU4ZmMzM2U1MTY1Ny9jaGFwdGVyLTgxLzMuanBn");
        // https://cdn.mangaweebs.in/data_2/manga_658fc33e51657/chapter-81/83.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2F3ZWVicy5pbi9kYXRhXzIvbWFuZ2FfNjU4ZmMzM2U1MTY1Ny9jaGFwdGVyLTgxLzgzLmpwZw==");
        // https://cdn.mangaweebs.in/data_2/manga_658fc33e51657/chapter-81/75.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2F3ZWVicy5pbi9kYXRhXzIvbWFuZ2FfNjU4ZmMzM2U1MTY1Ny9jaGFwdGVyLTgxLzc1LmpwZw==");
    }
}

