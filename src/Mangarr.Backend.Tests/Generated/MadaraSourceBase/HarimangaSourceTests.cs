using System.Collections;

namespace Mangarr.Backend.Tests;

public class HarimangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "harimanga";

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
        // https://harimanga.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci8=");
        // https://harimanga.com/manga/i-was-reborn-as-his-highness-the-princes-little-evil-dragon/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL2ktd2FzLXJlYm9ybi1hcy1oaXMtaGlnaG5lc3MtdGhlLXByaW5jZXMtbGl0dGxlLWV2aWwtZHJhZ29uLw==");
        // https://harimanga.com/manga/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL3BsZWFzZS1nZXQtb3V0LW9mLW15LWhvdXNlaG9sZC8=");
        // https://harimanga.com/manga/mave-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL21hdmUtYW5vdGhlci13b3JsZC8=");
        // https://harimanga.com/manga/master-huo-fails-to-pursue-his-wife/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL21hc3Rlci1odW8tZmFpbHMtdG8tcHVyc3VlLWhpcy13aWZlLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://harimanga.com/manga/i-was-reborn-as-his-highness-the-princes-little-evil-dragon/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL2ktd2FzLXJlYm9ybi1hcy1oaXMtaGlnaG5lc3MtdGhlLXByaW5jZXMtbGl0dGxlLWV2aWwtZHJhZ29uL2NoYXB0ZXItNi8=");
        // https://harimanga.com/manga/mave-another-world/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL21hdmUtYW5vdGhlci13b3JsZC9jaGFwdGVyLTcv");
        // https://harimanga.com/manga/master-huo-fails-to-pursue-his-wife/chapter-38/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL21hc3Rlci1odW8tZmFpbHMtdG8tcHVyc3VlLWhpcy13aWZlL2NoYXB0ZXItMzgv");
        // https://harimanga.com/manga/dark-and-light-martial-emperor/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL2RhcmstYW5kLWxpZ2h0LW1hcnRpYWwtZW1wZXJvci9jaGFwdGVyLTgv");
        // https://harimanga.com/manga/mave-another-world/chapter-39/
        yield return new TestCaseData("aHR0cHM6Ly9oYXJpbWFuZ2EuY29tL21hbmdhL21hdmUtYW5vdGhlci13b3JsZC9jaGFwdGVyLTM5Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://img-2.harimanga.com/manga_6595ad14f3996/5ae378ee33be6904df849ab99d2c0714/086.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvNWFlMzc4ZWUzM2JlNjkwNGRmODQ5YWI5OWQyYzA3MTQvMDg2LndlYnA=");
        // https://img-2.harimanga.com/manga_6595ad14f3996/25b52d443ff65920151535b7ee6f4e14/51.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvMjViNTJkNDQzZmY2NTkyMDE1MTUzNWI3ZWU2ZjRlMTQvNTEud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/25b52d443ff65920151535b7ee6f4e14/14.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvMjViNTJkNDQzZmY2NTkyMDE1MTUzNWI3ZWU2ZjRlMTQvMTQud2VicA==");
        // https://img-2.harimanga.com/manga_6595ad14f3996/5ae378ee33be6904df849ab99d2c0714/065.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvNWFlMzc4ZWUzM2JlNjkwNGRmODQ5YWI5OWQyYzA3MTQvMDY1LndlYnA=");
        // https://img-2.harimanga.com/manga_6595ad14f3996/25b52d443ff65920151535b7ee6f4e14/42.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWctMi5oYXJpbWFuZ2EuY29tL21hbmdhXzY1OTVhZDE0ZjM5OTYvMjViNTJkNDQzZmY2NTkyMDE1MTUzNWI3ZWU2ZjRlMTQvNDIud2VicA==");
    }
}

