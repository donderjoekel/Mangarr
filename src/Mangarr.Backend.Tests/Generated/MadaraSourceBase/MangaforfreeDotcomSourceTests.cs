using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaforfreeDotcomSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaforfree.com";

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
        // https://mangaforfree.com/manga/hack-and-befriend-the-streamers/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL2hhY2stYW5kLWJlZnJpZW5kLXRoZS1zdHJlYW1lcnMv");
        // https://mangaforfree.com/manga/at-work-no/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL2F0LXdvcmstbm8v");
        // https://mangaforfree.com/manga/this-is-a-great-restaurant/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL3RoaXMtaXMtYS1ncmVhdC1yZXN0YXVyYW50Lw==");
        // https://mangaforfree.com/manga/knock-santa-is-here%e2%99%a5-story-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL2tub2NrLXNhbnRhLWlzLWhlcmUlZTIlOTklYTUtc3RvcnktNS8=");
        // https://mangaforfree.com/manga/playing-a-game-with-a-manager-with-big-breasts/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL3BsYXlpbmctYS1nYW1lLXdpdGgtYS1tYW5hZ2VyLXdpdGgtYmlnLWJyZWFzdHMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaforfree.com/manga/this-is-a-great-restaurant/chapter-6-raw/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL3RoaXMtaXMtYS1ncmVhdC1yZXN0YXVyYW50L2NoYXB0ZXItNi1yYXcv");
        // https://mangaforfree.com/manga/hack-and-befriend-the-streamers/chapter-6-raw/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL2hhY2stYW5kLWJlZnJpZW5kLXRoZS1zdHJlYW1lcnMvY2hhcHRlci02LXJhdy8=");
        // https://mangaforfree.com/manga/at-work-no/chapter-7-raw/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL2F0LXdvcmstbm8vY2hhcHRlci03LXJhdy8=");
        // https://mangaforfree.com/manga/this-is-a-great-restaurant/chapter-9-raw/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL3RoaXMtaXMtYS1ncmVhdC1yZXN0YXVyYW50L2NoYXB0ZXItOS1yYXcv");
        // https://mangaforfree.com/manga/playing-a-game-with-a-manager-with-big-breasts/chapter-1-raw/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmZyZWUuY29tL21hbmdhL3BsYXlpbmctYS1nYW1lLXdpdGgtYS1tYW5hZ2VyLXdpdGgtYmlnLWJyZWFzdHMvY2hhcHRlci0xLXJhdy8=");
    }

    public static IEnumerable ValidImages()
    {
        // http://mangaforfree.com/wp-content/uploads/WP-manga/data/manga_65873f9ea2984/4698f66ebcf78f1cc9895e1396c9130c/05_result.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhZm9yZnJlZS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU4NzNmOWVhMjk4NC80Njk4ZjY2ZWJjZjc4ZjFjYzk4OTVlMTM5NmM5MTMwYy8wNV9yZXN1bHQuanBn");
        // http://mangaforfree.com/wp-content/uploads/WP-manga/data/manga_6591a02b8f124/428054c43ec61359abf61701b586daa1/01_result.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhZm9yZnJlZS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5MWEwMmI4ZjEyNC80MjgwNTRjNDNlYzYxMzU5YWJmNjE3MDFiNTg2ZGFhMS8wMV9yZXN1bHQuanBn");
        // http://mangaforfree.com/wp-content/uploads/WP-manga/data/manga_65873f9ea2984/4698f66ebcf78f1cc9895e1396c9130c/14_result.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhZm9yZnJlZS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU4NzNmOWVhMjk4NC80Njk4ZjY2ZWJjZjc4ZjFjYzk4OTVlMTM5NmM5MTMwYy8xNF9yZXN1bHQuanBn");
        // http://mangaforfree.com/wp-content/uploads/WP-manga/data/manga_65873f9ea2984/4698f66ebcf78f1cc9895e1396c9130c/23_result.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhZm9yZnJlZS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU4NzNmOWVhMjk4NC80Njk4ZjY2ZWJjZjc4ZjFjYzk4OTVlMTM5NmM5MTMwYy8yM19yZXN1bHQuanBn");
        // http://mangaforfree.com/wp-content/uploads/WP-manga/data/manga_6592f3f179436/ae22cd8169327b54aeef2c114c6baeca/18_result.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhZm9yZnJlZS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5MmYzZjE3OTQzNi9hZTIyY2Q4MTY5MzI3YjU0YWVlZjJjMTE0YzZiYWVjYS8xOF9yZXN1bHQuanBn");
    }
}

