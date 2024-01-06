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
        // https://ascalonscans.com?p=4461
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9NDQ2MXw0NDYx");
        // https://ascalonscans.com?p=4018
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9NDAxOHw0MDE4");
        // https://ascalonscans.com?p=3358
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzM1OHwzMzU4");
        // https://ascalonscans.com?p=3243
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzI0M3wzMjQz");
        // https://ascalonscans.com?p=3275
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzI3NXwzMjc1");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://ascalonscans.com/i-am-the-servers-adversary-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL2ktYW0tdGhlLXNlcnZlcnMtYWR2ZXJzYXJ5LWNoYXB0ZXItNC98aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzI3NXw0");
        // https://ascalonscans.com/white-scandal-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3doaXRlLXNjYW5kYWwtY2hhcHRlci00L3xodHRwczovL2FzY2Fsb25zY2Fucy5jb20/cD00MDE4fDQ=");
        // https://ascalonscans.com/lady-crumb-saintess-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL2xhZHktY3J1bWItc2FpbnRlc3MtY2hhcHRlci03L3xodHRwczovL2FzY2Fsb25zY2Fucy5jb20/cD0zMzU4fDc=");
        // https://ascalonscans.com/i-am-the-servers-adversary-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL2ktYW0tdGhlLXNlcnZlcnMtYWR2ZXJzYXJ5LWNoYXB0ZXItMi98aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzI3NXwy");
        // https://ascalonscans.com/friends-dont-act-like-this-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL2ZyaWVuZHMtZG9udC1hY3QtbGlrZS10aGlzLWNoYXB0ZXItMy98aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzI0M3wz");
    }

    public static IEnumerable ValidImages()
    {
        // https://ascalonscans.com/wp-content/uploads/2023/12/03-111.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzAzLTExMS53ZWJw");
        // https://ascalonscans.com/wp-content/uploads/2023/12/01-110.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzAxLTExMC53ZWJw");
        // https://ascalonscans.com/wp-content/uploads/2023/12/06-85.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA2LTg1LndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2023/12/01-97.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzAxLTk3LndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2023/12/09-50.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA5LTUwLndlYnA=");
    }
}

