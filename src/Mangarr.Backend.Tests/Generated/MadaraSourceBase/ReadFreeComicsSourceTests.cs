using System.Collections;

namespace Mangarr.Backend.Tests;

public class ReadFreeComicsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "readfreecomics";

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
        // https://readfreecomics.com/webtoon-comic/shiboritoranaide-onna-shounin-san/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4v");
        // https://readfreecomics.com/webtoon-comic/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy90aGUtc3Rvcnktb2YtaG93LWktZ290LXRvZ2V0aGVyLXdpdGgtdGhlLW1hbmFnZXItb24tY2hyaXN0bWFzLw==");
        // https://readfreecomics.com/webtoon-comic/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy90aGUtZXh0cmFzLWFjYWRlbXktc3Vydml2YWwtZ3VpZGUv");
        // https://readfreecomics.com/webtoon-comic/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy90aGUtY3Jvd24tcHJpbmNlLXRoYXQtc2VsbHMtbWVkaWNpbmUv");
        // https://readfreecomics.com/webtoon-comic/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://readfreecomics.com/webtoon-comic/shiboritoranaide-onna-shounin-san/chapter-45-1/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci00NS0xLw==");
        // https://readfreecomics.com/webtoon-comic/shiboritoranaide-onna-shounin-san/chapter-41-5/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci00MS01Lw==");
        // https://readfreecomics.com/webtoon-comic/shiboritoranaide-onna-shounin-san/chapter-25-1/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0yNS0xLw==");
        // https://readfreecomics.com/webtoon-comic/shiboritoranaide-onna-shounin-san/chapter-39-1/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0zOS0xLw==");
        // https://readfreecomics.com/webtoon-comic/shiboritoranaide-onna-shounin-san/chapter-31-2/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZnJlZWNvbWljcy5jb20vd2VidG9vbi1jb21pYy9zaGlib3JpdG9yYW5haWRlLW9ubmEtc2hvdW5pbi1zYW4vY2hhcHRlci0zMS0yLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://images.hentaimanga.me/manga_659092f216e07/chapter-39-1/14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuaGVudGFpbWFuZ2EubWUvbWFuZ2FfNjU5MDkyZjIxNmUwNy9jaGFwdGVyLTM5LTEvMTQuanBn");
        // https://images.hentaimanga.me/manga_659092f216e07/chapter-39-1/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuaGVudGFpbWFuZ2EubWUvbWFuZ2FfNjU5MDkyZjIxNmUwNy9jaGFwdGVyLTM5LTEvMDIuanBn");
        // https://images.hentaimanga.me/manga_659092f216e07/chapter-41-5/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuaGVudGFpbWFuZ2EubWUvbWFuZ2FfNjU5MDkyZjIxNmUwNy9jaGFwdGVyLTQxLTUvMy5qcGc=");
        // https://images.hentaimanga.me/manga_659092f216e07/chapter-39-1/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuaGVudGFpbWFuZ2EubWUvbWFuZ2FfNjU5MDkyZjIxNmUwNy9jaGFwdGVyLTM5LTEvMDUuanBn");
        // https://images.hentaimanga.me/manga_659092f216e07/chapter-25-1/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuaGVudGFpbWFuZ2EubWUvbWFuZ2FfNjU5MDkyZjIxNmUwNy9jaGFwdGVyLTI1LTEvMDQuanBn");
    }
}

