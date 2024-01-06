using System.Collections;

namespace Mangarr.Backend.Tests;

public class ElarcToonSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "elarcpage";

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
        // https://elarctoon.com?p=503772
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzNzcyfDUwMzc3Mg==");
        // https://elarctoon.com?p=503764
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzNzY0fDUwMzc2NA==");
        // https://elarctoon.com?p=503371
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzMzcxfDUwMzM3MQ==");
        // https://elarctoon.com?p=503136
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzMTM2fDUwMzEzNg==");
        // https://elarctoon.com?p=501615
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAxNjE1fDUwMTYxNQ==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://elarctoon.com/im-not-the-hero-chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL2ltLW5vdC10aGUtaGVyby1jaGFwdGVyLTE2L3xodHRwczovL2VsYXJjdG9vbi5jb20/cD01MDE2MTV8MTY=");
        // https://elarctoon.com/regressor-of-the-fallen-family-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3JlZ3Jlc3Nvci1vZi10aGUtZmFsbGVuLWZhbWlseS1jaGFwdGVyLTEvfGh0dHBzOi8vZWxhcmN0b29uLmNvbT9wPTUwMzEzNnwx");
        // https://elarctoon.com/dark-and-light-martial-emperor-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci1jaGFwdGVyLTIwL3xodHRwczovL2VsYXJjdG9vbi5jb20/cD01MDMzNzF8MjA=");
        // https://elarctoon.com/all-football-talents-are-mine-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL2FsbC1mb290YmFsbC10YWxlbnRzLWFyZS1taW5lLWNoYXB0ZXItNi98aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzNzcyfDY=");
        // https://elarctoon.com/im-not-the-hero-chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL2ltLW5vdC10aGUtaGVyby1jaGFwdGVyLTE3L3xodHRwczovL2VsYXJjdG9vbi5jb20/cD01MDE2MTV8MTc=");
    }

    public static IEnumerable ValidImages()
    {
        // https://elarctoon.com/wp-content/uploads/2024/01/16-21.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzE2LTIxLmpwZw==");
        // https://elarctoon.com/wp-content/uploads/2024/01/18-22.webp
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzE4LTIyLndlYnA=");
        // https://elarctoon.com/wp-content/uploads/2024/01/3-40.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzMtNDAuanBn");
        // https://elarctoon.com/wp-content/uploads/2024/01/16-27.webp
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzE2LTI3LndlYnA=");
        // https://elarctoon.com/wp-content/uploads/2024/01/11-33.webp
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzExLTMzLndlYnA=");
    }
}

