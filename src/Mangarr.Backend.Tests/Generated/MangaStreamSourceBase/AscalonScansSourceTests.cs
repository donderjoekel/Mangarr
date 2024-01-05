using System.Collections;

namespace Mangarr.Backend.Tests;

public class AscalonScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "ascalonscans";

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
        // https://ascalonscans.com/manga/white-scandal/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL21hbmdhL3doaXRlLXNjYW5kYWwv");
        // https://ascalonscans.com/manga/lady-crumb-saintess/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL21hbmdhL2xhZHktY3J1bWItc2FpbnRlc3Mv");
        // https://ascalonscans.com/manga/friends-dont-act-like-this/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL21hbmdhL2ZyaWVuZHMtZG9udC1hY3QtbGlrZS10aGlzLw==");
        // https://ascalonscans.com/manga/i-am-the-servers-adversary/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL21hbmdhL2ktYW0tdGhlLXNlcnZlcnMtYWR2ZXJzYXJ5Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://ascalonscans.com/lady-crumb-saintess-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL2xhZHktY3J1bWItc2FpbnRlc3MtY2hhcHRlci0yLw==");
        // https://ascalonscans.com/white-scandal-chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3doaXRlLXNjYW5kYWwtY2hhcHRlci05Lw==");
        // https://ascalonscans.com/white-scandal-chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3doaXRlLXNjYW5kYWwtY2hhcHRlci0wLw==");
        // https://ascalonscans.com/white-scandal-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3doaXRlLXNjYW5kYWwtY2hhcHRlci0xLw==");
        // https://ascalonscans.com/white-scandal-chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3doaXRlLXNjYW5kYWwtY2hhcHRlci0xMC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://ascalonscans.com/wp-content/uploads/2023/12/06-105.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA2LTEwNS53ZWJw");
        // https://ascalonscans.com/wp-content/uploads/2023/12/05-68.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA1LTY4LndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2023/12/00-69.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzAwLTY5LndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2023/12/12-20.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzEyLTIwLndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2023/12/11-47.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzExLTQ3LndlYnA=");
    }
}

