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
        // https://mangasaga.com/painter-of-the-night/chapter-3
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMw==");
        // https://mangasaga.com/i-can-hear-it-without-a-microphone/chapter-102
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0xMDI=");
        // https://mangasaga.com/painter-of-the-night/chapter-44-3-season-2-sneak-peek
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItNDQtMy1zZWFzb24tMi1zbmVhay1wZWVr");
        // https://mangasaga.com/i-can-hear-it-without-a-microphone/chapter-97
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci05Nw==");
        // https://mangasaga.com/i-can-hear-it-without-a-microphone/chapter-70
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNhZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci03MA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s15.mbbcdn.com/res/manga/painter-of-the-night/chapter-3/33.jpg?acc=3Zs6W3TYPjobQgj-btLzAw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0zLzMzLmpwZz9hY2M9M1pzNlczVFlQam9iUWdqLWJ0THpBdyZleHA9MTcwNDQ4NDgwMA==");
        // https://s20.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-70/f58540a190649257a608f403df2ff63d.jpg?acc=kFujm_4qjPRfpRkiobd7YA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMjAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTcwL2Y1ODU0MGExOTA2NDkyNTdhNjA4ZjQwM2RmMmZmNjNkLmpwZz9hY2M9a0Z1am1fNHFqUFJmcFJraW9iZDdZQSZleHA9MTcwNDQ4NDgwMA==");
        // https://s11.mbbcdn.com/res/manga/painter-of-the-night/chapter-3/9.jpg?acc=0_FZoBHBkFnFKiBDxCQsRQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0zLzkuanBnP2FjYz0wX0Zab0JIQmtGbkZLaUJEeENRc1JRJmV4cD0xNzA0NDg0ODAw");
        // https://s11.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-97/56b7cd1f25015a372677429d53eab43c.jpeg?acc=RPgv4EOaflQ35ZtlYscJJw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTk3LzU2YjdjZDFmMjUwMTVhMzcyNjc3NDI5ZDUzZWFiNDNjLmpwZWc/YWNjPVJQZ3Y0RU9hZmxRMzVadGxZc2NKSncmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s9.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-97/8cce367280c2861ab26b8f07b39b5f91.jpeg?acc=FJ7cYvnkRjG0QtiOKW_XDQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zOS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItOTcvOGNjZTM2NzI4MGMyODYxYWIyNmI4ZjA3YjM5YjVmOTEuanBlZz9hY2M9Rko3Y1l2bmtSakcwUXRpT0tXX1hEUSZleHA9MTcwNDQ4NDgwMA==");
    }
}

