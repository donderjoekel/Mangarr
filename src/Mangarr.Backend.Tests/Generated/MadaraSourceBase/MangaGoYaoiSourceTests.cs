using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaGoYaoiSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangagoyaoi";

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
        // https://asurascans.us/manga/a-comic-artists-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL2EtY29taWMtYXJ0aXN0cy1zdXJ2aXZhbC1ndWlkZS8=");
        // https://asurascans.us/manga/emperors-domination-novel/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL2VtcGVyb3JzLWRvbWluYXRpb24tbm92ZWwv");
        // https://asurascans.us/manga/legend-of-mir-gold-armored-sword-dragon/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL2xlZ2VuZC1vZi1taXItZ29sZC1hcm1vcmVkLXN3b3JkLWRyYWdvbi8=");
        // https://asurascans.us/manga/the-gateway-of-revolution/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL3RoZS1nYXRld2F5LW9mLXJldm9sdXRpb24v");
        // https://asurascans.us/manga/the-greatest-estate-designer/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL3RoZS1ncmVhdGVzdC1lc3RhdGUtZGVzaWduZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://asurascans.us/manga/the-greatest-estate-designer/chapter-045/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL3RoZS1ncmVhdGVzdC1lc3RhdGUtZGVzaWduZXIvY2hhcHRlci0wNDUv");
        // https://asurascans.us/manga/the-gateway-of-revolution/chapter-027/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL3RoZS1nYXRld2F5LW9mLXJldm9sdXRpb24vY2hhcHRlci0wMjcv");
        // https://asurascans.us/manga/legend-of-mir-gold-armored-sword-dragon/chapter-019/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL2xlZ2VuZC1vZi1taXItZ29sZC1hcm1vcmVkLXN3b3JkLWRyYWdvbi9jaGFwdGVyLTAxOS8=");
        // https://asurascans.us/manga/the-greatest-estate-designer/chapter-018/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL3RoZS1ncmVhdGVzdC1lc3RhdGUtZGVzaWduZXIvY2hhcHRlci0wMTgv");
        // https://asurascans.us/manga/emperors-domination-novel/chapter-032/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL21hbmdhL2VtcGVyb3JzLWRvbWluYXRpb24tbm92ZWwvY2hhcHRlci0wMzIv");
    }

    public static IEnumerable ValidImages()
    {
        // https://asurascans.us/wp-content/uploads/WP-manga/data/manga_647e14eae2ea8/chapter-045/n003.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0N2UxNGVhZTJlYTgvY2hhcHRlci0wNDUvbjAwMy5qcGc=");
        // https://asurascans.us/wp-content/uploads/WP-manga/data/manga_647e14eae2ea8/chapter-018/k029.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0N2UxNGVhZTJlYTgvY2hhcHRlci0wMTgvazAyOS5qcGc=");
        // https://asurascans.us/wp-content/uploads/WP-manga/data/manga_647e14eae2ea8/chapter-045/n015.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0N2UxNGVhZTJlYTgvY2hhcHRlci0wNDUvbjAxNS5qcGc=");
        // https://asurascans.us/wp-content/uploads/WP-manga/data/manga_647e14eae2ea8/chapter-018/k022.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0N2UxNGVhZTJlYTgvY2hhcHRlci0wMTgvazAyMi5qcGc=");
        // https://asurascans.us/wp-content/uploads/WP-manga/data/manga_647e14eae2ea8/chapter-018/k015.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXNjYW5zLnVzL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0N2UxNGVhZTJlYTgvY2hhcHRlci0wMTgvazAxNS5qcGc=");
    }
}

