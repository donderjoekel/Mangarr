using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaRubyDotcomSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaruby.com";

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
        // https://mangaruby.com/manga/im-a-villain-but-i-saved-the-female-lead/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2ltLWEtdmlsbGFpbi1idXQtaS1zYXZlZC10aGUtZmVtYWxlLWxlYWQv");
        // https://mangaruby.com/manga/pretty-woman/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL3ByZXR0eS13b21hbi8=");
        // https://mangaruby.com/manga/i-think-i-have-transmigrated-somewhere/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2ktdGhpbmstaS1oYXZlLXRyYW5zbWlncmF0ZWQtc29tZXdoZXJlLw==");
        // https://mangaruby.com/manga/ive-probably-made-a-mistake-in-getting-married/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2l2ZS1wcm9iYWJseS1tYWRlLWEtbWlzdGFrZS1pbi1nZXR0aW5nLW1hcnJpZWQv");
        // https://mangaruby.com/manga/angelica-my-wife-has-changed/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2FuZ2VsaWNhLW15LXdpZmUtaGFzLWNoYW5nZWQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaruby.com/manga/im-a-villain-but-i-saved-the-female-lead/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2ltLWEtdmlsbGFpbi1idXQtaS1zYXZlZC10aGUtZmVtYWxlLWxlYWQvY2hhcHRlci02Lw==");
        // https://mangaruby.com/manga/pretty-woman/chapter-1-public-relation-crisis/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL3ByZXR0eS13b21hbi9jaGFwdGVyLTEtcHVibGljLXJlbGF0aW9uLWNyaXNpcy8=");
        // https://mangaruby.com/manga/i-think-i-have-transmigrated-somewhere/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2ktdGhpbmstaS1oYXZlLXRyYW5zbWlncmF0ZWQtc29tZXdoZXJlL2NoYXB0ZXItMy8=");
        // https://mangaruby.com/manga/im-a-villain-but-i-saved-the-female-lead/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2ltLWEtdmlsbGFpbi1idXQtaS1zYXZlZC10aGUtZmVtYWxlLWxlYWQvY2hhcHRlci00Lw==");
        // https://mangaruby.com/manga/angelica-my-wife-has-changed/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ1YnkuY29tL21hbmdhL2FuZ2VsaWNhLW15LXdpZmUtaGFzLWNoYW5nZWQvY2hhcHRlci0xLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65199b23c2eec/2745c8136d2e1f994a408cc4384422b3/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTE5OWIyM2MyZWVjLzI3NDVjODEzNmQyZTFmOTk0YTQwOGNjNDM4NDQyMmIzLzAwMS5qcGc=");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_65184a376cd1a/955b2e1113d740b2fc71487ba3d3f99e/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTE4NGEzNzZjZDFhLzk1NWIyZTExMTNkNzQwYjJmYzcxNDg3YmEzZDNmOTllLzAxLmpwZw==");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_651aed6f5f141/c8f3b015e6dc8474ef8a3a7ed3111512/image-01.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTFhZWQ2ZjVmMTQxL2M4ZjNiMDE1ZTZkYzg0NzRlZjhhM2E3ZWQzMTExNTEyL2ltYWdlLTAxLndlYnA=");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_651aed6f5f141/773a043f820ea004ffdf2e9c95dce024/01.webp
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTFhZWQ2ZjVmMTQxLzc3M2EwNDNmODIwZWEwMDRmZmRmMmU5Yzk1ZGNlMDI0LzAxLndlYnA=");
        // https://coffeemanga.io/wp-content/uploads/WP-manga/data/manga_651aa7bce014e/34369cf5e9068f929e69a96bf0ab1376/0.png
        yield return new TestCaseData("aHR0cHM6Ly9jb2ZmZWVtYW5nYS5pby93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTFhYTdiY2UwMTRlLzM0MzY5Y2Y1ZTkwNjhmOTI5ZTY5YTk2YmYwYWIxMzc2LzAucG5n");
    }
}

