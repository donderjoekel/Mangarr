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
        // https://coffeemanga.io/manga/i-raised-my-fiance-with-money/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9pLXJhaXNlZC1teS1maWFuY2Utd2l0aC1tb25leS9jaGFwdGVyLTMv");
        // https://coffeemanga.io/manga/absolute-threshold/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci03Lw==");
        // https://coffeemanga.io/manga/absolute-threshold/chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci0xMS8=");
        // https://coffeemanga.io/manga/absolute-threshold/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci0zLw==");
        // https://coffeemanga.io/manga/absolute-threshold/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby9tYW5nYS9hYnNvbHV0ZS10aHJlc2hvbGQvY2hhcHRlci02Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65952381ca144/8da1258992eaa2979a6b64b00ef7db62/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1MjM4MWNhMTQ0LzhkYTEyNTg5OTJlYWEyOTc5YTZiNjRiMDBlZjdkYjYyLzAxLmpwZw==");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65952381ca144/719ba8d9411fe09f3e356c40f57f4032/2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1MjM4MWNhMTQ0LzcxOWJhOGQ5NDExZmUwOWYzZTM1NmM0MGY1N2Y0MDMyLzIuanBn");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65952381ca144/27ba85b1eb556c08c76121a5f3f828aa/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1MjM4MWNhMTQ0LzI3YmE4NWIxZWI1NTZjMDhjNzYxMjFhNWYzZjgyOGFhLzEuanBn");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65952381ca144/719ba8d9411fe09f3e356c40f57f4032/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1MjM4MWNhMTQ0LzcxOWJhOGQ5NDExZmUwOWYzZTM1NmM0MGY1N2Y0MDMyLzEuanBn");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_6592fc9d92b30/923b7af2a7ceabc41720a21ce9f7d1b2/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkyZmM5ZDkyYjMwLzkyM2I3YWYyYTdjZWFiYzQxNzIwYTIxY2U5ZjdkMWIyLzAyLmpwZw==");
    }
}

