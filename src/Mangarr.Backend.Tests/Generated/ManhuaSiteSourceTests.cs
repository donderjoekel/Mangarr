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
        // https://manhuasite.com/bj-alex/chapter-35
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9iai1hbGV4L2NoYXB0ZXItMzU=");
        // https://manhuasite.com/painter-of-the-night/chapter-84
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTg0");
        // https://manhuasite.com/dangerous-convenience-store/chapter-31
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci0zMQ==");
        // https://manhuasite.com/bj-alex/chapter-17
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9iai1hbGV4L2NoYXB0ZXItMTc=");
        // https://manhuasite.com/painter-of-the-night/chapter-111
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFzaXRlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTExMQ==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s13.mbbcdn.com/res/manga/painter-of-the-night/chapter-84/d8006c5162c7_29.jpg?acc=tDGk7k6oYM05OLqq28KRFA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci04NC9kODAwNmM1MTYyYzdfMjkuanBnP2FjYz10REdrN2s2b1lNMDVPTHFxMjhLUkZBJmV4cD0xNzA0Mzc2ODAw");
        // https://s17.mbbcdn.com/res/manga/painter-of-the-night/chapter-111/b63d58ea6bf03b676db5c1ca2cc9cb18.webp?acc=qkMogd37uAJCxdyVqcXuvw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMTEvYjYzZDU4ZWE2YmYwM2I2NzZkYjVjMWNhMmNjOWNiMTgud2VicD9hY2M9cWtNb2dkMzd1QUpDeGR5VnFjWHV2dyZleHA9MTcwNDM3NjgwMA==");
        // https://s20.mbbcdn.com/res/manga/bj-alex/chapter-17/efb8d7b332a9_13.jpg?acc=m8y_Pp0sl2fwkJ0Ua2lKfA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMjAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTE3L2VmYjhkN2IzMzJhOV8xMy5qcGc/YWNjPW04eV9QcDBzbDJmd2tKMFVhMmxLZkEmZXhwPTE3MDQzNzY4MDA=");
        // https://s8.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-31/1a3be5b91e6e_28.jpg?acc=YtosWch8qUkjAWhst4ckSg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zOC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci0zMS8xYTNiZTViOTFlNmVfMjguanBnP2FjYz1ZdG9zV2NoOHFVa2pBV2hzdDRja1NnJmV4cD0xNzA0Mzc2ODAw");
        // https://s15.mbbcdn.com/res/manga/painter-of-the-night/chapter-84/a4aebff24e61_31.jpg?acc=6W5sihBEXT-oSyvREO2QpA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci04NC9hNGFlYmZmMjRlNjFfMzEuanBnP2FjYz02VzVzaWhCRVhULW9TeXZSRU8yUXBBJmV4cD0xNzA0Mzc2ODAw");
    }
}

