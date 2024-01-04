using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaFabSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangafab";

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
        // https://mangafab.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vcGFpbnRlci1vZi10aGUtbmlnaHR8cGFpbnRlci1vZi10aGUtbmlnaHQ=");
        // https://mangafab.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZXxpLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25l");
        // https://mangafab.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vYmotYWxleHxiai1hbGV4");
        // https://mangafab.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vMTktZGF5c3wxOS1kYXlz");
        // https://mangafab.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlfGRhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZQ==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangafab.com/dangerous-convenience-store/chapter-76
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItNzY=");
        // https://mangafab.com/i-can-hear-it-without-a-microphone/chapter-57
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTU3");
        // https://mangafab.com/bj-alex/chapter-97
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vYmotYWxleC9jaGFwdGVyLTk3");
        // https://mangafab.com/i-can-hear-it-without-a-microphone/chapter-76
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTc2");
        // https://mangafab.com/painter-of-the-night/chapter-121
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMjE=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s12.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-76/89e402e33d29e916a3a00cb54e39157e.jpg?acc=6Z91yV6wz_eRdSlrc688nQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTIubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTc2Lzg5ZTQwMmUzM2QyOWU5MTZhM2EwMGNiNTRlMzkxNTdlLmpwZz9hY2M9Nlo5MXlWNnd6X2VSZFNscmM2ODhuUSZleHA9MTcwNDM3NjgwMA==");
        // https://s3.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-76/0224781dd9e1770a4916b0fb7747b6e6.jpg?acc=TSHpaoD3eFQsf0bO5LMkRg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci03Ni8wMjI0NzgxZGQ5ZTE3NzBhNDkxNmIwZmI3NzQ3YjZlNi5qcGc/YWNjPVRTSHBhb0QzZUZRc2YwYk81TE1rUmcmZXhwPTE3MDQzNzY4MDA=");
        // https://s5.mbbcdn.com/res/manga/bj-alex/chapter-97/4820d816ab68_12.jpg?acc=eu0uaKpbcpAf7E7zBX_u6Q&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItOTcvNDgyMGQ4MTZhYjY4XzEyLmpwZz9hY2M9ZXUwdWFLcGJjcEFmN0U3ekJYX3U2USZleHA9MTcwNDM3NjgwMA==");
        // https://s2.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-76/ca479aba4d6e2e2be80ab042276cfaa6.jpg?acc=WfNNIk98hs5eACEQJ4J8Cw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci03Ni9jYTQ3OWFiYTRkNmUyZTJiZTgwYWIwNDIyNzZjZmFhNi5qcGc/YWNjPVdmTk5Jazk4aHM1ZUFDRVFKNEo4Q3cmZXhwPTE3MDQzNzY4MDA=");
        // https://s15.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-57/63167c0a278f_1.jpg?acc=Sr3CEdlQRkJH6knQ2KP5sw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTU3LzYzMTY3YzBhMjc4Zl8xLmpwZz9hY2M9U3IzQ0VkbFFSa0pINmtuUTJLUDVzdyZleHA9MTcwNDM3NjgwMA==");
    }
}

