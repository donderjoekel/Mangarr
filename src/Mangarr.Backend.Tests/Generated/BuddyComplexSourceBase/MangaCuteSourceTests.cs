using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaCuteSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangacute";

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
        // https://mangacute.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://mangacute.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://mangacute.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://mangacute.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://mangacute.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangacute.com/bj-alex/chapter-84
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2JqLWFsZXgvY2hhcHRlci04NA==");
        // https://mangacute.com/painter-of-the-night/chapter-119
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMTE5");
        // https://mangacute.com/painter-of-the-night/chapter-9
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItOQ==");
        // https://mangacute.com/dangerous-convenience-store/vol-2-chapter-58-end-of-season-2
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS92b2wtMi1jaGFwdGVyLTU4LWVuZC1vZi1zZWFzb24tMg==");
        // https://mangacute.com/i-can-hear-it-without-a-microphone/chapter-38
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0zOA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s7.mbbcdn.com/res/manga/painter-of-the-night/chapter-9/35.jpg?acc=tQgf5oVPsqR4n__i2k9vig&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTkvMzUuanBnP2FjYz10UWdmNW9WUHNxUjRuX19pMms5dmlnJmV4cD0xNzA0NDg0ODAw");
        // https://s16.mbbcdn.com/res/manga/dangerous-convenience-store/vol-2-chapter-58-end-of-season-2/e94759009f5e_6.jpg?acc=WJCFZp7POzkwYXwiD9Qi2g&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTYubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL3ZvbC0yLWNoYXB0ZXItNTgtZW5kLW9mLXNlYXNvbi0yL2U5NDc1OTAwOWY1ZV82LmpwZz9hY2M9V0pDRlpwN1BPemt3WVh3aUQ5UWkyZyZleHA9MTcwNDQ4NDgwMA==");
        // https://s17.mbbcdn.com/res/manga/bj-alex/chapter-84/0e745fe5a2b5_12.jpg?acc=9ISfddB5LQIqm95Pav3Q_A&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTg0LzBlNzQ1ZmU1YTJiNV8xMi5qcGc/YWNjPTlJU2ZkZEI1TFFJcW05NVBhdjNRX0EmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s13.mbbcdn.com/res/manga/dangerous-convenience-store/vol-2-chapter-58-end-of-season-2/668d2747dae7_3.jpg?acc=VtOMtgIJUvNiPna_e2aNgw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL3ZvbC0yLWNoYXB0ZXItNTgtZW5kLW9mLXNlYXNvbi0yLzY2OGQyNzQ3ZGFlN18zLmpwZz9hY2M9VnRPTXRnSUpVdk5pUG5hX2UyYU5ndyZleHA9MTcwNDQ4NDgwMA==");
        // https://s14.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-38/e25eca1a2eaf_10.jpg?acc=3aEwdtxdGYzkrcnuW7P3MQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM4L2UyNWVjYTFhMmVhZl8xMC5qcGc/YWNjPTNhRXdkdHhkR1l6a3JjbnVXN1AzTVEmZXhwPTE3MDQ0ODQ4MDA=");
    }
}

