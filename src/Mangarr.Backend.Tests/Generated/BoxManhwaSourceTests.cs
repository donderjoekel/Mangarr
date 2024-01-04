using System.Collections;

namespace Mangarr.Backend.Tests;

public class BoxManhwaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "boxmanhwa";

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
        // https://boxmanhwa.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://boxmanhwa.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://boxmanhwa.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://boxmanhwa.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://boxmanhwa.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://boxmanhwa.com/bj-alex/chapter-66
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2JqLWFsZXgvY2hhcHRlci02Ng==");
        // https://boxmanhwa.com/i-can-hear-it-without-a-microphone/chapter-22
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0yMg==");
        // https://boxmanhwa.com/i-can-hear-it-without-a-microphone/chapter-16
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0xNg==");
        // https://boxmanhwa.com/dangerous-convenience-store/chapter-10
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTEw");
        // https://boxmanhwa.com/bj-alex/chapter-40
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2JqLWFsZXgvY2hhcHRlci00MA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s8.mbbcdn.com/res/manga/bj-alex/chapter-66/41790ced4dba_40.jpg?acc=U-OEc_FBkqraccpOjnTuuA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zOC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItNjYvNDE3OTBjZWQ0ZGJhXzQwLmpwZz9hY2M9VS1PRWNfRkJrcXJhY2NwT2puVHV1QSZleHA9MTcwNDM3NjgwMA==");
        // https://s15.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-22/01dbdac4ae90_7.jpg?acc=pycMtaUC_n6i6UsnO1dclw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTIyLzAxZGJkYWM0YWU5MF83LmpwZz9hY2M9cHljTXRhVUNfbjZpNlVzbk8xZGNsdyZleHA9MTcwNDM3NjgwMA==");
        // https://s14.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-16/9422e6c83a72_4.jpg?acc=9QsQFpIxq4G-qtbzMXFEng&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTE2Lzk0MjJlNmM4M2E3Ml80LmpwZz9hY2M9OVFzUUZwSXhxNEctcXRiek1YRkVuZyZleHA9MTcwNDM3NjgwMA==");
        // https://s20.mbbcdn.com/res/manga/bj-alex/chapter-66/10eaba7d7b46_32.jpg?acc=LW44tFzOO3knQe6QzoVOyA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMjAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTY2LzEwZWFiYTdkN2I0Nl8zMi5qcGc/YWNjPUxXNDR0RnpPTzNrblFlNlF6b1ZPeUEmZXhwPTE3MDQzNzY4MDA=");
        // https://s13.mbbcdn.com/res/manga/bj-alex/chapter-66/7c3f97bc1ad7_5.jpg?acc=bl7UHwM9DYcrR7eAE4FwAg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTY2LzdjM2Y5N2JjMWFkN181LmpwZz9hY2M9Ymw3VUh3TTlEWWNyUjdlQUU0RndBZyZleHA9MTcwNDM3NjgwMA==");
    }
}

