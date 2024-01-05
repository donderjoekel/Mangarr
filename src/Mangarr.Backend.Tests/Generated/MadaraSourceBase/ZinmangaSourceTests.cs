using System.Collections;

namespace Mangarr.Backend.Tests;

public class ZinmangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "zinmanga";

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
        // https://zinmanga.com/manga/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvcGxlYXNlLWdldC1vdXQtb2YtbXktaG91c2Vob2xkLw==");
        // https://zinmanga.com/manga/i-raised-my-fianc-with-money/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvaS1yYWlzZWQtbXktZmlhbmMtd2l0aC1tb25leS8=");
        // https://zinmanga.com/manga/how-to-protect-my-male-lead/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvaG93LXRvLXByb3RlY3QtbXktbWFsZS1sZWFkLw==");
        // https://zinmanga.com/manga/reasoning-with-a-beast/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvcmVhc29uaW5nLXdpdGgtYS1iZWFzdC8=");
        // https://zinmanga.com/manga/unrivaled-gamer-dominating-with-the-exskill-hero-master/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvdW5yaXZhbGVkLWdhbWVyLWRvbWluYXRpbmctd2l0aC10aGUtZXhza2lsbC1oZXJvLW1hc3Rlci8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://zinmanga.com/manga/how-to-protect-my-male-lead/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvaG93LXRvLXByb3RlY3QtbXktbWFsZS1sZWFkL2NoYXB0ZXItMy8=");
        // https://zinmanga.com/manga/i-raised-my-fianc-with-money/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvaS1yYWlzZWQtbXktZmlhbmMtd2l0aC1tb25leS9jaGFwdGVyLTQv");
        // https://zinmanga.com/manga/how-to-protect-my-male-lead/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvaG93LXRvLXByb3RlY3QtbXktbWFsZS1sZWFkL2NoYXB0ZXItNy8=");
        // https://zinmanga.com/manga/how-to-protect-my-male-lead/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvaG93LXRvLXByb3RlY3QtbXktbWFsZS1sZWFkL2NoYXB0ZXItNi8=");
        // https://zinmanga.com/manga/reasoning-with-a-beast/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly96aW5tYW5nYS5jb20vbWFuZ2EvcmVhc29uaW5nLXdpdGgtYS1iZWFzdC9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.topmanhua.com/manga_638397987213355800/d30fdb91641b3da580686bbc7bb6ea9c/1-X003-Y001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9tYW5nYV82MzgzOTc5ODcyMTMzNTU4MDAvZDMwZmRiOTE2NDFiM2RhNTgwNjg2YmJjN2JiNmVhOWMvMS1YMDAzLVkwMDEuanBn");
        // https://cdn.topmanhua.com/how-to-protect-my-male-lead/chapter-3/081.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQvY2hhcHRlci0zLzA4MS5qcGc=");
        // https://cdn.topmanhua.com/reasoning-with-a-beast/chapter-1/003.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9yZWFzb25pbmctd2l0aC1hLWJlYXN0L2NoYXB0ZXItMS8wMDMuanBn");
        // https://cdn.topmanhua.com/i-raised-my-fiance-with-money/chapter-4/004.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9pLXJhaXNlZC1teS1maWFuY2Utd2l0aC1tb25leS9jaGFwdGVyLTQvMDA0LmpwZw==");
        // https://cdn.topmanhua.com/how-to-protect-my-male-lead/chapter-3/069.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQvY2hhcHRlci0zLzA2OS5qcGc=");
    }
}

