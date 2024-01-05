using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwafullSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwafull";

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
        // https://manhwafull.com/manga/here-u-are/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9oZXJlLXUtYXJlLw==");
        // https://manhwafull.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9uYXVnaHR5LW1hbGUtZnJpZW5kLw==");
        // https://manhwafull.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC8=");
        // https://manhwafull.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
        // https://manhwafull.com/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ob2x5LW1haWRlbi1zeXN0ZW0tYm91bmQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwafull.com/manga/here-u-are/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9oZXJlLXUtYXJlL2NoYXB0ZXItNS8=");
        // https://manhwafull.com/manga/meat-doll-workshop-in-another-world/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC9jaGFwdGVyLTEv");
        // https://manhwafull.com/manga/meat-doll-workshop-in-another-world/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC9jaGFwdGVyLTMv");
        // https://manhwafull.com/manga/starting-with-the-holy-maiden-system-bound/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9zdGFydGluZy13aXRoLXRoZS1ob2x5LW1haWRlbi1zeXN0ZW0tYm91bmQvY2hhcHRlci0yLw==");
        // https://manhwafull.com/manga/naughty-male-friend/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2FmdWxsLmNvbS9tYW5nYS9uYXVnaHR5LW1hbGUtZnJpZW5kL2NoYXB0ZXItMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMC9jaGFwXzBfMTEuanBn");
        // https://cdn2.mangagg.com/manga_54f619e883af962072faa0e2032c1b0e/chapter_0/chap_0_22.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzU0ZjYxOWU4ODNhZjk2MjA3MmZhYTBlMjAzMmMxYjBlL2NoYXB0ZXJfMC9jaGFwXzBfMjIuanBn");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_30.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMC9jaGFwXzBfMzAuanBn");
        // https://cdn2.mangagg.com/manga_54f619e883af962072faa0e2032c1b0e/chapter_2/chap_2_9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzU0ZjYxOWU4ODNhZjk2MjA3MmZhYTBlMjAzMmMxYjBlL2NoYXB0ZXJfMi9jaGFwXzJfOS5qcGc=");
        // https://cdn2.mangagg.com/manga_9f37d87938938d473ff641d4781ea30c/chapter_0/chap_0_29.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzlmMzdkODc5Mzg5MzhkNDczZmY2NDFkNDc4MWVhMzBjL2NoYXB0ZXJfMC9jaGFwXzBfMjkuanBn");
    }
}

