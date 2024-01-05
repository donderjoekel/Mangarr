using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaUSSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuaus";

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
        // https://manhuaus.com/manga/full-time-swordsman/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvZnVsbC10aW1lLXN3b3Jkc21hbi8=");
        // https://manhuaus.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yLw==");
        // https://manhuaus.com/manga/emperor-qin-returns-i-am-the-eternal-immortal-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvZW1wZXJvci1xaW4tcmV0dXJucy1pLWFtLXRoZS1ldGVybmFsLWltbW9ydGFsLWVtcGVyb3Iv");
        // https://manhuaus.com/manga/the-unbeatable-dungeons-lazy-boss-monster/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvdGhlLXVuYmVhdGFibGUtZHVuZ2VvbnMtbGF6eS1ib3NzLW1vbnN0ZXIv");
        // https://manhuaus.com/manga/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvcmVpbmNhcm5hdG9yLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuaus.com/manga/dark-and-light-martial-emperor/chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yL2NoYXB0ZXItMTIv");
        // https://manhuaus.com/manga/dark-and-light-martial-emperor/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yL2NoYXB0ZXItMTAv");
        // https://manhuaus.com/manga/dark-and-light-martial-emperor/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yL2NoYXB0ZXItMi8=");
        // https://manhuaus.com/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvdGhlLXVuYmVhdGFibGUtZHVuZ2VvbnMtbGF6eS1ib3NzLW1vbnN0ZXIvY2hhcHRlci0wLw==");
        // https://manhuaus.com/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF1cy5jb20vbWFuZ2EvdGhlLXVuYmVhdGFibGUtZHVuZ2VvbnMtbGF6eS1ib3NzLW1vbnN0ZXIvY2hhcHRlci0xLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.manhuaus.com/image/manga_659172da88dfb/58c352528c246aaba41ae29f86bb1159/007.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhdXMuY29tL2ltYWdlL21hbmdhXzY1OTE3MmRhODhkZmIvNThjMzUyNTI4YzI0NmFhYmE0MWFlMjlmODZiYjExNTkvMDA3LndlYnA=");
        // https://cdn.manhuaus.com/image/manga_659172da88dfb/58c352528c246aaba41ae29f86bb1159/012.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhdXMuY29tL2ltYWdlL21hbmdhXzY1OTE3MmRhODhkZmIvNThjMzUyNTI4YzI0NmFhYmE0MWFlMjlmODZiYjExNTkvMDEyLndlYnA=");
        // https://cdn.manhuaus.com/image/manga_659172da88dfb/e93749af0252063983eb4056b47612be/003.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhdXMuY29tL2ltYWdlL21hbmdhXzY1OTE3MmRhODhkZmIvZTkzNzQ5YWYwMjUyMDYzOTgzZWI0MDU2YjQ3NjEyYmUvMDAzLndlYnA=");
        // https://cdn.manhuaus.com/image/manga_6596c299940f1/ddf2871c4d928c9521433b91717f79e7/04.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhdXMuY29tL2ltYWdlL21hbmdhXzY1OTZjMjk5OTQwZjEvZGRmMjg3MWM0ZDkyOGM5NTIxNDMzYjkxNzE3Zjc5ZTcvMDQud2VicA==");
        // https://cdn.manhuaus.com/image/manga_6596c299940f1/f1f0d5cd64cec5ef9ce236e9361fb137/13.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhdXMuY29tL2ltYWdlL21hbmdhXzY1OTZjMjk5OTQwZjEvZjFmMGQ1Y2Q2NGNlYzVlZjljZTIzNmU5MzYxZmIxMzcvMTMud2VicA==");
    }
}

