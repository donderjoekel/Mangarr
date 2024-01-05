using System.Collections;

namespace Mangarr.Backend.Tests;

public class AdultWebtoonSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "adultwebtoon";

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
        // https://adultwebtoon.com/adult-webtoon/shiboritoranaide-onna-shounin-san/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLw==");
        // https://adultwebtoon.com/adult-webtoon/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://adultwebtoon.com/adult-webtoon/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vdGhlLWV4dHJhcy1hY2FkZW15LXN1cnZpdmFsLWd1aWRlLw==");
        // https://adultwebtoon.com/adult-webtoon/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vdGhlLWNyb3duLXByaW5jZS10aGF0LXNlbGxzLW1lZGljaW5lLw==");
        // https://adultwebtoon.com/adult-webtoon/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vbWVhdC1kb2xsLXdvcmtzaG9wLWluLWFub3RoZXItd29ybGQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://adultwebtoon.com/adult-webtoon/shiboritoranaide-onna-shounin-san/chapter-14-2/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMTQtMi8=");
        // https://adultwebtoon.com/adult-webtoon/shiboritoranaide-onna-shounin-san/chapter-22-5/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMjItNS8=");
        // https://adultwebtoon.com/adult-webtoon/shiboritoranaide-onna-shounin-san/chapter-36-1/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMzYtMS8=");
        // https://adultwebtoon.com/adult-webtoon/shiboritoranaide-onna-shounin-san/chapter-13-2/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMTMtMi8=");
        // https://adultwebtoon.com/adult-webtoon/shiboritoranaide-onna-shounin-san/chapter-41-1/
        yield return new TestCaseData("aHR0cHM6Ly9hZHVsdHdlYnRvb24uY29tL2FkdWx0LXdlYnRvb24vc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItNDEtMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-41-1/08.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItNDEtMS8wOC5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-22-5/5.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMjItNS81LmpwZw==");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-13-2/05.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTMtMi8wNS5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-22-5/4.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMjItNS80LmpwZw==");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-36-1/02.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMzYtMS8wMi5qcGc=");
    }
}

