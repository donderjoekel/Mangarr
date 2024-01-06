using System.Collections;

namespace Mangarr.Backend.Tests;

public class xCaliBRScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "xcalibr";

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
        // https://xcalibrscans.com?p=7765
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tP3A9Nzc2NXw3NzY1");
        // https://xcalibrscans.com?p=7453
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tP3A9NzQ1M3w3NDUz");
        // https://xcalibrscans.com?p=6940
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tP3A9Njk0MHw2OTQw");
        // https://xcalibrscans.com?p=4834
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tP3A9NDgzNHw0ODM0");
        // https://xcalibrscans.com?p=4500
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tP3A9NDUwMHw0NTAw");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://xcalibrscans.com/am-i-invincible-chapter-42/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2FtLWktaW52aW5jaWJsZS1jaGFwdGVyLTQyL3xodHRwczovL3hjYWxpYnJzY2Fucy5jb20/cD00NTAwfDQy");
        // https://xcalibrscans.com/am-i-invincible-chapter-54/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2FtLWktaW52aW5jaWJsZS1jaGFwdGVyLTU0L3xodHRwczovL3hjYWxpYnJzY2Fucy5jb20/cD00NTAwfDU0");
        // https://xcalibrscans.com/earthlings-are-insane-chapter-31/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2VhcnRobGluZ3MtYXJlLWluc2FuZS1jaGFwdGVyLTMxL3xodHRwczovL3hjYWxpYnJzY2Fucy5jb20/cD00ODM0fDMx");
        // https://xcalibrscans.com/am-i-invincible-chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2FtLWktaW52aW5jaWJsZS1jaGFwdGVyLTE4L3xodHRwczovL3hjYWxpYnJzY2Fucy5jb20/cD00NTAwfDE4");
        // https://xcalibrscans.com/the-strongest-emperor-god-resets-his-worthless-life-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3RoZS1zdHJvbmdlc3QtZW1wZXJvci1nb2QtcmVzZXRzLWhpcy13b3J0aGxlc3MtbGlmZS1jaGFwdGVyLTcvfGh0dHBzOi8veGNhbGlicnNjYW5zLmNvbT9wPTY5NDB8Nw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://xcalibrscans.com/wp-content/uploads/assets/AII/AII_54_2286f16EEaeD669507e477F96D7ED9F1/AII_54_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvQUlJL0FJSV81NF8yMjg2ZjE2RUVhZUQ2Njk1MDdlNDc3Rjk2RDdFRDlGMS9BSUlfNTRfNy5qcGc=");
        // https://xcalibrscans.com/wp-content/uploads/assets/AII/AII_54_2286f16EEaeD669507e477F96D7ED9F1/AII_54_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvQUlJL0FJSV81NF8yMjg2ZjE2RUVhZUQ2Njk1MDdlNDc3Rjk2RDdFRDlGMS9BSUlfNTRfNi5qcGc=");
        // https://xcalibrscans.com/wp-content/uploads/assets/AII/AII_42_24d4F6e5E77575A58E8D330F3B4FA4Dd/AII_42_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvQUlJL0FJSV80Ml8yNGQ0RjZlNUU3NzU3NUE1OEU4RDMzMEYzQjRGQTREZC9BSUlfNDJfNy5qcGc=");
        // https://xcalibrscans.com/wp-content/uploads/assets/AII/AII_42_24d4F6e5E77575A58E8D330F3B4FA4Dd/AII_42_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvQUlJL0FJSV80Ml8yNGQ0RjZlNUU3NzU3NUE1OEU4RDMzMEYzQjRGQTREZC9BSUlfNDJfMS5qcGc=");
        // https://xcalibrscans.com/wp-content/uploads/assets/EAI/EAI_31_f6c5D14a007921B6833c3e1c84313ca7/EAI_31_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvRUFJL0VBSV8zMV9mNmM1RDE0YTAwNzkyMUI2ODMzYzNlMWM4NDMxM2NhNy9FQUlfMzFfMS5qcGc=");
    }
}

