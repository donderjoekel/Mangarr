using System.Collections;

namespace Mangarr.Backend.Tests;

public class CosmicScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "cosmicscans";

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
        // https://cosmic-scans.com?p=47129
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDcxMjl8NDcxMjk=");
        // https://cosmic-scans.com?p=46229
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDYyMjl8NDYyMjk=");
        // https://cosmic-scans.com?p=46158
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDYxNTh8NDYxNTg=");
        // https://cosmic-scans.com?p=43347
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDMzNDd8NDMzNDc=");
        // https://cosmic-scans.com?p=40446
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDA0NDZ8NDA0NDY=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://cosmic-scans.com/the-regressors-retired-life-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3RoZS1yZWdyZXNzb3JzLXJldGlyZWQtbGlmZS1jaGFwdGVyLTIvfGh0dHBzOi8vY29zbWljLXNjYW5zLmNvbT9wPTQwNDQ2fDI=");
        // https://cosmic-scans.com/eleceed-raws-chapter-273/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI3My98aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDMzNDd8Mjcz");
        // https://cosmic-scans.com/eleceed-raws-chapter-272/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI3Mi98aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tP3A9NDMzNDd8Mjcy");
        // https://cosmic-scans.com/the-housekeeper-in-the-dungeon-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3RoZS1ob3VzZWtlZXBlci1pbi10aGUtZHVuZ2Vvbi1jaGFwdGVyLTYvfGh0dHBzOi8vY29zbWljLXNjYW5zLmNvbT9wPTQ3MTI5fDY=");
        // https://cosmic-scans.com/questism-chapter-116/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3F1ZXN0aXNtLWNoYXB0ZXItMTE2L3xodHRwczovL2Nvc21pYy1zY2Fucy5jb20/cD00NjIyOXwxMTY=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cosmic-scans.com/wp-content/uploads/2023/11/08-11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExLzA4LTExLmpwZw==");
        // https://cosmic-scans.com/wp-content/uploads/2023/11/23-3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExLzIzLTMuanBn");
        // https://cosmic-scans.com/wp-content/uploads/2023/09/TRR-CH-209.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzA5L1RSUi1DSC0yMDkud2VicA==");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/P_017-3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BfMDE3LTMuanBn");
        // https://cosmic-scans.com/wp-content/uploads/2023/11/16-10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExLzE2LTEwLmpwZw==");
    }
}

