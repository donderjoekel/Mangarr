using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaKissSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangakiss";

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
        // https://mangakiss.org/manga/the-officer-is-madly-in-love-with-me/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1vZmZpY2VyLWlzLW1hZGx5LWluLWxvdmUtd2l0aC1tZS8=");
        // https://mangakiss.org/manga/heroines-cynicism-increases-daily-after-rebirth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL2hlcm9pbmVzLWN5bmljaXNtLWluY3JlYXNlcy1kYWlseS1hZnRlci1yZWJpcnRoLw==");
        // https://mangakiss.org/manga/the-marriage-with-the-notoriously-rich-boss/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1tYXJyaWFnZS13aXRoLXRoZS1ub3RvcmlvdXNseS1yaWNoLWJvc3Mv");
        // https://mangakiss.org/manga/little-witch-wife-dont-run-away-from-me/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL2xpdHRsZS13aXRjaC13aWZlLWRvbnQtcnVuLWF3YXktZnJvbS1tZS8=");
        // https://mangakiss.org/manga/lonely-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL2xvbmVseS1lbXBlcm9yLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangakiss.org/manga/the-marriage-with-the-notoriously-rich-boss/chapter-82/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1tYXJyaWFnZS13aXRoLXRoZS1ub3RvcmlvdXNseS1yaWNoLWJvc3MvY2hhcHRlci04Mi8=");
        // https://mangakiss.org/manga/the-marriage-with-the-notoriously-rich-boss/chapter-124/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1tYXJyaWFnZS13aXRoLXRoZS1ub3RvcmlvdXNseS1yaWNoLWJvc3MvY2hhcHRlci0xMjQv");
        // https://mangakiss.org/manga/the-marriage-with-the-notoriously-rich-boss/chapter-161/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1tYXJyaWFnZS13aXRoLXRoZS1ub3RvcmlvdXNseS1yaWNoLWJvc3MvY2hhcHRlci0xNjEv");
        // https://mangakiss.org/manga/the-marriage-with-the-notoriously-rich-boss/chapter-184/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1tYXJyaWFnZS13aXRoLXRoZS1ub3RvcmlvdXNseS1yaWNoLWJvc3MvY2hhcHRlci0xODQv");
        // https://mangakiss.org/manga/the-officer-is-madly-in-love-with-me/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL21hbmdhL3RoZS1vZmZpY2VyLWlzLW1hZGx5LWluLWxvdmUtd2l0aC1tZS9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangakiss.org/wp-content/uploads/WP-manga/data/manga_62eba5b71d442/1e2fd32790c20f175d7cf733a248ccd2/a-(8).jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzYyZWJhNWI3MWQ0NDIvMWUyZmQzMjc5MGMyMGYxNzVkN2NmNzMzYTI0OGNjZDIvYS0oOCkuanBn");
        // https://mangakiss.org/wp-content/uploads/WP-manga/data/manga_62eba5b71d442/1e2fd32790c20f175d7cf733a248ccd2/a-(10).jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzYyZWJhNWI3MWQ0NDIvMWUyZmQzMjc5MGMyMGYxNzVkN2NmNzMzYTI0OGNjZDIvYS0oMTApLmpwZw==");
        // https://mangakiss.org/wp-content/uploads/WP-manga/data/manga_62eba5b71d442/6c440004d91197885cc1477730cac7c2/a-(16).jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzYyZWJhNWI3MWQ0NDIvNmM0NDAwMDRkOTExOTc4ODVjYzE0Nzc3MzBjYWM3YzIvYS0oMTYpLmpwZw==");
        // https://mangakiss.org/wp-content/uploads/WP-manga/data/manga_641499875e6ea/323dede43344e82350cdaba854c99751/a-(9).jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0MTQ5OTg3NWU2ZWEvMzIzZGVkZTQzMzQ0ZTgyMzUwY2RhYmE4NTRjOTk3NTEvYS0oOSkuanBn");
        // https://mangakiss.org/wp-content/uploads/WP-manga/data/manga_62eba5b71d442/1e2fd32790c20f175d7cf733a248ccd2/a-(16).jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtpc3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzYyZWJhNWI3MWQ0NDIvMWUyZmQzMjc5MGMyMGYxNzVkN2NmNzMzYTI0OGNjZDIvYS0oMTYpLmpwZw==");
    }
}

