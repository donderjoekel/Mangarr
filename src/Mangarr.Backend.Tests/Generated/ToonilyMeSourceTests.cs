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
        // https://toonily.me/sister-neighbors/chapter-73
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3Npc3Rlci1uZWlnaGJvcnMvY2hhcHRlci03Mw==");
        // https://toonily.me/a-wonderful-new-world/chapter-133
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTEzMw==");
        // https://toonily.me/weak-point/chapter-35
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3dlYWstcG9pbnQvY2hhcHRlci0zNQ==");
        // https://toonily.me/a-wonderful-new-world/chapter-93
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTkz");
        // https://toonily.me/a-wonderful-new-world/chapter-81
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTgx");
    }

    public static IEnumerable ValidImages()
    {
        // https://s20.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-35/7d7df66c146a_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMjAudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzVhZDdkYWRkYzY5ZWZkNzVlMDg3MGQzMTI5MjNmYmQ2L2NoYXB0ZXItMzUvN2Q3ZGY2NmMxNDZhXzE0LmpwZw==");
        // https://s2.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-35/ffec2348d91a_16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMi50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvNWFkN2RhZGRjNjllZmQ3NWUwODcwZDMxMjkyM2ZiZDYvY2hhcHRlci0zNS9mZmVjMjM0OGQ5MWFfMTYuanBn");
        // https://s11.toonilycdnv2.xyz/toonily/manga/4c096a11aa6c2696ecab630a062fb8f6/chapter-133/bf91a6d3abfa_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTEudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzRjMDk2YTExYWE2YzI2OTZlY2FiNjMwYTA2MmZiOGY2L2NoYXB0ZXItMTMzL2JmOTFhNmQzYWJmYV81LmpwZw==");
        // https://s18.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-35/5fa975daa506_32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTgudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzVhZDdkYWRkYzY5ZWZkNzVlMDg3MGQzMTI5MjNmYmQ2L2NoYXB0ZXItMzUvNWZhOTc1ZGFhNTA2XzMyLmpwZw==");
        // https://s7.toonilycdnv2.xyz/toonily/manga/4c096a11aa6c2696ecab630a062fb8f6/chapter-133/d2f0b2cd50e3_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zNy50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvNGMwOTZhMTFhYTZjMjY5NmVjYWI2MzBhMDYyZmI4ZjYvY2hhcHRlci0xMzMvZDJmMGIyY2Q1MGUzXzEuanBn");
    }
}

