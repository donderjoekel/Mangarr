using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaXYZSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaxyz";

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
        // https://mangaxyz.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vcGFpbnRlci1vZi10aGUtbmlnaHR8cGFpbnRlci1vZi10aGUtbmlnaHQ=");
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZXxpLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25l");
        // https://mangaxyz.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vYmotYWxleHxiai1hbGV4");
        // https://mangaxyz.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vMTktZGF5c3wxOS1kYXlz");
        // https://mangaxyz.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlfGRhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZQ==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone/chapter-14
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTE0");
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone/chapter-38
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM4");
        // https://mangaxyz.com/painter-of-the-night/chapter-116
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMTY=");
        // https://mangaxyz.com/painter-of-the-night/hiatus-0801
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vcGFpbnRlci1vZi10aGUtbmlnaHQvaGlhdHVzLTA4MDE=");
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone/chapter-96
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTk2");
    }

    public static IEnumerable ValidImages()
    {
        // https://s15.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-96/bfa2a780ea379ee449752cc7f5a98aa1.jpeg?acc=rVFk2cMSJatVx12t5kB5VQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTk2L2JmYTJhNzgwZWEzNzllZTQ0OTc1MmNjN2Y1YTk4YWExLmpwZWc/YWNjPXJWRmsyY01TSmF0VngxMnQ1a0I1VlEmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s8.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-38/51417031ed79_4.jpg?acc=JGo1uY4k_6v5K4E87-Tzxg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zOC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMzgvNTE0MTcwMzFlZDc5XzQuanBnP2FjYz1KR28xdVk0a182djVLNEU4Ny1UenhnJmV4cD0xNzA0NDg0ODAw");
        // https://s17.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-38/065b57c4f0a7_53.jpg?acc=YSthEpo4299xBbPlqnOhNw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM4LzA2NWI1N2M0ZjBhN181My5qcGc/YWNjPVlTdGhFcG80Mjk5eEJiUGxxbk9oTncmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s4.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-14/0b78b81a61f5_47.jpg?acc=t4JSVJAouazo7YvIOvZvag&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMTQvMGI3OGI4MWE2MWY1XzQ3LmpwZz9hY2M9dDRKU1ZKQW91YXpvN1l2SU92WnZhZyZleHA9MTcwNDQ4NDgwMA==");
        // https://s7.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-14/43351154fe76_50.jpg?acc=aTzU9NZ77kgXPHALZ7y41g&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMTQvNDMzNTExNTRmZTc2XzUwLmpwZz9hY2M9YVR6VTlOWjc3a2dYUEhBTFo3eTQxZyZleHA9MTcwNDQ4NDgwMA==");
    }
}

