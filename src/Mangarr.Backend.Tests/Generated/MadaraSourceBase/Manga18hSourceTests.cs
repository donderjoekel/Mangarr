using System.Collections;

namespace Mangarr.Backend.Tests;

public class Manga18hSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manga18h";

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
        // https://manga18h.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sLw==");
        // https://manga18h.xyz/manga/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvbWFraW5nLWZyaWVuZHMtd2l0aC1zdHJlYW1lcnMtYnktaGFja2luZy8=");
        // https://manga18h.xyz/manga/unlock-her-heart/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvdW5sb2NrLWhlci1oZWFydC8=");
        // https://manga18h.xyz/manga/seniors-of-class-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2Evc2VuaW9ycy1vZi1jbGFzcy01Lw==");
        // https://manga18h.xyz/manga/herbal-love-story/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvaGVyYmFsLWxvdmUtc3Rvcnkv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manga18h.xyz/manga/seniors-of-class-5/chapter-44/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2Evc2VuaW9ycy1vZi1jbGFzcy01L2NoYXB0ZXItNDQv");
        // https://manga18h.xyz/manga/herbal-love-story/chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvaGVyYmFsLWxvdmUtc3RvcnkvY2hhcHRlci0yOS8=");
        // https://manga18h.xyz/manga/herbal-love-story/chapter-30/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvaGVyYmFsLWxvdmUtc3RvcnkvY2hhcHRlci0zMC8=");
        // https://manga18h.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol/chapter-26/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sL2NoYXB0ZXItMjYv");
        // https://manga18h.xyz/manga/herbal-love-story/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4aC54eXovbWFuZ2EvaGVyYmFsLWxvdmUtc3RvcnkvY2hhcHRlci0yMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img.manga18h.com/manga_b581d9ed591c4d64d1da8a4f73971e11/cfa9bdcd5946e4520066e180c3081363/35.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhX2I1ODFkOWVkNTkxYzRkNjRkMWRhOGE0ZjczOTcxZTExL2NmYTliZGNkNTk0NmU0NTIwMDY2ZTE4MGMzMDgxMzYzLzM1LmpwZw==");
        // http://hentai1.io/wp-content/uploads/WP-manga/data/manga_450ec75d1f88a9459ceb5bd11e771f04/ba6a2637a564b923d98252551d68dcef/09.jpg
        yield return new TestCaseData("aHR0cDovL2hlbnRhaTEuaW8vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNDUwZWM3NWQxZjg4YTk0NTljZWI1YmQxMWU3NzFmMDQvYmE2YTI2MzdhNTY0YjkyM2Q5ODI1MjU1MWQ2OGRjZWYvMDkuanBn");
        // http://hentai1.io/wp-content/uploads/WP-manga/data/manga_450ec75d1f88a9459ceb5bd11e771f04/707fe08232c3db544217f464d36ffd3d/05.jpg
        yield return new TestCaseData("aHR0cDovL2hlbnRhaTEuaW8vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNDUwZWM3NWQxZjg4YTk0NTljZWI1YmQxMWU3NzFmMDQvNzA3ZmUwODIzMmMzZGI1NDQyMTdmNDY0ZDM2ZmZkM2QvMDUuanBn");
        // http://hentai1.io/wp-content/uploads/WP-manga/data/manga_73ebfd6d4612edb981e83d80c64f8bef/64e2b4c1e1043b55b8995c779da8a43c/85.jpg
        yield return new TestCaseData("aHR0cDovL2hlbnRhaTEuaW8vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNzNlYmZkNmQ0NjEyZWRiOTgxZTgzZDgwYzY0ZjhiZWYvNjRlMmI0YzFlMTA0M2I1NWI4OTk1Yzc3OWRhOGE0M2MvODUuanBn");
        // https://img.manga18h.com/manga_b581d9ed591c4d64d1da8a4f73971e11/cfa9bdcd5946e4520066e180c3081363/72.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhX2I1ODFkOWVkNTkxYzRkNjRkMWRhOGE0ZjczOTcxZTExL2NmYTliZGNkNTk0NmU0NTIwMDY2ZTE4MGMzMDgxMzYzLzcyLmpwZw==");
    }
}

