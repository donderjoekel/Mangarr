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
        // https://truemanga.com/i-can-hear-it-without-a-microphone/chapter-68
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci02OA==");
        // https://truemanga.com/painter-of-the-night/chapter-14
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMTQ=");
        // https://truemanga.com/i-can-hear-it-without-a-microphone/chapter-53
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci01Mw==");
        // https://truemanga.com/dangerous-convenience-store/chapter-22
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTIy");
        // https://truemanga.com/bj-alex/chapter-97
        yield return new TestCaseData("aHR0cHM6Ly90cnVlbWFuZ2EuY29tL2JqLWFsZXgvY2hhcHRlci05Nw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s10.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-68/8ae8aa39a9a46920e6ce8a2c077994ef.jpg?acc=03DgbpPyoFjvE97ktCT-iQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTY4LzhhZThhYTM5YTlhNDY5MjBlNmNlOGEyYzA3Nzk5NGVmLmpwZz9hY2M9MDNEZ2JwUHlvRmp2RTk3a3RDVC1pUSZleHA9MTcwNDQ4NDgwMA==");
        // https://s12.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-53/bbc30f3d55d3_25.jpg?acc=6rcS85MWwq-B13VzzEICOg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTIubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTUzL2JiYzMwZjNkNTVkM18yNS5qcGc/YWNjPTZyY1M4NU1Xd3EtQjEzVnp6RUlDT2cmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s15.mbbcdn.com/res/manga/painter-of-the-night/chapter-14/8.jpg?acc=OSHPrPs0IaEFCKZpXZmHUg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xNC84LmpwZz9hY2M9T1NIUHJQczBJYUVGQ0tacFhabUhVZyZleHA9MTcwNDQ4NDgwMA==");
        // https://s3.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-53/d758bbe58738_36.jpg?acc=sQRPsw1kN9IyPm63eiNywA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNTMvZDc1OGJiZTU4NzM4XzM2LmpwZz9hY2M9c1FSUHN3MWtOOUl5UG02M2VpTnl3QSZleHA9MTcwNDQ4NDgwMA==");
        // https://s17.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-53/2ca477de8c16_30.jpg?acc=g0j1GEjEHgdPeNocainh2A&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTUzLzJjYTQ3N2RlOGMxNl8zMC5qcGc/YWNjPWcwajFHRWpFSGdkUGVOb2NhaW5oMkEmZXhwPTE3MDQ0ODQ4MDA=");
    }
}

