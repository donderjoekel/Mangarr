using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaRollsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangarolls";

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
        // https://mangarolls.net/manga/dark-and-light-martial-emperor-comic-manhwa/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3ItY29taWMtbWFuaHdhLw==");
        // https://mangarolls.net/manga/the-unbeatable-dungeons-lazy-boss-monster-manhwa-comic/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS90aGUtdW5iZWF0YWJsZS1kdW5nZW9ucy1sYXp5LWJvc3MtbW9uc3Rlci1tYW5od2EtY29taWMv");
        // https://mangarolls.net/manga/reincarnator-manhwa-comic/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9yZWluY2FybmF0b3ItbWFuaHdhLWNvbWljLw==");
        // https://mangarolls.net/manga/the-extras-academy-survival-guide-manhwa-comic/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS90aGUtZXh0cmFzLWFjYWRlbXktc3Vydml2YWwtZ3VpZGUtbWFuaHdhLWNvbWljLw==");
        // https://mangarolls.net/manga/black-corporation-joseon-manhwa-comic/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9ibGFjay1jb3Jwb3JhdGlvbi1qb3Nlb24tbWFuaHdhLWNvbWljLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangarolls.net/manga/the-unbeatable-dungeons-lazy-boss-monster-manhwa-comic/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS90aGUtdW5iZWF0YWJsZS1kdW5nZW9ucy1sYXp5LWJvc3MtbW9uc3Rlci1tYW5od2EtY29taWMvY2hhcHRlci0wLw==");
        // https://mangarolls.net/manga/dark-and-light-martial-emperor-comic-manhwa/chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3ItY29taWMtbWFuaHdhL2NoYXB0ZXItMTIv");
        // https://mangarolls.net/manga/dark-and-light-martial-emperor-comic-manhwa/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3ItY29taWMtbWFuaHdhL2NoYXB0ZXItMTcv");
        // https://mangarolls.net/manga/dark-and-light-martial-emperor-comic-manhwa/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3ItY29taWMtbWFuaHdhL2NoYXB0ZXItMTAv");
        // https://mangarolls.net/manga/dark-and-light-martial-emperor-comic-manhwa/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3ItY29taWMtbWFuaHdhL2NoYXB0ZXItNi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangarolls.net/wp-content/uploads/WP-manga/data/manga_6596e88a0a9a8/af66c4dc27db0539d5d7ef686f8b1820/05.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2ZTg4YTBhOWE4L2FmNjZjNGRjMjdkYjA1MzlkNWQ3ZWY2ODZmOGIxODIwLzA1LndlYnA=");
        // https://mangarolls.net/wp-content/uploads/WP-manga/data/manga_6596e88a0a9a8/a4cdd71de49add445c337599bfdb8d03/08.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2ZTg4YTBhOWE4L2E0Y2RkNzFkZTQ5YWRkNDQ1YzMzNzU5OWJmZGI4ZDAzLzA4LndlYnA=");
        // https://mangarolls.net/wp-content/uploads/WP-manga/data/manga_6596e88a0a9a8/cf79e2c5285dfddbebd776d817959bc9/03.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2ZTg4YTBhOWE4L2NmNzllMmM1Mjg1ZGZkZGJlYmQ3NzZkODE3OTU5YmM5LzAzLndlYnA=");
        // https://mangarolls.net/wp-content/uploads/WP-manga/data/manga_6596e88a0a9a8/cf79e2c5285dfddbebd776d817959bc9/16.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2ZTg4YTBhOWE4L2NmNzllMmM1Mjg1ZGZkZGJlYmQ3NzZkODE3OTU5YmM5LzE2LndlYnA=");
        // https://mangarolls.net/wp-content/uploads/WP-manga/data/manga_6591d360f073a/ba20f67adfe25d15fcd58de34cadef39/07.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJvbGxzLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxZDM2MGYwNzNhL2JhMjBmNjdhZGZlMjVkMTVmY2Q1OGRlMzRjYWRlZjM5LzA3LndlYnA=");
    }
}

