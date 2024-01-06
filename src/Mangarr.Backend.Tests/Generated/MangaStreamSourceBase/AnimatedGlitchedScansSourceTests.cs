using System.Collections;

namespace Mangarr.Backend.Tests;

public class AnimatedGlitchedScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "anigliscans";

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
        // https://anigliscans.xyz?p=47169
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NzE2OXw0NzE2OQ==");
        // https://anigliscans.xyz?p=46620
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjYyMHw0NjYyMA==");
        // https://anigliscans.xyz?p=46028
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjAyOHw0NjAyOA==");
        // https://anigliscans.xyz?p=45570
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NTU3MHw0NTU3MA==");
        // https://anigliscans.xyz?p=43278
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00MzI3OHw0MzI3OA==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://anigliscans.xyz/awakened-thief-steals-the-world-4/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovYXdha2VuZWQtdGhpZWYtc3RlYWxzLXRoZS13b3JsZC00L3xodHRwczovL2FuaWdsaXNjYW5zLnh5ej9wPTQ1NTcwfDQ=");
        // https://anigliscans.xyz/im-the-only-one-with-outstanding-cheats-after-my-class-got-transported-to-another-world-1/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovaW0tdGhlLW9ubHktb25lLXdpdGgtb3V0c3RhbmRpbmctY2hlYXRzLWFmdGVyLW15LWNsYXNzLWdvdC10cmFuc3BvcnRlZC10by1hbm90aGVyLXdvcmxkLTEvfGh0dHBzOi8vYW5pZ2xpc2NhbnMueHl6P3A9NDcxNjl8MQ==");
        // https://anigliscans.xyz/awakened-thief-steals-the-world-2/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovYXdha2VuZWQtdGhpZWYtc3RlYWxzLXRoZS13b3JsZC0yL3xodHRwczovL2FuaWdsaXNjYW5zLnh5ej9wPTQ1NTcwfDI=");
        // https://anigliscans.xyz/please-get-out-of-my-household-1/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovcGxlYXNlLWdldC1vdXQtb2YtbXktaG91c2Vob2xkLTEvfGh0dHBzOi8vYW5pZ2xpc2NhbnMueHl6P3A9NDYwMjh8MQ==");
        // https://anigliscans.xyz/the-book-of-abyss-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovdGhlLWJvb2stb2YtYWJ5c3MtY2hhcHRlci0zL3xodHRwczovL2FuaWdsaXNjYW5zLnh5ej9wPTQ2NjIwfDM=");
    }

    public static IEnumerable ValidImages()
    {
        // https://anigliscans.xyz/wp-content/uploads/2024/01/02-3.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItMy5qcGVn");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/02-3.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDItMy5qcGVn");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/00-1.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDAtMS5qcGVn");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/12-1.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTItMS5qcGVn");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/01-40.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEtNDAuanBn");
    }
}

