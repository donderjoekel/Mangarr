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
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone/chapter-96
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTk2");
        // https://mangaxyz.com/bj-alex/chapter-43
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vYmotYWxleC9jaGFwdGVyLTQz");
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone/chapter-28
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTI4");
        // https://mangaxyz.com/bj-alex/chapter-68
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vYmotYWxleC9jaGFwdGVyLTY4");
        // https://mangaxyz.com/i-can-hear-it-without-a-microphone/chapter-61
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXh5ei5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTYx");
    }

    public static IEnumerable ValidImages()
    {
        // https://s19.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-96/4f34d79217d322d0e1489b01f2b648f1.jpeg?acc=ZhfuW0QuY3aLX1SH5TCq2g&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTkubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTk2LzRmMzRkNzkyMTdkMzIyZDBlMTQ4OWIwMWYyYjY0OGYxLmpwZWc/YWNjPVpoZnVXMFF1WTNhTFgxU0g1VENxMmcmZXhwPTE3MDQzNzY4MDA=");
        // https://s3.mbbcdn.com/res/manga/bj-alex/chapter-68/44f403514b2d_18.jpg?acc=LqzmpPtgQVlgxKiUuK8LNQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItNjgvNDRmNDAzNTE0YjJkXzE4LmpwZz9hY2M9THF6bXBQdGdRVmxneEtpVXVLOExOUSZleHA9MTcwNDM3NjgwMA==");
        // https://s14.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-96/50f78c21331460bb5884f662e07e0290.jpeg?acc=kxyEiuNU9YpbrlLqxNL4mg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTk2LzUwZjc4YzIxMzMxNDYwYmI1ODg0ZjY2MmUwN2UwMjkwLmpwZWc/YWNjPWt4eUVpdU5VOVlwYnJsTHF4Tkw0bWcmZXhwPTE3MDQzNzY4MDA=");
        // https://s19.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-28/0831c475f0ec_1631165656871_3.jpg?acc=vq4eK4dI9jDNS8M5-1ZLwQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTkubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTI4LzA4MzFjNDc1ZjBlY18xNjMxMTY1NjU2ODcxXzMuanBnP2FjYz12cTRlSzRkSTlqRE5TOE01LTFaTHdRJmV4cD0xNzA0Mzc2ODAw");
        // https://s7.mbbcdn.com/res/manga/bj-alex/chapter-68/47ec2c295759_22.jpg?acc=wWnz7OWzDlnGKoCsI2GLTQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItNjgvNDdlYzJjMjk1NzU5XzIyLmpwZz9hY2M9d1duejdPV3pEbG5HS29Dc0kyR0xUUSZleHA9MTcwNDM3NjgwMA==");
    }
}

