using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManyToonSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manytoon";

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
        // https://manytoon.com/comic/you-came-during-the-massage-earlier-didnt-you/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91Lw==");
        // https://manytoon.com/comic/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://manytoon.com/comic/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMvbWFraW5nLWZyaWVuZHMtd2l0aC1zdHJlYW1lcnMtYnktaGFja2luZy8=");
        // https://manytoon.com/comic/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMvbm90LWF0LXdvcmsv");
        // https://manytoon.com/comic/playing-a-game-with-the-big-breasted-manager/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMvcGxheWluZy1hLWdhbWUtd2l0aC10aGUtYmlnLWJyZWFzdGVkLW1hbmFnZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manytoon.com/comic/you-came-during-the-massage-earlier-didnt-you/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMTkv");
        // https://manytoon.com/comic/you-came-during-the-massage-earlier-didnt-you/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItOS8=");
        // https://manytoon.com/comic/you-came-during-the-massage-earlier-didnt-you/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMS8=");
        // https://manytoon.com/comic/the-story-of-how-i-got-together-with-the-manager-on-christmas/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy9jaGFwdGVyLTEv");
        // https://manytoon.com/comic/you-came-during-the-massage-earlier-didnt-you/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vY29taWMveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://manytoon.com/wp-content/uploads/WP-manga/data/manga_6596625605efb/f266c8a2d5fc45bf2b8c8761bb6705ec/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjYyNTYwNWVmYi9mMjY2YzhhMmQ1ZmM0NWJmMmI4Yzg3NjFiYjY3MDVlYy8wNi5qcGc=");
        // https://manytoon.com/wp-content/uploads/WP-manga/data/manga_6596625605efb/f266c8a2d5fc45bf2b8c8761bb6705ec/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjYyNTYwNWVmYi9mMjY2YzhhMmQ1ZmM0NWJmMmI4Yzg3NjFiYjY3MDVlYy8wMi5qcGc=");
        // https://manytoon.com/wp-content/uploads/WP-manga/data/manga_6596625605efb/301e7afeafdc5cb75469ec341aa9e09e/07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjYyNTYwNWVmYi8zMDFlN2FmZWFmZGM1Y2I3NTQ2OWVjMzQxYWE5ZTA5ZS8wNy5qcGc=");
        // https://manytoon.com/wp-content/uploads/WP-manga/data/manga_6596625605efb/dcb170f365063ccb93d01475e7d3bf7e/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjYyNTYwNWVmYi9kY2IxNzBmMzY1MDYzY2NiOTNkMDE0NzVlN2QzYmY3ZS8wOC5qcGc=");
        // https://manytoon.com/wp-content/uploads/WP-manga/data/manga_6596625605efb/688077752ae2bf7f1a168e095a8377e8/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW55dG9vbi5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NjYyNTYwNWVmYi82ODgwNzc3NTJhZTJiZjdmMWExNjhlMDk1YTgzNzdlOC8wOS5qcGc=");
    }
}

