using System.Collections;

namespace Mangarr.Backend.Tests;

public class HreadsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hreads";

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
        // https://hreads.net/comic/the-novels-extra/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1ub3ZlbHMtZXh0cmEv");
        // https://hreads.net/comic/the-player/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1wbGF5ZXIv");
        // https://hreads.net/comic/relationship-reverse-button/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3JlbGF0aW9uc2hpcC1yZXZlcnNlLWJ1dHRvbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hreads.net/comic/the-novels-extra/chapter-84/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1ub3ZlbHMtZXh0cmEvY2hhcHRlci04NC8=");
        // https://hreads.net/comic/the-player/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1wbGF5ZXIvY2hhcHRlci01Lw==");
        // https://hreads.net/comic/the-novels-extra/chapter-59/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1ub3ZlbHMtZXh0cmEvY2hhcHRlci01OS8=");
        // https://hreads.net/comic/the-novels-extra/chapter-70/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1ub3ZlbHMtZXh0cmEvY2hhcHRlci03MC8=");
        // https://hreads.net/comic/the-novels-extra/chapter-82/
        yield return new TestCaseData("aHR0cHM6Ly9ocmVhZHMubmV0L2NvbWljL3RoZS1ub3ZlbHMtZXh0cmEvY2hhcHRlci04Mi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.hreads.net/manga_657cc7fcb3557/1b8ce28fa3b68c4f63609792316ee1e06473a0bd/8.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaHJlYWRzLm5ldC9tYW5nYV82NTdjYzdmY2IzNTU3LzFiOGNlMjhmYTNiNjhjNGY2MzYwOTc5MjMxNmVlMWUwNjQ3M2EwYmQvOC53ZWJw");
        // https://cdn.hreads.net/manga_657cc7fcb3557/7d5b288b8de3612498f21ffb72ed4ae7525327cb/11.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaHJlYWRzLm5ldC9tYW5nYV82NTdjYzdmY2IzNTU3LzdkNWIyODhiOGRlMzYxMjQ5OGYyMWZmYjcyZWQ0YWU3NTI1MzI3Y2IvMTEud2VicA==");
        // https://cdn.hreads.net/manga_657cc7fcb3557/d947d045f8fc2f58e0f58c4427f7fab73d5bd16e/2.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaHJlYWRzLm5ldC9tYW5nYV82NTdjYzdmY2IzNTU3L2Q5NDdkMDQ1ZjhmYzJmNThlMGY1OGM0NDI3ZjdmYWI3M2Q1YmQxNmUvMi53ZWJw");
        // https://cdn.hreads.net/manga_657cc7fcb3557/27533459940f84fd0123e9c0564a1d9d11220a62/8.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaHJlYWRzLm5ldC9tYW5nYV82NTdjYzdmY2IzNTU3LzI3NTMzNDU5OTQwZjg0ZmQwMTIzZTljMDU2NGExZDlkMTEyMjBhNjIvOC53ZWJw");
        // https://cdn.hreads.net/manga_657cc7fcb3557/7d5b288b8de3612498f21ffb72ed4ae7525327cb/9.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaHJlYWRzLm5ldC9tYW5nYV82NTdjYzdmY2IzNTU3LzdkNWIyODhiOGRlMzYxMjQ5OGYyMWZmYjcyZWQ0YWU3NTI1MzI3Y2IvOS53ZWJw");
    }
}

