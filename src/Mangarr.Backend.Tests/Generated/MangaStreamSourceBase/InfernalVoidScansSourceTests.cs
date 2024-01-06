using System.Collections;

namespace Mangarr.Backend.Tests;

public class InfernalVoidScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "voidscans";

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
        // https://void-scans.com?p=88293
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MjkzfDg4Mjkz");
        // https://void-scans.com?p=88175
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MTc1fDg4MTc1");
        // https://void-scans.com?p=88171
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MTcxfDg4MTcx");
        // https://void-scans.com?p=88053
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MDUzfDg4MDUz");
        // https://void-scans.com?p=88003
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MDAzfDg4MDAz");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://void-scans.com?p=88251
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MjUxfDg4MjUx");
        // https://void-scans.com?p=88213
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MjEzfDg4MjEz");
        // https://void-scans.com?p=88097
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MDk3fDg4MDk3");
        // https://void-scans.com?p=88276
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4Mjc2fDg4Mjc2");
        // https://void-scans.com?p=88211
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MjExfDg4MjEx");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/03-67.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDMtNjcud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/01-81.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDEtODEud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/05-58.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDUtNTgud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/06-80.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDYtODAud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/09-55.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDktNTUud2VicA==");
    }
}

