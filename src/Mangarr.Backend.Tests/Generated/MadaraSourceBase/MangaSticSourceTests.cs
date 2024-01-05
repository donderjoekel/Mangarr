using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaSticSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangastic";

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
        // https://toon69.com/manga/strawberry-market/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL3N0cmF3YmVycnktbWFya2V0L2NoYXB0ZXItNS8=");
        // https://toon69.com/manga/mother-in-law-bends-to-my-will/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC9jaGFwdGVyLTEv");
        // https://toon69.com/manga/sss-class-undercover-agent/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL3Nzcy1jbGFzcy11bmRlcmNvdmVyLWFnZW50L2NoYXB0ZXItMTAv");
        // https://toon69.com/manga/could-you-please-touch-me-there/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUvY2hhcHRlci00Lw==");
        // https://toon69.com/manga/mother-in-law-bends-to-my-will/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL21hbmdhL21vdGhlci1pbi1sYXctYmVuZHMtdG8tbXktd2lsbC9jaGFwdGVyLTMv");
    }

    public static IEnumerable ValidImages()
    {
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/strawberry-market-7070/chapter-5/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3N0cmF3YmVycnktbWFya2V0LTcwNzAvY2hhcHRlci01LzguanBn");
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/strawberry-market-7070/chapter-5/16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3N0cmF3YmVycnktbWFya2V0LTcwNzAvY2hhcHRlci01LzE2LmpwZw==");
        // https://toon69.com/wp-content/uploads/WP-manga/data/sss-class-undercover-agent-7074/chapter-10/7.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3Nzcy1jbGFzcy11bmRlcmNvdmVyLWFnZW50LTcwNzQvY2hhcHRlci0xMC83LmpwZw==");
        // https://image.toon69.xyz/wp-content/uploads/WP-manga/data/could-you-please-touch-me-there-7076/chapter-4/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS50b29uNjkueHl6L3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUtNzA3Ni9jaGFwdGVyLTQvNS5qcGc=");
        // https://toon69.com/wp-content/uploads/WP-manga/data/sss-class-undercover-agent-7074/chapter-10/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly90b29uNjkuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3Nzcy1jbGFzcy11bmRlcmNvdmVyLWFnZW50LTcwNzQvY2hhcHRlci0xMC80LmpwZw==");
    }
}

