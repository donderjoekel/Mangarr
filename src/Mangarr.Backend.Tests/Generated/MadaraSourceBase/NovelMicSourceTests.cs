using System.Collections;

namespace Mangarr.Backend.Tests;

public class NovelMicSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "novelmic";

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
        // https://novelmic.com/comic/this-merman-is-biting-me-again/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvdGhpcy1tZXJtYW4taXMtYml0aW5nLW1lLWFnYWluLw==");
        // https://novelmic.com/comic/a-professional-assassin-raises-a-fox/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvYS1wcm9mZXNzaW9uYWwtYXNzYXNzaW4tcmFpc2VzLWEtZm94Lw==");
        // https://novelmic.com/comic/lucky-adventure-in-the-survival-game/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvbHVja3ktYWR2ZW50dXJlLWluLXRoZS1zdXJ2aXZhbC1nYW1lLw==");
        // https://novelmic.com/comic/policing-in-the-zhou-dynasty/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvcG9saWNpbmctaW4tdGhlLXpob3UtZHluYXN0eS8=");
        // https://novelmic.com/comic/this-game-is-too-real/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvdGhpcy1nYW1lLWlzLXRvby1yZWFsLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://novelmic.com/comic/policing-in-the-zhou-dynasty/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvcG9saWNpbmctaW4tdGhlLXpob3UtZHluYXN0eS9jaGFwdGVyLTIv");
        // https://novelmic.com/comic/this-merman-is-biting-me-again/chapter-88/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvdGhpcy1tZXJtYW4taXMtYml0aW5nLW1lLWFnYWluL2NoYXB0ZXItODgv");
        // https://novelmic.com/comic/this-merman-is-biting-me-again/chapter-54/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvdGhpcy1tZXJtYW4taXMtYml0aW5nLW1lLWFnYWluL2NoYXB0ZXItNTQv");
        // https://novelmic.com/comic/lucky-adventure-in-the-survival-game/chapter-43/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvbHVja3ktYWR2ZW50dXJlLWluLXRoZS1zdXJ2aXZhbC1nYW1lL2NoYXB0ZXItNDMv");
        // https://novelmic.com/comic/lucky-adventure-in-the-survival-game/chapter-54/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vY29taWMvbHVja3ktYWR2ZW50dXJlLWluLXRoZS1zdXJ2aXZhbC1nYW1lL2NoYXB0ZXItNTQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://novelmic.com/wp-content/uploads/WP-manga/data/manga_659403ce21128/5031a893c34919b092323f33ab70cddc/34.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDAzY2UyMTEyOC81MDMxYTg5M2MzNDkxOWIwOTIzMjNmMzNhYjcwY2RkYy8zNC5qcGc=");
        // https://novelmic.com/wp-content/uploads/WP-manga/data/manga_659403ce21128/842f0cde94a2c9dc8ecfda2d4eda73f2/24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDAzY2UyMTEyOC84NDJmMGNkZTk0YTJjOWRjOGVjZmRhMmQ0ZWRhNzNmMi8yNC5qcGc=");
        // https://novelmic.com/wp-content/uploads/WP-manga/data/manga_6583d75499e1b/782099fe3831544a192f2ef67320efe7/6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU4M2Q3NTQ5OWUxYi83ODIwOTlmZTM4MzE1NDRhMTkyZjJlZjY3MzIwZWZlNy82LmpwZw==");
        // https://novelmic.com/wp-content/uploads/WP-manga/data/manga_659403ce21128/5031a893c34919b092323f33ab70cddc/32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDAzY2UyMTEyOC81MDMxYTg5M2MzNDkxOWIwOTIzMjNmMzNhYjcwY2RkYy8zMi5qcGc=");
        // https://novelmic.com/wp-content/uploads/WP-manga/data/manga_6583d75499e1b/782099fe3831544a192f2ef67320efe7/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbG1pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU4M2Q3NTQ5OWUxYi83ODIwOTlmZTM4MzE1NDRhMTkyZjJlZjY3MzIwZWZlNy8xMS5qcGc=");
    }
}

