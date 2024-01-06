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
        // https://void-scans.com/preview-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9wcmV2aWV3LWNoYXB0ZXItNS98aHR0cHM6Ly92b2lkLXNjYW5zLmNvbT9wPTg4MTc1fDU=");
        // https://void-scans.com/avalon-of-disaster-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9hdmFsb24tb2YtZGlzYXN0ZXItY2hhcHRlci00L3xodHRwczovL3ZvaWQtc2NhbnMuY29tP3A9ODgyOTN8NA==");
        // https://void-scans.com/chairman-kang-the-newcomer-chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9jaGFpcm1hbi1rYW5nLXRoZS1uZXdjb21lci1jaGFwdGVyLTI0L3xodHRwczovL3ZvaWQtc2NhbnMuY29tP3A9ODgxNzF8MjQ=");
        // https://void-scans.com/chairman-kang-the-newcomer-chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9jaGFpcm1hbi1rYW5nLXRoZS1uZXdjb21lci1jaGFwdGVyLTExL3xodHRwczovL3ZvaWQtc2NhbnMuY29tP3A9ODgxNzF8MTE=");
        // https://void-scans.com/chairman-kang-the-newcomer-chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly92b2lkLXNjYW5zLmNvbS9jaGFpcm1hbi1rYW5nLXRoZS1uZXdjb21lci1jaGFwdGVyLTIxL3xodHRwczovL3ZvaWQtc2NhbnMuY29tP3A9ODgxNzF8MjE=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/05-85.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDUtODUud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/26-2.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMjYtMi53ZWJw");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/02-76.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItNzYud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/04-76.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDQtNzYud2VicA==");
        // https://cdn.void-scans.com/wp-content/uploads/2024/01/02-79.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udm9pZC1zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItNzkud2VicA==");
    }
}

