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
        // https://toonitube.com/lucky-guy/chapter-73-special-episode-2
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2x1Y2t5LWd1eS9jaGFwdGVyLTczLXNwZWNpYWwtZXBpc29kZS0y");
        // https://toonitube.com/lucky-guy/chapter-22
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2x1Y2t5LWd1eS9jaGFwdGVyLTIy");
        // https://toonitube.com/weak-point/chapter-48
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL3dlYWstcG9pbnQvY2hhcHRlci00OA==");
        // https://toonitube.com/weak-point/chapter-54
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL3dlYWstcG9pbnQvY2hhcHRlci01NA==");
        // https://toonitube.com/learning-the-hard-way/chapter-12
        yield return new TestCaseData("aHR0cHM6Ly90b29uaXR1YmUuY29tL2xlYXJuaW5nLXRoZS1oYXJkLXdheS9jaGFwdGVyLTEy");
    }

    public static IEnumerable ValidImages()
    {
        // https://s11.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-22/2cd551a40510_20.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTEudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzJmNGFjYjdlMmMwZjNlNDVhMTI4ZjlhZDExMGJiMTNjL2NoYXB0ZXItMjIvMmNkNTUxYTQwNTEwXzIwLmpwZw==");
        // https://s16.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-73-special-episode-2/2ba3f8e52403_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTYudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzJmNGFjYjdlMmMwZjNlNDVhMTI4ZjlhZDExMGJiMTNjL2NoYXB0ZXItNzMtc3BlY2lhbC1lcGlzb2RlLTIvMmJhM2Y4ZTUyNDAzXzQuanBn");
        // https://s6.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-22/1fd5721087f6_15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zNi50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMmY0YWNiN2UyYzBmM2U0NWExMjhmOWFkMTEwYmIxM2MvY2hhcHRlci0yMi8xZmQ1NzIxMDg3ZjZfMTUuanBn");
        // https://s8.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-73-special-episode-2/76eea4c0fec1_16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zOC50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvMmY0YWNiN2UyYzBmM2U0NWExMjhmOWFkMTEwYmIxM2MvY2hhcHRlci03My1zcGVjaWFsLWVwaXNvZGUtMi83NmVlYTRjMGZlYzFfMTYuanBn");
        // https://s3.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-54/c9f22d7d5d97_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMy50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvNWFkN2RhZGRjNjllZmQ3NWUwODcwZDMxMjkyM2ZiZDYvY2hhcHRlci01NC9jOWYyMmQ3ZDVkOTdfMS5qcGc=");
    }
}

