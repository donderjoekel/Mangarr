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
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMi8=");
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTYv");
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTAv");
        // https://darkscans.com/mangas/reincarnator/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9yZWluY2FybmF0b3IvY2hhcHRlci01Lw==");
        // https://darkscans.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9kYXJrc2NhbnMuY29tL21hbmdhcy9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTcv");
    }

    public static IEnumerable ValidImages()
    {
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-17/mr-devourer-please-act-like-a-final-boss-45c48cce2e2d7fbdea1afc51c7c6ad26.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTE3L21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtNDVjNDhjY2UyZTJkN2ZiZGVhMWFmYzUxYzdjNmFkMjYuanBn");
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-2/mr-devourer-please-act-like-a-final-boss-d3d9446802a44259755d38e6d163e820.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTIvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy1kM2Q5NDQ2ODAyYTQ0MjU5NzU1ZDM4ZTZkMTYzZTgyMC5qcGc=");
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-16/mr-devourer-please-act-like-a-final-boss-c4ca4238a0b923820dcc509a6f75849b.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTE2L21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtYzRjYTQyMzhhMGI5MjM4MjBkY2M1MDlhNmY3NTg0OWIuanBn");
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-2/mr-devourer-please-act-like-a-final-boss-cfcd208495d565ef66e7dff9f98764da.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTIvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy1jZmNkMjA4NDk1ZDU2NWVmNjZlN2RmZjlmOTg3NjRkYS5qcGc=");
        // http://cdn1.darkscans.com/manga/mr-devourer-please-act-like-a-final-boss-16/mr-devourer-please-act-like-a-final-boss-e4da3b7fbbce2345d7772b0674a318d5.jpg
        yield return new TestCaseData("aHR0cDovL2NkbjEuZGFya3NjYW5zLmNvbS9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTE2L21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MtZTRkYTNiN2ZiYmNlMjM0NWQ3NzcyYjA2NzRhMzE4ZDUuanBn");
    }
}

