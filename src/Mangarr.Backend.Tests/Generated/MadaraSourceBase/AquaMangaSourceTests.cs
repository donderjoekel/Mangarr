using System.Collections;

namespace Mangarr.Backend.Tests;

public class AquaMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "aquamanga";

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
        // https://aquamanga.org/manga/the-male-leads-were-stolen-by-an-extra/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1tYWxlLWxlYWRzLXdlcmUtc3RvbGVuLWJ5LWFuLWV4dHJhLw==");
        // https://aquamanga.org/manga/the-law-of-being-friends-with-a-male/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1sYXctb2YtYmVpbmctZnJpZW5kcy13aXRoLWEtbWFsZS8=");
        // https://aquamanga.org/manga/the-last-cultivator/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1sYXN0LWN1bHRpdmF0b3Iv");
        // https://aquamanga.org/manga/i-tamed-my-ex-husbands-mad-dog/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL2ktdGFtZWQtbXktZXgtaHVzYmFuZHMtbWFkLWRvZy8=");
        // https://aquamanga.org/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://aquamanga.org/manga/i-have-a-blade-that-can-cut-heaven-and-earth/i-have-a-blade-that-can-cut-heaven-and-earth/ch-3-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoLTMtY2hhcHRlci0zLw==");
        // https://aquamanga.org/manga/the-law-of-being-friends-with-a-male/the-law-of-being-friends-with-a-male/ch-8-chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1sYXctb2YtYmVpbmctZnJpZW5kcy13aXRoLWEtbWFsZS90aGUtbGF3LW9mLWJlaW5nLWZyaWVuZHMtd2l0aC1hLW1hbGUvY2gtOC1jaGFwdGVyLTgv");
        // https://aquamanga.org/manga/the-law-of-being-friends-with-a-male/the-law-of-being-friends-with-a-male/ch-13-chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1sYXctb2YtYmVpbmctZnJpZW5kcy13aXRoLWEtbWFsZS90aGUtbGF3LW9mLWJlaW5nLWZyaWVuZHMtd2l0aC1hLW1hbGUvY2gtMTMtY2hhcHRlci0xMy8=");
        // https://aquamanga.org/manga/the-male-leads-were-stolen-by-an-extra/the-male-leads-were-stolen-by-the-extra/ch-8-chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1tYWxlLWxlYWRzLXdlcmUtc3RvbGVuLWJ5LWFuLWV4dHJhL3RoZS1tYWxlLWxlYWRzLXdlcmUtc3RvbGVuLWJ5LXRoZS1leHRyYS9jaC04LWNoYXB0ZXItOC8=");
        // https://aquamanga.org/manga/the-last-cultivator/the-last-cultivator/ch-6-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1sYXN0LWN1bHRpdmF0b3IvdGhlLWxhc3QtY3VsdGl2YXRvci9jaC02LWNoYXB0ZXItNi8=");
    }

    public static IEnumerable ValidImages()
    {
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6596ddd4a36c1/a71ce2e165cc0437aa73784b463359d9/01.jpg
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NmRkZDRhMzZjMS9hNzFjZTJlMTY1Y2MwNDM3YWE3Mzc4NGI0NjMzNTlkOS8wMS5qcGc=");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6596e8f80752b/79ee3db7b710a07b319f0cb11f5aed97/09.jpg
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NmU4ZjgwNzUyYi83OWVlM2RiN2I3MTBhMDdiMzE5ZjBjYjExZjVhZWQ5Ny8wOS5qcGc=");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6596e9a5bd147/f379fc437c2086bfc95859aaef6e3b97/03.png
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NmU5YTViZDE0Ny9mMzc5ZmM0MzdjMjA4NmJmYzk1ODU5YWFlZjZlM2I5Ny8wMy5wbmc=");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6596ddd4a36c1/a71ce2e165cc0437aa73784b463359d9/03.jpg
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NmRkZDRhMzZjMS9hNzFjZTJlMTY1Y2MwNDM3YWE3Mzc4NGI0NjMzNTlkOS8wMy5qcGc=");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6596ddd4a36c1/a71ce2e165cc0437aa73784b463359d9/02.jpg
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NmRkZDRhMzZjMS9hNzFjZTJlMTY1Y2MwNDM3YWE3Mzc4NGI0NjMzNTlkOS8wMi5qcGc=");
    }
}

