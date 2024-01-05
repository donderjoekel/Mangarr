using System.Collections;

namespace Mangarr.Backend.Tests;

public class ElarcToonSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "elarctoon";

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
        // https://elarctoon.com/series/im-not-the-hero/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3Nlcmllcy9pbS1ub3QtdGhlLWhlcm8v");
        // https://elarctoon.com/series/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3Nlcmllcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLw==");
        // https://elarctoon.com/series/the-book-of-abyss/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3Nlcmllcy90aGUtYm9vay1vZi1hYnlzcy8=");
        // https://elarctoon.com/series/the-solo-necromancer-leading-an-immortal-army-transfers-to-become-an-sss-rank-adventure/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3Nlcmllcy90aGUtc29sby1uZWNyb21hbmNlci1sZWFkaW5nLWFuLWltbW9ydGFsLWFybXktdHJhbnNmZXJzLXRvLWJlY29tZS1hbi1zc3MtcmFuay1hZHZlbnR1cmUv");
        // https://elarctoon.com/series/utori-the-legacy/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3Nlcmllcy91dG9yaS10aGUtbGVnYWN5Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://elarctoon.com/im-not-the-hero-chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL2ltLW5vdC10aGUtaGVyby1jaGFwdGVyLTE1Lw==");
        // https://elarctoon.com/the-solo-necromancer-leading-an-immortal-army-transfers-to-become-an-sss-rank-adventure-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3RoZS1zb2xvLW5lY3JvbWFuY2VyLWxlYWRpbmctYW4taW1tb3J0YWwtYXJteS10cmFuc2ZlcnMtdG8tYmVjb21lLWFuLXNzcy1yYW5rLWFkdmVudHVyZS1jaGFwdGVyLTUv");
        // https://elarctoon.com/mr-devourer-please-act-like-a-final-boss-chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtY2hhcHRlci0wLw==");
        // https://elarctoon.com/im-not-the-hero-chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL2ltLW5vdC10aGUtaGVyby1jaGFwdGVyLTI0Lw==");
        // https://elarctoon.com/the-solo-necromancer-leading-an-immortal-army-transfers-to-become-an-sss-rank-adventure-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3RoZS1zb2xvLW5lY3JvbWFuY2VyLWxlYWRpbmctYW4taW1tb3J0YWwtYXJteS10cmFuc2ZlcnMtdG8tYmVjb21lLWFuLXNzcy1yYW5rLWFkdmVudHVyZS1jaGFwdGVyLTcv");
    }

    public static IEnumerable ValidImages()
    {
        // https://elarctoon.com/wp-content/uploads/manga/the-solo-necromancer-leading-an-immortal-army-transfers-to-become-an-sss-rank-adventure/chapter-5/16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9tYW5nYS90aGUtc29sby1uZWNyb21hbmNlci1sZWFkaW5nLWFuLWltbW9ydGFsLWFybXktdHJhbnNmZXJzLXRvLWJlY29tZS1hbi1zc3MtcmFuay1hZHZlbnR1cmUvY2hhcHRlci01LzE2LmpwZw==");
        // https://elarctoon.com/wp-content/uploads/manga/the-solo-necromancer-leading-an-immortal-army-transfers-to-become-an-sss-rank-adventure/chapter-7/23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9tYW5nYS90aGUtc29sby1uZWNyb21hbmNlci1sZWFkaW5nLWFuLWltbW9ydGFsLWFybXktdHJhbnNmZXJzLXRvLWJlY29tZS1hbi1zc3MtcmFuay1hZHZlbnR1cmUvY2hhcHRlci03LzIzLmpwZw==");
        // https://elarctoon.com/wp-content/uploads/2024/01/5-45.webp
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzUtNDUud2VicA==");
        // https://elarctoon.com/wp-content/uploads/manga/mr-devourer-please-act-like-a-final-boss/chapter-0/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMC84LmpwZw==");
        // https://elarctoon.com/wp-content/uploads/manga/the-solo-necromancer-leading-an-immortal-army-transfers-to-become-an-sss-rank-adventure/chapter-5/22.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9tYW5nYS90aGUtc29sby1uZWNyb21hbmNlci1sZWFkaW5nLWFuLWltbW9ydGFsLWFybXktdHJhbnNmZXJzLXRvLWJlY29tZS1hbi1zc3MtcmFuay1hZHZlbnR1cmUvY2hhcHRlci01LzIyLmpwZw==");
    }
}

