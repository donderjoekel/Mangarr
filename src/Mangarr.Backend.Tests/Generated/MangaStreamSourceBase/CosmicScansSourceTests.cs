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
        // https://cosmic-scans.com/the-housekeeper-in-the-dungeon-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3RoZS1ob3VzZWtlZXBlci1pbi10aGUtZHVuZ2Vvbi1jaGFwdGVyLTYv");
        // https://cosmic-scans.com/how-to-fight-chapter-210/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2hvdy10by1maWdodC1jaGFwdGVyLTIxMC8=");
        // https://cosmic-scans.com/eleceed-raws-chapter-276/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI3Ni8=");
        // https://cosmic-scans.com/eleceed-raws-chapter-274/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI3NC8=");
        // https://cosmic-scans.com/eleceed-raws-chapter-278/
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL2VsZWNlZWQtcmF3cy1jaGFwdGVyLTI3OC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cosmic-scans.com/wp-content/uploads/2024/01/HD-CH-603.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL0hELUNILTYwMy53ZWJw");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/P_047.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BfMDQ3LmpwZw==");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/P_043.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BfMDQzLmpwZw==");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/11-8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzExLTguanBn");
        // https://cosmic-scans.com/wp-content/uploads/2023/12/22-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb3NtaWMtc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzIyLTEuanBn");
    }
}

