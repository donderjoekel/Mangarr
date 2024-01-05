using System.Collections;

namespace Mangarr.Backend.Tests;

public class BoxManhwaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "boxmanhwa";

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
        // https://boxmanhwa.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://boxmanhwa.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://boxmanhwa.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://boxmanhwa.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://boxmanhwa.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://boxmanhwa.com/i-can-hear-it-without-a-microphone/chapter-58
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci01OA==");
        // https://boxmanhwa.com/i-can-hear-it-without-a-microphone/chapter-31
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0zMQ==");
        // https://boxmanhwa.com/painter-of-the-night/chapter-25
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMjU=");
        // https://boxmanhwa.com/bj-alex/chapter-88
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2JqLWFsZXgvY2hhcHRlci04OA==");
        // https://boxmanhwa.com/bj-alex/chapter-84
        yield return new TestCaseData("aHR0cHM6Ly9ib3htYW5od2EuY29tL2JqLWFsZXgvY2hhcHRlci04NA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s3.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-31/9920c03e311f_24.jpg?acc=uOeSlpKvnKKPYu2k3zttxw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMzEvOTkyMGMwM2UzMTFmXzI0LmpwZz9hY2M9dU9lU2xwS3ZuS0tQWXUyazN6dHR4dyZleHA9MTcwNDQ4NDgwMA==");
        // https://s7.mbbcdn.com/res/manga/bj-alex/chapter-84/dcb0566c15dc_2.jpg?acc=SUy3yvE2zEQS8ZhMOyhGlA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItODQvZGNiMDU2NmMxNWRjXzIuanBnP2FjYz1TVXkzeXZFMnpFUVM4WmhNT3loR2xBJmV4cD0xNzA0NDg0ODAw");
        // https://s15.mbbcdn.com/res/manga/bj-alex/chapter-84/7829026ad5f0_10.jpg?acc=jGwa_OKP11faYTQKxgX4zw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTg0Lzc4MjkwMjZhZDVmMF8xMC5qcGc/YWNjPWpHd2FfT0tQMTFmYVlUUUt4Z1g0encmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s12.mbbcdn.com/res/manga/bj-alex/chapter-84/95667f7d882f_7.jpg?acc=hsHm1rM87vEaPvreZ9roew&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTIubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTg0Lzk1NjY3ZjdkODgyZl83LmpwZz9hY2M9aHNIbTFyTTg3dkVhUHZyZVo5cm9ldyZleHA9MTcwNDQ4NDgwMA==");
        // https://s13.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-58/b6eb03b7b59a_51.jpg?acc=dMcl7qvQwNUpPII3YxHORQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTU4L2I2ZWIwM2I3YjU5YV81MS5qcGc/YWNjPWRNY2w3cXZRd05VcFBJSTNZeEhPUlEmZXhwPTE3MDQ0ODQ4MDA=");
    }
}

