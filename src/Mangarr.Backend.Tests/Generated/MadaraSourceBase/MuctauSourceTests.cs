using System.Collections;

namespace Mangarr.Backend.Tests;

public class MuctauSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "muctau";

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
        // https://bibimanga.com/manga/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL25vdC1hdC13b3JrLw==");
        // https://bibimanga.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQv");
        // https://bibimanga.com/manga/i-raised-my-fiance-with-money/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5Lw==");
        // https://bibimanga.com/manga/how-to-protect-my-male-lead/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC8=");
        // https://bibimanga.com/manga/reasoning-with-a-beast/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlYXNvbmluZy13aXRoLWEtYmVhc3Qv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://bibimanga.com/manga/naughty-male-friend/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL25hdWdodHktbWFsZS1mcmllbmQvY2hhcHRlci0xLw==");
        // https://bibimanga.com/manga/reasoning-with-a-beast/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlYXNvbmluZy13aXRoLWEtYmVhc3QvY2hhcHRlci0yLw==");
        // https://bibimanga.com/manga/i-raised-my-fiance-with-money/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktcmFpc2VkLW15LWZpYW5jZS13aXRoLW1vbmV5L2NoYXB0ZXItMi8=");
        // https://bibimanga.com/manga/how-to-protect-my-male-lead/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC9jaGFwdGVyLTEv");
        // https://bibimanga.com/manga/how-to-protect-my-male-lead/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2hvdy10by1wcm90ZWN0LW15LW1hbGUtbGVhZC9jaGFwdGVyLTIv");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-198437/chapter-1/36.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQtMTk4NDM3L2NoYXB0ZXItMS8zNi5qcGc=");
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-198437/chapter-1/30.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQtMTk4NDM3L2NoYXB0ZXItMS8zMC5qcGc=");
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/manga_6594b2edd4612/4281ff837740176925666dd7c15e32ba/13---13-4.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk0YjJlZGQ0NjEyLzQyODFmZjgzNzc0MDE3NjkyNTY2NmRkN2MxNWUzMmJhLzEzLS0tMTMtNC53ZWJw");
        // https://cdn.bibimanga.com/wp-content/uploads/WP-manga/data/how-to-protect-my-male-lead-198437/chapter-1/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYmliaW1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQtMTk4NDM3L2NoYXB0ZXItMS8zLmpwZw==");
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/naughty-male-friend-198449/chapter-1/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL25hdWdodHktbWFsZS1mcmllbmQtMTk4NDQ5L2NoYXB0ZXItMS85LmpwZw==");
    }
}

