using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaZoneSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuazone";

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
        // https://manhuazone.org/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3Iv");
        // https://manhuazone.org/manga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLw==");
        // https://manhuazone.org/manga/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9yZWluY2FybmF0b3Iv");
        // https://manhuazone.org/manga/black-corporation-joseon/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9ibGFjay1jb3Jwb3JhdGlvbi1qb3Nlb24v");
        // https://manhuazone.org/manga/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS90aGUtZXh0cmFzLWFjYWRlbXktc3Vydml2YWwtZ3VpZGUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuazone.org/manga/mr-devourer-please-act-like-a-final-boss/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTUv");
        // https://manhuazone.org/manga/dark-and-light-martial-emperor/chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci0xMy8=");
        // https://manhuazone.org/manga/the-extras-academy-survival-guide/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS90aGUtZXh0cmFzLWFjYWRlbXktc3Vydml2YWwtZ3VpZGUvY2hhcHRlci0wLw==");
        // https://manhuazone.org/manga/mr-devourer-please-act-like-a-final-boss/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMTcv");
        // https://manhuazone.org/manga/mr-devourer-please-act-like-a-final-boss/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItNC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://manhuazone.org/wp-content/uploads/WP-manga/data/manga_6596fe0626764/0251eaf3b064fe5fa8f81f045a1f5bd2/02.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2ZmUwNjI2NzY0LzAyNTFlYWYzYjA2NGZlNWZhOGY4MWYwNDVhMWY1YmQyLzAyLndlYnA=");
        // https://manhuazone.org/wp-content/uploads/WP-manga/data/manga_6591d3624a967/806311e5cd87e7831d865949de08840f/08-0.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxZDM2MjRhOTY3LzgwNjMxMWU1Y2Q4N2U3ODMxZDg2NTk0OWRlMDg4NDBmLzA4LTAud2VicA==");
        // https://manhuazone.org/wp-content/uploads/WP-manga/data/manga_6591d3624a967/806311e5cd87e7831d865949de08840f/03-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxZDM2MjRhOTY3LzgwNjMxMWU1Y2Q4N2U3ODMxZDg2NTk0OWRlMDg4NDBmLzAzLTEud2VicA==");
        // https://manhuazone.org/wp-content/uploads/WP-manga/data/manga_658dc7ec1c783/05bf05e6ddb1619b4a683aec5beb5bd3/7-0.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NThkYzdlYzFjNzgzLzA1YmYwNWU2ZGRiMTYxOWI0YTY4M2FlYzViZWI1YmQzLzctMC53ZWJw");
        // https://manhuazone.org/wp-content/uploads/WP-manga/data/manga_6591d3624a967/fbe9518bf64d090690b8ef62088d5fdd/08-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWF6b25lLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxZDM2MjRhOTY3L2ZiZTk1MThiZjY0ZDA5MDY5MGI4ZWY2MjA4OGQ1ZmRkLzA4LTEud2VicA==");
    }
}

