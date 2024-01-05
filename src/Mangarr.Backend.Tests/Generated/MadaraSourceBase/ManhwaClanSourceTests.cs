using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaClanSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwaclan";

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
        // https://manhwaclan.com/manga/the-grand-dukes-beloved-granddaughter/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS90aGUtZ3JhbmQtZHVrZXMtYmVsb3ZlZC1ncmFuZGRhdWdodGVyLw==");
        // https://manhwaclan.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3Iv");
        // https://manhwaclan.com/manga/ill-pay-for-your-life-lets-both-go-crazy-together/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9pbGwtcGF5LWZvci15b3VyLWxpZmUtbGV0cy1ib3RoLWdvLWNyYXp5LXRvZ2V0aGVyLw==");
        // https://manhwaclan.com/manga/i-was-reborn-as-his-highness-the-princes-little-evil-dragon/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9pLXdhcy1yZWJvcm4tYXMtaGlzLWhpZ2huZXNzLXRoZS1wcmluY2VzLWxpdHRsZS1ldmlsLWRyYWdvbi8=");
        // https://manhwaclan.com/manga/mave-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9tYXZlLWFub3RoZXItd29ybGQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwaclan.com/manga/mave-another-world/chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9tYXZlLWFub3RoZXItd29ybGQvY2hhcHRlci0xMy8=");
        // https://manhwaclan.com/manga/dark-and-light-martial-emperor/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci02Lw==");
        // https://manhwaclan.com/manga/mave-another-world/chapter-46/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9tYXZlLWFub3RoZXItd29ybGQvY2hhcHRlci00Ni8=");
        // https://manhwaclan.com/manga/the-grand-dukes-beloved-granddaughter/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS90aGUtZ3JhbmQtZHVrZXMtYmVsb3ZlZC1ncmFuZGRhdWdodGVyL2NoYXB0ZXItNS8=");
        // https://manhwaclan.com/manga/ill-pay-for-your-life-lets-both-go-crazy-together/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FjbGFuLmNvbS9tYW5nYS9pbGwtcGF5LWZvci15b3VyLWxpZmUtbGV0cy1ib3RoLWdvLWNyYXp5LXRvZ2V0aGVyL2NoYXB0ZXItOC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img-2.harimanga.com/manga_65974e8e07903/c9056cbe1e97bbc77d63fcb76a5f62de/05.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTc0ZThlMDc5MDMvYzkwNTZjYmUxZTk3YmJjNzdkNjNmY2I3NmE1ZjYyZGUvMDUud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/57ce6b309e6f4ef54abc3198ecb807b4/38.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvNTdjZTZiMzA5ZTZmNGVmNTRhYmMzMTk4ZWNiODA3YjQvMzgud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/57ce6b309e6f4ef54abc3198ecb807b4/76.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvNTdjZTZiMzA5ZTZmNGVmNTRhYmMzMTk4ZWNiODA3YjQvNzYud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/57ce6b309e6f4ef54abc3198ecb807b4/46.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvNTdjZTZiMzA5ZTZmNGVmNTRhYmMzMTk4ZWNiODA3YjQvNDYud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/57ce6b309e6f4ef54abc3198ecb807b4/34.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvNTdjZTZiMzA5ZTZmNGVmNTRhYmMzMTk4ZWNiODA3YjQvMzQud2VicA==");
    }
}

