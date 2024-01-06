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
        // https://ascalonscans.com?p=4059
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9NDA1OXw0MDU5");
        // https://ascalonscans.com?p=3643
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9MzY0M3wzNjQz");
        // https://ascalonscans.com?p=4257
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9NDI1N3w0MjU3");
        // https://ascalonscans.com?p=4074
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9NDA3NHw0MDc0");
        // https://ascalonscans.com?p=4688
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tP3A9NDY4OHw0Njg4");
    }

    public static IEnumerable ValidImages()
    {
        // https://ascalonscans.com/wp-content/uploads/2023/12/12-35.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzEyLTM1LndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2023/12/07-116.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA3LTExNi53ZWJw");
        // https://ascalonscans.com/wp-content/uploads/2024/01/08-6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzA4LTYuanBn");
        // https://ascalonscans.com/wp-content/uploads/2023/12/09-86.webp
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA5LTg2LndlYnA=");
        // https://ascalonscans.com/wp-content/uploads/2024/01/06-6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc2NhbG9uc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzA2LTYuanBn");
    }
}

