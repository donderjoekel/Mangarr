using System.Collections;

namespace Mangarr.Backend.Tests;

public class KunMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "kunmanga";

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
        // https://kunmanga.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yLw==");
        // https://kunmanga.com/manga/i-was-reborn-as-his-highness-the-princes-little-evil-dragon/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvaS13YXMtcmVib3JuLWFzLWhpcy1oaWdobmVzcy10aGUtcHJpbmNlcy1saXR0bGUtZXZpbC1kcmFnb24v");
        // https://kunmanga.com/manga/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvcGxlYXNlLWdldC1vdXQtb2YtbXktaG91c2Vob2xkLw==");
        // https://kunmanga.com/manga/mave-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWF2ZS1hbm90aGVyLXdvcmxkLw==");
        // https://kunmanga.com/manga/master-huo-fails-to-pursue-his-wife/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWFzdGVyLWh1by1mYWlscy10by1wdXJzdWUtaGlzLXdpZmUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://kunmanga.com/manga/mave-another-world/chapter-43/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWF2ZS1hbm90aGVyLXdvcmxkL2NoYXB0ZXItNDMv");
        // https://kunmanga.com/manga/mave-another-world/chapter-48/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWF2ZS1hbm90aGVyLXdvcmxkL2NoYXB0ZXItNDgv");
        // https://kunmanga.com/manga/mave-another-world/chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWF2ZS1hbm90aGVyLXdvcmxkL2NoYXB0ZXItMjQv");
        // https://kunmanga.com/manga/mave-another-world/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWF2ZS1hbm90aGVyLXdvcmxkL2NoYXB0ZXItMC8=");
        // https://kunmanga.com/manga/master-huo-fails-to-pursue-his-wife/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9rdW5tYW5nYS5jb20vbWFuZ2EvbWFzdGVyLWh1by1mYWlscy10by1wdXJzdWUtaGlzLXdpZmUvY2hhcHRlci0xNS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img-2.harimanga.com/manga_6595ad14f3996/1127567148857f1ddcce03c49e06dd09/32.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvMTEyNzU2NzE0ODg1N2YxZGRjY2UwM2M0OWUwNmRkMDkvMzIud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/b339d1653b5adc6b5605abe9c1f5d3eb/69.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvYjMzOWQxNjUzYjVhZGM2YjU2MDVhYmU5YzFmNWQzZWIvNjkud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/958e37aaa1c430f29db3cd557391ef98/71.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvOTU4ZTM3YWFhMWM0MzBmMjlkYjNjZDU1NzM5MWVmOTgvNzEud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/1127567148857f1ddcce03c49e06dd09/72.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvMTEyNzU2NzE0ODg1N2YxZGRjY2UwM2M0OWUwNmRkMDkvNzIud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/1127567148857f1ddcce03c49e06dd09/25.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvMTEyNzU2NzE0ODg1N2YxZGRjY2UwM2M0OWUwNmRkMDkvMjUud2VicA==");
    }
}

