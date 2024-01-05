using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwatopSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwatop";

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
        // https://manhwatop.com/manga/the-owner-of-a-building/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3RoZS1vd25lci1vZi1hLWJ1aWxkaW5nLw==");
        // https://manhwatop.com/manga/we-are-101/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3dlLWFyZS0xMDEv");
        // https://manhwatop.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
        // https://manhwatop.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL21lYXQtZG9sbC13b3Jrc2hvcC1pbi1hbm90aGVyLXdvcmxkLw==");
        // https://manhwatop.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwatop.com/manga/the-owner-of-a-building/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3RoZS1vd25lci1vZi1hLWJ1aWxkaW5nL2NoYXB0ZXItMjUv");
        // https://manhwatop.com/manga/the-owner-of-a-building/chapter-30/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3RoZS1vd25lci1vZi1hLWJ1aWxkaW5nL2NoYXB0ZXItMzAv");
        // https://manhwatop.com/manga/the-owner-of-a-building/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3RoZS1vd25lci1vZi1hLWJ1aWxkaW5nL2NoYXB0ZXItMTUv");
        // https://manhwatop.com/manga/the-owner-of-a-building/chapter-37/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3RoZS1vd25lci1vZi1hLWJ1aWxkaW5nL2NoYXB0ZXItMzcv");
        // https://manhwatop.com/manga/the-owner-of-a-building/chapter-35/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL21hbmdhL3RoZS1vd25lci1vZi1hLWJ1aWxkaW5nL2NoYXB0ZXItMzUv");
    }

    public static IEnumerable ValidImages()
    {
        // https://manhwatop.com/wp-content/uploads/WP-manga/data/manga_65978a38f0f55/3871d1d4f373f145eab0f116629bc687/2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTc4YTM4ZjBmNTUvMzg3MWQxZDRmMzczZjE0NWVhYjBmMTE2NjI5YmM2ODcvMi5qcGc=");
        // https://manhwatop.com/wp-content/uploads/WP-manga/data/manga_65978a38f0f55/b638f29514ea134de442e36a2f61ffb0/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTc4YTM4ZjBmNTUvYjYzOGYyOTUxNGVhMTM0ZGU0NDJlMzZhMmY2MWZmYjAvMDEuanBn");
        // https://manhwatop.com/wp-content/uploads/WP-manga/data/manga_65978a38f0f55/640298ac51a83756d35a994ff5ed955c/13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTc4YTM4ZjBmNTUvNjQwMjk4YWM1MWE4Mzc1NmQzNWE5OTRmZjVlZDk1NWMvMTMuanBn");
        // https://manhwatop.com/wp-content/uploads/WP-manga/data/manga_65978a38f0f55/bcc7fc4d67ce58a6a84a50afec2f774c/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTc4YTM4ZjBmNTUvYmNjN2ZjNGQ2N2NlNThhNmE4NGE1MGFmZWMyZjc3NGMvMDEuanBn");
        // https://manhwatop.com/wp-content/uploads/WP-manga/data/manga_65978a38f0f55/b638f29514ea134de442e36a2f61ffb0/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0b3AuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTc4YTM4ZjBmNTUvYjYzOGYyOTUxNGVhMTM0ZGU0NDJlMzZhMmY2MWZmYjAvMDguanBn");
    }
}

