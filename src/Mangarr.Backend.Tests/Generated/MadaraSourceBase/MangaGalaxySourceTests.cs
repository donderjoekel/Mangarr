using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaGalaxySourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangagalaxy";

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
        // https://mangagalaxy.me/manga/blood-parasite/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9ibG9vZC1wYXJhc2l0ZS8=");
        // https://mangagalaxy.me/manga/omniscient-immortal-cultivator/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9vbW5pc2NpZW50LWltbW9ydGFsLWN1bHRpdmF0b3Iv");
        // https://mangagalaxy.me/manga/flash-sword/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9mbGFzaC1zd29yZC8=");
        // https://mangagalaxy.me/manga/eternal-saint/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9ldGVybmFsLXNhaW50Lw==");
        // https://mangagalaxy.me/manga/return-of-the-frozen-player/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9yZXR1cm4tb2YtdGhlLWZyb3plbi1wbGF5ZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangagalaxy.me/manga/flash-sword/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9mbGFzaC1zd29yZC9jaGFwdGVyLTMv");
        // https://mangagalaxy.me/manga/omniscient-immortal-cultivator/chapter-0-preview/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9vbW5pc2NpZW50LWltbW9ydGFsLWN1bHRpdmF0b3IvY2hhcHRlci0wLXByZXZpZXcv");
        // https://mangagalaxy.me/manga/blood-parasite/chapter-6_1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9ibG9vZC1wYXJhc2l0ZS9jaGFwdGVyLTZfMS8=");
        // https://mangagalaxy.me/manga/flash-sword/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9mbGFzaC1zd29yZC9jaGFwdGVyLTcv");
        // https://mangagalaxy.me/manga/flash-sword/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS9tYW5nYS9mbGFzaC1zd29yZC9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangagalaxy.me/wp-content/uploads/WP-manga/data/manga_65805e920277d/3cf12027641467efc1482ce7d94b960d/30.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgwNWU5MjAyNzdkLzNjZjEyMDI3NjQxNDY3ZWZjMTQ4MmNlN2Q5NGI5NjBkLzMwLmpwZw==");
        // https://mangagalaxy.me/wp-content/uploads/WP-manga/data/manga_65805e920277d/3cf12027641467efc1482ce7d94b960d/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgwNWU5MjAyNzdkLzNjZjEyMDI3NjQxNDY3ZWZjMTQ4MmNlN2Q5NGI5NjBkLzExLmpwZw==");
        // https://mangagalaxy.me/wp-content/uploads/WP-manga/data/manga_65805e920277d/3cf12027641467efc1482ce7d94b960d/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgwNWU5MjAyNzdkLzNjZjEyMDI3NjQxNDY3ZWZjMTQ4MmNlN2Q5NGI5NjBkLzA0LmpwZw==");
        // https://mangagalaxy.me/wp-content/uploads/WP-manga/data/manga_6579a8b19ec42/cc1e188ce5c71dad7a8396ce5c97bff0/64.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc5YThiMTllYzQyL2NjMWUxODhjZTVjNzFkYWQ3YTgzOTZjZTVjOTdiZmYwLzY0LmpwZw==");
        // https://mangagalaxy.me/wp-content/uploads/WP-manga/data/manga_6579a8b19ec42/e64f153beca34887c4491a9875561ca4/58.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWdhbGF4eS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc5YThiMTllYzQyL2U2NGYxNTNiZWNhMzQ4ODdjNDQ5MWE5ODc1NTYxY2E0LzU4LmpwZw==");
    }
}

