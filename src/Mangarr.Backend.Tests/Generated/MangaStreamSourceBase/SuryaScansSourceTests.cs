using System.Collections;

namespace Mangarr.Backend.Tests;

public class SuryaScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "suryascans";

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
        // https://suryacomics.com?p=31608
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMTYwOHwzMTYwOA==");
        // https://suryacomics.com?p=30525
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMDUyNXwzMDUyNQ==");
        // https://suryacomics.com?p=30149
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMDE0OXwzMDE0OQ==");
        // https://suryacomics.com?p=29498
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0yOTQ5OHwyOTQ5OA==");
        // https://suryacomics.com?p=29494
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0yOTQ5NHwyOTQ5NA==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://suryacomics.com?p=32207
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMjIwN3wzMjIwNw==");
        // https://suryacomics.com?p=31002
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMTAwMnwzMTAwMg==");
        // https://suryacomics.com?p=31362
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMTM2MnwzMTM2Mg==");
        // https://suryacomics.com?p=31613
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMTYxM3wzMTYxMw==");
        // https://suryacomics.com?p=30920
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMDkyMHwzMDkyMA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://suryacomics.com/wp-content/uploads/2024/01/01-3.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDEtMy53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/4-64.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvNC02NC53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/11-100.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTEtMTAwLndlYnA=");
        // https://suryacomics.com/wp-content/uploads/2024/01/10-3.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTAtMy53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/10-131.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTAtMTMxLndlYnA=");
    }
}

