using System.Collections;

namespace Mangarr.Backend.Tests;

public class PornComixSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "porncomix";

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
        // https://www.porncomixonline.net/m-comic/sandlust-big-brother-part-17/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3NhbmRsdXN0LWJpZy1icm90aGVyLXBhcnQtMTcv");
        // https://www.porncomixonline.net/m-comic/piratesofthecoalsack-16-18/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3BpcmF0ZXNvZnRoZWNvYWxzYWNrLTE2LTE4Lw==");
        // https://www.porncomixonline.net/m-comic/blacknwhitecomics-black-devotion/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL2JsYWNrbndoaXRlY29taWNzLWJsYWNrLWRldm90aW9uLw==");
        // https://www.porncomixonline.net/m-comic/rocketmanatee-viola-and-penny/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3JvY2tldG1hbmF0ZWUtdmlvbGEtYW5kLXBlbm55Lw==");
        // https://www.porncomixonline.net/m-comic/healers-aoin-no-junreibi/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL2hlYWxlcnMtYW9pbi1uby1qdW5yZWliaS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.porncomixonline.net/m-comic/sandlust-big-brother-part-17/sandlust-big-brother-part-26/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3NhbmRsdXN0LWJpZy1icm90aGVyLXBhcnQtMTcvc2FuZGx1c3QtYmlnLWJyb3RoZXItcGFydC0yNi8=");
        // https://www.porncomixonline.net/m-comic/piratesofthecoalsack-16-18/dangerouslines-pirates-of-the-coal-sack-22/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3BpcmF0ZXNvZnRoZWNvYWxzYWNrLTE2LTE4L2Rhbmdlcm91c2xpbmVzLXBpcmF0ZXMtb2YtdGhlLWNvYWwtc2Fjay0yMi8=");
        // https://www.porncomixonline.net/m-comic/piratesofthecoalsack-16-18/dangerouslines-pirates-of-the-coal-sack-19/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3BpcmF0ZXNvZnRoZWNvYWxzYWNrLTE2LTE4L2Rhbmdlcm91c2xpbmVzLXBpcmF0ZXMtb2YtdGhlLWNvYWwtc2Fjay0xOS8=");
        // https://www.porncomixonline.net/m-comic/piratesofthecoalsack-16-18/dangerouslines-pirates-of-the-coal-sack-20/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3BpcmF0ZXNvZnRoZWNvYWxzYWNrLTE2LTE4L2Rhbmdlcm91c2xpbmVzLXBpcmF0ZXMtb2YtdGhlLWNvYWwtc2Fjay0yMC8=");
        // https://www.porncomixonline.net/m-comic/sandlust-big-brother-part-17/sandlust-big-brother-part-21/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9tLWNvbWljL3NhbmRsdXN0LWJpZy1icm90aGVyLXBhcnQtMTcvc2FuZGx1c3QtYmlnLWJyb3RoZXItcGFydC0yMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://www.porncomixonline.net/pics/WP-manga/data/manga_61fbeb7f3304c/825b281062260fe707bccea835b191d2/0063e1b0ed0436e.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9waWNzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjFmYmViN2YzMzA0Yy84MjViMjgxMDYyMjYwZmU3MDdiY2NlYTgzNWIxOTFkMi8wMDYzZTFiMGVkMDQzNmUuanBn");
        // https://www.porncomixonline.net/pics/WP-manga/data/manga_61fbeb7f3304c/7d0c4a3f8889beeb8c3593afd93f57db/00.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9waWNzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjFmYmViN2YzMzA0Yy83ZDBjNGEzZjg4ODliZWViOGMzNTkzYWZkOTNmNTdkYi8wMC5qcGc=");
        // https://www.porncomixonline.net/pics/WP-manga/data/manga_618a786de23b1/c81a6c22c12cff9c2fcd6a8bceb3ff7f/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9waWNzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjE4YTc4NmRlMjNiMS9jODFhNmMyMmMxMmNmZjljMmZjZDZhOGJjZWIzZmY3Zi8wMDEuanBn");
        // https://www.porncomixonline.net/pics/WP-manga/data/manga_61fbeb7f3304c/542d177b384361746e8f497b4d97806e/Pirates-of-the-Coal-Sack-19--DangerousLines-(1).jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9waWNzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjFmYmViN2YzMzA0Yy81NDJkMTc3YjM4NDM2MTc0NmU4ZjQ5N2I0ZDk3ODA2ZS9QaXJhdGVzLW9mLXRoZS1Db2FsLVNhY2stMTktLURhbmdlcm91c0xpbmVzLSgxKS5qcGc=");
        // https://www.porncomixonline.net/pics/WP-manga/data/manga_618a786de23b1/1c907703712bdd9634772cd5b26b40cb/BB26-Page_01.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucG9ybmNvbWl4b25saW5lLm5ldC9waWNzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjE4YTc4NmRlMjNiMS8xYzkwNzcwMzcxMmJkZDk2MzQ3NzJjZDViMjZiNDBjYi9CQjI2LVBhZ2VfMDEuanBn");
    }
}

