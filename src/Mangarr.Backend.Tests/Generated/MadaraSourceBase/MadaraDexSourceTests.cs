using System.Collections;

namespace Mangarr.Backend.Tests;

public class MadaraDexSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "madaradex";

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
        // https://madaradex.org/title/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL25vdC1hdC13b3JrLw==");
        // https://madaradex.org/title/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL21ha2luZy1mcmllbmRzLXdpdGgtc3RyZWFtZXJzLWJ5LWhhY2tpbmcv");
        // https://madaradex.org/title/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL3RoZS1zdG9yeS1vZi1ob3ctaS1nb3QtdG9nZXRoZXItd2l0aC10aGUtbWFuYWdlci1vbi1jaHJpc3RtYXMv");
        // https://madaradex.org/title/playing-a-game-with-my-busty-manager/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL3BsYXlpbmctYS1nYW1lLXdpdGgtbXktYnVzdHktbWFuYWdlci8=");
        // https://madaradex.org/title/the-cheat-code-hitter-fucks-them-all/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL3RoZS1jaGVhdC1jb2RlLWhpdHRlci1mdWNrcy10aGVtLWFsbC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://madaradex.org/title/making-friends-with-streamers-by-hacking/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL21ha2luZy1mcmllbmRzLXdpdGgtc3RyZWFtZXJzLWJ5LWhhY2tpbmcvY2hhcHRlci0xLw==");
        // https://madaradex.org/title/the-cheat-code-hitter-fucks-them-all/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL3RoZS1jaGVhdC1jb2RlLWhpdHRlci1mdWNrcy10aGVtLWFsbC9jaGFwdGVyLTIv");
        // https://madaradex.org/title/the-cheat-code-hitter-fucks-them-all/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL3RoZS1jaGVhdC1jb2RlLWhpdHRlci1mdWNrcy10aGVtLWFsbC9jaGFwdGVyLTUv");
        // https://madaradex.org/title/making-friends-with-streamers-by-hacking/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL21ha2luZy1mcmllbmRzLXdpdGgtc3RyZWFtZXJzLWJ5LWhhY2tpbmcvY2hhcHRlci0yLw==");
        // https://madaradex.org/title/making-friends-with-streamers-by-hacking/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYWRhcmFkZXgub3JnL3RpdGxlL21ha2luZy1mcmllbmRzLXdpdGgtc3RyZWFtZXJzLWJ5LWhhY2tpbmcvY2hhcHRlci0zLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.madaradex.org/manga_658817553cf97/chapter-2/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFkYXJhZGV4Lm9yZy9tYW5nYV82NTg4MTc1NTNjZjk3L2NoYXB0ZXItMi80LmpwZw==");
        // https://cdn.madaradex.org/manga_658817553cf97/chapter-2/7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFkYXJhZGV4Lm9yZy9tYW5nYV82NTg4MTc1NTNjZjk3L2NoYXB0ZXItMi83LmpwZw==");
    }
}

