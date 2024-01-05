using System.Collections;

namespace Mangarr.Backend.Tests;

public class PonyMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "ponymanga";

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
        // https://ponymanga.com/manga/devil_on_the_crossroad/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2RldmlsX29uX3RoZV9jcm9zc3JvYWQv");
        // https://ponymanga.com/manga/the_empress_of_ashes/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL3RoZV9lbXByZXNzX29mX2FzaGVzLw==");
        // https://ponymanga.com/manga/chasing_lilies/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2NoYXNpbmdfbGlsaWVzLw==");
        // https://ponymanga.com/manga/my_boss_s_beastly_lush/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL215X2Jvc3Nfc19iZWFzdGx5X2x1c2gv");
        // https://ponymanga.com/manga/hate-mate/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2hhdGUtbWF0ZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://ponymanga.com/manga/the_empress_of_ashes/chapter-30/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL3RoZV9lbXByZXNzX29mX2FzaGVzL2NoYXB0ZXItMzAv");
        // https://ponymanga.com/manga/devil_on_the_crossroad/season-1-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2RldmlsX29uX3RoZV9jcm9zc3JvYWQvc2Vhc29uLTEtY2hhcHRlci0yMC8=");
        // https://ponymanga.com/manga/hate-mate/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2hhdGUtbWF0ZS9jaGFwdGVyLTEv");
        // https://ponymanga.com/manga/devil_on_the_crossroad/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2RldmlsX29uX3RoZV9jcm9zc3JvYWQvY2hhcHRlci0xOC8=");
        // https://ponymanga.com/manga/hate-mate/chapter-38/
        yield return new TestCaseData("aHR0cHM6Ly9wb255bWFuZ2EuY29tL21hbmdhL2hhdGUtbWF0ZS9jaGFwdGVyLTM4Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://image.ponymanga.com/hate_mate/chapter-38/013.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wb255bWFuZ2EuY29tL2hhdGVfbWF0ZS9jaGFwdGVyLTM4LzAxMy5qcGVn");
        // https://image.ponymanga.com/hate_mate/chapter-1/033.png
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wb255bWFuZ2EuY29tL2hhdGVfbWF0ZS9jaGFwdGVyLTEvMDMzLnBuZw==");
        // https://image.ponymanga.com/devil_on_the_crossroad/chapter-18/009.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wb255bWFuZ2EuY29tL2RldmlsX29uX3RoZV9jcm9zc3JvYWQvY2hhcHRlci0xOC8wMDkuanBn");
        // https://image.ponymanga.com/hate_mate/chapter-1/039.png
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wb255bWFuZ2EuY29tL2hhdGVfbWF0ZS9jaGFwdGVyLTEvMDM5LnBuZw==");
        // https://image.ponymanga.com/the_empress_of_ashes/chapter-30/011.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wb255bWFuZ2EuY29tL3RoZV9lbXByZXNzX29mX2FzaGVzL2NoYXB0ZXItMzAvMDExLmpwZWc=");
    }
}

