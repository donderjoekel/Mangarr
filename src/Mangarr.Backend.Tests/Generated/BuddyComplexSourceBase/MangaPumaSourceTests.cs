using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaPumaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangapuma";

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
        // https://mangapuma.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://mangapuma.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://mangapuma.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://mangapuma.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://mangapuma.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangapuma.com/dangerous-convenience-store/chapter-88
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTg4");
        // https://mangapuma.com/bj-alex/chapter-90
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2JqLWFsZXgvY2hhcHRlci05MA==");
        // https://mangapuma.com/i-can-hear-it-without-a-microphone/chapter-103
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0xMDM=");
        // https://mangapuma.com/painter-of-the-night/chapter-117
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMTE3");
        // https://mangapuma.com/dangerous-convenience-store/chapter-36
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXB1bWEuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTM2");
    }

    public static IEnumerable ValidImages()
    {
        // https://s14.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-36/550c2b5c7f2c_5.jpg?acc=1SwkE1QkTHVXa0_ZtYYNJA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItMzYvNTUwYzJiNWM3ZjJjXzUuanBnP2FjYz0xU3drRTFRa1RIVlhhMF9adFlZTkpBJmV4cD0xNzA0NDg0ODAw");
        // https://s14.mbbcdn.com/res/manga/painter-of-the-night/chapter-117/5adbe660e76dfe5963c21233642c2c77.webp?acc=UNbU3nSxck87rmxsT2KDBA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMTcvNWFkYmU2NjBlNzZkZmU1OTYzYzIxMjMzNjQyYzJjNzcud2VicD9hY2M9VU5iVTNuU3hjazg3cm14c1QyS0RCQSZleHA9MTcwNDQ4NDgwMA==");
        // https://s4.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-88/aae96e2e7e7fca4e93c0edb134e12c42.jpg?acc=rqeJEYGj_FkiO6yTaVwKcw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci04OC9hYWU5NmUyZTdlN2ZjYTRlOTNjMGVkYjEzNGUxMmM0Mi5qcGc/YWNjPXJxZUpFWUdqX0ZraU82eVRhVndLY3cmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s13.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-103/e464b41802c5f47b355626f7be621a4c.jpeg?acc=HUcyklTn_lxzoGlmNNDFRg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTEwMy9lNDY0YjQxODAyYzVmNDdiMzU1NjI2ZjdiZTYyMWE0Yy5qcGVnP2FjYz1IVWN5a2xUbl9seHpvR2xtTk5ERlJnJmV4cD0xNzA0NDg0ODAw");
        // https://s17.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-103/93b39edd162bd6d75174b251dafcbfe0.jpeg?acc=9OgXWF8zHBkFbuMnftBKFw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTEwMy85M2IzOWVkZDE2MmJkNmQ3NTE3NGIyNTFkYWZjYmZlMC5qcGVnP2FjYz05T2dYV0Y4ekhCa0ZidU1uZnRCS0Z3JmV4cD0xNzA0NDg0ODAw");
    }
}

