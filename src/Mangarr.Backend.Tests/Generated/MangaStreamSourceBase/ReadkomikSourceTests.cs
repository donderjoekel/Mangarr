using System.Collections;

namespace Mangarr.Backend.Tests;

public class ReadkomikSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "readkomik";

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
        // https://readkomik.com/manga/i-rely-on-my-invincibility-to-deal-tons-of-damage-passively/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21hbmdhL2ktcmVseS1vbi1teS1pbnZpbmNpYmlsaXR5LXRvLWRlYWwtdG9ucy1vZi1kYW1hZ2UtcGFzc2l2ZWx5Lw==");
        // https://readkomik.com/manga/return-of-top-class-master/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21hbmdhL3JldHVybi1vZi10b3AtY2xhc3MtbWFzdGVyLw==");
        // https://readkomik.com/manga/the-iron-blooded-necromancer-has-returned/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21hbmdhL3RoZS1pcm9uLWJsb29kZWQtbmVjcm9tYW5jZXItaGFzLXJldHVybmVkLw==");
        // https://readkomik.com/manga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3Mv");
        // https://readkomik.com/manga/0-kill-assassine/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21hbmdhLzAta2lsbC1hc3Nhc3NpbmUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://readkomik.com/mdpalfb-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21kcGFsZmItY2hhcHRlci03Lw==");
        // https://readkomik.com/mdpalfb-chapter-14/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21kcGFsZmItY2hhcHRlci0xNC8=");
        // https://readkomik.com/ibnr-chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2libnItY2hhcHRlci0xMy8=");
        // https://readkomik.com/ibnr-chapter-31/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL2libnItY2hhcHRlci0zMS8=");
        // https://readkomik.com/mdpalfb-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFka29taWsuY29tL21kcGFsZmItY2hhcHRlci0yLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://rkscans.com/wp-content/uploads/2024/01/MDPALFB-14__6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9NRFBBTEZCLTE0X182LmpwZw==");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-13__4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTEzX180LmpwZw==");
        // https://rkscans.com/wp-content/uploads/2024/01/IBNR-13__10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9JQk5SLTEzX18xMC5qcGc=");
        // https://rkscans.com/wp-content/uploads/2024/01/MDPALFB-02__1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9NRFBBTEZCLTAyX18xLmpwZw==");
        // https://rkscans.com/wp-content/uploads/2024/01/MDPALFB-02__3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ya3NjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvMjAyNC8wMS9NRFBBTEZCLTAyX18zLmpwZw==");
    }
}

