using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaUSSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaus";

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
        // https://mangaus.xyz/manga/my-wife-is-from-thousand-years-ago/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9teS13aWZlLWlzLWZyb20tdGhvdXNhbmQteWVhcnMtYWdvLw==");
        // https://mangaus.xyz/manga/past-life-returner/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9wYXN0LWxpZmUtcmV0dXJuZXIv");
        // https://mangaus.xyz/manga/i-work-nine-to-five-in-the-immortal-cultivation-world/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9pLXdvcmstbmluZS10by1maXZlLWluLXRoZS1pbW1vcnRhbC1jdWx0aXZhdGlvbi13b3JsZC8=");
        // https://mangaus.xyz/manga/i-the-invincible-villain-master-with-my-apprentices/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9pLXRoZS1pbnZpbmNpYmxlLXZpbGxhaW4tbWFzdGVyLXdpdGgtbXktYXBwcmVudGljZXMv");
        // https://mangaus.xyz/manga/i-am-the-rising-villain/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9pLWFtLXRoZS1yaXNpbmctdmlsbGFpbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaus.xyz/manga/i-the-invincible-villain-master-with-my-apprentices/chapter-83/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9pLXRoZS1pbnZpbmNpYmxlLXZpbGxhaW4tbWFzdGVyLXdpdGgtbXktYXBwcmVudGljZXMvY2hhcHRlci04My8=");
        // https://mangaus.xyz/manga/my-wife-is-from-thousand-years-ago/chapter-52/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9teS13aWZlLWlzLWZyb20tdGhvdXNhbmQteWVhcnMtYWdvL2NoYXB0ZXItNTIv");
        // https://mangaus.xyz/manga/my-wife-is-from-thousand-years-ago/chapter-59/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9teS13aWZlLWlzLWZyb20tdGhvdXNhbmQteWVhcnMtYWdvL2NoYXB0ZXItNTkv");
        // https://mangaus.xyz/manga/past-life-returner/chapter-23/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9wYXN0LWxpZmUtcmV0dXJuZXIvY2hhcHRlci0yMy8=");
        // https://mangaus.xyz/manga/i-work-nine-to-five-in-the-immortal-cultivation-world/chapter-43/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXVzLnh5ei9tYW5nYS9pLXdvcmstbmluZS10by1maXZlLWluLXRoZS1pbW1vcnRhbC1jdWx0aXZhdGlvbi13b3JsZC9jaGFwdGVyLTQzLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://img.manhuafast.net/images/2023-09-15/15596757866504499f6a77d6.13498282.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZmFzdC5uZXQvaW1hZ2VzLzIwMjMtMDktMTUvMTU1OTY3NTc4NjY1MDQ0OTlmNmE3N2Q2LjEzNDk4MjgyLmpwZw==");
        // https://img.manhuafast.net/images/2023-01-12/29616049263beebeaa2f946.98402109.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZmFzdC5uZXQvaW1hZ2VzLzIwMjMtMDEtMTIvMjk2MTYwNDkyNjNiZWViZWFhMmY5NDYuOTg0MDIxMDkuanBn");
        // https://img.manhuafast.net/images/2023-01-12/36541544263beebeaa304e2.26203961.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZmFzdC5uZXQvaW1hZ2VzLzIwMjMtMDEtMTIvMzY1NDE1NDQyNjNiZWViZWFhMzA0ZTIuMjYyMDM5NjEuanBn");
    }
}

