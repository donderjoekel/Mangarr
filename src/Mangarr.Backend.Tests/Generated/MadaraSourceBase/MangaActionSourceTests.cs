using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaActionSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaaction";

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
        // https://mangaaction.com/manga/marielle-clarac-no-konyaku/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvbWFyaWVsbGUtY2xhcmFjLW5vLWtvbnlha3Uv");
        // https://mangaaction.com/manga/jiisama-ga-iku/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2Evamlpc2FtYS1nYS1pa3Uv");
        // https://mangaaction.com/manga/absolute-necromancer/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvYWJzb2x1dGUtbmVjcm9tYW5jZXIv");
        // https://mangaaction.com/manga/attic-princess/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvYXR0aWMtcHJpbmNlc3Mv");
        // https://mangaaction.com/manga/ice-lamp/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvaWNlLWxhbXAv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaaction.com/manga/attic-princess/chapter-26/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvYXR0aWMtcHJpbmNlc3MvY2hhcHRlci0yNi8=");
        // https://mangaaction.com/manga/ice-lamp/chapter-65/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvaWNlLWxhbXAvY2hhcHRlci02NS8=");
        // https://mangaaction.com/manga/attic-princess/chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2EvYXR0aWMtcHJpbmNlc3MvY2hhcHRlci0yNC8=");
        // https://mangaaction.com/manga/jiisama-ga-iku/chapter-11.2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2Evamlpc2FtYS1nYS1pa3UvY2hhcHRlci0xMS4yLw==");
        // https://mangaaction.com/manga/jiisama-ga-iku/chapter-41/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWFjdGlvbi5jb20vbWFuZ2Evamlpc2FtYS1nYS1pa3UvY2hhcHRlci00MS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s1.cdn-manga.com/files/WP-manga/data/4679/6e7813f89069a5aa22fd8f6385bd77ff/36.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDY3OS82ZTc4MTNmODkwNjlhNWFhMjJmZDhmNjM4NWJkNzdmZi8zNi5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/4194/1c75b8a6703f0bf546e164e8b6dc8f59/58-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDE5NC8xYzc1YjhhNjcwM2YwYmY1NDZlMTY0ZThiNmRjOGY1OS81OC1vLmpwZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/4310/2ce741988a5c42370731b5bd0ed4d6c5/28.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDMxMC8yY2U3NDE5ODhhNWM0MjM3MDczMWI1YmQwZWQ0ZDZjNS8yOC5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/4310/2ce741988a5c42370731b5bd0ed4d6c5/23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDMxMC8yY2U3NDE5ODhhNWM0MjM3MDczMWI1YmQwZWQ0ZDZjNS8yMy5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/4194/1c75b8a6703f0bf546e164e8b6dc8f59/75-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvNDE5NC8xYzc1YjhhNjcwM2YwYmY1NDZlMTY0ZThiNmRjOGY1OS83NS1vLmpwZw==");
    }
}

