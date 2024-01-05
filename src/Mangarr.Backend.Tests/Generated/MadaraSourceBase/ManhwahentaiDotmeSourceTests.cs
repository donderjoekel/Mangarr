using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwahentaiDotmeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwahentai.me";

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
        // https://manhwahentai.me/webtoon/you-came-during-the-massage-earlier-didnt-you/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3Uv");
        // https://manhwahentai.me/webtoon/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi90aGUtc3Rvcnktb2YtaG93LWktZ290LXRvZ2V0aGVyLXdpdGgtdGhlLW1hbmFnZXItb24tY2hyaXN0bWFzLw==");
        // https://manhwahentai.me/webtoon/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi9tYWtpbmctZnJpZW5kcy13aXRoLXN0cmVhbWVycy1ieS1oYWNraW5nLw==");
        // https://manhwahentai.me/webtoon/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi9ub3QtYXQtd29yay8=");
        // https://manhwahentai.me/webtoon/mr-wolfs-valley-girl-diet/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi9tci13b2xmcy12YWxsZXktZ2lybC1kaWV0Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwahentai.me/webtoon/you-came-during-the-massage-earlier-didnt-you/chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3UvY2hhcHRlci0yMC8=");
        // https://manhwahentai.me/webtoon/you-came-during-the-massage-earlier-didnt-you/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3UvY2hhcHRlci0xNi8=");
        // https://manhwahentai.me/webtoon/you-came-during-the-massage-earlier-didnt-you/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3UvY2hhcHRlci05Lw==");
        // https://manhwahentai.me/webtoon/you-came-during-the-massage-earlier-didnt-you/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3UvY2hhcHRlci0xNy8=");
        // https://manhwahentai.me/webtoon/you-came-during-the-massage-earlier-didnt-you/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd2VidG9vbi95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3UvY2hhcHRlci0xNS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://manhwahentai.me/wp-content/uploads/WP-manga/data/manga_65963b0902054/0a37e585c129219be3c3657233e14044/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjNiMDkwMjA1NC8wYTM3ZTU4NWMxMjkyMTliZTNjMzY1NzIzM2UxNDA0NC8wMi5qcGc=");
        // https://manhwahentai.me/wp-content/uploads/WP-manga/data/manga_65963b0902054/eaa7a569d79035510f9d0e682892b0df/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjNiMDkwMjA1NC9lYWE3YTU2OWQ3OTAzNTUxMGY5ZDBlNjgyODkyYjBkZi8wNS5qcGc=");
        // https://manhwahentai.me/wp-content/uploads/WP-manga/data/manga_65963b0902054/bd8e8a95f25a6b29f56e29d54a2c08b7/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjNiMDkwMjA1NC9iZDhlOGE5NWYyNWE2YjI5ZjU2ZTI5ZDU0YTJjMDhiNy8wMy5qcGc=");
        // https://manhwahentai.me/wp-content/uploads/WP-manga/data/manga_65963b0902054/8dcffaa5fdd57a5bfddb29b1a10f6f2e/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjNiMDkwMjA1NC84ZGNmZmFhNWZkZDU3YTViZmRkYjI5YjFhMTBmNmYyZS8wNS5qcGc=");
        // https://manhwahentai.me/wp-content/uploads/WP-manga/data/manga_65963b0902054/8dcffaa5fdd57a5bfddb29b1a10f6f2e/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FoZW50YWkubWUvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjNiMDkwMjA1NC84ZGNmZmFhNWZkZDU3YTViZmRkYjI5YjFhMTBmNmYyZS8wOS5qcGc=");
    }
}

