using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaDashTXSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manga-tx";

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
        // https://mangaempress.com/manga/kumo-desu-ga-nani-ka/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL2t1bW8tZGVzdS1nYS1uYW5pLWthLw==");
        // https://mangaempress.com/manga/attack-on-titan/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL2F0dGFjay1vbi10aXRhbi8=");
        // https://mangaempress.com/manga/shokugeki-no-soma/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL3Nob2t1Z2VraS1uby1zb21hLw==");
        // https://mangaempress.com/manga/immortal-swordsman-in-the-reverse-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL2ltbW9ydGFsLXN3b3Jkc21hbi1pbi10aGUtcmV2ZXJzZS13b3JsZC8=");
        // https://mangaempress.com/manga/rebirth-of-the-urban-immortal-cultivator/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL3JlYmlydGgtb2YtdGhlLXVyYmFuLWltbW9ydGFsLWN1bHRpdmF0b3Iv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaempress.com/manga/rebirth-of-the-urban-immortal-cultivator/chapter-232/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL3JlYmlydGgtb2YtdGhlLXVyYmFuLWltbW9ydGFsLWN1bHRpdmF0b3IvY2hhcHRlci0yMzIv");
        // https://mangaempress.com/manga/rebirth-of-the-urban-immortal-cultivator/chapter-415/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL3JlYmlydGgtb2YtdGhlLXVyYmFuLWltbW9ydGFsLWN1bHRpdmF0b3IvY2hhcHRlci00MTUv");
        // https://mangaempress.com/manga/rebirth-of-the-urban-immortal-cultivator/chapter-587/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL3JlYmlydGgtb2YtdGhlLXVyYmFuLWltbW9ydGFsLWN1bHRpdmF0b3IvY2hhcHRlci01ODcv");
        // https://mangaempress.com/manga/immortal-swordsman-in-the-reverse-world/chapter-255/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL2ltbW9ydGFsLXN3b3Jkc21hbi1pbi10aGUtcmV2ZXJzZS13b3JsZC9jaGFwdGVyLTI1NS8=");
        // https://mangaempress.com/manga/attack-on-titan/chapter-51/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWVtcHJlc3MuY29tL21hbmdhL2F0dGFjay1vbi10aXRhbi9jaGFwdGVyLTUxLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s1.cdn-manga.com/files/WP-manga/data/955/13779343c56c075373795e5fd62d2e74/22.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvOTU1LzEzNzc5MzQzYzU2YzA3NTM3Mzc5NWU1ZmQ2MmQyZTc0LzIyLmpwZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/30/5cf2016e51e53b6f1e513c7cf956b4ea/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvMzAvNWNmMjAxNmU1MWU1M2I2ZjFlNTEzYzdjZjk1NmI0ZWEvMS5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/955/13779343c56c075373795e5fd62d2e74/30.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvOTU1LzEzNzc5MzQzYzU2YzA3NTM3Mzc5NWU1ZmQ2MmQyZTc0LzMwLmpwZw==");
        // https://s1.cdn-manga.com/files/WP-manga/data/30/5cf2016e51e53b6f1e513c7cf956b4ea/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvMzAvNWNmMjAxNmU1MWU1M2I2ZjFlNTEzYzdjZjk1NmI0ZWEvNS5qcGc=");
        // https://s1.cdn-manga.com/files/WP-manga/data/955/13779343c56c075373795e5fd62d2e74/33.jpg
        yield return new TestCaseData("aHR0cHM6Ly9zMS5jZG4tbWFuZ2EuY29tL2ZpbGVzL1dQLW1hbmdhL2RhdGEvOTU1LzEzNzc5MzQzYzU2YzA3NTM3Mzc5NWU1ZmQ2MmQyZTc0LzMzLmpwZw==");
    }
}

