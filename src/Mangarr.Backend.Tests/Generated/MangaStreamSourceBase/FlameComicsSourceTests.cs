using System.Collections;

namespace Mangarr.Backend.Tests;

public class FlameComicsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "flamecomics";

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
        // https://flamecomics.com/series/star-fostered-swordmaster/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc2VyaWVzL3N0YXItZm9zdGVyZWQtc3dvcmRtYXN0ZXIv");
        // https://flamecomics.com/series/insanely-talented-player/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc2VyaWVzL2luc2FuZWx5LXRhbGVudGVkLXBsYXllci8=");
        // https://flamecomics.com/series/baek-clans-terminally-ill-young-master/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc2VyaWVzL2JhZWstY2xhbnMtdGVybWluYWxseS1pbGwteW91bmctbWFzdGVyLw==");
        // https://flamecomics.com/series/academys-genius-swordsman/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc2VyaWVzL2FjYWRlbXlzLWdlbml1cy1zd29yZHNtYW4v");
        // https://flamecomics.com/series/the-god-of-war-who-regressed-to-level-2/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc2VyaWVzL3RoZS1nb2Qtb2Ytd2FyLXdoby1yZWdyZXNzZWQtdG8tbGV2ZWwtMi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://flamecomics.com/the-god-of-war-who-regressed-to-level-2-chapter-37/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vdGhlLWdvZC1vZi13YXItd2hvLXJlZ3Jlc3NlZC10by1sZXZlbC0yLWNoYXB0ZXItMzcv");
        // https://flamecomics.com/academys-genius-swordsman-chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYWNhZGVteXMtZ2VuaXVzLXN3b3Jkc21hbi1jaGFwdGVyLTI5Lw==");
        // https://flamecomics.com/insanely-talented-player-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vaW5zYW5lbHktdGFsZW50ZWQtcGxheWVyLWNoYXB0ZXItMS8=");
        // https://flamecomics.com/star-fostered-swordmaster-chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc3Rhci1mb3N0ZXJlZC1zd29yZG1hc3Rlci1jaGFwdGVyLTgv");
        // https://flamecomics.com/star-fostered-swordmaster-chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc3Rhci1mb3N0ZXJlZC1zd29yZG1hc3Rlci1jaGFwdGVyLTEwLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://flamecomics.com/wp-content/uploads/2023/09/SFS_11-2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvU0ZTXzExLTIuanBn");
        // https://flamecomics.com/wp-content/uploads/2023/12/AGS_29_00.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQUdTXzI5XzAwLmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2023/10/SFS_06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvU0ZTXzA2LmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2023/09/CAUGHT_UP_WITH_THE_RAWS-1-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvQ0FVR0hUX1VQX1dJVEhfVEhFX1JBV1MtMS0xLmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2023/12/AGS_29_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQUdTXzI5XzE0LmpwZw==");
    }
}

