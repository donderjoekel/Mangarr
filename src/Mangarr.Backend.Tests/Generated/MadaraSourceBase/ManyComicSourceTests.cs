using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManyComicSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manycomic";

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
        // https://manycomic.com/comic/shiboritoranaide-onna-shounin-san/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3NoaWJvcml0b3JhbmFpZGUtb25uYS1zaG91bmluLXNhbi8=");
        // https://manycomic.com/comic/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3RoZS1zdG9yeS1vZi1ob3ctaS1nb3QtdG9nZXRoZXItd2l0aC10aGUtbWFuYWdlci1vbi1jaHJpc3RtYXMv");
        // https://manycomic.com/comic/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3RoZS1leHRyYXMtYWNhZGVteS1zdXJ2aXZhbC1ndWlkZS8=");
        // https://manycomic.com/comic/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3RoZS1jcm93bi1wcmluY2UtdGhhdC1zZWxscy1tZWRpY2luZS8=");
        // https://manycomic.com/comic/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL21lYXQtZG9sbC13b3Jrc2hvcC1pbi1hbm90aGVyLXdvcmxkLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manycomic.com/comic/shiboritoranaide-onna-shounin-san/chapter-19-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3NoaWJvcml0b3JhbmFpZGUtb25uYS1zaG91bmluLXNhbi9jaGFwdGVyLTE5LTUv");
        // https://manycomic.com/comic/shiboritoranaide-onna-shounin-san/chapter-14-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3NoaWJvcml0b3JhbmFpZGUtb25uYS1zaG91bmluLXNhbi9jaGFwdGVyLTE0LTIv");
        // https://manycomic.com/comic/shiboritoranaide-onna-shounin-san/chapter-14-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3NoaWJvcml0b3JhbmFpZGUtb25uYS1zaG91bmluLXNhbi9jaGFwdGVyLTE0LTEv");
        // https://manycomic.com/comic/the-extras-academy-survival-guide/chapter-06/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3RoZS1leHRyYXMtYWNhZGVteS1zdXJ2aXZhbC1ndWlkZS9jaGFwdGVyLTA2Lw==");
        // https://manycomic.com/comic/shiboritoranaide-onna-shounin-san/chapter-39-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55Y29taWMuY29tL2NvbWljL3NoaWJvcml0b3JhbmFpZGUtb25uYS1zaG91bmluLXNhbi9jaGFwdGVyLTM5LTIv");
    }

    public static IEnumerable ValidImages()
    {
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-14-2/02.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTQtMi8wMi5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-39-2/13.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMzktMi8xMy5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-39-2/28.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMzktMi8yOC5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-19-5/2.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTktNS8yLmpwZw==");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-14-2/10.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTQtMi8xMC5qcGc=");
    }
}

