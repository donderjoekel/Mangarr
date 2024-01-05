using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaTyrantSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangatyrant";

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
        // https://mangatyrant.com/manga/the-genius-assassin-who-takes-it-all/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLWdlbml1cy1hc3Nhc3Npbi13aG8tdGFrZXMtaXQtYWxsLw==");
        // https://mangatyrant.com/manga/the-edgeless-sword-from-the-village/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLWVkZ2VsZXNzLXN3b3JkLWZyb20tdGhlLXZpbGxhZ2Uv");
        // https://mangatyrant.com/manga/the-nebulas-civilization/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLW5lYnVsYXMtY2l2aWxpemF0aW9uLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangatyrant.com/manga/the-nebulas-civilization/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLW5lYnVsYXMtY2l2aWxpemF0aW9uL2NoYXB0ZXItMTYv");
        // https://mangatyrant.com/manga/the-edgeless-sword-from-the-village/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLWVkZ2VsZXNzLXN3b3JkLWZyb20tdGhlLXZpbGxhZ2UvY2hhcHRlci05Lw==");
        // https://mangatyrant.com/manga/the-edgeless-sword-from-the-village/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLWVkZ2VsZXNzLXN3b3JkLWZyb20tdGhlLXZpbGxhZ2UvY2hhcHRlci0xNi8=");
        // https://mangatyrant.com/manga/the-genius-assassin-who-takes-it-all/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vbWFuZ2EvdGhlLWdlbml1cy1hc3Nhc3Npbi13aG8tdGFrZXMtaXQtYWxsL2NoYXB0ZXItNy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangatyrant.com/wp-content/uploads/WP-manga/data/manga_65857f241b928/cc9088001d0bfc778e5e0532afcce069/3.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU4NTdmMjQxYjkyOC9jYzkwODgwMDFkMGJmYzc3OGU1ZTA1MzJhZmNjZTA2OS8zLndlYnA=");
        // https://mangatyrant.com/wp-content/uploads/WP-manga/data/manga_657adbd0692a4/262a3c93bb218fea0566ea2833879a03/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU3YWRiZDA2OTJhNC8yNjJhM2M5M2JiMjE4ZmVhMDU2NmVhMjgzMzg3OWEwMy8wOC5qcGc=");
        // https://mangatyrant.com/wp-content/uploads/WP-manga/data/manga_657ac2d6bfa39/8eee29b0ea8e24c1bbf4ba94c1cd5a83/42.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU3YWMyZDZiZmEzOS84ZWVlMjliMGVhOGUyNGMxYmJmNGJhOTRjMWNkNWE4My80Mi5qcGc=");
        // https://mangatyrant.com/wp-content/uploads/WP-manga/data/manga_657ac2d6bfa39/8eee29b0ea8e24c1bbf4ba94c1cd5a83/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU3YWMyZDZiZmEzOS84ZWVlMjliMGVhOGUyNGMxYmJmNGJhOTRjMWNkNWE4My8wMy5qcGc=");
        // https://mangatyrant.com/wp-content/uploads/WP-manga/data/manga_657ac2d6bfa39/8eee29b0ea8e24c1bbf4ba94c1cd5a83/32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXR5cmFudC5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU3YWMyZDZiZmEzOS84ZWVlMjliMGVhOGUyNGMxYmJmNGJhOTRjMWNkNWE4My8zMi5qcGc=");
    }
}

