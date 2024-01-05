using System.Collections;

namespace Mangarr.Backend.Tests;

public class TooniTubeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "toonitube";

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
        // https://toonitube.com/sister-neighbors
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL3Npc3Rlci1uZWlnaGJvcnN8c2lzdGVyLW5laWdoYm9ycw==");
        // https://toonitube.com/a-wonderful-new-world
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZHxhLXdvbmRlcmZ1bC1uZXctd29ybGQ=");
        // https://toonitube.com/weak-point
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL3dlYWstcG9pbnR8d2Vhay1wb2ludA==");
        // https://toonitube.com/lucky-guy
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2x1Y2t5LWd1eXxsdWNreS1ndXk=");
        // https://toonitube.com/learning-the-hard-way
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2xlYXJuaW5nLXRoZS1oYXJkLXdheXxsZWFybmluZy10aGUtaGFyZC13YXk=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://toonitube.com/a-wonderful-new-world/chapter-39
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTM5");
        // https://toonitube.com/sister-neighbors/chapter-3
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL3Npc3Rlci1uZWlnaGJvcnMvY2hhcHRlci0z");
        // https://toonitube.com/a-wonderful-new-world/chapter-52
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTUy");
        // https://toonitube.com/weak-point/chapter-53
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL3dlYWstcG9pbnQvY2hhcHRlci01Mw==");
        // https://toonitube.com/a-wonderful-new-world/chapter-212
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTIxMg==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s14.toonilycdnv2.xyz/toonily/manga/080de9a0f41010d495a8e8d31a7f3738/chapter-3/728e4cae5846_19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTQudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzA4MGRlOWEwZjQxMDEwZDQ5NWE4ZThkMzFhN2YzNzM4L2NoYXB0ZXItMy83MjhlNGNhZTU4NDZfMTkuanBn");
        // https://s19.toonilycdnv2.xyz/toonily/manga/080de9a0f41010d495a8e8d31a7f3738/chapter-3/80fcaf4a22d1_24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTkudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzA4MGRlOWEwZjQxMDEwZDQ5NWE4ZThkMzFhN2YzNzM4L2NoYXB0ZXItMy84MGZjYWY0YTIyZDFfMjQuanBn");
        // https://s2.toonilycdnv2.xyz/toonily/manga/080de9a0f41010d495a8e8d31a7f3738/chapter-3/bc4b561823eb_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMi50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMDgwZGU5YTBmNDEwMTBkNDk1YThlOGQzMWE3ZjM3MzgvY2hhcHRlci0zL2JjNGI1NjE4MjNlYl83LmpwZw==");
        // https://s18.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-53/75cde5d84ebb_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTgudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzVhZDdkYWRkYzY5ZWZkNzVlMDg3MGQzMTI5MjNmYmQ2L2NoYXB0ZXItNTMvNzVjZGU1ZDg0ZWJiXzEuanBn");
        // https://s17.toonilycdnv2.xyz/toonily/manga/080de9a0f41010d495a8e8d31a7f3738/chapter-3/1d652c47caa5_2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTcudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzA4MGRlOWEwZjQxMDEwZDQ5NWE4ZThkMzFhN2YzNzM4L2NoYXB0ZXItMy8xZDY1MmM0N2NhYTVfMi5qcGc=");
    }
}

