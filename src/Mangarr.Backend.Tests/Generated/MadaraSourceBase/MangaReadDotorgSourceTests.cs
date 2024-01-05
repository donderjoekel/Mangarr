using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaReadDotorgSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaread.org";

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
        // https://www.mangaread.org/manga/i-suddenly-have-an-older-sister/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9pLXN1ZGRlbmx5LWhhdmUtYW4tb2xkZXItc2lzdGVyLw==");
        // https://www.mangaread.org/manga/return-of-top-class-master/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9yZXR1cm4tb2YtdG9wLWNsYXNzLW1hc3Rlci8=");
        // https://www.mangaread.org/manga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLw==");
        // https://www.mangaread.org/manga/reincarnator-manhwa/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9yZWluY2FybmF0b3ItbWFuaHdhLw==");
        // https://www.mangaread.org/manga/reincarnated-devils-plan-for-raising-the-strongest-hero/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9yZWluY2FybmF0ZWQtZGV2aWxzLXBsYW4tZm9yLXJhaXNpbmctdGhlLXN0cm9uZ2VzdC1oZXJvLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.mangaread.org/manga/i-suddenly-have-an-older-sister/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9pLXN1ZGRlbmx5LWhhdmUtYW4tb2xkZXItc2lzdGVyL2NoYXB0ZXItOS8=");
        // https://www.mangaread.org/manga/reincarnator-manhwa/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9yZWluY2FybmF0b3ItbWFuaHdhL2NoYXB0ZXItMC8=");
        // https://www.mangaread.org/manga/i-suddenly-have-an-older-sister/chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9pLXN1ZGRlbmx5LWhhdmUtYW4tb2xkZXItc2lzdGVyL2NoYXB0ZXItMTMv");
        // https://www.mangaread.org/manga/i-suddenly-have-an-older-sister/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9pLXN1ZGRlbmx5LWhhdmUtYW4tb2xkZXItc2lzdGVyL2NoYXB0ZXItMTAv");
        // https://www.mangaread.org/manga/mr-devourer-please-act-like-a-final-boss/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy9tYW5nYS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItOC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://www.mangaread.org/wp-content/uploads/WP-manga/data/manga_65966b1f10fb4/aaf78530a3a84706f7711925d1aea85f/13-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NmIxZjEwZmI0L2FhZjc4NTMwYTNhODQ3MDZmNzcxMTkyNWQxYWVhODVmLzEzLW8uanBn");
        // https://www.mangaread.org/wp-content/uploads/WP-manga/data/manga_65966b1f10fb4/203a85fde398cdfb79d64d17b79aa2b5/8.jpeg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NmIxZjEwZmI0LzIwM2E4NWZkZTM5OGNkZmI3OWQ2NGQxN2I3OWFhMmI1LzguanBlZw==");
        // https://www.mangaread.org/wp-content/uploads/WP-manga/data/manga_65966b1f10fb4/203a85fde398cdfb79d64d17b79aa2b5/3.jpeg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NmIxZjEwZmI0LzIwM2E4NWZkZTM5OGNkZmI3OWQ2NGQxN2I3OWFhMmI1LzMuanBlZw==");
        // https://www.mangaread.org/wp-content/uploads/WP-manga/data/manga_65918812e121c/ee064d60374403636afa568387fcc12c/10.jpeg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxODgxMmUxMjFjL2VlMDY0ZDYwMzc0NDAzNjM2YWZhNTY4Mzg3ZmNjMTJjLzEwLmpwZWc=");
        // https://www.mangaread.org/wp-content/uploads/WP-manga/data/manga_65966b1f10fb4/203a85fde398cdfb79d64d17b79aa2b5/28.jpeg
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuZ2FyZWFkLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NmIxZjEwZmI0LzIwM2E4NWZkZTM5OGNkZmI3OWQ2NGQxN2I3OWFhMmI1LzI4LmpwZWc=");
    }
}

