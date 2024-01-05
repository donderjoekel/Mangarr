using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaFreakDotonlineSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangafreak.online";

    public static IEnumerable ValidSearchResults()
    {
        yield return new TestCaseData("i");
        yield return new TestCaseData("o");
        yield return new TestCaseData("u");
    }

    public static IEnumerable ValidChapterLists()
    {
        // https://mangafreak.online/manga/solo-login/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9zb2xvLWxvZ2luLw==");
        // https://mangafreak.online/manga/adelines-twilight/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9hZGVsaW5lcy10d2lsaWdodC8=");
        // https://mangafreak.online/manga/reaper-of-the-drifting-moon/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9yZWFwZXItb2YtdGhlLWRyaWZ0aW5nLW1vb24v");
        // https://mangafreak.online/manga/to-face-the-tiger/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS90by1mYWNlLXRoZS10aWdlci8=");
        // https://mangafreak.online/manga/catastrophic-necromancer/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9jYXRhc3Ryb3BoaWMtbmVjcm9tYW5jZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangafreak.online/manga/solo-login/chapter-95/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9zb2xvLWxvZ2luL2NoYXB0ZXItOTUv");
        // https://mangafreak.online/manga/solo-login/chapter-60/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9zb2xvLWxvZ2luL2NoYXB0ZXItNjAv");
        // https://mangafreak.online/manga/to-face-the-tiger/chapter-26/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS90by1mYWNlLXRoZS10aWdlci9jaGFwdGVyLTI2Lw==");
        // https://mangafreak.online/manga/reaper-of-the-drifting-moon/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9yZWFwZXItb2YtdGhlLWRyaWZ0aW5nLW1vb24vY2hhcHRlci0xMC8=");
        // https://mangafreak.online/manga/solo-login/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZyZWFrLm9ubGluZS9tYW5nYS9zb2xvLWxvZ2luL2NoYXB0ZXItMy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s1.cdn-manga.com/files/WP-manga/data/4398/fe1f203045d0a2eb6c07a459f7b74149/19-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDM5OC9mZTFmMjAzMDQ1ZDBhMmViNmMwN2E0NTlmN2I3NDE0OS8xOS1vLmpwZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/4689/2ce741988a5c42370731b5bd0ed4d6c5/54.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDY4OS8yY2U3NDE5ODhhNWM0MjM3MDczMWI1YmQwZWQ0ZDZjNS81NC5qcGVn");
        // https://s1.cdn-manga.com/files/WP-manga/data/4689/2ce741988a5c42370731b5bd0ed4d6c5/155.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDY4OS8yY2U3NDE5ODhhNWM0MjM3MDczMWI1YmQwZWQ0ZDZjNS8xNTUuanBlZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/4689/2ce741988a5c42370731b5bd0ed4d6c5/126.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDY4OS8yY2U3NDE5ODhhNWM0MjM3MDczMWI1YmQwZWQ0ZDZjNS8xMjYuanBlZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/634/9283cf27051bcfc348361d41a0d8265d/6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNjM0LzkyODNjZjI3MDUxYmNmYzM0ODM2MWQ0MWEwZDgyNjVkLzYuanBn");
    }
}

