using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaRosieSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangarosie";

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
        // https://toon69.com/manga/sss-class-undercover-agent/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL3Nzcy1jbGFzcy11bmRlcmNvdmVyLWFnZW50Lw==");
        // https://toon69.com/manga/could-you-please-touch-me-there/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUv");
        // https://toon69.com/manga/my-life-is-a-piece-of-cake/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL215LWxpZmUtaXMtYS1waWVjZS1vZi1jYWtlLw==");
        // https://toon69.com/manga/strawberry-market/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL3N0cmF3YmVycnktbWFya2V0Lw==");
        // https://toon69.com/manga/mother-in-law-bends-to-my-will/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://toon69.com/manga/mother-in-law-bends-to-my-will/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC9jaGFwdGVyLTUv");
        // https://toon69.com/manga/strawberry-market/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL3N0cmF3YmVycnktbWFya2V0L2NoYXB0ZXItMi8=");
        // https://toon69.com/manga/could-you-please-touch-me-there/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUvY2hhcHRlci01Lw==");
        // https://toon69.com/manga/mother-in-law-bends-to-my-will/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC9jaGFwdGVyLTcv");
        // https://toon69.com/manga/could-you-please-touch-me-there/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUvY2hhcHRlci03Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/mother-in-law-bends-to-my-will-7053/chapter-7/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC03MDUzL2NoYXB0ZXItNy85LmpwZw==");
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/could-you-please-touch-me-there-7076/chapter-7/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUtNzA3Ni9jaGFwdGVyLTcvNS5qcGc=");
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/strawberry-market-7070/chapter-2/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3N0cmF3YmVycnktbWFya2V0LTcwNzAvY2hhcHRlci0yLzguanBn");
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/could-you-please-touch-me-there-7076/chapter-5/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUtNzA3Ni9jaGFwdGVyLTUvMy5qcGc=");
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/mother-in-law-bends-to-my-will-7053/chapter-7/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC03MDUzL2NoYXB0ZXItNy8xMS5qcGc=");
    }
}

