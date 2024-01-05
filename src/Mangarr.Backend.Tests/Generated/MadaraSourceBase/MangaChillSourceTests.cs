using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaChillSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangachill";

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
        // https://toonchill.com/manga/since-my-time-is-limited-im-entering-a-contract-marriage/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL3NpbmNlLW15LXRpbWUtaXMtbGltaXRlZC1pbS1lbnRlcmluZy1hLWNvbnRyYWN0LW1hcnJpYWdlLw==");
        // https://toonchill.com/manga/absolute-threshold/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2Fic29sdXRlLXRocmVzaG9sZC8=");
        // https://toonchill.com/manga/demonas/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMv");
        // https://toonchill.com/manga/how-to-protect-my-male-lead/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC8=");
        // https://toonchill.com/manga/i-raised-my-fiance-with-money/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://toonchill.com/manga/demonas/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci00Lw==");
        // https://toonchill.com/manga/demonas/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci0xNy8=");
        // https://toonchill.com/manga/how-to-protect-my-male-lead/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC9jaGFwdGVyLTcv");
        // https://toonchill.com/manga/demonas/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci02Lw==");
        // https://toonchill.com/manga/demonas/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci01Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/c17389674aa146a75552abc1e71b1da2/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvYzE3Mzg5Njc0YWExNDZhNzU1NTJhYmMxZTcxYjFkYTIvMDYuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/85012e108422f6f0957dcec174ec7671/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvODUwMTJlMTA4NDIyZjZmMDk1N2RjZWMxNzRlYzc2NzEvMDEuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/88d1366f0d0cb7e35c25875e5146f1a4/21.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvODhkMTM2NmYwZDBjYjdlMzVjMjU4NzVlNTE0NmYxYTQvMjEuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/88d1366f0d0cb7e35c25875e5146f1a4/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvODhkMTM2NmYwZDBjYjdlMzVjMjU4NzVlNTE0NmYxYTQvMDYuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-124735/chapter-7/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC0xMjQ3MzUvY2hhcHRlci03LzExLmpwZw==");
    }
}

