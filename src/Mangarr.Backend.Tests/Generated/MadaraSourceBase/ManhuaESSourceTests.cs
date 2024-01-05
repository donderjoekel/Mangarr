using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaESSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuaes";

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
        // https://manhuaes.com/manga/apotheosis/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvYXBvdGhlb3Npcy8=");
        // https://manhuaes.com/manga/real-man/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvcmVhbC1tYW4v");
        // https://manhuaes.com/manga/how-to-protect-my-male-lead/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvaG93LXRvLXByb3RlY3QtbXktbWFsZS1sZWFkLw==");
        // https://manhuaes.com/manga/im-the-great-immortal/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvaW0tdGhlLWdyZWF0LWltbW9ydGFsLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuaes.com/manga/apotheosis/chapter-328/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvYXBvdGhlb3Npcy9jaGFwdGVyLTMyOC8=");
        // https://manhuaes.com/manga/im-the-great-immortal/chapter-451/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvaW0tdGhlLWdyZWF0LWltbW9ydGFsL2NoYXB0ZXItNDUxLw==");
        // https://manhuaes.com/manga/apotheosis/chapter-1110/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvYXBvdGhlb3Npcy9jaGFwdGVyLTExMTAv");
        // https://manhuaes.com/manga/im-the-great-immortal/chapter-277/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvaW0tdGhlLWdyZWF0LWltbW9ydGFsL2NoYXB0ZXItMjc3Lw==");
        // https://manhuaes.com/manga/im-the-great-immortal/chapter-507/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFlcy5jb20vbWFuZ2EvaW0tdGhlLWdyZWF0LWltbW9ydGFsL2NoYXB0ZXItNTA3Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://img.manhuaes.com/apotheosis/chapter-1110/010.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZXMuY29tL2Fwb3RoZW9zaXMvY2hhcHRlci0xMTEwLzAxMC5qcGc=");
        // https://img.manhuaes.com/im-the-great-immortal/chapter-277/023.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZXMuY29tL2ltLXRoZS1ncmVhdC1pbW1vcnRhbC9jaGFwdGVyLTI3Ny8wMjMuanBn");
        // https://img.manhuaes.com/apotheosis/chapter-328/011.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZXMuY29tL2Fwb3RoZW9zaXMvY2hhcHRlci0zMjgvMDExLmpwZw==");
        // https://img.manhuaes.com/apotheosis/chapter-1110/015.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZXMuY29tL2Fwb3RoZW9zaXMvY2hhcHRlci0xMTEwLzAxNS5qcGc=");
        // https://img.manhuaes.com/im-the-great-immortal/chapter-277/020.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZXMuY29tL2ltLXRoZS1ncmVhdC1pbW1vcnRhbC9jaGFwdGVyLTI3Ny8wMjAuanBn");
    }
}

