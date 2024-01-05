using System.Collections;

namespace Mangarr.Backend.Tests;

public class TheGuildSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "theguild";

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
        // https://theguildscans.com/manga/castle-2-pinnacle/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS9jYXN0bGUtMi1waW5uYWNsZS8=");
        // https://theguildscans.com/manga/the-darkness-was-comfortable-for-me/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS90aGUtZGFya25lc3Mtd2FzLWNvbWZvcnRhYmxlLWZvci1tZS8=");
        // https://theguildscans.com/manga/what-do-you-wish-for-with-those-murky-eyes/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS93aGF0LWRvLXlvdS13aXNoLWZvci13aXRoLXRob3NlLW11cmt5LWV5ZXMv");
        // https://theguildscans.com/manga/the-greatest-philosopher-with-zero-magic/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS90aGUtZ3JlYXRlc3QtcGhpbG9zb3BoZXItd2l0aC16ZXJvLW1hZ2ljLw==");
        // https://theguildscans.com/manga/villager-a-wants-to-save-the-villainess-no-matter-what/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS92aWxsYWdlci1hLXdhbnRzLXRvLXNhdmUtdGhlLXZpbGxhaW5lc3Mtbm8tbWF0dGVyLXdoYXQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://theguildscans.com/manga/the-darkness-was-comfortable-for-me/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS90aGUtZGFya25lc3Mtd2FzLWNvbWZvcnRhYmxlLWZvci1tZS9jaGFwdGVyLTQv");
        // https://theguildscans.com/manga/castle-2-pinnacle/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS9jYXN0bGUtMi1waW5uYWNsZS9jaGFwdGVyLTcv");
        // https://theguildscans.com/manga/the-darkness-was-comfortable-for-me/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS90aGUtZGFya25lc3Mtd2FzLWNvbWZvcnRhYmxlLWZvci1tZS9jaGFwdGVyLTgv");
        // https://theguildscans.com/manga/villager-a-wants-to-save-the-villainess-no-matter-what/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS92aWxsYWdlci1hLXdhbnRzLXRvLXNhdmUtdGhlLXZpbGxhaW5lc3Mtbm8tbWF0dGVyLXdoYXQvY2hhcHRlci0xLw==");
        // https://theguildscans.com/manga/what-do-you-wish-for-with-those-murky-eyes/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS9tYW5nYS93aGF0LWRvLXlvdS13aXNoLWZvci13aXRoLXRob3NlLW11cmt5LWV5ZXMvY2hhcHRlci0zLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://theguildscans.com/wp-content/uploads/WP-manga/data/manga_6440f90c74674/a683f77a94bd515ae378484e4ea7ba04/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQwZjkwYzc0Njc0L2E2ODNmNzdhOTRiZDUxNWFlMzc4NDg0ZTRlYTdiYTA0LzAzLmpwZw==");
        // https://theguildscans.com/wp-content/uploads/WP-manga/data/manga_6440f90c74674/a683f77a94bd515ae378484e4ea7ba04/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQwZjkwYzc0Njc0L2E2ODNmNzdhOTRiZDUxNWFlMzc4NDg0ZTRlYTdiYTA0LzA0LmpwZw==");
        // https://theguildscans.com/wp-content/uploads/WP-manga/data/manga_620f08cc3c747/6ddbd659416139f233e7f7a644fb1c3a/00.png
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MjBmMDhjYzNjNzQ3LzZkZGJkNjU5NDE2MTM5ZjIzM2U3ZjdhNjQ0ZmIxYzNhLzAwLnBuZw==");
        // https://theguildscans.com/wp-content/uploads/WP-manga/data/manga_6286485c6aa56/6e502fd9b333510a056e79f5d6601544/00.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82Mjg2NDg1YzZhYTU2LzZlNTAyZmQ5YjMzMzUxMGEwNTZlNzlmNWQ2NjAxNTQ0LzAwLmpwZw==");
        // https://theguildscans.com/wp-content/uploads/WP-manga/data/manga_6440f90c74674/a683f77a94bd515ae378484e4ea7ba04/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVndWlsZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQwZjkwYzc0Njc0L2E2ODNmNzdhOTRiZDUxNWFlMzc4NDg0ZTRlYTdiYTA0LzA1LmpwZw==");
    }
}

