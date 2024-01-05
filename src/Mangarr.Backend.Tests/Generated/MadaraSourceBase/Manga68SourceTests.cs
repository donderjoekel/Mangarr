using System.Collections;

namespace Mangarr.Backend.Tests;

public class Manga68SourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manga68";

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
        // https://manga68.com/manga/reasoning-with-a-beast/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9yZWFzb25pbmctd2l0aC1hLWJlYXN0Lw==");
        // https://manga68.com/manga/when-the-villainess-meets-the-crazy-heroine/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS93aGVuLXRoZS12aWxsYWluZXNzLW1lZXRzLXRoZS1jcmF6eS1oZXJvaW5lLw==");
        // https://manga68.com/manga/the-saviors-bucket-list/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS90aGUtc2F2aW9ycy1idWNrZXQtbGlzdC8=");
        // https://manga68.com/manga/im-the-one-who-died-but-the-hero-went-crazy-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9pbS10aGUtb25lLXdoby1kaWVkLWJ1dC10aGUtaGVyby13ZW50LWNyYXp5LTIv");
        // https://manga68.com/manga/i-became-the-games-biggest-villain-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9pLWJlY2FtZS10aGUtZ2FtZXMtYmlnZ2VzdC12aWxsYWluLTIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manga68.com/manga/im-the-one-who-died-but-the-hero-went-crazy-2/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9pbS10aGUtb25lLXdoby1kaWVkLWJ1dC10aGUtaGVyby13ZW50LWNyYXp5LTIvY2hhcHRlci02Lw==");
        // https://manga68.com/manga/the-saviors-bucket-list/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS90aGUtc2F2aW9ycy1idWNrZXQtbGlzdC9jaGFwdGVyLTQv");
        // https://manga68.com/manga/reasoning-with-a-beast/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9yZWFzb25pbmctd2l0aC1hLWJlYXN0L2NoYXB0ZXItMi8=");
        // https://manga68.com/manga/im-the-one-who-died-but-the-hero-went-crazy-2/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9pbS10aGUtb25lLXdoby1kaWVkLWJ1dC10aGUtaGVyby13ZW50LWNyYXp5LTIvY2hhcHRlci00Lw==");
        // https://manga68.com/manga/im-the-one-who-died-but-the-hero-went-crazy-2/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTY4LmNvbS9tYW5nYS9pbS10aGUtb25lLXdoby1kaWVkLWJ1dC10aGUtaGVyby13ZW50LWNyYXp5LTIvY2hhcHRlci01Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn4.manga68.com//manga_ada7959da9f0916c009f7d1262dde091/chapter_5/chap_5_45.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG40Lm1hbmdhNjguY29tLy9tYW5nYV9hZGE3OTU5ZGE5ZjA5MTZjMDA5ZjdkMTI2MmRkZTA5MS9jaGFwdGVyXzUvY2hhcF81XzQ1LmpwZw==");
        // https://cdn4.manga68.com//manga_ada7959da9f0916c009f7d1262dde091/chapter_4/chap_4_33.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG40Lm1hbmdhNjguY29tLy9tYW5nYV9hZGE3OTU5ZGE5ZjA5MTZjMDA5ZjdkMTI2MmRkZTA5MS9jaGFwdGVyXzQvY2hhcF80XzMzLmpwZw==");
        // https://cdn4.manga68.com//manga_ada7959da9f0916c009f7d1262dde091/chapter_5/chap_5_52.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG40Lm1hbmdhNjguY29tLy9tYW5nYV9hZGE3OTU5ZGE5ZjA5MTZjMDA5ZjdkMTI2MmRkZTA5MS9jaGFwdGVyXzUvY2hhcF81XzUyLmpwZw==");
        // https://cdn4.manga68.com//manga_ada7959da9f0916c009f7d1262dde091/chapter_4/chap_4_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG40Lm1hbmdhNjguY29tLy9tYW5nYV9hZGE3OTU5ZGE5ZjA5MTZjMDA5ZjdkMTI2MmRkZTA5MS9jaGFwdGVyXzQvY2hhcF80XzYuanBn");
        // https://cdn4.manga68.com//manga_ada7959da9f0916c009f7d1262dde091/chapter_5/chap_5_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG40Lm1hbmdhNjguY29tLy9tYW5nYV9hZGE3OTU5ZGE5ZjA5MTZjMDA5ZjdkMTI2MmRkZTA5MS9jaGFwdGVyXzUvY2hhcF81XzEuanBn");
    }
}

