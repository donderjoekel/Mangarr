using System.Collections;

namespace Mangarr.Backend.Tests;

public class ToonilyMeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "toonilyme";

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
        // https://toonily.me/sister-neighbors
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3Npc3Rlci1uZWlnaGJvcnN8c2lzdGVyLW5laWdoYm9ycw==");
        // https://toonily.me/a-wonderful-new-world
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2Etd29uZGVyZnVsLW5ldy13b3JsZHxhLXdvbmRlcmZ1bC1uZXctd29ybGQ=");
        // https://toonily.me/weak-point
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3dlYWstcG9pbnR8d2Vhay1wb2ludA==");
        // https://toonily.me/lucky-guy
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2x1Y2t5LWd1eXxsdWNreS1ndXk=");
        // https://toonily.me/learning-the-hard-way
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2xlYXJuaW5nLXRoZS1oYXJkLXdheXxsZWFybmluZy10aGUtaGFyZC13YXk=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://toonily.me/sister-neighbors/chapter-87
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3Npc3Rlci1uZWlnaGJvcnMvY2hhcHRlci04Nw==");
        // https://toonily.me/learning-the-hard-way/chapter-74
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2xlYXJuaW5nLXRoZS1oYXJkLXdheS9jaGFwdGVyLTc0");
        // https://toonily.me/a-wonderful-new-world/chapter-18
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTE4");
        // https://toonily.me/lucky-guy/chapter-25
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2x1Y2t5LWd1eS9jaGFwdGVyLTI1");
        // https://toonily.me/lucky-guy/chapter-15
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2x1Y2t5LWd1eS9jaGFwdGVyLTE1");
    }

    public static IEnumerable ValidImages()
    {
        // https://s17.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-15/9a153bab1625_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTcudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzJmNGFjYjdlMmMwZjNlNDVhMTI4ZjlhZDExMGJiMTNjL2NoYXB0ZXItMTUvOWExNTNiYWIxNjI1XzE3LmpwZw==");
        // https://s2.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-74/d3b01624001d_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMi50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMWRlNDJmMTRhZTI4NWU1YWU1N2MzYTMwNTFlODI3YjIvY2hhcHRlci03NC9kM2IwMTYyNDAwMWRfMTAuanBn");
        // https://s19.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-15/8a5049705d8f_19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTkudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzJmNGFjYjdlMmMwZjNlNDVhMTI4ZjlhZDExMGJiMTNjL2NoYXB0ZXItMTUvOGE1MDQ5NzA1ZDhmXzE5LmpwZw==");
        // https://s10.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-74/814fc3612e0a_18.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTAudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzFkZTQyZjE0YWUyODVlNWFlNTdjM2EzMDUxZTgyN2IyL2NoYXB0ZXItNzQvODE0ZmMzNjEyZTBhXzE4LmpwZw==");
        // https://s12.toonilycdnv2.xyz/toonily/manga/1de42f14ae285e5ae57c3a3051e827b2/chapter-74/e9618347f7aa_20.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTIudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzFkZTQyZjE0YWUyODVlNWFlNTdjM2EzMDUxZTgyN2IyL2NoYXB0ZXItNzQvZTk2MTgzNDdmN2FhXzIwLmpwZw==");
    }
}

