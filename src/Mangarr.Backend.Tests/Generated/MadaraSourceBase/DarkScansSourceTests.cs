using System.Collections;

namespace Mangarr.Backend.Tests;

public class DarkScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "darkscans";

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
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLw==");
        // https://darkscans.com/mangas/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9yZWluY2FybmF0b3Iv");
        // https://darkscans.com/mangas/the-demon-emperor-hopes-for-a-hero/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLw==");
        // https://darkscans.com/mangas/it-turns-out-that-i-have-been-invincible-for-a-long-time/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9pdC10dXJucy1vdXQtdGhhdC1pLWhhdmUtYmVlbi1pbnZpbmNpYmxlLWZvci1hLWxvbmctdGltZS8=");
        // https://darkscans.com/mangas/0-kill-assassine/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy8wLWtpbGwtYXNzYXNzaW5lLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTcv");
        // https://darkscans.com/mangas/0-kill-assassine/chapter-01/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy8wLWtpbGwtYXNzYXNzaW5lL2NoYXB0ZXItMDEv");
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTgv");
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItOS8=");
        // https://darkscans.com/mangas/the-demon-emperor-hopes-for-a-hero/chapter-02/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvL2NoYXB0ZXItMDIv");
    }

    public static IEnumerable ValidImages()
    {
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-18/mr-devourer-please-act-like-a-final-boss-c81e728d9d4c2f636f067f89cc14862c.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTE4L21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtYzgxZTcyOGQ5ZDRjMmY2MzZmMDY3Zjg5Y2MxNDg2MmMuanBn");
        // http://cdn1.darkscans.com/manga/the-demon-emperor-hopes-for-a-hero-02/the-demon-emperor-hopes-for-a-hero-cfcd208495d565ef66e7dff9f98764da.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLTAyL3RoZS1kZW1vbi1lbXBlcm9yLWhvcGVzLWZvci1hLWhlcm8tY2ZjZDIwODQ5NWQ1NjVlZjY2ZTdkZmY5Zjk4NzY0ZGEuanBn");
        // http://cdn1.darkscans.com/manga/the-demon-emperor-hopes-for-a-hero-02/the-demon-emperor-hopes-for-a-hero-c51ce410c124a10e0db5e4b97fc2af39.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLTAyL3RoZS1kZW1vbi1lbXBlcm9yLWhvcGVzLWZvci1hLWhlcm8tYzUxY2U0MTBjMTI0YTEwZTBkYjVlNGI5N2ZjMmFmMzkuanBn");
        // http://cdn1.darkscans.com/manga/0-kill-assassine-01/0-kill-assassine-a87ff679a2f3e71d9181a67b7542122c.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS8wLWtpbGwtYXNzYXNzaW5lLTAxLzAta2lsbC1hc3Nhc3NpbmUtYTg3ZmY2NzlhMmYzZTcxZDkxODFhNjdiNzU0MjEyMmMuanBn");
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-17/mr-devourer-please-act-like-a-final-boss-8e296a067a37563370ded05f5a3bf3ec.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTE3L21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtOGUyOTZhMDY3YTM3NTYzMzcwZGVkMDVmNWEzYmYzZWMuanBn");
    }
}

