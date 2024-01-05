using System.Collections;

namespace Mangarr.Backend.Tests;

public class NitroMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "nitromanga";

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
        // https://nitromanga.com/mangas/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy8=");
        // https://nitromanga.com/mangas/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvcmVpbmNhcm5hdG9yLw==");
        // https://nitromanga.com/mangas/the-demon-emperor-hopes-for-a-hero/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvdGhlLWRlbW9uLWVtcGVyb3ItaG9wZXMtZm9yLWEtaGVyby8=");
        // https://nitromanga.com/mangas/it-turns-out-that-i-have-been-invincible-for-a-long-time/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvaXQtdHVybnMtb3V0LXRoYXQtaS1oYXZlLWJlZW4taW52aW5jaWJsZS1mb3ItYS1sb25nLXRpbWUv");
        // https://nitromanga.com/mangas/zero-kill-assassine/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvemVyby1raWxsLWFzc2Fzc2luZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://nitromanga.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy9jaGFwdGVyLTAv");
        // https://nitromanga.com/mangas/zero-kill-assassine/chapter-01/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvemVyby1raWxsLWFzc2Fzc2luZS9jaGFwdGVyLTAxLw==");
        // https://nitromanga.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy9jaGFwdGVyLTE5Lw==");
        // https://nitromanga.com/mangas/reincarnator/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvcmVpbmNhcm5hdG9yL2NoYXB0ZXItMC8=");
        // https://nitromanga.com/mangas/mr-devourer-please-act-like-a-final-boss/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9uaXRyb21hbmdhLmNvbS9tYW5nYXMvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy9jaGFwdGVyLTIxLw==");
    }

    public static IEnumerable ValidImages()
    {
        // http://cdn.mangabaz.com/manga/mr-devourer-please-act-like-a-final-boss-21/mr-devourer-please-act-like-a-final-boss-a87ff679a2f3e71d9181a67b7542122c.jpg
        yield return new TestCaseData("aHR0cDovL2Nkbi5tYW5nYWJhei5jb20vbWFuZ2EvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy0yMS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLWE4N2ZmNjc5YTJmM2U3MWQ5MTgxYTY3Yjc1NDIxMjJjLmpwZw==");
        // http://cdn.mangabaz.com/manga/reincarnator-manhwa-0/reincarnator-1679091c5a880faf6fb5e6087eb1b2dc.jpg
        yield return new TestCaseData("aHR0cDovL2Nkbi5tYW5nYWJhei5jb20vbWFuZ2EvcmVpbmNhcm5hdG9yLW1hbmh3YS0wL3JlaW5jYXJuYXRvci0xNjc5MDkxYzVhODgwZmFmNmZiNWU2MDg3ZWIxYjJkYy5qcGc=");
        // http://cdn.mangabaz.com/manga/mr-devourer-please-act-like-a-final-boss-21/mr-devourer-please-act-like-a-final-boss-c9f0f895fb98ab9159f51fd0297e236d.jpg
        yield return new TestCaseData("aHR0cDovL2Nkbi5tYW5nYWJhei5jb20vbWFuZ2EvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy0yMS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLWM5ZjBmODk1ZmI5OGFiOTE1OWY1MWZkMDI5N2UyMzZkLmpwZw==");
        // http://cdn.mangabaz.com/manga/mr-devourer-please-act-like-a-final-boss-21/mr-devourer-please-act-like-a-final-boss-aab3238922bcc25a6f606eb525ffdc56.jpg
        yield return new TestCaseData("aHR0cDovL2Nkbi5tYW5nYWJhei5jb20vbWFuZ2EvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy0yMS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLWFhYjMyMzg5MjJiY2MyNWE2ZjYwNmViNTI1ZmZkYzU2LmpwZw==");
        // http://cdn.mangabaz.com/manga/mr-devourer-please-act-like-a-final-boss-21/mr-devourer-please-act-like-a-final-boss-6512bd43d9caa6e02c990b0a82652dca.jpg
        yield return new TestCaseData("aHR0cDovL2Nkbi5tYW5nYWJhei5jb20vbWFuZ2EvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy0yMS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLTY1MTJiZDQzZDljYWE2ZTAyYzk5MGIwYTgyNjUyZGNhLmpwZw==");
    }
}

