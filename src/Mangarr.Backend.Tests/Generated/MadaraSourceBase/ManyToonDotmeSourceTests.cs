using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManyToonDotmeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manytoon.me";

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
        // https://manytoon.me/manhwa/shiboritoranaide-onna-shounin-san-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLTIv");
        // https://manytoon.me/manhwa/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2EvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://manytoon.me/manhwa/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2EvdGhlLWV4dHJhcy1hY2FkZW15LXN1cnZpdmFsLWd1aWRlLw==");
        // https://manytoon.me/manhwa/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2EvdGhlLWNyb3duLXByaW5jZS10aGF0LXNlbGxzLW1lZGljaW5lLw==");
        // https://manytoon.me/manhwa/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2EvbWVhdC1kb2xsLXdvcmtzaG9wLWluLWFub3RoZXItd29ybGQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manytoon.me/manhwa/the-crown-prince-that-sells-medicine/chapter-01/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2EvdGhlLWNyb3duLXByaW5jZS10aGF0LXNlbGxzLW1lZGljaW5lL2NoYXB0ZXItMDEv");
        // https://manytoon.me/manhwa/shiboritoranaide-onna-shounin-san-2/chapter-37-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLTIvY2hhcHRlci0zNy0xLw==");
        // https://manytoon.me/manhwa/shiboritoranaide-onna-shounin-san-2/chapter-15-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLTIvY2hhcHRlci0xNS01Lw==");
        // https://manytoon.me/manhwa/shiboritoranaide-onna-shounin-san-2/chapter-32-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLTIvY2hhcHRlci0zMi0yLw==");
        // https://manytoon.me/manhwa/shiboritoranaide-onna-shounin-san-2/chapter-18-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5tZS9tYW5od2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLTIvY2hhcHRlci0xOC01Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // http://images.hentaimanga.me/manga_658ed0efab8b6/chapter-01/02.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NThlZDBlZmFiOGI2L2NoYXB0ZXItMDEvMDIuanBn");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-37-1/09.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMzctMS8wOS5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-32-2/13.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMzItMi8xMy5qcGc=");
        // http://images.hentaimanga.me/manga_659092f216e07/chapter-18-5/2.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NTkwOTJmMjE2ZTA3L2NoYXB0ZXItMTgtNS8yLmpwZw==");
        // http://images.hentaimanga.me/manga_658ed0efab8b6/chapter-01/01.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82NThlZDBlZmFiOGI2L2NoYXB0ZXItMDEvMDEuanBn");
    }
}

