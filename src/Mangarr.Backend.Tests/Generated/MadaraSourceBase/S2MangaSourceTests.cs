using System.Collections;

namespace Mangarr.Backend.Tests;

public class S2MangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "s2manga";

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
        // https://www.s2manga.com/manga/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvcGxlYXNlLWdldC1vdXQtb2YtbXktaG91c2Vob2xkLw==");
        // https://www.s2manga.com/manga/office-marriage-after-a-breakup/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2Evb2ZmaWNlLW1hcnJpYWdlLWFmdGVyLWEtYnJlYWt1cC8=");
        // https://www.s2manga.com/manga/archmage-streamer/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvYXJjaG1hZ2Utc3RyZWFtZXIv");
        // https://www.s2manga.com/manga/master-huo-fails-to-pursue-his-wife/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvbWFzdGVyLWh1by1mYWlscy10by1wdXJzdWUtaGlzLXdpZmUv");
        // https://www.s2manga.com/manga/f-class-destiny-hunter/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvZi1jbGFzcy1kZXN0aW55LWh1bnRlci8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.s2manga.com/manga/f-class-destiny-hunter/chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvZi1jbGFzcy1kZXN0aW55LWh1bnRlci9jaGFwdGVyLTEzLw==");
        // https://www.s2manga.com/manga/master-huo-fails-to-pursue-his-wife/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvbWFzdGVyLWh1by1mYWlscy10by1wdXJzdWUtaGlzLXdpZmUvY2hhcHRlci03Lw==");
        // https://www.s2manga.com/manga/f-class-destiny-hunter/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvZi1jbGFzcy1kZXN0aW55LWh1bnRlci9jaGFwdGVyLTgv");
        // https://www.s2manga.com/manga/f-class-destiny-hunter/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvZi1jbGFzcy1kZXN0aW55LWh1bnRlci9jaGFwdGVyLTQv");
        // https://www.s2manga.com/manga/f-class-destiny-hunter/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly93d3cuczJtYW5nYS5jb20vbWFuZ2EvZi1jbGFzcy1kZXN0aW55LWh1bnRlci9jaGFwdGVyLTE5Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://vps1.s2manga.com/manga_14f1237ef67855b265687d388420fb95/chapter_7/ch_7_34.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzE0ZjEyMzdlZjY3ODU1YjI2NTY4N2QzODg0MjBmYjk1L2NoYXB0ZXJfNy9jaF83XzM0LmpwZw==");
        // https://vps1.s2manga.com/manga_805a2e012c396cf85701ce0f89c6e6e4/chapter_18/ch_18_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzgwNWEyZTAxMmMzOTZjZjg1NzAxY2UwZjg5YzZlNmU0L2NoYXB0ZXJfMTgvY2hfMThfMTcuanBn");
        // https://vps1.s2manga.com/manga_805a2e012c396cf85701ce0f89c6e6e4/chapter_18/ch_18_21.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzgwNWEyZTAxMmMzOTZjZjg1NzAxY2UwZjg5YzZlNmU0L2NoYXB0ZXJfMTgvY2hfMThfMjEuanBn");
        // https://vps1.s2manga.com/manga_805a2e012c396cf85701ce0f89c6e6e4/chapter_18/ch_18_33.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzgwNWEyZTAxMmMzOTZjZjg1NzAxY2UwZjg5YzZlNmU0L2NoYXB0ZXJfMTgvY2hfMThfMzMuanBn");
        // https://vps1.s2manga.com/manga_14f1237ef67855b265687d388420fb95/chapter_7/ch_7_17.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzE0ZjEyMzdlZjY3ODU1YjI2NTY4N2QzODg0MjBmYjk1L2NoYXB0ZXJfNy9jaF83XzE3LmpwZw==");
    }
}

