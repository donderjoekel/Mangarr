using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaSagaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangasaga";

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
        // https://mangasaga.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://mangasaga.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://mangasaga.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://mangasaga.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://mangasaga.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangasaga.com/bj-alex/chapter-35
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2JqLWFsZXgvY2hhcHRlci0zNQ==");
        // https://mangasaga.com/i-can-hear-it-without-a-microphone/chapter-87
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci04Nw==");
        // https://mangasaga.com/bj-alex/chapter-90
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2JqLWFsZXgvY2hhcHRlci05MA==");
        // https://mangasaga.com/bj-alex/chapter-32
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2JqLWFsZXgvY2hhcHRlci0zMg==");
        // https://mangasaga.com/painter-of-the-night/chapter-90
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItOTA=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s19.mbbcdn.com/res/manga/bj-alex/chapter-90/82c7b3697c98_38.jpg?acc=_2rVnY-hECOu6MQC7_HBYw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTkubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTkwLzgyYzdiMzY5N2M5OF8zOC5qcGc/YWNjPV8yclZuWS1oRUNPdTZNUUM3X0hCWXcmZXhwPTE3MDQzNzY4MDA=");
        // https://s2.mbbcdn.com/res/manga/bj-alex/chapter-90/8fc2fb2cf2dd_1.jpg?acc=eoI_HISo-hnkse7Z9gNwXA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItOTAvOGZjMmZiMmNmMmRkXzEuanBnP2FjYz1lb0lfSElTby1obmtzZTdaOWdOd1hBJmV4cD0xNzA0Mzc2ODAw");
        // https://s16.mbbcdn.com/res/manga/bj-alex/chapter-90/a38d97c33068_55.jpg?acc=iOVTOKVYeqO0k7lVbGw-aQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTYubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTkwL2EzOGQ5N2MzMzA2OF81NS5qcGc/YWNjPWlPVlRPS1ZZZXFPMGs3bFZiR3ctYVEmZXhwPTE3MDQzNzY4MDA=");
        // https://s20.mbbcdn.com/res/manga/bj-alex/chapter-90/984a21f88912_19.jpg?acc=sXvRCN-MDcMDvTOjZuNb-g&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMjAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTkwLzk4NGEyMWY4ODkxMl8xOS5qcGc/YWNjPXNYdlJDTi1NRGNNRHZUT2padU5iLWcmZXhwPTE3MDQzNzY4MDA=");
        // https://s11.mbbcdn.com/res/manga/bj-alex/chapter-35/fe73c3276966_7.jpg?acc=K875xHRDv4stAt283aAkQQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTM1L2ZlNzNjMzI3Njk2Nl83LmpwZz9hY2M9Szg3NXhIUkR2NHN0QXQyODNhQWtRUSZleHA9MTcwNDM3NjgwMA==");
    }
}

