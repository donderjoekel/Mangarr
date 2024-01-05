using System.Collections;

namespace Mangarr.Backend.Tests;

public class CoffeeMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "coffeemanga";

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
        // https://coffeemanga.io/manga/since-my-time-is-limited-im-entering-a-contract-marriage/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9zaW5jZS1teS10aW1lLWlzLWxpbWl0ZWQtaW0tZW50ZXJpbmctYS1jb250cmFjdC1tYXJyaWFnZS8=");
        // https://coffeemanga.io/manga/absolute-threshold/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQv");
        // https://coffeemanga.io/manga/how-to-protect-my-male-lead/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9ob3ctdG8tcHJvdGVjdC1teS1tYWxlLWxlYWQv");
        // https://coffeemanga.io/manga/i-raised-my-fiance-with-money/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9pLXJhaXNlZC1teS1maWFuY2Utd2l0aC1tb25leS8=");
        // https://coffeemanga.io/manga/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9wbGVhc2UtZ2V0LW91dC1vZi1teS1ob3VzZWhvbGQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://coffeemanga.io/manga/absolute-threshold/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci0xLw==");
        // https://coffeemanga.io/manga/i-raised-my-fiance-with-money/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9pLXJhaXNlZC1teS1maWFuY2Utd2l0aC1tb25leS9jaGFwdGVyLTIv");
        // https://coffeemanga.io/manga/please-get-out-of-my-household/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9wbGVhc2UtZ2V0LW91dC1vZi1teS1ob3VzZWhvbGQvY2hhcHRlci0xLw==");
        // https://coffeemanga.io/manga/absolute-threshold/chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci0xMS8=");
        // https://coffeemanga.io/manga/absolute-threshold/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci05Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65952381ca144/719ba8d9411fe09f3e356c40f57f4032/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1MjM4MWNhMTQ0LzcxOWJhOGQ5NDExZmUwOWYzZTM1NmM0MGY1N2Y0MDMyLzEuanBn");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_6592d89d6923e/0eb9794239fe207f0b00c94f73267412/image-01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkyZDg5ZDY5MjNlLzBlYjk3OTQyMzlmZTIwN2YwYjAwYzk0ZjczMjY3NDEyL2ltYWdlLTAxLmpwZw==");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_6592fc9d92b30/664c2728d9257093764737c8778dccd2/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkyZmM5ZDkyYjMwLzY2NGMyNzI4ZDkyNTcwOTM3NjQ3MzdjODc3OGRjY2QyLzAyLmpwZw==");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_6592d89d6923e/0eb9794239fe207f0b00c94f73267412/image-02.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkyZDg5ZDY5MjNlLzBlYjk3OTQyMzlmZTIwN2YwYjAwYzk0ZjczMjY3NDEyL2ltYWdlLTAyLndlYnA=");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65952381ca144/66f95cf91e33f72e595417bb3a10adff/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1MjM4MWNhMTQ0LzY2Zjk1Y2Y5MWUzM2Y3MmU1OTU0MTdiYjNhMTBhZGZmLzAyLmpwZw==");
    }
}

