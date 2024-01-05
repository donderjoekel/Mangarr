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
        // https://suryacomics.com/manga/99-boss/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWFuZ2EvOTktYm9zcy8=");
        // https://suryacomics.com/manga/preview/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWFuZ2EvcHJldmlldy8=");
        // https://suryacomics.com/manga/merciless/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWFuZ2EvbWVyY2lsZXNzLw==");
        // https://suryacomics.com/manga/the-return-of-apocalypses-tyrant/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWFuZ2EvdGhlLXJldHVybi1vZi1hcG9jYWx5cHNlcy10eXJhbnQv");
        // https://suryacomics.com/manga/ill-be-a-villain-in-this-life/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWFuZ2EvaWxsLWJlLWEtdmlsbGFpbi1pbi10aGlzLWxpZmUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://suryacomics.com/merciless-chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWVyY2lsZXNzLWNoYXB0ZXItMjIv");
        // https://suryacomics.com/merciless-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vbWVyY2lsZXNzLWNoYXB0ZXItMjAv");
        // https://suryacomics.com/ill-be-a-villain-in-this-life-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vaWxsLWJlLWEtdmlsbGFpbi1pbi10aGlzLWxpZmUtY2hhcHRlci01Lw==");
        // https://suryacomics.com/the-return-of-apocalypses-tyrant-chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vdGhlLXJldHVybi1vZi1hcG9jYWx5cHNlcy10eXJhbnQtY2hhcHRlci0xMy8=");
        // https://suryacomics.com/the-return-of-apocalypses-tyrant-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vdGhlLXJldHVybi1vZi1hcG9jYWx5cHNlcy10eXJhbnQtY2hhcHRlci02Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://suryacomics.com/wp-content/uploads/2023/12/6-66.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvNi02Ni53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2024/01/02-3.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItMy53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/6-59.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvNi01OS53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2024/01/12-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTItMS53ZWJw");
        // https://suryacomics.com/wp-content/uploads/2023/12/12-39.webp
        yield return new TestCaseData("aHR0cHM6Ly9zdXJ5YWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTItMzkud2VicA==");
    }
}

