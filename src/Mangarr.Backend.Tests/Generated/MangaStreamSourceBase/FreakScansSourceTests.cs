using System.Collections;

namespace Mangarr.Backend.Tests;

public class FreakScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "freakscans";

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
        // https://freakscans.com?p=24923
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0OTIzfDI0OTIz");
        // https://freakscans.com?p=24841
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0ODQxfDI0ODQx");
        // https://freakscans.com?p=24069
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0MDY5fDI0MDY5");
        // https://freakscans.com?p=23965
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTY1fDIzOTY1");
        // https://freakscans.com?p=23932
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTMyfDIzOTMy");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://freakscans.com/0-kill-assassine-ch-03/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS8wLWtpbGwtYXNzYXNzaW5lLWNoLTAzL3xodHRwczovL2ZyZWFrc2NhbnMuY29tP3A9MjM5NjV8Mw==");
        // https://freakscans.com/the-demon-emperor-hopes-for-a-hero-ch-02/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLWNoLTAyL3xodHRwczovL2ZyZWFrc2NhbnMuY29tP3A9MjQwNjl8Mg==");
        // https://freakscans.com/police-returners-reset-life-ch-38/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9wb2xpY2UtcmV0dXJuZXJzLXJlc2V0LWxpZmUtY2gtMzgvfGh0dHBzOi8vZnJlYWtzY2Fucy5jb20/cD0yNDg0MXwzOA==");
        // https://freakscans.com/potion-witch-ch-03/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9wb3Rpb24td2l0Y2gtY2gtMDMvfGh0dHBzOi8vZnJlYWtzY2Fucy5jb20/cD0yMzkzMnwz");
        // https://freakscans.com/0-kill-assassine-ch-04/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS8wLWtpbGwtYXNzYXNzaW5lLWNoLTA0L3xodHRwczovL2ZyZWFrc2NhbnMuY29tP3A9MjM5NjV8NA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://i2.wp.com/freakscans.com/wp-content/uploads/2023/12/18-19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTgtMTkuanBn");
    }
}

