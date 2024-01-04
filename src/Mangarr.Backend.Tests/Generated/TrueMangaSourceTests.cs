using System.Collections;

namespace Mangarr.Backend.Tests;

public class TrueMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "truemanga";

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
        // https://truemanga.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://truemanga.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://truemanga.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://truemanga.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://truemanga.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://truemanga.com/i-can-hear-it-without-a-microphone/chapter-30-5-creators-note
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0zMC01LWNyZWF0b3JzLW5vdGU=");
        // https://truemanga.com/i-can-hear-it-without-a-microphone/chapter-35
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0zNQ==");
        // https://truemanga.com/dangerous-convenience-store/chapter-55
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTU1");
        // https://truemanga.com/painter-of-the-night/chapter-122
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMTIy");
        // https://truemanga.com/i-can-hear-it-without-a-microphone/chapter-14
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0xNA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s2.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-35/c72ee15af7d8_24.jpg?acc=7PWCW5WCzMafoq1MbjHHkA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMzUvYzcyZWUxNWFmN2Q4XzI0LmpwZz9hY2M9N1BXQ1c1V0N6TWFmb3ExTWJqSEhrQSZleHA9MTcwNDM3NjgwMA==");
        // https://s13.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-14/8b0daa624b52_36.jpg?acc=4oV50SgeLG8xwjZ1wEjiag&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTE0LzhiMGRhYTYyNGI1Ml8zNi5qcGc/YWNjPTRvVjUwU2dlTEc4eHdqWjF3RWppYWcmZXhwPTE3MDQzNzY4MDA=");
        // https://s13.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-55/06cdfab07f67_6.jpg?acc=FGfZVSxk3YW1Sit9oN2uxA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItNTUvMDZjZGZhYjA3ZjY3XzYuanBnP2FjYz1GR2ZaVlN4azNZVzFTaXQ5b04ydXhBJmV4cD0xNzA0Mzc2ODAw");
        // https://s5.mbbcdn.com/res/manga/painter-of-the-night/chapter-122/1c79d8adddec5e517df3afbea2728ffa.webp?acc=GofV1nrmHzl0oXlzo-MQpw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTEyMi8xYzc5ZDhhZGRkZWM1ZTUxN2RmM2FmYmVhMjcyOGZmYS53ZWJwP2FjYz1Hb2ZWMW5ybUh6bDBvWGx6by1NUXB3JmV4cD0xNzA0Mzc2ODAw");
        // https://s8.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-35/f863950f9102_10.jpg?acc=RO4P0EbBenQiyILSYr7JPQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zOC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMzUvZjg2Mzk1MGY5MTAyXzEwLmpwZz9hY2M9Uk80UDBFYkJlblFpeUlMU1lyN0pQUSZleHA9MTcwNDM3NjgwMA==");
    }
}

