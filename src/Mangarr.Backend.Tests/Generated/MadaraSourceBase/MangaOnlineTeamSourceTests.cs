using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaOnlineTeamSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaonlineteam";

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
        // https://mangaonlineteam.com/manga/captain-is-this-battlefield-here/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL2NhcHRhaW4taXMtdGhpcy1iYXR0bGVmaWVsZC1oZXJlLw==");
        // https://mangaonlineteam.com/manga/the-player-hides-his-past/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL3RoZS1wbGF5ZXItaGlkZXMtaGlzLXBhc3Qv");
        // https://mangaonlineteam.com/manga/i-decided-not-to-pretend-i-dont-see-it-anymore/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL2ktZGVjaWRlZC1ub3QtdG8tcHJldGVuZC1pLWRvbnQtc2VlLWl0LWFueW1vcmUv");
        // https://mangaonlineteam.com/manga/tyranny-of-the-gale/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL3R5cmFubnktb2YtdGhlLWdhbGUv");
        // https://mangaonlineteam.com/manga/jobless-monster-player/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL2pvYmxlc3MtbW9uc3Rlci1wbGF5ZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaonlineteam.com/manga/tyranny-of-the-gale/chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL3R5cmFubnktb2YtdGhlLWdhbGUvY2hhcHRlci0yOS8=");
        // https://mangaonlineteam.com/manga/the-player-hides-his-past/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL3RoZS1wbGF5ZXItaGlkZXMtaGlzLXBhc3QvY2hhcHRlci0xNi8=");
        // https://mangaonlineteam.com/manga/jobless-monster-player/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL2pvYmxlc3MtbW9uc3Rlci1wbGF5ZXIvY2hhcHRlci0yNS8=");
        // https://mangaonlineteam.com/manga/captain-is-this-battlefield-here/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL2NhcHRhaW4taXMtdGhpcy1iYXR0bGVmaWVsZC1oZXJlL2NoYXB0ZXItMTkv");
        // https://mangaonlineteam.com/manga/the-player-hides-his-past/chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL21hbmdhL3RoZS1wbGF5ZXItaGlkZXMtaGlzLXBhc3QvY2hhcHRlci0yOS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangaonlineteam.com/wp-content/uploads/WP-manga/data/10443/b5c3011c718bf5fdb3909cbca061a5b0/13-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhLzEwNDQzL2I1YzMwMTFjNzE4YmY1ZmRiMzkwOWNiY2EwNjFhNWIwLzEzLW8uanBn");
        // https://mangaonlineteam.com/wp-content/uploads/WP-manga/data/10443/b5c3011c718bf5fdb3909cbca061a5b0/4-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhLzEwNDQzL2I1YzMwMTFjNzE4YmY1ZmRiMzkwOWNiY2EwNjFhNWIwLzQtby5qcGc=");
        // https://mangaonlineteam.com/wp-content/uploads/WP-manga/data/10443/b5c3011c718bf5fdb3909cbca061a5b0/18-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhLzEwNDQzL2I1YzMwMTFjNzE4YmY1ZmRiMzkwOWNiY2EwNjFhNWIwLzE4LW8uanBn");
        // https://mangaonlineteam.com/wp-content/uploads/WP-manga/data/10450/39e1dfdf3b0d44a2510902b0a28b14c7/6-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhLzEwNDUwLzM5ZTFkZmRmM2IwZDQ0YTI1MTA5MDJiMGEyOGIxNGM3LzYtby5qcGc=");
        // https://mangaonlineteam.com/wp-content/uploads/WP-manga/data/10441/71738020a0607d8b2b195d5dd5d5e9cc/15-o.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW9ubGluZXRlYW0uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhLzEwNDQxLzcxNzM4MDIwYTA2MDdkOGIyYjE5NWQ1ZGQ1ZDVlOWNjLzE1LW8uanBn");
    }
}

