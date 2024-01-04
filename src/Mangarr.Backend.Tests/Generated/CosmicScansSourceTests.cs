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
        // https://cosmic-scans.com/manga/the-housekeeper-in-the-dungeon/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL21hbmdhL3RoZS1ob3VzZWtlZXBlci1pbi10aGUtZHVuZ2Vvbi8=");
        // https://cosmic-scans.com/manga/questism/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL21hbmdhL3F1ZXN0aXNtLw==");
        // https://cosmic-scans.com/manga/how-to-fight/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL21hbmdhL2hvdy10by1maWdodC8=");
        // https://cosmic-scans.com/manga/eleceed-raws/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL21hbmdhL2VsZWNlZWQtcmF3cy8=");
        // https://cosmic-scans.com/manga/regressors-life-after-retirement/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL21hbmdhL3JlZ3Jlc3NvcnMtbGlmZS1hZnRlci1yZXRpcmVtZW50Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://cosmic-scans.com/questism-chapter-114/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3F1ZXN0aXNtLWNoYXB0ZXItMTE0Lw==");
        // https://cosmic-scans.com/how-to-fight-chapter-211/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2hvdy10by1maWdodC1jaGFwdGVyLTIxMS8=");
        // https://cosmic-scans.com/eleceed-raws-chapter-271/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI3MS8=");
        // https://cosmic-scans.com/regressors-life-after-retirement-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3JlZ3Jlc3NvcnMtbGlmZS1hZnRlci1yZXRpcmVtZW50LWNoYXB0ZXItNi8=");
        // https://cosmic-scans.com/eleceed-raws-chapter-269/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI2OS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cosmic-scans.com/wp-content/uploads/2023/09/TRR-CH-612.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzA5L1RSUi1DSC02MTIud2VicA==");
        // https://cosmic-scans.com/wp-content/uploads/2023/11/04-2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExLzA0LTIuanBn");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/P_047-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BfMDQ3LTEuanBn");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/P_013-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BfMDEzLTEuanBn");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/P_010-2.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BfMDEwLTIud2VicA==");
    }
}

