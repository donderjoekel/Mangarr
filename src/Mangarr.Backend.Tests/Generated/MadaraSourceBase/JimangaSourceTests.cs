using System.Collections;

namespace Mangarr.Backend.Tests;

public class JimangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "jimanga";

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
        // https://s2manga.io/manga/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL3BsZWFzZS1nZXQtb3V0LW9mLW15LWhvdXNlaG9sZC8=");
        // https://s2manga.io/manga/master-huo-fails-to-pursue-his-wife/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL21hc3Rlci1odW8tZmFpbHMtdG8tcHVyc3VlLWhpcy13aWZlLw==");
        // https://s2manga.io/manga/archmage-streamer/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL2FyY2htYWdlLXN0cmVhbWVyLw==");
        // https://s2manga.io/manga/office-marriage-after-a-breakup/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL29mZmljZS1tYXJyaWFnZS1hZnRlci1hLWJyZWFrdXAv");
        // https://s2manga.io/manga/red-and-mad/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL3JlZC1hbmQtbWFkLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://s2manga.io/manga/master-huo-fails-to-pursue-his-wife/chapter-33/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL21hc3Rlci1odW8tZmFpbHMtdG8tcHVyc3VlLWhpcy13aWZlL2NoYXB0ZXItMzMv");
        // https://s2manga.io/manga/master-huo-fails-to-pursue-his-wife/chapter-30/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL21hc3Rlci1odW8tZmFpbHMtdG8tcHVyc3VlLWhpcy13aWZlL2NoYXB0ZXItMzAv");
        // https://s2manga.io/manga/archmage-streamer/chapter-35/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL2FyY2htYWdlLXN0cmVhbWVyL2NoYXB0ZXItMzUv");
        // https://s2manga.io/manga/master-huo-fails-to-pursue-his-wife/chapter-23/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL21hc3Rlci1odW8tZmFpbHMtdG8tcHVyc3VlLWhpcy13aWZlL2NoYXB0ZXItMjMv");
        // https://s2manga.io/manga/archmage-streamer/chapter-54/
        yield return new TestCaseData("aHR0cHM6Ly9zMm1hbmdhLmlvL21hbmdhL2FyY2htYWdlLXN0cmVhbWVyL2NoYXB0ZXItNTQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://vps1.s2manga.com/manga_8ee0dd3abb823f07430d1f5bd7b511eb/chapter_34/ch_34_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzhlZTBkZDNhYmI4MjNmMDc0MzBkMWY1YmQ3YjUxMWViL2NoYXB0ZXJfMzQvY2hfMzRfNC5qcGc=");
        // https://vps1.s2manga.com/manga_14f1237ef67855b265687d388420fb95/chapter_30/ch_30_4.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzE0ZjEyMzdlZjY3ODU1YjI2NTY4N2QzODg0MjBmYjk1L2NoYXB0ZXJfMzAvY2hfMzBfNC5qcGc=");
        // https://vps1.s2manga.com/manga_8ee0dd3abb823f07430d1f5bd7b511eb/chapter_56/ch_56_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzhlZTBkZDNhYmI4MjNmMDc0MzBkMWY1YmQ3YjUxMWViL2NoYXB0ZXJfNTYvY2hfNTZfNS5qcGc=");
        // https://vps1.s2manga.com/manga_8ee0dd3abb823f07430d1f5bd7b511eb/chapter_56/ch_56_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzhlZTBkZDNhYmI4MjNmMDc0MzBkMWY1YmQ3YjUxMWViL2NoYXB0ZXJfNTYvY2hfNTZfNy5qcGc=");
        // https://vps1.s2manga.com/manga_14f1237ef67855b265687d388420fb95/chapter_23/ch_23_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly92cHMxLnMybWFuZ2EuY29tL21hbmdhXzE0ZjEyMzdlZjY3ODU1YjI2NTY4N2QzODg0MjBmYjk1L2NoYXB0ZXJfMjMvY2hfMjNfNi5qcGc=");
    }
}

