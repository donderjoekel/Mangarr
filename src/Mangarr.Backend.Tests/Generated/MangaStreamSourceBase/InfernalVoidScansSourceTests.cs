using System.Collections;

namespace Mangarr.Backend.Tests;

public class InfernalVoidScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "infernalvoidscans";

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
        // https://void-scans.com/manga/preview/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9tYW5nYS9wcmV2aWV3Lw==");
        // https://void-scans.com/manga/this-life-starts-as-a-child-actor/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9tYW5nYS90aGlzLWxpZmUtc3RhcnRzLWFzLWEtY2hpbGQtYWN0b3Iv");
        // https://void-scans.com/manga/99-boss/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9tYW5nYS85OS1ib3NzLw==");
        // https://void-scans.com/manga/the-return-of-apocalypses-tyrant/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9tYW5nYS90aGUtcmV0dXJuLW9mLWFwb2NhbHlwc2VzLXR5cmFudC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://void-scans.com/99-boss-chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS85OS1ib3NzLWNoYXB0ZXItOC8=");
        // https://void-scans.com/this-life-starts-as-a-child-actor-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS90aGlzLWxpZmUtc3RhcnRzLWFzLWEtY2hpbGQtYWN0b3ItY2hhcHRlci0yMC8=");
        // https://void-scans.com/the-return-of-apocalypses-tyrant-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS90aGUtcmV0dXJuLW9mLWFwb2NhbHlwc2VzLXR5cmFudC1jaGFwdGVyLTIwLw==");
        // https://void-scans.com/the-return-of-apocalypses-tyrant-chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS90aGUtcmV0dXJuLW9mLWFwb2NhbHlwc2VzLXR5cmFudC1jaGFwdGVyLTEyLw==");
        // https://void-scans.com/this-life-starts-as-a-child-actor-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS90aGlzLWxpZmUtc3RhcnRzLWFzLWEtY2hpbGQtYWN0b3ItY2hhcHRlci02Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.void-scans.com/wp-content/uploads/2023/10/11_11_11zon-29.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvMTFfMTFfMTF6b24tMjkud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/10-11.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTAtMTEud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/01-14.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDEtMTQud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/05-13.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDUtMTMud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/01-37.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDEtMzcud2VicA==");
    }
}

