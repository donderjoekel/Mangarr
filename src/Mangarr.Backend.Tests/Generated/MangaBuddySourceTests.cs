using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaBuddySourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangabuddy";

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
        // https://mangabuddy.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9wYWludGVyLW9mLXRoZS1uaWdodHxwYWludGVyLW9mLXRoZS1uaWdodA==");
        // https://mangabuddy.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lfGktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmU=");
        // https://mangabuddy.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9iai1hbGV4fGJqLWFsZXg=");
        // https://mangabuddy.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS8xOS1kYXlzfDE5LWRheXM=");
        // https://mangabuddy.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmV8ZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3Jl");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangabuddy.com/bj-alex/chapter-40
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9iai1hbGV4L2NoYXB0ZXItNDA=");
        // https://mangabuddy.com/painter-of-the-night/chapter-30-1
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTMwLTE=");
        // https://mangabuddy.com/i-can-hear-it-without-a-microphone/chapter-41
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNDE=");
        // https://mangabuddy.com/bj-alex/chapter-4
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9iai1hbGV4L2NoYXB0ZXItNA==");
        // https://mangabuddy.com/dangerous-convenience-store/chapter-8
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci04");
    }

    public static IEnumerable ValidImages()
    {
        // https://s17.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-41/0a56411d3248_19.jpg?acc=OerKIfH1upbB61CiiF1hWw&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTQxLzBhNTY0MTFkMzI0OF8xOS5qcGc/YWNjPU9lcktJZkgxdXBiQjYxQ2lpRjFoV3cmZXhwPTE3MDQzNzY4MDA=");
        // https://s11.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-41/6b7678990104_13.jpg?acc=yDEOPAWXj5n_LY4UdbDl3g&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTQxLzZiNzY3ODk5MDEwNF8xMy5qcGc/YWNjPXlERU9QQVdYajVuX0xZNFVkYkRsM2cmZXhwPTE3MDQzNzY4MDA=");
        // https://s8.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-41/702f57cd251d_10.jpg?acc=ozwN-qkSbDBrEUOXI7BXAA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zOC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNDEvNzAyZjU3Y2QyNTFkXzEwLmpwZz9hY2M9b3p3Ti1xa1NiREJyRVVPWEk3QlhBQSZleHA9MTcwNDM3NjgwMA==");
        // https://s13.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-41/67595aa48250_35.jpg?acc=UlGwgbSnKVHQjomAGXyaBA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTQxLzY3NTk1YWE0ODI1MF8zNS5qcGc/YWNjPVVsR3dnYlNuS1ZIUWpvbUFHWHlhQkEmZXhwPTE3MDQzNzY4MDA=");
        // https://s8.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-41/6f9e2c181128_50.jpg?acc=H8gr9diAgDINKEi68zQiWA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zOC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNDEvNmY5ZTJjMTgxMTI4XzUwLmpwZz9hY2M9SDhncjlkaUFnRElOS0VpNjh6UWlXQSZleHA9MTcwNDM3NjgwMA==");
    }
}

