using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaSpinSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaspin";

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
        // https://mangaspin.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://mangaspin.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://mangaspin.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://mangaspin.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://mangaspin.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaspin.com/painter-of-the-night/chapter-105
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMTA1");
        // https://mangaspin.com/i-can-hear-it-without-a-microphone/chapter-68
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci02OA==");
        // https://mangaspin.com/i-can-hear-it-without-a-microphone/chapter-88
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci04OA==");
        // https://mangaspin.com/dangerous-convenience-store/chapter-94
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTk0");
        // https://mangaspin.com/painter-of-the-night/chapter-32
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMzI=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s13.mbbcdn.com/res/manga/painter-of-the-night/chapter-105/39dcd14dfc87b8ff453eda44436f94c4.webp?acc=61Uc878tRex-op6UJWojkw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMDUvMzlkY2QxNGRmYzg3YjhmZjQ1M2VkYTQ0NDM2Zjk0YzQud2VicD9hY2M9NjFVYzg3OHRSZXgtb3A2VUpXb2prdyZleHA9MTcwNDQ4NDgwMA==");
        // https://s2.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-94/7d898f5469fdb2886b558ae774a49f78.jpeg?acc=DLXEp1laFyHozNjS0Gg2IQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci05NC83ZDg5OGY1NDY5ZmRiMjg4NmI1NThhZTc3NGE0OWY3OC5qcGVnP2FjYz1ETFhFcDFsYUZ5SG96TmpTMEdnMklRJmV4cD0xNzA0NDg0ODAw");
        // https://s4.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-68/839e3d03c020396de429f339c337c640.jpg?acc=VnA-c_Y8684LYfGQPHtxKA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNjgvODM5ZTNkMDNjMDIwMzk2ZGU0MjlmMzM5YzMzN2M2NDAuanBnP2FjYz1WbkEtY19ZODY4NExZZkdRUEh0eEtBJmV4cD0xNzA0NDg0ODAw");
        // https://s6.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-94/a340fef2f0a44e76ed84009456354327.jpeg?acc=WzWjiV-oeRpxWoBFmWU9SQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci05NC9hMzQwZmVmMmYwYTQ0ZTc2ZWQ4NDAwOTQ1NjM1NDMyNy5qcGVnP2FjYz1XeldqaVYtb2VScHhXb0JGbVdVOVNRJmV4cD0xNzA0NDg0ODAw");
        // https://s7.mbbcdn.com/res/manga/painter-of-the-night/chapter-105/d4d9ac2aec51619fbf2e6b1800103b42.webp?acc=WVRfX1O_KF-xAOU5fjZ7BQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTEwNS9kNGQ5YWMyYWVjNTE2MTlmYmYyZTZiMTgwMDEwM2I0Mi53ZWJwP2FjYz1XVlJmWDFPX0tGLXhBT1U1ZmpaN0JRJmV4cD0xNzA0NDg0ODAw");
    }
}

