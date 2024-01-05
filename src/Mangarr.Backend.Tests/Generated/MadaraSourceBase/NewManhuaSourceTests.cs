using System.Collections;

namespace Mangarr.Backend.Tests;

public class NewManhuaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "newmanhua";

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
        // https://newmanhua.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
        // https://newmanhua.com/manga/after-signing-for-90000-years-the-former-taoist-monk-wants-to-cut/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL2FmdGVyLXNpZ25pbmctZm9yLTkwMDAwLXllYXJzLXRoZS1mb3JtZXItdGFvaXN0LW1vbmstd2FudHMtdG8tY3V0Lw==");
        // https://newmanhua.com/manga/emperor-qin-returns-i-am-the-eternal-immortal-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL2VtcGVyb3ItcWluLXJldHVybnMtaS1hbS10aGUtZXRlcm5hbC1pbW1vcnRhbC1lbXBlcm9yLw==");
        // https://newmanhua.com/manga/after-ten-years-of-chopping-wood-immortals-begged-to-become-my-disciples/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL2FmdGVyLXRlbi15ZWFycy1vZi1jaG9wcGluZy13b29kLWltbW9ydGFscy1iZWdnZWQtdG8tYmVjb21lLW15LWRpc2NpcGxlcy8=");
        // https://newmanhua.com/manga/moon-slayer/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL21vb24tc2xheWVyLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://newmanhua.com/manga/after-signing-for-90000-years-the-former-taoist-monk-wants-to-cut/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL2FmdGVyLXNpZ25pbmctZm9yLTkwMDAwLXllYXJzLXRoZS1mb3JtZXItdGFvaXN0LW1vbmstd2FudHMtdG8tY3V0L2NoYXB0ZXItMC8=");
        // https://newmanhua.com/manga/starting-with-the-holy-maiden-system-bound/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC9jaGFwdGVyLTIv");
        // https://newmanhua.com/manga/after-ten-years-of-chopping-wood-immortals-begged-to-become-my-disciples/chapter-33/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL2FmdGVyLXRlbi15ZWFycy1vZi1jaG9wcGluZy13b29kLWltbW9ydGFscy1iZWdnZWQtdG8tYmVjb21lLW15LWRpc2NpcGxlcy9jaGFwdGVyLTMzLw==");
        // https://newmanhua.com/manga/moon-slayer/chapter-27/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL21vb24tc2xheWVyL2NoYXB0ZXItMjcv");
        // https://newmanhua.com/manga/after-signing-for-90000-years-the-former-taoist-monk-wants-to-cut/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL21hbmdhL2FmdGVyLXNpZ25pbmctZm9yLTkwMDAwLXllYXJzLXRoZS1mb3JtZXItdGFvaXN0LW1vbmstd2FudHMtdG8tY3V0L2NoYXB0ZXItNC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.newmanhua.com/manga_657b1b133d60b/chapter-27/8.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubmV3bWFuaHVhLmNvbS9tYW5nYV82NTdiMWIxMzNkNjBiL2NoYXB0ZXItMjcvOC53ZWJw");
        // https://cdn.newmanhua.com/manga_657b1b7378191/chapter-33/14.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubmV3bWFuaHVhLmNvbS9tYW5nYV82NTdiMWI3Mzc4MTkxL2NoYXB0ZXItMzMvMTQud2VicA==");
        // https://cdn.newmanhua.com/manga_657b1b133d60b/chapter-27/10.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubmV3bWFuaHVhLmNvbS9tYW5nYV82NTdiMWIxMzNkNjBiL2NoYXB0ZXItMjcvMTAud2VicA==");
        // https://newmanhua.com/wp-content/uploads/WP-manga/data/manga_658e5bbc0f15d/ddec752277ebb2fdfba82b15d368fee6/2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9uZXdtYW5odWEuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OGU1YmJjMGYxNWQvZGRlYzc1MjI3N2ViYjJmZGZiYTgyYjE1ZDM2OGZlZTYvMi5qcGc=");
        // https://cdn.newmanhua.com/manga_657b1b7378191/chapter-33/5.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubmV3bWFuaHVhLmNvbS9tYW5nYV82NTdiMWI3Mzc4MTkxL2NoYXB0ZXItMzMvNS53ZWJw");
    }
}

