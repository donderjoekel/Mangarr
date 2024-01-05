using System.Collections;

namespace Mangarr.Backend.Tests;

public class BananaMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "bananamanga";

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
        // https://bananamanga.net/manga/release-that-witch/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvcmVsZWFzZS10aGF0LXdpdGNoLw==");
        // https://bananamanga.net/manga/magic-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvbWFnaWMtZW1wZXJvci8=");
        // https://bananamanga.net/manga/golden-time-ryu-hyang/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvZ29sZGVuLXRpbWUtcnl1LWh5YW5nLw==");
        // https://bananamanga.net/manga/sesame-and-rice-cake/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2Evc2VzYW1lLWFuZC1yaWNlLWNha2Uv");
        // https://bananamanga.net/manga/the-lady-and-the-beast-hongseul/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvdGhlLWxhZHktYW5kLXRoZS1iZWFzdC1ob25nc2V1bC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://bananamanga.net/manga/release-that-witch/ch-367/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvcmVsZWFzZS10aGF0LXdpdGNoL2NoLTM2Ny8=");
        // https://bananamanga.net/manga/release-that-witch/ch-196/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvcmVsZWFzZS10aGF0LXdpdGNoL2NoLTE5Ni8=");
        // https://bananamanga.net/manga/release-that-witch/ch-111/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvcmVsZWFzZS10aGF0LXdpdGNoL2NoLTExMS8=");
        // https://bananamanga.net/manga/magic-emperor/ch-199/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvbWFnaWMtZW1wZXJvci9jaC0xOTkv");
        // https://bananamanga.net/manga/release-that-witch/ch-234/
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvbWFuZ2EvcmVsZWFzZS10aGF0LXdpdGNoL2NoLTIzNC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://bananamanga.net/wp-content/uploads/WP-manga/data/manga_62ec9911752de/ch-199/p001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjJlYzk5MTE3NTJkZS9jaC0xOTkvcDAwMS5qcGc=");
        // https://bananamanga.net/wp-content/uploads/WP-manga/data/manga_62ec9911752de/ch-199/p024.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjJlYzk5MTE3NTJkZS9jaC0xOTkvcDAyNC5qcGc=");
        // https://bananamanga.net/wp-content/uploads/WP-manga/data/manga_62ec9911752de/ch-199/p007.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjJlYzk5MTE3NTJkZS9jaC0xOTkvcDAwNy5qcGc=");
        // https://bananamanga.net/wp-content/uploads/WP-manga/data/manga_62ed27b52321f/ch-111/s20200124_170741_072.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjJlZDI3YjUyMzIxZi9jaC0xMTEvczIwMjAwMTI0XzE3MDc0MV8wNzIuanBn");
        // https://bananamanga.net/wp-content/uploads/WP-manga/data/manga_62ec9911752de/ch-199/p021.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYW5hbmFtYW5nYS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjJlYzk5MTE3NTJkZS9jaC0xOTkvcDAyMS5qcGc=");
    }
}

