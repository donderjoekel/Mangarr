using System.Collections;

namespace Mangarr.Backend.Tests;

public class FreeWebtoonCoinsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "freewebtooncoins";

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
        // https://freewebtooncoins.com/webtoon/i-failed-to-throw-the-villain-away/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL2ktZmFpbGVkLXRvLXRocm93LXRoZS12aWxsYWluLWF3YXkv");
        // https://freewebtooncoins.com/webtoon/quick-transmigration-top-notch-villain-must-be-cleansed/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL3F1aWNrLXRyYW5zbWlncmF0aW9uLXRvcC1ub3RjaC12aWxsYWluLW11c3QtYmUtY2xlYW5zZWQv");
        // https://freewebtooncoins.com/webtoon/the-stepmother-likes-harems/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL3RoZS1zdGVwbW90aGVyLWxpa2VzLWhhcmVtcy8=");
        // https://freewebtooncoins.com/webtoon/i-see-your-death/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL2ktc2VlLXlvdXItZGVhdGgv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://freewebtooncoins.com/webtoon/the-stepmother-likes-harems/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL3RoZS1zdGVwbW90aGVyLWxpa2VzLWhhcmVtcy9jaGFwdGVyLTAv");
        // https://freewebtooncoins.com/webtoon/quick-transmigration-top-notch-villain-must-be-cleansed/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL3F1aWNrLXRyYW5zbWlncmF0aW9uLXRvcC1ub3RjaC12aWxsYWluLW11c3QtYmUtY2xlYW5zZWQvY2hhcHRlci0wLw==");
        // https://freewebtooncoins.com/webtoon/i-failed-to-throw-the-villain-away/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL2ktZmFpbGVkLXRvLXRocm93LXRoZS12aWxsYWluLWF3YXkvY2hhcHRlci04Lw==");
        // https://freewebtooncoins.com/webtoon/quick-transmigration-top-notch-villain-must-be-cleansed/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL3F1aWNrLXRyYW5zbWlncmF0aW9uLXRvcC1ub3RjaC12aWxsYWluLW11c3QtYmUtY2xlYW5zZWQvY2hhcHRlci0xLw==");
        // https://freewebtooncoins.com/webtoon/i-failed-to-throw-the-villain-away/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93ZWJ0b29uL2ktZmFpbGVkLXRvLXRocm93LXRoZS12aWxsYWluLWF3YXkvY2hhcHRlci0yMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://freewebtooncoins.com/wp-content/uploads/WP-manga/data/i-failed-to-throw-the-villain-away/chapter-8/chapter-8_39.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9pLWZhaWxlZC10by10aHJvdy10aGUtdmlsbGFpbi1hd2F5L2NoYXB0ZXItOC9jaGFwdGVyLThfMzkuanBn");
        // https://freewebtooncoins.com/wp-content/uploads/WP-manga/data/i-failed-to-throw-the-villain-away/chapter-21/chapter-21_45.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9pLWZhaWxlZC10by10aHJvdy10aGUtdmlsbGFpbi1hd2F5L2NoYXB0ZXItMjEvY2hhcHRlci0yMV80NS5qcGc=");
        // https://freewebtooncoins.com/wp-content/uploads/WP-manga/data/i-failed-to-throw-the-villain-away/chapter-21/chapter-21_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9pLWZhaWxlZC10by10aHJvdy10aGUtdmlsbGFpbi1hd2F5L2NoYXB0ZXItMjEvY2hhcHRlci0yMV81LmpwZw==");
        // https://freewebtooncoins.com/wp-content/uploads/WP-manga/data/i-failed-to-throw-the-villain-away/chapter-8/chapter-8_19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9pLWZhaWxlZC10by10aHJvdy10aGUtdmlsbGFpbi1hd2F5L2NoYXB0ZXItOC9jaGFwdGVyLThfMTkuanBn");
        // https://freewebtooncoins.com/wp-content/uploads/WP-manga/data/the-stepmother-likes-harems/chapter-0/chapter-0_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mcmVld2VidG9vbmNvaW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS90aGUtc3RlcG1vdGhlci1saWtlcy1oYXJlbXMvY2hhcHRlci0wL2NoYXB0ZXItMF81LmpwZw==");
    }
}

