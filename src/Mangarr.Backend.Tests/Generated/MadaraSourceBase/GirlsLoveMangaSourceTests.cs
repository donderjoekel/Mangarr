using System.Collections;

namespace Mangarr.Backend.Tests;

public class GirlsLoveMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "girlslovemanga";

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
        // https://glmanga.com/manga/fainda-goshi-no-ano-ko/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9mYWluZGEtZ29zaGktbm8tYW5vLWtvLw==");
        // https://glmanga.com/manga/ouji-sama-nante-iranai/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9vdWppLXNhbWEtbmFudGUtaXJhbmFpLw==");
        // https://glmanga.com/manga/club-amour/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9jbHViLWFtb3VyLw==");
        // https://glmanga.com/manga/mebae-vivid-yuri-anthology/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9tZWJhZS12aXZpZC15dXJpLWFudGhvbG9neS8=");
        // https://glmanga.com/manga/the-unemployed-and-the-high-schooler/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS90aGUtdW5lbXBsb3llZC1hbmQtdGhlLWhpZ2gtc2Nob29sZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://glmanga.com/manga/ouji-sama-nante-iranai/chapter-44-for-the-times-when-we-cant-see-each-other-at-school/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9vdWppLXNhbWEtbmFudGUtaXJhbmFpL2NoYXB0ZXItNDQtZm9yLXRoZS10aW1lcy13aGVuLXdlLWNhbnQtc2VlLWVhY2gtb3RoZXItYXQtc2Nob29sLw==");
        // https://glmanga.com/manga/fainda-goshi-no-ano-ko/the-girl-through-the-viewfinder/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9mYWluZGEtZ29zaGktbm8tYW5vLWtvL3RoZS1naXJsLXRocm91Z2gtdGhlLXZpZXdmaW5kZXIvY2hhcHRlci02Lw==");
        // https://glmanga.com/manga/ouji-sama-nante-iranai/chapter-196-starting-point/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9vdWppLXNhbWEtbmFudGUtaXJhbmFpL2NoYXB0ZXItMTk2LXN0YXJ0aW5nLXBvaW50Lw==");
        // https://glmanga.com/manga/ouji-sama-nante-iranai/chapter-68/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9vdWppLXNhbWEtbmFudGUtaXJhbmFpL2NoYXB0ZXItNjgv");
        // https://glmanga.com/manga/club-amour/episode-2/
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS9tYW5nYS9jbHViLWFtb3VyL2VwaXNvZGUtMi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://glmanga.com/wp-content/uploads/WP-manga/data/manga_637bac09e4297/a4778e320c50160a2bac929b13ff624b/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MzdiYWMwOWU0Mjk3L2E0Nzc4ZTMyMGM1MDE2MGEyYmFjOTI5YjEzZmY2MjRiLzAxLmpwZw==");
        // https://glmanga.com/wp-content/uploads/WP-manga/data/manga_637bac09e4297/70853ab218ae4a7d3c1cc7b4167da7fd/20.jpg
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MzdiYWMwOWU0Mjk3LzcwODUzYWIyMThhZTRhN2QzYzFjYzdiNDE2N2RhN2ZkLzIwLmpwZw==");
        // https://glmanga.com/wp-content/uploads/WP-manga/data/manga_637a4455b9ebd/ff5331d5fab25da88c2525734ed26817/07.webp
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MzdhNDQ1NWI5ZWJkL2ZmNTMzMWQ1ZmFiMjVkYTg4YzI1MjU3MzRlZDI2ODE3LzA3LndlYnA=");
        // https://glmanga.com/wp-content/uploads/WP-manga/data/manga_637bac09e4297/a4778e320c50160a2bac929b13ff624b/18.jpg
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MzdiYWMwOWU0Mjk3L2E0Nzc4ZTMyMGM1MDE2MGEyYmFjOTI5YjEzZmY2MjRiLzE4LmpwZw==");
        // https://glmanga.com/wp-content/uploads/WP-manga/data/manga_637bac09e4297/70853ab218ae4a7d3c1cc7b4167da7fd/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9nbG1hbmdhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MzdiYWMwOWU0Mjk3LzcwODUzYWIyMThhZTRhN2QzYzFjYzdiNDE2N2RhN2ZkLzExLmpwZw==");
    }
}

