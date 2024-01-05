using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaSiteSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuasite";

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
        // https://manhuasite.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodHxwYWludGVyLW9mLXRoZS1uaWdodA==");
        // https://manhuasite.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lfGktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmU=");
        // https://manhuasite.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9iai1hbGV4fGJqLWFsZXg=");
        // https://manhuasite.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS8xOS1kYXlzfDE5LWRheXM=");
        // https://manhuasite.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmV8ZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3Jl");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuasite.com/dangerous-convenience-store/chapter-28
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci0yOA==");
        // https://manhuasite.com/painter-of-the-night/chapter-98
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTk4");
        // https://manhuasite.com/dangerous-convenience-store/chapter-20
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci0yMA==");
        // https://manhuasite.com/painter-of-the-night/chapter-65
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTY1");
        // https://manhuasite.com/painter-of-the-night/chapter-94
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTk0");
    }

    public static IEnumerable ValidImages()
    {
        // https://s1.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-28/5a8561f6b4bc_26.jpg?acc=f0YdMkoOWL_vj9To6qotag&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci0yOC81YTg1NjFmNmI0YmNfMjYuanBnP2FjYz1mMFlkTWtvT1dMX3ZqOVRvNnFvdGFnJmV4cD0xNzA0NDg0ODAw");
        // https://s16.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-28/ef51ae04698c_21.jpg?acc=HhXIYN_nM4W35fbPKtzsYw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTYubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItMjgvZWY1MWFlMDQ2OThjXzIxLmpwZz9hY2M9SGhYSVlOX25NNFczNWZiUEt0enNZdyZleHA9MTcwNDQ4NDgwMA==");
        // https://s5.mbbcdn.com/res/manga/painter-of-the-night/chapter-94/cfc6bc689c14_1643586531056_2.jpg?acc=mi0kbmJd04cpowMvDm2t1w&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTk0L2NmYzZiYzY4OWMxNF8xNjQzNTg2NTMxMDU2XzIuanBnP2FjYz1taTBrYm1KZDA0Y3Bvd012RG0ydDF3JmV4cD0xNzA0NDg0ODAw");
        // https://s14.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-28/1f7d6cb9109f_39.jpg?acc=N2ByRao8W46wvqZyzLl6ig&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItMjgvMWY3ZDZjYjkxMDlmXzM5LmpwZz9hY2M9TjJCeVJhbzhXNDZ3dnFaeXpMbDZpZyZleHA9MTcwNDQ4NDgwMA==");
        // https://s13.mbbcdn.com/res/manga/painter-of-the-night/chapter-65/6.jpg?acc=QgevG3gOhlDA72V_aTcZIg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci02NS82LmpwZz9hY2M9UWdldkczZ09obERBNzJWX2FUY1pJZyZleHA9MTcwNDQ4NDgwMA==");
    }
}

