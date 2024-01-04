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
        // https://flamecomics.com/academys-genius-swordsman-chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYWNhZGVteXMtZ2VuaXVzLXN3b3Jkc21hbi1jaGFwdGVyLTI5Lw==");
        // https://flamecomics.com/academys-genius-swordsman-chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYWNhZGVteXMtZ2VuaXVzLXN3b3Jkc21hbi1jaGFwdGVyLTI0Lw==");
        // https://flamecomics.com/baek-clans-terminally-ill-young-master-chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYmFlay1jbGFucy10ZXJtaW5hbGx5LWlsbC15b3VuZy1tYXN0ZXItY2hhcHRlci05Lw==");
        // https://flamecomics.com/insanely-talented-player-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vaW5zYW5lbHktdGFsZW50ZWQtcGxheWVyLWNoYXB0ZXItMS8=");
        // https://flamecomics.com/academys-genius-swordsman-chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYWNhZGVteXMtZ2VuaXVzLXN3b3Jkc21hbi1jaGFwdGVyLTE3Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://flamecomics.com/wp-content/uploads/2023/09/ITPlayer-1-13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvSVRQbGF5ZXItMS0xMy5qcGc=");
        // https://flamecomics.com/wp-content/uploads/2023/10/AGS_14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvQUdTXzE0LmpwZw==");
        // https://flamecomics.com/wp-content/uploads/2022/05/readonflamescans.png
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjIvMDUvcmVhZG9uZmxhbWVzY2Fucy5wbmc=");
        // https://flamecomics.com/wp-content/uploads/2023/09/ITPlayer-1-16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvSVRQbGF5ZXItMS0xNi5qcGc=");
        // https://flamecomics.com/wp-content/uploads/2023/12/AGS_29_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQUdTXzI5XzE3LmpwZw==");
    }
}

