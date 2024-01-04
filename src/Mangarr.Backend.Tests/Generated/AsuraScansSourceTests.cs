using System.Collections;

namespace Mangarr.Backend.Tests;

public class AsuraScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "asurascans";

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
        // https://asuratoon.com/manga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3Mv");
        // https://asuratoon.com/manga/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21hbmdhL3JlaW5jYXJuYXRvci8=");
        // https://asuratoon.com/manga/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21hbmdhL3RoZS1leHRyYXMtYWNhZGVteS1zdXJ2aXZhbC1ndWlkZS8=");
        // https://asuratoon.com/manga/0435219386-the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21hbmdhLzA0MzUyMTkzODYtdGhlLWNyb3duLXByaW5jZS10aGF0LXNlbGxzLW1lZGljaW5lLw==");
        // https://asuratoon.com/manga/0435219386-genius-corpse-collecting-warrior/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21hbmdhLzA0MzUyMTkzODYtZ2VuaXVzLWNvcnBzZS1jb2xsZWN0aW5nLXdhcnJpb3Iv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://asuratoon.com/mr-devourer-please-act-like-a-final-boss-chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtY2hhcHRlci0xNy8=");
        // https://asuratoon.com/mr-devourer-please-act-like-a-final-boss-chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtY2hhcHRlci02Lw==");
        // https://asuratoon.com/3955407132-genius-corpse-collecting-warrior-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tLzM5NTU0MDcxMzItZ2VuaXVzLWNvcnBzZS1jb2xsZWN0aW5nLXdhcnJpb3ItY2hhcHRlci0zLw==");
        // https://asuratoon.com/mr-devourer-please-act-like-a-final-boss-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtY2hhcHRlci00Lw==");
        // https://asuratoon.com/reincarnator-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3JlaW5jYXJuYXRvci1jaGFwdGVyLTQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://asuratoon.com/wp-content/uploads/custom-upload/275119/4/0r0.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTExOS80LzByMC5qcGc=");
        // https://asuratoon.com/wp-content/uploads/2023/12/08-7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA4LTcuanBn");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275119/4/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTExOS80LzA5LmpwZw==");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275119/4/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTExOS80LzAzLmpwZw==");
        // https://asuratoon.com/wp-content/uploads/2023/12/04-5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzA0LTUuanBn");
    }
}

