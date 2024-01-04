using System.Collections;

namespace Mangarr.Backend.Tests;

public class AnimatedGlitchScansSourceTests : SourceTestBase
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
        // https://anigliscans.xyz/series/im-the-only-one-with-outstanding-cheats-after-my-class-got-transported-to-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovc2VyaWVzL2ltLXRoZS1vbmx5LW9uZS13aXRoLW91dHN0YW5kaW5nLWNoZWF0cy1hZnRlci1teS1jbGFzcy1nb3QtdHJhbnNwb3J0ZWQtdG8tYW5vdGhlci13b3JsZC8=");
        // https://anigliscans.xyz/series/the-book-of-abyss/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovc2VyaWVzL3RoZS1ib29rLW9mLWFieXNzLw==");
        // https://anigliscans.xyz/series/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovc2VyaWVzL3BsZWFzZS1nZXQtb3V0LW9mLW15LWhvdXNlaG9sZC8=");
        // https://anigliscans.xyz/series/awakened-thief-steals-the-world/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovc2VyaWVzL2F3YWtlbmVkLXRoaWVmLXN0ZWFscy10aGUtd29ybGQv");
        // https://anigliscans.xyz/series/unrivaled-gamer-dominating-with-the-ex-skill-hero-master/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovc2VyaWVzL3Vucml2YWxlZC1nYW1lci1kb21pbmF0aW5nLXdpdGgtdGhlLWV4LXNraWxsLWhlcm8tbWFzdGVyLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://anigliscans.xyz/the-book-of-abyss-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovdGhlLWJvb2stb2YtYWJ5c3MtY2hhcHRlci0zLw==");
        // https://anigliscans.xyz/please-get-out-of-my-household-3/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovcGxlYXNlLWdldC1vdXQtb2YtbXktaG91c2Vob2xkLTMv");
        // https://anigliscans.xyz/awakened-thief-steals-the-world-7/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovYXdha2VuZWQtdGhpZWYtc3RlYWxzLXRoZS13b3JsZC03Lw==");
        // https://anigliscans.xyz/awakened-thief-steals-the-world-4/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovYXdha2VuZWQtdGhpZWYtc3RlYWxzLXRoZS13b3JsZC00Lw==");
        // https://anigliscans.xyz/awakened-thief-steals-the-world-5/
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovYXdha2VuZWQtdGhpZWYtc3RlYWxzLXRoZS13b3JsZC01Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://anigliscans.xyz/wp-content/uploads/2023/12/01-10.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEtMTAuanBlZw==");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/11-10.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTEtMTAuanBlZw==");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/07-12.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDctMTIuanBlZw==");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/09-3.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDktMy5qcGVn");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/01-12.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEtMTIuanBlZw==");
    }
}

