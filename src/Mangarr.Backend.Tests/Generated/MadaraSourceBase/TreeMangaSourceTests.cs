using System.Collections;

namespace Mangarr.Backend.Tests;

public class TreeMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "treemanga";

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
        // https://treemanga.com/manga/terror-vs-revival/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3RlcnJvci12cy1yZXZpdmFsLw==");
        // https://treemanga.com/manga/without-parallel/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3dpdGhvdXQtcGFyYWxsZWwv");
        // https://treemanga.com/manga/only-want-it-with-you/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL29ubHktd2FudC1pdC13aXRoLXlvdS8=");
        // https://treemanga.com/manga/white-scandal/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3doaXRlLXNjYW5kYWwv");
        // https://treemanga.com/manga/returned-as-a-martial-genius/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3JldHVybmVkLWFzLWEtbWFydGlhbC1nZW5pdXMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://treemanga.com/manga/terror-vs-revival/chapter-61/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3RlcnJvci12cy1yZXZpdmFsL2NoYXB0ZXItNjEv");
        // https://treemanga.com/manga/terror-vs-revival/chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3RlcnJvci12cy1yZXZpdmFsL2NoYXB0ZXItMTEv");
        // https://treemanga.com/manga/without-parallel/chapter-65/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3dpdGhvdXQtcGFyYWxsZWwvY2hhcHRlci02NS8=");
        // https://treemanga.com/manga/white-scandal/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3doaXRlLXNjYW5kYWwvY2hhcHRlci00Lw==");
        // https://treemanga.com/manga/without-parallel/chapter-69/
        yield return new TestCaseData("aHR0cHM6Ly90cmVlbWFuZ2EuY29tL21hbmdhL3dpdGhvdXQtcGFyYWxsZWwvY2hhcHRlci02OS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://storage.manhwateen.com///manga_be98d96266307dc8cbedc8001331a95a/chapter_22/chap_22_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfYmU5OGQ5NjI2NjMwN2RjOGNiZWRjODAwMTMzMWE5NWEvY2hhcHRlcl8yMi9jaGFwXzIyXzYuanBn");
        // https://storage.manhwateen.com///manga_3bc5f0580009a0fff6d288c81efab206/chapter_4/chap_4_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfM2JjNWYwNTgwMDA5YTBmZmY2ZDI4OGM4MWVmYWIyMDYvY2hhcHRlcl80L2NoYXBfNF82LmpwZw==");
        // https://storage.manhwateen.com///manga_be98d96266307dc8cbedc8001331a95a/chapter_26/chap_26_11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfYmU5OGQ5NjI2NjMwN2RjOGNiZWRjODAwMTMzMWE5NWEvY2hhcHRlcl8yNi9jaGFwXzI2XzExLmpwZw==");
        // https://storage.manhwateen.com///manga_be98d96266307dc8cbedc8001331a95a/chapter_22/chap_22_2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zdG9yYWdlLm1hbmh3YXRlZW4uY29tLy8vbWFuZ2FfYmU5OGQ5NjI2NjMwN2RjOGNiZWRjODAwMTMzMWE5NWEvY2hhcHRlcl8yMi9jaGFwXzIyXzIuanBn");
    }
}

