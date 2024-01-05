using System.Collections;

namespace Mangarr.Backend.Tests;

public class KaiScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "kaiscans";

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
        // https://kaiscans.com/series/raising-my-fiance-with-money/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vc2VyaWVzL3JhaXNpbmctbXktZmlhbmNlLXdpdGgtbW9uZXkv");
        // https://kaiscans.com/series/reclusive-mage/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vc2VyaWVzL3JlY2x1c2l2ZS1tYWdlLw==");
        // https://kaiscans.com/series/im-the-strongest-boss/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vc2VyaWVzL2ltLXRoZS1zdHJvbmdlc3QtYm9zcy8=");
        // https://kaiscans.com/series/brother-am-i-cute/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vc2VyaWVzL2Jyb3RoZXItYW0taS1jdXRlLw==");
        // https://kaiscans.com/series/i-dont-want-the-male-leads-child/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vc2VyaWVzL2ktZG9udC13YW50LXRoZS1tYWxlLWxlYWRzLWNoaWxkLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://kaiscans.com/i-dont-want-the-male-leads-child-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vaS1kb250LXdhbnQtdGhlLW1hbGUtbGVhZHMtY2hpbGQtY2hhcHRlci0xLw==");
        // https://kaiscans.com/im-the-strongest-boss-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vaW0tdGhlLXN0cm9uZ2VzdC1ib3NzLWNoYXB0ZXItMy8=");
        // https://kaiscans.com/raising-my-fiance-with-money-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vcmFpc2luZy1teS1maWFuY2Utd2l0aC1tb25leS1jaGFwdGVyLTQv");
        // https://kaiscans.com/reclusive-mage-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vcmVjbHVzaXZlLW1hZ2UtY2hhcHRlci0zLw==");
        // https://kaiscans.com/i-dont-want-the-male-leads-child-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vaS1kb250LXdhbnQtdGhlLW1hbGUtbGVhZHMtY2hpbGQtY2hhcHRlci0zLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://kaiscans.com/wp-content/uploads/2023/12/11-78.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTEtNzguanBn");
        // https://kaiscans.com/wp-content/uploads/2023/12/08-1032.webp
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDgtMTAzMi53ZWJw");
        // https://kaiscans.com/wp-content/uploads/2023/12/06-94.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDYtOTQuanBn");
        // https://kaiscans.com/wp-content/uploads/2024/01/02-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItMS5qcGc=");
        // https://kaiscans.com/wp-content/uploads/2023/12/16-504.webp
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTYtNTA0LndlYnA=");
    }
}

