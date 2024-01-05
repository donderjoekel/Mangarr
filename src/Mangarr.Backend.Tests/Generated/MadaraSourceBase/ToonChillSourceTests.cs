using System.Collections;

namespace Mangarr.Backend.Tests;

public class ToonChillSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "toonchill";

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
        // https://toonchill.com/manga/how-to-protect-my-male-lead/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC9jaGFwdGVyLTcv");
        // https://toonchill.com/manga/demonas/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci0xOS8=");
        // https://toonchill.com/manga/demonas/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci0xNy8=");
        // https://toonchill.com/manga/demonas/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2RlbW9uYXMvY2hhcHRlci0yMS8=");
        // https://toonchill.com/manga/i-raised-my-fiance-with-money/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL21hbmdhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5L2NoYXB0ZXItNC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://toonchill.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-124735/chapter-7/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC0xMjQ3MzUvY2hhcHRlci03LzEuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/i-raised-my-fiance-with-money-124731/chapter-4/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5LTEyNDczMS9jaGFwdGVyLTQvNS5qcGc=");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/f5beed7c171f0786338c97dacad440ef/12.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvZjViZWVkN2MxNzFmMDc4NjMzOGM5N2RhY2FkNDQwZWYvMTIuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/f5beed7c171f0786338c97dacad440ef/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvZjViZWVkN2MxNzFmMDc4NjMzOGM5N2RhY2FkNDQwZWYvMDUuanBn");
        // https://toonchill.com/wp-content/uploads/WP-manga/data/manga_6594cf9bef028/11f33761be112ee9650e04911cf64ad5/17.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uY2hpbGwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTRjZjliZWYwMjgvMTFmMzM3NjFiZTExMmVlOTY1MGUwNDkxMWNmNjRhZDUvMTcuanBn");
    }
}

