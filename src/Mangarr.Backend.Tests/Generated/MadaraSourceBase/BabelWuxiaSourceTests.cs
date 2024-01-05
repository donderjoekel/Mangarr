using System.Collections;

namespace Mangarr.Backend.Tests;

public class BabelWuxiaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "babelwuxia";

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
        // https://babelwuxia.com/manga/grand-general/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9ncmFuZC1nZW5lcmFsLw==");
        // https://babelwuxia.com/manga/records-of-the-swordsman-scholar/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9yZWNvcmRzLW9mLXRoZS1zd29yZHNtYW4tc2Nob2xhci8=");
        // https://babelwuxia.com/manga/reincarnated-escort-warrior/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9yZWluY2FybmF0ZWQtZXNjb3J0LXdhcnJpb3Iv");
        // https://babelwuxia.com/manga/after-ten-years-of-chopping-wood-immortals-begged-to-become-my-disciples/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9hZnRlci10ZW4teWVhcnMtb2YtY2hvcHBpbmctd29vZC1pbW1vcnRhbHMtYmVnZ2VkLXRvLWJlY29tZS1teS1kaXNjaXBsZXMv");
        // https://babelwuxia.com/manga/the-youngest-son-of-a-master-swordsman/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS90aGUteW91bmdlc3Qtc29uLW9mLWEtbWFzdGVyLXN3b3Jkc21hbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://babelwuxia.com/manga/grand-general/chapter-083/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9ncmFuZC1nZW5lcmFsL2NoYXB0ZXItMDgzLw==");
        // https://babelwuxia.com/manga/grand-general/chapter-044/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9ncmFuZC1nZW5lcmFsL2NoYXB0ZXItMDQ0Lw==");
        // https://babelwuxia.com/manga/grand-general/chapter-079/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9ncmFuZC1nZW5lcmFsL2NoYXB0ZXItMDc5Lw==");
        // https://babelwuxia.com/manga/the-youngest-son-of-a-master-swordsman/chapter-067/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS90aGUteW91bmdlc3Qtc29uLW9mLWEtbWFzdGVyLXN3b3Jkc21hbi9jaGFwdGVyLTA2Ny8=");
        // https://babelwuxia.com/manga/after-ten-years-of-chopping-wood-immortals-begged-to-become-my-disciples/chapter-036/
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS9tYW5nYS9hZnRlci10ZW4teWVhcnMtb2YtY2hvcHBpbmctd29vZC1pbW1vcnRhbHMtYmVnZ2VkLXRvLWJlY29tZS1teS1kaXNjaXBsZXMvY2hhcHRlci0wMzYv");
    }

    public static IEnumerable ValidImages()
    {
        // https://babelwuxia.com/wp-content/uploads/WP-manga/data/manga_64466ac20180e/chapter-044/u20230714_152139_2690.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ2NmFjMjAxODBlL2NoYXB0ZXItMDQ0L3UyMDIzMDcxNF8xNTIxMzlfMjY5MC5qcGc=");
        // https://babelwuxia.com/wp-content/uploads/WP-manga/data/manga_644667fba96ea/chapter-067/j041.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ2NjdmYmE5NmVhL2NoYXB0ZXItMDY3L2owNDEuanBn");
        // https://babelwuxia.com/wp-content/uploads/WP-manga/data/manga_64466ac20180e/chapter-079/j067.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ2NmFjMjAxODBlL2NoYXB0ZXItMDc5L2owNjcuanBn");
        // https://babelwuxia.com/wp-content/uploads/WP-manga/data/manga_64466ac20180e/chapter-079/j023.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ2NmFjMjAxODBlL2NoYXB0ZXItMDc5L2owMjMuanBn");
        // https://babelwuxia.com/wp-content/uploads/WP-manga/data/manga_644668a4e9d8a/chapter-036/v061.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iYWJlbHd1eGlhLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ2NjhhNGU5ZDhhL2NoYXB0ZXItMDM2L3YwNjEuanBn");
    }
}

