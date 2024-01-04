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
        // https://mangaspin.com/painter-of-the-night/chapter-89
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItODk=");
        // https://mangaspin.com/i-can-hear-it-without-a-microphone/chapter-5
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci01");
        // https://mangaspin.com/dangerous-convenience-store/afterword-season-2-review
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9hZnRlcndvcmQtc2Vhc29uLTItcmV2aWV3");
        // https://mangaspin.com/painter-of-the-night/chapter-39
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMzk=");
        // https://mangaspin.com/painter-of-the-night/chapter-102-6
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNwaW4uY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMTAyLTY=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s2.mbbcdn.com/res/manga/dangerous-convenience-store/afterword-season-2-review/dca3938aab51_3.jpg?acc=MrejGGzb-Wm0_6p9RII8bA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvYWZ0ZXJ3b3JkLXNlYXNvbi0yLXJldmlldy9kY2EzOTM4YWFiNTFfMy5qcGc/YWNjPU1yZWpHR3piLVdtMF82cDlSSUk4YkEmZXhwPTE3MDQzNzY4MDA=");
        // https://s5.mbbcdn.com/res/manga/dangerous-convenience-store/afterword-season-2-review/9ab2359476db_6.jpg?acc=cUxH1pEoNXnDKGUTzT7ckg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvYWZ0ZXJ3b3JkLXNlYXNvbi0yLXJldmlldy85YWIyMzU5NDc2ZGJfNi5qcGc/YWNjPWNVeEgxcEVvTlhuREtHVVR6VDdja2cmZXhwPTE3MDQzNzY4MDA=");
        // https://s19.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-5/07ad91f5b9b0_1.jpg?acc=tLWWx_8ZIZCP6F2xcjf9VQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTkubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTUvMDdhZDkxZjViOWIwXzEuanBnP2FjYz10TFdXeF84WklaQ1A2RjJ4Y2pmOVZRJmV4cD0xNzA0Mzc2ODAw");
        // https://s14.mbbcdn.com/res/manga/painter-of-the-night/chapter-89/760e084d549a_3.jpg?acc=_HUidxZrdwgfFTDM2ZYTuQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci04OS83NjBlMDg0ZDU0OWFfMy5qcGc/YWNjPV9IVWlkeFpyZHdnZkZURE0yWllUdVEmZXhwPTE3MDQzNzY4MDA=");
        // https://s10.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-5/82057e421d90_32.jpg?acc=OD74scrorkjvpLG3bV0IMw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTUvODIwNTdlNDIxZDkwXzMyLmpwZz9hY2M9T0Q3NHNjcm9ya2p2cExHM2JWMElNdyZleHA9MTcwNDM3NjgwMA==");
    }
}

