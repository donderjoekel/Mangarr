using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaScoSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangasco";

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
        // https://manhwasco.net/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
        // https://manhwasco.net/manga/the-unbeatable-dungeons-lazy-boss-monster/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3RoZS11bmJlYXRhYmxlLWR1bmdlb25zLWxhenktYm9zcy1tb25zdGVyLw==");
        // https://manhwasco.net/manga/sss-grade-saint-knight/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3Nzcy1ncmFkZS1zYWludC1rbmlnaHQv");
        // https://manhwasco.net/manga/reincarnator-manhwa/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3JlaW5jYXJuYXRvci1tYW5od2Ev");
        // https://manhwasco.net/manga/it-turns-out-that-i-have-been-invincible-for-a-long-time/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL2l0LXR1cm5zLW91dC10aGF0LWktaGF2ZS1iZWVuLWludmluY2libGUtZm9yLWEtbG9uZy10aW1lLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwasco.net/manga/reincarnator-manhwa/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3JlaW5jYXJuYXRvci1tYW5od2EvY2hhcHRlci0yLw==");
        // https://manhwasco.net/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3RoZS11bmJlYXRhYmxlLWR1bmdlb25zLWxhenktYm9zcy1tb25zdGVyL2NoYXB0ZXItNS8=");
        // https://manhwasco.net/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3RoZS11bmJlYXRhYmxlLWR1bmdlb25zLWxhenktYm9zcy1tb25zdGVyL2NoYXB0ZXItMS8=");
        // https://manhwasco.net/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3RoZS11bmJlYXRhYmxlLWR1bmdlb25zLWxhenktYm9zcy1tb25zdGVyL2NoYXB0ZXItMTUv");
        // https://manhwasco.net/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FzY28ubmV0L21hbmdhL3RoZS11bmJlYXRhYmxlLWR1bmdlb25zLWxhenktYm9zcy1tb25zdGVyL2NoYXB0ZXItOS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn1.manhwasco.net/img/manga_6591700ede9b7/chapter-5/003.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4xLm1hbmh3YXNjby5uZXQvaW1nL21hbmdhXzY1OTE3MDBlZGU5YjcvY2hhcHRlci01LzAwMy5qcGc=");
        // https://cdn1.manhwasco.net/img/manga_6591700ede9b7/chapter-1/012.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4xLm1hbmh3YXNjby5uZXQvaW1nL21hbmdhXzY1OTE3MDBlZGU5YjcvY2hhcHRlci0xLzAxMi5qcGc=");
        // https://cdn1.manhwasco.net/img/manga_6591700ede9b7/chapter-1/010.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4xLm1hbmh3YXNjby5uZXQvaW1nL21hbmdhXzY1OTE3MDBlZGU5YjcvY2hhcHRlci0xLzAxMC5qcGc=");
        // https://cdn1.manhwasco.net/img/manga_6591700ede9b7/chapter-5/012.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4xLm1hbmh3YXNjby5uZXQvaW1nL21hbmdhXzY1OTE3MDBlZGU5YjcvY2hhcHRlci01LzAxMi5qcGc=");
        // https://cdn1.manhwasco.net/img/manga_6591700ede9b7/chapter-1/014.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4xLm1hbmh3YXNjby5uZXQvaW1nL21hbmdhXzY1OTE3MDBlZGU5YjcvY2hhcHRlci0xLzAxNC5qcGc=");
    }
}

