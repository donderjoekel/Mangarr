using System.Collections;

namespace Mangarr.Backend.Tests;

public class AquaMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "aquamanga";

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
        // https://aquamanga.org/manga/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1leHRyYXMtYWNhZGVteS1zdXJ2aXZhbC1ndWlkZS8=");
        // https://aquamanga.org/manga/the-archmages-daughter/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1hcmNobWFnZXMtZGF1Z2h0ZXIv");
        // https://aquamanga.org/manga/the-guy-she-was-interested-in-wasnt-a-guy-at-all/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1ndXktc2hlLXdhcy1pbnRlcmVzdGVkLWluLXdhc250LWEtZ3V5LWF0LWFsbC8=");
        // https://aquamanga.org/manga/the-descent-of-the-patriarch/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1kZXNjZW50LW9mLXRoZS1wYXRyaWFyY2gv");
        // https://aquamanga.org/manga/shin-no-jitsuryoku-wa-girigiri-made-kakushite-iyou-to-omou/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3NoaW4tbm8taml0c3VyeW9rdS13YS1naXJpZ2lyaS1tYWRlLWtha3VzaGl0ZS1peW91LXRvLW9tb3Uv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://aquamanga.org/manga/the-descent-of-the-patriarch/the-descent-of-the-patriarch/ch-20-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1kZXNjZW50LW9mLXRoZS1wYXRyaWFyY2gvdGhlLWRlc2NlbnQtb2YtdGhlLXBhdHJpYXJjaC9jaC0yMC1jaGFwdGVyLTIwLw==");
        // https://aquamanga.org/manga/the-archmages-daughter/the-archmages-daughter/chapter-171/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1hcmNobWFnZXMtZGF1Z2h0ZXIvdGhlLWFyY2htYWdlcy1kYXVnaHRlci9jaGFwdGVyLTE3MS8=");
        // https://aquamanga.org/manga/the-archmages-daughter/the-archmages-daughter/chapter-188/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1hcmNobWFnZXMtZGF1Z2h0ZXIvdGhlLWFyY2htYWdlcy1kYXVnaHRlci9jaGFwdGVyLTE4OC8=");
        // https://aquamanga.org/manga/the-archmages-daughter/the-archmages-daughter/chapter-44/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1hcmNobWFnZXMtZGF1Z2h0ZXIvdGhlLWFyY2htYWdlcy1kYXVnaHRlci9jaGFwdGVyLTQ0Lw==");
        // https://aquamanga.org/manga/the-guy-she-was-interested-in-wasnt-a-guy-at-all/the-guy-she-was-interested-in-wasnt-a-guy-at-all/chapter-70-my-star/
        yield return new TestCaseData("aHR0cHM6Ly9hcXVhbWFuZ2Eub3JnL21hbmdhL3RoZS1ndXktc2hlLXdhcy1pbnRlcmVzdGVkLWluLXdhc250LWEtZ3V5LWF0LWFsbC90aGUtZ3V5LXNoZS13YXMtaW50ZXJlc3RlZC1pbi13YXNudC1hLWd1eS1hdC1hbGwvY2hhcHRlci03MC1teS1zdGFyLw==");
    }

    public static IEnumerable ValidImages()
    {
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6595594183a47/e332060dbfb4cfdc5e827979f8f87204/27.webp
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NTU5NDE4M2E0Ny9lMzMyMDYwZGJmYjRjZmRjNWU4Mjc5NzlmOGY4NzIwNC8yNy53ZWJw");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6595594183a47/e332060dbfb4cfdc5e827979f8f87204/55.webp
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NTU5NDE4M2E0Ny9lMzMyMDYwZGJmYjRjZmRjNWU4Mjc5NzlmOGY4NzIwNC81NS53ZWJw");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6595594183a47/e332060dbfb4cfdc5e827979f8f87204/49.webp
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NTU5NDE4M2E0Ny9lMzMyMDYwZGJmYjRjZmRjNWU4Mjc5NzlmOGY4NzIwNC80OS53ZWJw");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6595594183a47/70eeb795394381e5b6a53e66021e45e3/11.webp
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NTU5NDE4M2E0Ny83MGVlYjc5NTM5NDM4MWU1YjZhNTNlNjYwMjFlNDVlMy8xMS53ZWJw");
        // http://aquamanga.org/wp-content/uploads/WP-manga/data/manga_6595594183a47/e332060dbfb4cfdc5e827979f8f87204/50.webp
        yield return new TestCaseData("aHR0cDovL2FxdWFtYW5nYS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NTU5NDE4M2E0Ny9lMzMyMDYwZGJmYjRjZmRjNWU4Mjc5NzlmOGY4NzIwNC81MC53ZWJw");
    }
}

