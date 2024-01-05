using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaFoxFullSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangafoxfull";

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
        // https://mangafoxfull.com/manga/insanely-talented-player/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2luc2FuZWx5LXRhbGVudGVkLXBsYXllci8=");
        // https://mangafoxfull.com/manga/lady-dragon/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2xhZHktZHJhZ29uLw==");
        // https://mangafoxfull.com/manga/dead-knight-gunther/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2RlYWQta25pZ2h0LWd1bnRoZXIv");
        // https://mangafoxfull.com/manga/intoxicated-butterfly-and-cold-moon/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2ludG94aWNhdGVkLWJ1dHRlcmZseS1hbmQtY29sZC1tb29uLw==");
        // https://mangafoxfull.com/manga/sword-demon-island/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL3N3b3JkLWRlbW9uLWlzbGFuZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangafoxfull.com/manga/sword-demon-island/chapter-64/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL3N3b3JkLWRlbW9uLWlzbGFuZC9jaGFwdGVyLTY0Lw==");
        // https://mangafoxfull.com/manga/lady-dragon/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2xhZHktZHJhZ29uL2NoYXB0ZXItOS8=");
        // https://mangafoxfull.com/manga/dead-knight-gunther/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2RlYWQta25pZ2h0LWd1bnRoZXIvY2hhcHRlci0xMC8=");
        // https://mangafoxfull.com/manga/sword-demon-island/chapter-49/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL3N3b3JkLWRlbW9uLWlzbGFuZC9jaGFwdGVyLTQ5Lw==");
        // https://mangafoxfull.com/manga/dead-knight-gunther/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZveGZ1bGwuY29tL21hbmdhL2RlYWQta25pZ2h0LWd1bnRoZXIvY2hhcHRlci03Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s1.cdn-manga.com/files/WP-manga/data/4580/b5f72d89ddfd0f7e10bf9a2e0430d693/39.webp
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDU4MC9iNWY3MmQ4OWRkZmQwZjdlMTBiZjlhMmUwNDMwZDY5My8zOS53ZWJw");
        // https://s1.cdn-manga.com/files/WP-manga/data/4580/b5f72d89ddfd0f7e10bf9a2e0430d693/5.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDU4MC9iNWY3MmQ4OWRkZmQwZjdlMTBiZjlhMmUwNDMwZDY5My81LmpwZWc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/4580/b5f72d89ddfd0f7e10bf9a2e0430d693/27.webp
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDU4MC9iNWY3MmQ4OWRkZmQwZjdlMTBiZjlhMmUwNDMwZDY5My8yNy53ZWJw");
        // https://s1.cdn-manga.com/files/WP-manga/data/4558/a694865305bc4861c58b48555af64fcf/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDU1OC9hNjk0ODY1MzA1YmM0ODYxYzU4YjQ4NTU1YWY2NGZjZi8xMS5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/4558/2c3fa319191b5cd22abec9a255bae78c/27.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDU1OC8yYzNmYTMxOTE5MWI1Y2QyMmFiZWM5YTI1NWJhZTc4Yy8yNy5qcGc=");
    }
}

