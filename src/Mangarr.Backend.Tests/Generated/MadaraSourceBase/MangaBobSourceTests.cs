using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaBobSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangabob";

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
        // https://mangabob.com/comic/divine-path-to-supremacy/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvZGl2aW5lLXBhdGgtdG8tc3VwcmVtYWN5Lw==");
        // https://mangabob.com/comic/policing-in-the-zhou-dynasty/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvcG9saWNpbmctaW4tdGhlLXpob3UtZHluYXN0eS8=");
        // https://mangabob.com/comic/this-game-is-too-real/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvdGhpcy1nYW1lLWlzLXRvby1yZWFsLw==");
        // https://mangabob.com/comic/this-martial-saint-is-way-too-generous/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvdGhpcy1tYXJ0aWFsLXNhaW50LWlzLXdheS10b28tZ2VuZXJvdXMv");
        // https://mangabob.com/comic/my-eight-husbands-are-here/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvbXktZWlnaHQtaHVzYmFuZHMtYXJlLWhlcmUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangabob.com/comic/this-martial-saint-is-way-too-generous/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvdGhpcy1tYXJ0aWFsLXNhaW50LWlzLXdheS10b28tZ2VuZXJvdXMvY2hhcHRlci0xMC8=");
        // https://mangabob.com/comic/my-eight-husbands-are-here/chapter-14/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvbXktZWlnaHQtaHVzYmFuZHMtYXJlLWhlcmUvY2hhcHRlci0xNC8=");
        // https://mangabob.com/comic/this-martial-saint-is-way-too-generous/chapter-38/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvdGhpcy1tYXJ0aWFsLXNhaW50LWlzLXdheS10b28tZ2VuZXJvdXMvY2hhcHRlci0zOC8=");
        // https://mangabob.com/comic/divine-path-to-supremacy/chapter-45/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvZGl2aW5lLXBhdGgtdG8tc3VwcmVtYWN5L2NoYXB0ZXItNDUv");
        // https://mangabob.com/comic/this-martial-saint-is-way-too-generous/chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJvYi5jb20vY29taWMvdGhpcy1tYXJ0aWFsLXNhaW50LWlzLXdheS10b28tZ2VuZXJvdXMvY2hhcHRlci0xNS8=");
    }

    public static IEnumerable ValidImages()
    {
        // http://mangabob.com/wp-content/uploads/WP-manga/data/manga_656eeb624fff5/cb12260ee531ca439032ab7561c831ef/0044.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhYm9iLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZlZWI2MjRmZmY1L2NiMTIyNjBlZTUzMWNhNDM5MDMyYWI3NTYxYzgzMWVmLzAwNDQuanBn");
        // http://mangabob.com/wp-content/uploads/WP-manga/data/manga_657561f63ac91/4f8b00f0cf1e1571ba5f91da0581846e/0039.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhYm9iLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc1NjFmNjNhYzkxLzRmOGIwMGYwY2YxZTE1NzFiYTVmOTFkYTA1ODE4NDZlLzAwMzkuanBn");
        // http://mangabob.com/wp-content/uploads/WP-manga/data/manga_656eeb624fff5/cb12260ee531ca439032ab7561c831ef/0065.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhYm9iLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZlZWI2MjRmZmY1L2NiMTIyNjBlZTUzMWNhNDM5MDMyYWI3NTYxYzgzMWVmLzAwNjUuanBn");
        // http://mangabob.com/wp-content/uploads/WP-manga/data/manga_656eeb624fff5/8fc937473d473cc8e51baef726112fec/144.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhYm9iLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZlZWI2MjRmZmY1LzhmYzkzNzQ3M2Q0NzNjYzhlNTFiYWVmNzI2MTEyZmVjLzE0NC5qcGc=");
        // http://mangabob.com/wp-content/uploads/WP-manga/data/manga_656eeb624fff5/8fc937473d473cc8e51baef726112fec/103.jpg
        yield return new TestCaseData("aHR0cDovL21hbmdhYm9iLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZlZWI2MjRmZmY1LzhmYzkzNzQ3M2Q0NzNjYzhlNTFiYWVmNzI2MTEyZmVjLzEwMy5qcGc=");
    }
}

