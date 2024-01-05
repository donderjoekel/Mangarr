using System.Collections;

namespace Mangarr.Backend.Tests;

public class ToonilyDotmeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "toonily.me";

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
        // https://toonily.me/weak-point/chapter-34
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3dlYWstcG9pbnQvY2hhcHRlci0zNA==");
        // https://toonily.me/weak-point/chapter-32
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL3dlYWstcG9pbnQvY2hhcHRlci0zMg==");
        // https://toonily.me/a-wonderful-new-world/chapter-162
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2Etd29uZGVyZnVsLW5ldy13b3JsZC9jaGFwdGVyLTE2Mg==");
        // https://toonily.me/lucky-guy/chapter-71-the-end
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2x1Y2t5LWd1eS9jaGFwdGVyLTcxLXRoZS1lbmQ=");
        // https://toonily.me/lucky-guy/chapter-15
        yield return new TestCaseData("aHR0cHM6Ly90b29uaWx5Lm1lL2x1Y2t5LWd1eS9jaGFwdGVyLTE1");
    }

    public static IEnumerable ValidImages()
    {
        // https://s10.toonilycdnv2.xyz/toonily/manga/2f4acb7e2c0f3e45a128f9ad110bb13c/chapter-15/f3a740329482_30.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTAudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzJmNGFjYjdlMmMwZjNlNDVhMTI4ZjlhZDExMGJiMTNjL2NoYXB0ZXItMTUvZjNhNzQwMzI5NDgyXzMwLmpwZw==");
        // https://s17.toonilycdnv2.xyz/toonily/manga/4c096a11aa6c2696ecab630a062fb8f6/chapter-162/bda86f213cc3_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTcudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzRjMDk2YTExYWE2YzI2OTZlY2FiNjMwYTA2MmZiOGY2L2NoYXB0ZXItMTYyL2JkYTg2ZjIxM2NjM18xNC5qcGc=");
        // https://s14.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-32/565aa709a84c_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMTQudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzVhZDdkYWRkYzY5ZWZkNzVlMDg3MGQzMTI5MjNmYmQ2L2NoYXB0ZXItMzIvNTY1YWE3MDlhODRjXzQuanBn");
        // https://s7.toonilycdnv2.xyz/toonily/manga/5ad7daddc69efd75e0870d312923fbd6/chapter-34/dcd0f1c3673f_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zNy50b29uaWx5Y2RudjIueHl6L3Rvb25pbHkvbWFuZ2EvNWFkN2RhZGRjNjllZmQ3NWUwODcwZDMxMjkyM2ZiZDYvY2hhcHRlci0zNC9kY2QwZjFjMzY3M2ZfMTQuanBn");
        // https://s20.toonilycdnv2.xyz/toonily/manga/4c096a11aa6c2696ecab630a062fb8f6/chapter-162/565d891cfafb_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMjAudG9vbmlseWNkbnYyLnh5ei90b29uaWx5L21hbmdhLzRjMDk2YTExYWE2YzI2OTZlY2FiNjMwYTA2MmZiOGY2L2NoYXB0ZXItMTYyLzU2NWQ4OTFjZmFmYl8xNy5qcGc=");
    }
}

