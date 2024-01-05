using System.Collections;

namespace Mangarr.Backend.Tests;

public class AQUAScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "aquascans";

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
        // https://aquascans.com/manga/the-demon-emperor-hopes-for-a-hero/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL3RoZS1kZW1vbi1lbXBlcm9yLWhvcGVzLWZvci1hLWhlcm8v");
        // https://aquascans.com/manga/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL3JlaW5jYXJuYXRvci8=");
        // https://aquascans.com/manga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3Mv");
        // https://aquascans.com/manga/0-kill-assassine/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhLzAta2lsbC1hc3Nhc3NpbmUv");
        // https://aquascans.com/manga/black-corporation-joseon/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL2JsYWNrLWNvcnBvcmF0aW9uLWpvc2Vvbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://aquascans.com/manga/black-corporation-joseon/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL2JsYWNrLWNvcnBvcmF0aW9uLWpvc2Vvbi9jaGFwdGVyLTgv");
        // https://aquascans.com/manga/mr-devourer-please-act-like-a-final-boss/chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MvY2hhcHRlci0xMS8=");
        // https://aquascans.com/manga/mr-devourer-please-act-like-a-final-boss/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MvY2hhcHRlci0xOS8=");
        // https://aquascans.com/manga/black-corporation-joseon/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL2JsYWNrLWNvcnBvcmF0aW9uLWpvc2Vvbi9jaGFwdGVyLTE4Lw==");
        // https://aquascans.com/manga/reincarnator/chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhc2NhbnMuY29tL21hbmdhL3JlaW5jYXJuYXRvci9jaGFwdGVyLTI0Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.aquascans.com/black-corporation-joseon/chapter-18/13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYXF1YXNjYW5zLmNvbS9ibGFjay1jb3Jwb3JhdGlvbi1qb3Nlb24vY2hhcHRlci0xOC8xMy5qcGc=");
        // https://cdn.aquascans.com/reincarnator/chapter-24/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYXF1YXNjYW5zLmNvbS9yZWluY2FybmF0b3IvY2hhcHRlci0yNC84LmpwZw==");
        // https://cdn.aquascans.com/reincarnator/chapter-24/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYXF1YXNjYW5zLmNvbS9yZWluY2FybmF0b3IvY2hhcHRlci0yNC81LmpwZw==");
        // https://cdn.aquascans.com/mr-devourer-please-act-like-a-final-boss/chapter-11/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYXF1YXNjYW5zLmNvbS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTEvOS5qcGc=");
        // https://cdn.aquascans.com/black-corporation-joseon/chapter-8/11.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYXF1YXNjYW5zLmNvbS9ibGFjay1jb3Jwb3JhdGlvbi1qb3Nlb24vY2hhcHRlci04LzExLndlYnA=");
    }
}

