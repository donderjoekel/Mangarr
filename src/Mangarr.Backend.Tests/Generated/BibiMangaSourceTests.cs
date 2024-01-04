using System.Collections;

namespace Mangarr.Backend.Tests;

public class BibiMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "bibimanga";

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
        // https://bibimanga.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQv");
        // https://bibimanga.com/manga/i-raised-my-fiance-with-money/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5Lw==");
        // https://bibimanga.com/manga/how-to-protect-my-male-lead/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC8=");
        // https://bibimanga.com/manga/reasoning-with-a-beast/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlYXNvbmluZy13aXRoLWEtYmVhc3Qv");
        // https://bibimanga.com/manga/reclusive-mage/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlY2x1c2l2ZS1tYWdlLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://bibimanga.com/manga/naughty-male-friend/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQvY2hhcHRlci0xLw==");
        // https://bibimanga.com/manga/i-raised-my-fiance-with-money/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5L2NoYXB0ZXItNC8=");
        // https://bibimanga.com/manga/naughty-male-friend/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQvY2hhcHRlci0yLw==");
        // https://bibimanga.com/manga/how-to-protect-my-male-lead/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC9jaGFwdGVyLTEv");
        // https://bibimanga.com/manga/reclusive-mage/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlY2x1c2l2ZS1tYWdlL2NoYXB0ZXItMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-198437/chapter-1/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQtMTk4NDM3L2NoYXB0ZXItMS8zLmpwZw==");
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/reclusive-mage-198431/chapter-1/17.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9yZWNsdXNpdmUtbWFnZS0xOTg0MzEvY2hhcHRlci0xLzE3LmpwZw==");
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-198437/chapter-1/21.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQtMTk4NDM3L2NoYXB0ZXItMS8yMS5qcGc=");
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-198437/chapter-1/23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQtMTk4NDM3L2NoYXB0ZXItMS8yMy5qcGc=");
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/i-raised-my-fiance-with-money-198443/chapter-4/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5LTE5ODQ0My9jaGFwdGVyLTQvMy5qcGc=");
    }
}

