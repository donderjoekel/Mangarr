using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaTubeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwatube";

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
        // https://manhwatube.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodHxwYWludGVyLW9mLXRoZS1uaWdodA==");
        // https://manhwatube.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lfGktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmU=");
        // https://manhwatube.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9iai1hbGV4fGJqLWFsZXg=");
        // https://manhwatube.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS8xOS1kYXlzfDE5LWRheXM=");
        // https://manhwatube.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmV8ZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3Jl");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwatube.com/bj-alex/chapter-34
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9iai1hbGV4L2NoYXB0ZXItMzQ=");
        // https://manhwatube.com/dangerous-convenience-store/chapter-63
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci02Mw==");
        // https://manhwatube.com/painter-of-the-night/chapter-18
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTE4");
        // https://manhwatube.com/dangerous-convenience-store/chapter-67
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci02Nw==");
        // https://manhwatube.com/i-can-hear-it-without-a-microphone/chapter-27
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMjc=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s4.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-67/616385236e40509771bfc813fd91e016.jpg?acc=LW10QDNABEE274aQq6_-4Q&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci02Ny82MTYzODUyMzZlNDA1MDk3NzFiZmM4MTNmZDkxZTAxNi5qcGc/YWNjPUxXMTBRRE5BQkVFMjc0YVFxNl8tNFEmZXhwPTE3MDQzNzY4MDA=");
        // https://s13.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-27/e0f76f54d18b_35.jpg?acc=yWJlUVNREFk-pX4Vq7aA8Q&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTMubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTI3L2UwZjc2ZjU0ZDE4Yl8zNS5qcGc/YWNjPXlXSmxVVk5SRUZrLXBYNFZxN2FBOFEmZXhwPTE3MDQzNzY4MDA=");
        // https://s14.mbbcdn.com/res/manga/painter-of-the-night/chapter-18/10.jpg?acc=j79PecaP9KFQdAeHwoTLlQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xOC8xMC5qcGc/YWNjPWo3OVBlY2FQOUtGUWRBZUh3b1RMbFEmZXhwPTE3MDQzNzY4MDA=");
        // https://s20.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-27/69b110c33185_22.jpg?acc=bffmlrB7m64xozfBHWhqgA&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMjAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTI3LzY5YjExMGMzMzE4NV8yMi5qcGc/YWNjPWJmZm1sckI3bTY0eG96ZkJIV2hxZ0EmZXhwPTE3MDQzNzY4MDA=");
        // https://s5.mbbcdn.com/res/manga/painter-of-the-night/chapter-18/1.jpg?acc=cBd1YhvesAciFA-JNjM5tg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTE4LzEuanBnP2FjYz1jQmQxWWh2ZXNBY2lGQS1KTmpNNXRnJmV4cD0xNzA0Mzc2ODAw");
    }
}

