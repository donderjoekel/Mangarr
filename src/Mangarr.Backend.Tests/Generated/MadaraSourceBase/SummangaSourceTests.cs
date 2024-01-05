using System.Collections;

namespace Mangarr.Backend.Tests;

public class SummangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "summanga";

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
        // https://summanga.com/manga/divine-path-to-supremacy/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvZGl2aW5lLXBhdGgtdG8tc3VwcmVtYWN5Lw==");
        // https://summanga.com/manga/this-game-is-too-real/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvdGhpcy1nYW1lLWlzLXRvby1yZWFsLw==");
        // https://summanga.com/manga/policing-in-the-zhou-dynasty/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvcG9saWNpbmctaW4tdGhlLXpob3UtZHluYXN0eS8=");
        // https://summanga.com/manga/im-an-evil-god/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvaW0tYW4tZXZpbC1nb2Qv");
        // https://summanga.com/manga/losing-money-to-be-a-tycoon/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvbG9zaW5nLW1vbmV5LXRvLWJlLWEtdHljb29uLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://summanga.com/manga/im-an-evil-god/chapter-160/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvaW0tYW4tZXZpbC1nb2QvY2hhcHRlci0xNjAv");
        // https://summanga.com/manga/this-game-is-too-real/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvdGhpcy1nYW1lLWlzLXRvby1yZWFsL2NoYXB0ZXItMi8=");
        // https://summanga.com/manga/im-an-evil-god/chapter-384/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvaW0tYW4tZXZpbC1nb2QvY2hhcHRlci0zODQv");
        // https://summanga.com/manga/im-an-evil-god/chapter-121/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvaW0tYW4tZXZpbC1nb2QvY2hhcHRlci0xMjEv");
        // https://summanga.com/manga/im-an-evil-god/chapter-184/
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vbWFuZ2EvaW0tYW4tZXZpbC1nb2QvY2hhcHRlci0xODQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://summanga.com/wp-content/uploads/WP-manga/data/manga_656f155b343f7/df85e97e6ae3509ced95bb3a3004d45c/0075.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU2ZjE1NWIzNDNmNy9kZjg1ZTk3ZTZhZTM1MDljZWQ5NWJiM2EzMDA0ZDQ1Yy8wMDc1LmpwZw==");
        // https://summanga.com/wp-content/uploads/WP-manga/data/manga_6559ce4d17992/40a7e7e9bf8a2c51b0164087552cff6c/88.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1OWNlNGQxNzk5Mi80MGE3ZTdlOWJmOGEyYzUxYjAxNjQwODc1NTJjZmY2Yy84OC5qcGc=");
        // https://summanga.com/wp-content/uploads/WP-manga/data/manga_6559ce4d17992/de58921a1daf50bac3efe6fab1258cf9/3.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1OWNlNGQxNzk5Mi9kZTU4OTIxYTFkYWY1MGJhYzNlZmU2ZmFiMTI1OGNmOS8zLmpwZw==");
        // https://summanga.com/wp-content/uploads/WP-manga/data/manga_6559ce4d17992/4eddc0118f79017db2a8f9b19cbe4ba1/16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1OWNlNGQxNzk5Mi80ZWRkYzAxMThmNzkwMTdkYjJhOGY5YjE5Y2JlNGJhMS8xNi5qcGc=");
        // https://summanga.com/wp-content/uploads/WP-manga/data/manga_6559ce4d17992/a7a4e29aa83c02e75809260b6c47ee2c/102.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdW1tYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1OWNlNGQxNzk5Mi9hN2E0ZTI5YWE4M2MwMmU3NTgwOTI2MGI2YzQ3ZWUyYy8xMDIuanBn");
    }
}

