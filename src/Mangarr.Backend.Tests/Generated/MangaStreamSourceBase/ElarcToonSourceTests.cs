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
        // https://elarctoon.com?p=503836
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzODM2fDUwMzgzNg==");
        // https://elarctoon.com?p=503559
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzNTU5fDUwMzU1OQ==");
        // https://elarctoon.com?p=502131
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAyMTMxfDUwMjEzMQ==");
        // https://elarctoon.com?p=503138
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzMTM4fDUwMzEzOA==");
        // https://elarctoon.com?p=503826
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tP3A9NTAzODI2fDUwMzgyNg==");
    }

    public static IEnumerable ValidImages()
    {
        // https://elarctoon.com/wp-content/uploads/2024/01/8-39.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzgtMzkuanBn");
        // https://elarctoon.com/wp-content/uploads/manga/regressor-of-the-fallen-family/chapter-1/24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9tYW5nYS9yZWdyZXNzb3Itb2YtdGhlLWZhbGxlbi1mYW1pbHkvY2hhcHRlci0xLzI0LmpwZw==");
        // https://elarctoon.com/wp-content/uploads/manga/regressor-of-the-fallen-family/chapter-1/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9tYW5nYS9yZWdyZXNzb3Itb2YtdGhlLWZhbGxlbi1mYW1pbHkvY2hhcHRlci0xLzEwLmpwZw==");
        // https://elarctoon.com/wp-content/uploads/2024/01/1-36.webp
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzEtMzYud2VicA==");
        // https://elarctoon.com/wp-content/uploads/2024/01/3-38.jpg
        yield return new TestCaseData("aHR0cHM6Ly9lbGFyY3Rvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxLzMtMzguanBn");
    }
}

