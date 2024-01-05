using System.Collections;

namespace Mangarr.Backend.Tests;

public class OnlyManhwaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "onlymanhwa";

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
        // https://onlymanhwa.org/manhwa/gods-gambit/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvZ29kcy1nYW1iaXQv");
        // https://onlymanhwa.org/manhwa/im-not-a-regressor/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvaW0tbm90LWEtcmVncmVzc29yLw==");
        // https://onlymanhwa.org/manhwa/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvdGhlLWNyb3duLXByaW5jZS10aGF0LXNlbGxzLW1lZGljaW5lLw==");
        // https://onlymanhwa.org/manhwa/nano-machine/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvbmFuby1tYWNoaW5lLw==");
        // https://onlymanhwa.org/manhwa/return-to-player/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvcmV0dXJuLXRvLXBsYXllci8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://onlymanhwa.org/manhwa/nano-machine/chapter-183/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvbmFuby1tYWNoaW5lL2NoYXB0ZXItMTgzLw==");
        // https://onlymanhwa.org/manhwa/gods-gambit/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvZ29kcy1nYW1iaXQvY2hhcHRlci0xMC8=");
        // https://onlymanhwa.org/manhwa/return-to-player/chapter-43/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvcmV0dXJuLXRvLXBsYXllci9jaGFwdGVyLTQzLw==");
        // https://onlymanhwa.org/manhwa/nano-machine/chapter-151/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvbmFuby1tYWNoaW5lL2NoYXB0ZXItMTUxLw==");
        // https://onlymanhwa.org/manhwa/return-to-player/chapter-113/
        yield return new TestCaseData("aHR0cHM6Ly9vbmx5bWFuaHdhLm9yZy9tYW5od2EvcmV0dXJuLXRvLXBsYXllci9jaGFwdGVyLTExMy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.onlymanhwa.net/manga_6568415fed9e7/d10a1526326870dffd5210cafde5ec96/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ub25seW1hbmh3YS5uZXQvbWFuZ2FfNjU2ODQxNWZlZDllNy9kMTBhMTUyNjMyNjg3MGRmZmQ1MjEwY2FmZGU1ZWM5Ni8xMC5qcGc=");
        // https://cdn.onlymanhwa.net/manga_64b21a2d3d6e9/abec4871fd18aea54de3388d0a976a18/54.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ub25seW1hbmh3YS5uZXQvbWFuZ2FfNjRiMjFhMmQzZDZlOS9hYmVjNDg3MWZkMThhZWE1NGRlMzM4OGQwYTk3NmExOC81NC5qcGc=");
        // https://cdn.onlymanhwa.net/manga_64b21a2d3d6e9/abec4871fd18aea54de3388d0a976a18/50.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ub25seW1hbmh3YS5uZXQvbWFuZ2FfNjRiMjFhMmQzZDZlOS9hYmVjNDg3MWZkMThhZWE1NGRlMzM4OGQwYTk3NmExOC81MC5qcGc=");
        // https://cdn.onlymanhwa.net/manga_64b21a2d3d6e9/abec4871fd18aea54de3388d0a976a18/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ub25seW1hbmh3YS5uZXQvbWFuZ2FfNjRiMjFhMmQzZDZlOS9hYmVjNDg3MWZkMThhZWE1NGRlMzM4OGQwYTk3NmExOC8xMS5qcGc=");
        // https://cdn.onlymanhwa.net/manga_64b21a2d3d6e9/abec4871fd18aea54de3388d0a976a18/36.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ub25seW1hbmh3YS5uZXQvbWFuZ2FfNjRiMjFhMmQzZDZlOS9hYmVjNDg3MWZkMThhZWE1NGRlMzM4OGQwYTk3NmExOC8zNi5qcGc=");
    }
}

