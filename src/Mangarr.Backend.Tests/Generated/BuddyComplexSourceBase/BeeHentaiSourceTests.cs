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
        // https://beehentai.com/sister-neighbors/chapter-158
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3Npc3Rlci1uZWlnaGJvcnMvY2hhcHRlci0xNTg=");
        // https://beehentai.com/learning-the-hard-way/chapter-71
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2xlYXJuaW5nLXRoZS1oYXJkLXdheS9jaGFwdGVyLTcx");
        // https://beehentai.com/weak-point/chapter-111
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3dlYWstcG9pbnQvY2hhcHRlci0xMTE=");
        // https://beehentai.com/learning-the-hard-way/chapter-18
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL2xlYXJuaW5nLXRoZS1oYXJkLXdheS9jaGFwdGVyLTE4");
        // https://beehentai.com/sister-neighbors/chapter-77
        yield return new TestCaseData("aHR0cHM6Ly9iZWVoZW50YWkuY29tL3Npc3Rlci1uZWlnaGJvcnMvY2hhcHRlci03Nw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s2.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-18/e929ab1c502b_54.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMi50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMWRlNDJmMTRhZTI4NWU1YWU1N2MzYTMwNTFlODI3YjIvY2hhcHRlci0xOC9lOTI5YWIxYzUwMmJfNTQuanBn");
        // https://s16.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-18/dc6e888ca6e2_28.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTYudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzFkZTQyZjE0YWUyODVlNWFlNTdjM2EzMDUxZTgyN2IyL2NoYXB0ZXItMTgvZGM2ZTg4OGNhNmUyXzI4LmpwZw==");
        // https://s3.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-71/0b7bdd7815e4_44.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMy50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMWRlNDJmMTRhZTI4NWU1YWU1N2MzYTMwNTFlODI3YjIvY2hhcHRlci03MS8wYjdiZGQ3ODE1ZTRfNDQuanBn");
        // https://s1.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-18/ab5b3869afdb_33.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMWRlNDJmMTRhZTI4NWU1YWU1N2MzYTMwNTFlODI3YjIvY2hhcHRlci0xOC9hYjViMzg2OWFmZGJfMzMuanBn");
        // https://s19.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-71/6b8348049bff_20.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTkudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzFkZTQyZjE0YWUyODVlNWFlNTdjM2EzMDUxZTgyN2IyL2NoYXB0ZXItNzEvNmI4MzQ4MDQ5YmZmXzIwLmpwZw==");
    }
}

