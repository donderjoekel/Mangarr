using System.Collections;

namespace Mangarr.Backend.Tests;

public class BeeHentaiSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "beehentai";

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
        // https://beehentai.com/sister-neighbors
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3Npc3Rlci1uZWlnaGJvcnN8c2lzdGVyLW5laWdoYm9ycw==");
        // https://beehentai.com/a-wonderful-new-world
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZHxhLXdvbmRlcmZ1bC1uZXctd29ybGQ=");
        // https://beehentai.com/weak-point
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3dlYWstcG9pbnR8d2Vhay1wb2ludA==");
        // https://beehentai.com/lucky-guy
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2x1Y2t5LWd1eXxsdWNreS1ndXk=");
        // https://beehentai.com/learning-the-hard-way
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2xlYXJuaW5nLXRoZS1oYXJkLXdheXxsZWFybmluZy10aGUtaGFyZC13YXk=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://beehentai.com/lucky-guy/chapter-11
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2x1Y2t5LWd1eS9jaGFwdGVyLTEx");
        // https://beehentai.com/learning-the-hard-way/chapter-90
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2xlYXJuaW5nLXRoZS1oYXJkLXdheS9jaGFwdGVyLTkw");
        // https://beehentai.com/sister-neighbors/chapter-109
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3Npc3Rlci1uZWlnaGJvcnMvY2hhcHRlci0xMDk=");
        // https://beehentai.com/weak-point/chapter-9
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3dlYWstcG9pbnQvY2hhcHRlci05");
        // https://beehentai.com/weak-point/chapter-109
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3dlYWstcG9pbnQvY2hhcHRlci0xMDk=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s14.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-90/8c57f03be2bf_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTQudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzFkZTQyZjE0YWUyODVlNWFlNTdjM2EzMDUxZTgyN2IyL2NoYXB0ZXItOTAvOGM1N2YwM2JlMmJmXzQuanBn");
        // https://s13.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-9/ff3ec7083358_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTMudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzVhZDdkYWRkYzY5ZWZkNzVlMDg3MGQzMTI5MjNmYmQ2L2NoYXB0ZXItOS9mZjNlYzcwODMzNThfNy5qcGc=");
        // https://s9.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-9/3e263adbe661_23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zOS50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvNWFkN2RhZGRjNjllZmQ3NWUwODcwZDMxMjkyM2ZiZDYvY2hhcHRlci05LzNlMjYzYWRiZTY2MV8yMy5qcGc=");
        // https://s6.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-90/145b3fc9a9fe_16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zNi50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMWRlNDJmMTRhZTI4NWU1YWU1N2MzYTMwNTFlODI3YjIvY2hhcHRlci05MC8xNDViM2ZjOWE5ZmVfMTYuanBn");
        // https://s7.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-90/d2590fc74697_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zNy50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMWRlNDJmMTRhZTI4NWU1YWU1N2MzYTMwNTFlODI3YjIvY2hhcHRlci05MC9kMjU5MGZjNzQ2OTdfMTcuanBn");
    }
}

