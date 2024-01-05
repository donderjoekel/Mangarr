using System.Collections;

namespace Mangarr.Backend.Tests;

public class KissmangaDotinSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "kissmanga.in";

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
        // https://kissmanga.in/kissmanga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
        // https://kissmanga.in/kissmanga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3Mv");
        // https://kissmanga.in/kissmanga/the-demon-emperor-hopes-for-a-hero/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL3RoZS1kZW1vbi1lbXBlcm9yLWhvcGVzLWZvci1hLWhlcm8v");
        // https://kissmanga.in/kissmanga/reincarnator-manhwa/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL3JlaW5jYXJuYXRvci1tYW5od2Ev");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://kissmanga.in/kissmanga/mr-devourer-please-act-like-a-final-boss/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MvY2hhcHRlci0xNy8=");
        // https://kissmanga.in/kissmanga/mr-devourer-please-act-like-a-final-boss/chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MvY2hhcHRlci0yMi8=");
        // https://kissmanga.in/kissmanga/mr-devourer-please-act-like-a-final-boss/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MvY2hhcHRlci0xOC8=");
        // https://kissmanga.in/kissmanga/reincarnator-manhwa/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL3JlaW5jYXJuYXRvci1tYW5od2EvY2hhcHRlci0yLw==");
        // https://kissmanga.in/kissmanga/mr-devourer-please-act-like-a-final-boss/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9raXNzbWFuZ2EuaW4va2lzc21hbmdhL21yLWRldm91cmVyLXBsZWFzZS1hY3QtbGlrZS1hLWZpbmFsLWJvc3MvY2hhcHRlci01Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangaimages.site/wp-content/uploads/WP-manga/data/manga_65919baa75ff4/773de536b3c5caafd13f0d50cb64e01b/18.webp
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWltYWdlcy5zaXRlL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTE5YmFhNzVmZjQvNzczZGU1MzZiM2M1Y2FhZmQxM2YwZDUwY2I2NGUwMWIvMTgud2VicA==");
        // https://mangaimages.site/wp-content/uploads/WP-manga/data/manga_65919baa75ff4/19cdd33c47d611080b1ad7d263317056/19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWltYWdlcy5zaXRlL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTE5YmFhNzVmZjQvMTljZGQzM2M0N2Q2MTEwODBiMWFkN2QyNjMzMTcwNTYvMTkuanBn");
        // https://mangaimages.site/wp-content/uploads/WP-manga/data/manga_6590452a63d6f/5b1e550781733431cee951b1c3825a84/2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWltYWdlcy5zaXRlL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTA0NTJhNjNkNmYvNWIxZTU1MDc4MTczMzQzMWNlZTk1MWIxYzM4MjVhODQvMi5qcGc=");
        // https://mangaimages.site/wp-content/uploads/WP-manga/data/manga_65919baa75ff4/d79c2caf2b380004c82f736a792ddb48/6.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWltYWdlcy5zaXRlL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTE5YmFhNzVmZjQvZDc5YzJjYWYyYjM4MDAwNGM4MmY3MzZhNzkyZGRiNDgvNi5qcGc=");
        // https://mangaimages.site/wp-content/uploads/WP-manga/data/manga_65919baa75ff4/e5291f41ef8f78755c5653aa739ce6d4/18.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWltYWdlcy5zaXRlL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTE5YmFhNzVmZjQvZTUyOTFmNDFlZjhmNzg3NTVjNTY1M2FhNzM5Y2U2ZDQvMTguanBn");
    }
}

