using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaDistrictSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangadistrict";

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
        // https://mangadistrict.com/read-scan/the-game-fatal-doctor-official-uncensored/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vdGhlLWdhbWUtZmF0YWwtZG9jdG9yLW9mZmljaWFsLXVuY2Vuc29yZWQv");
        // https://mangadistrict.com/read-scan/steamy-studies-official/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vc3RlYW15LXN0dWRpZXMtb2ZmaWNpYWwv");
        // https://mangadistrict.com/read-scan/close-family-official/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vY2xvc2UtZmFtaWx5LW9mZmljaWFsLw==");
        // https://mangadistrict.com/read-scan/winter-wolf-official/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vd2ludGVyLXdvbGYtb2ZmaWNpYWwv");
        // https://mangadistrict.com/read-scan/my-own-naughty-scenario-official/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vbXktb3duLW5hdWdodHktc2NlbmFyaW8tb2ZmaWNpYWwv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangadistrict.com/read-scan/winter-wolf-official/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vd2ludGVyLXdvbGYtb2ZmaWNpYWwvY2hhcHRlci0xOC8=");
        // https://mangadistrict.com/read-scan/steamy-studies-official/chapter-28/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vc3RlYW15LXN0dWRpZXMtb2ZmaWNpYWwvY2hhcHRlci0yOC8=");
        // https://mangadistrict.com/read-scan/steamy-studies-official/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vc3RlYW15LXN0dWRpZXMtb2ZmaWNpYWwvY2hhcHRlci02Lw==");
        // https://mangadistrict.com/read-scan/the-game-fatal-doctor-official-uncensored/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vdGhlLWdhbWUtZmF0YWwtZG9jdG9yLW9mZmljaWFsLXVuY2Vuc29yZWQvY2hhcHRlci0xLw==");
        // https://mangadistrict.com/read-scan/winter-wolf-official/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWRpc3RyaWN0LmNvbS9yZWFkLXNjYW4vd2ludGVyLXdvbGYtb2ZmaWNpYWwvY2hhcHRlci0xNy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.mangadistrict.com/publication/manga_658f0d8b81279/chapter-28/12.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FkaXN0cmljdC5jb20vcHVibGljYXRpb24vbWFuZ2FfNjU4ZjBkOGI4MTI3OS9jaGFwdGVyLTI4LzEyLmpwZw==");
        // https://cdn.mangadistrict.com/publication/manga_658f0d8b81279/chapter-28/31.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FkaXN0cmljdC5jb20vcHVibGljYXRpb24vbWFuZ2FfNjU4ZjBkOGI4MTI3OS9jaGFwdGVyLTI4LzMxLmpwZw==");
        // https://cdn.mangadistrict.com/publication/manga_658f30b9a502e/chapter-18/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FkaXN0cmljdC5jb20vcHVibGljYXRpb24vbWFuZ2FfNjU4ZjMwYjlhNTAyZS9jaGFwdGVyLTE4LzA5LmpwZw==");
        // https://cdn.mangadistrict.com/publication/manga_658f0d8b81279/chapter-28/35.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FkaXN0cmljdC5jb20vcHVibGljYXRpb24vbWFuZ2FfNjU4ZjBkOGI4MTI3OS9jaGFwdGVyLTI4LzM1LmpwZw==");
        // https://cdn.mangadistrict.com/publication/manga_658f0d8b81279/chapter-28/29.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FkaXN0cmljdC5jb20vcHVibGljYXRpb24vbWFuZ2FfNjU4ZjBkOGI4MTI3OS9jaGFwdGVyLTI4LzI5LmpwZw==");
    }
}

