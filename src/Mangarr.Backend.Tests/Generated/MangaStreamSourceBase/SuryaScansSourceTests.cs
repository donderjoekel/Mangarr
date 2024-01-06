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
        // https://suryacomics.com/merciless-chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWVyY2lsZXNzLWNoYXB0ZXItMTkvfGh0dHBzOi8vc3VyeWFjb21pY3MuY29tP3A9MzAxNDl8MTk=");
        // https://suryacomics.com/the-return-of-apocalypses-tyrant-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vdGhlLXJldHVybi1vZi1hcG9jYWx5cHNlcy10eXJhbnQtY2hhcHRlci00L3xodHRwczovL3N1cnlhY29taWNzLmNvbT9wPTI5NDk4fDQ=");
        // https://suryacomics.com/merciless-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWVyY2lsZXNzLWNoYXB0ZXItMi98aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0zMDE0OXwy");
        // https://suryacomics.com/the-return-of-apocalypses-tyrant-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vdGhlLXJldHVybi1vZi1hcG9jYWx5cHNlcy10eXJhbnQtY2hhcHRlci03L3xodHRwczovL3N1cnlhY29taWNzLmNvbT9wPTI5NDk4fDc=");
        // https://suryacomics.com/ill-be-a-villain-in-this-life-chapter-31/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vaWxsLWJlLWEtdmlsbGFpbi1pbi10aGlzLWxpZmUtY2hhcHRlci0zMS98aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20/cD0yOTQ5NHwzMQ==");
    }

    public static IEnumerable ValidImages()
    {
        // https://suryacomics.com/wp-content/uploads/2023/12/1-38.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMS0zOC53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/7-30.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvNy0zMC53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/10-64.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTAtNjQud2VicA==");
        // https://suryacomics.com/wp-content/uploads/2023/12/3-57.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMy01Ny53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/12-96.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTItOTYud2VicA==");
    }
}

