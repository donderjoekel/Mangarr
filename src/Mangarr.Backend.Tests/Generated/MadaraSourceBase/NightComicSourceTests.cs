using System.Collections;

namespace Mangarr.Backend.Tests;

public class NightComicSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "nightcomic";

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
        // https://www.nightcomic.com/manga/i-have-a-mansion-in-the-post-apocalyptic-world/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvaS1oYXZlLWEtbWFuc2lvbi1pbi10aGUtcG9zdC1hcG9jYWx5cHRpYy13b3JsZC8=");
        // https://www.nightcomic.com/manga/my-girlfriend-is-a-zombie/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvbXktZ2lybGZyaWVuZC1pcy1hLXpvbWJpZS8=");
        // https://www.nightcomic.com/manga/release-that-witch/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvcmVsZWFzZS10aGF0LXdpdGNoLw==");
        // https://www.nightcomic.com/manga/rebirth-of-the-urban-immortal-cultivator/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvcmViaXJ0aC1vZi10aGUtdXJiYW4taW1tb3J0YWwtY3VsdGl2YXRvci8=");
        // https://www.nightcomic.com/manga/the-kings-avatar-webtoon/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvdGhlLWtpbmdzLWF2YXRhci13ZWJ0b29uLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.nightcomic.com/manga/rebirth-of-the-urban-immortal-cultivator/chapter-93/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvcmViaXJ0aC1vZi10aGUtdXJiYW4taW1tb3J0YWwtY3VsdGl2YXRvci9jaGFwdGVyLTkzLw==");
        // https://www.nightcomic.com/manga/my-girlfriend-is-a-zombie/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvbXktZ2lybGZyaWVuZC1pcy1hLXpvbWJpZS9jaGFwdGVyLTUv");
        // https://www.nightcomic.com/manga/i-have-a-mansion-in-the-post-apocalyptic-world/chapter-491/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvaS1oYXZlLWEtbWFuc2lvbi1pbi10aGUtcG9zdC1hcG9jYWx5cHRpYy13b3JsZC9jaGFwdGVyLTQ5MS8=");
        // https://www.nightcomic.com/manga/my-girlfriend-is-a-zombie/chapter-238/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvbXktZ2lybGZyaWVuZC1pcy1hLXpvbWJpZS9jaGFwdGVyLTIzOC8=");
        // https://www.nightcomic.com/manga/i-have-a-mansion-in-the-post-apocalyptic-world/chapter-342/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vbWFuZ2EvaS1oYXZlLWEtbWFuc2lvbi1pbi10aGUtcG9zdC1hcG9jYWx5cHRpYy13b3JsZC9jaGFwdGVyLTM0Mi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://www.nightcomic.com/wp-content/uploads/WP-manga/data/manga_61e2e7ecbdaec/860612bbfcfba6ebf4a03ac19fec84c6/image-6.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjFlMmU3ZWNiZGFlYy84NjA2MTJiYmZjZmJhNmViZjRhMDNhYzE5ZmVjODRjNi9pbWFnZS02LmpwZw==");
        // https://www.nightcomic.com/wp-content/uploads/WP-manga/data/manga_61e2e7ecbdaec/6fa3b335239400e6b9f34f22a0733bc7/image-12.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjFlMmU3ZWNiZGFlYy82ZmEzYjMzNTIzOTQwMGU2YjlmMzRmMjJhMDczM2JjNy9pbWFnZS0xMi5qcGc=");
        // https://www.nightcomic.com/wp-content/uploads/WP-manga/data/manga_617151e48530b/57d3ed1b90bf1562e09808a744fe6d65/image-0.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjE3MTUxZTQ4NTMwYi81N2QzZWQxYjkwYmYxNTYyZTA5ODA4YTc0NGZlNmQ2NS9pbWFnZS0wLmpwZw==");
        // https://www.nightcomic.com/wp-content/uploads/WP-manga/data/manga_61e2e7ecbdaec/6fa3b335239400e6b9f34f22a0733bc7/image-2.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjFlMmU3ZWNiZGFlYy82ZmEzYjMzNTIzOTQwMGU2YjlmMzRmMjJhMDczM2JjNy9pbWFnZS0yLmpwZw==");
        // https://www.nightcomic.com/wp-content/uploads/WP-manga/data/manga_617151e48530b/57d3ed1b90bf1562e09808a744fe6d65/image-4.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubmlnaHRjb21pYy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjE3MTUxZTQ4NTMwYi81N2QzZWQxYjkwYmYxNTYyZTA5ODA4YTc0NGZlNmQ2NS9pbWFnZS00LmpwZw==");
    }
}

