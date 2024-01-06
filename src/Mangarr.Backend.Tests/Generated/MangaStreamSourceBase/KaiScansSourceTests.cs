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
        // https://kaiscans.com?p=52742
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01Mjc0Mnw1Mjc0Mg==");
        // https://kaiscans.com?p=52207
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MjIwN3w1MjIwNw==");
        // https://kaiscans.com?p=51985
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MTk4NXw1MTk4NQ==");
        // https://kaiscans.com?p=51422
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MTQyMnw1MTQyMg==");
        // https://kaiscans.com?p=51059
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MTA1OXw1MTA1OQ==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://kaiscans.com?p=51558
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MTU1OHw1MTU1OA==");
        // https://kaiscans.com?p=52120
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MjEyMHw1MjEyMA==");
        // https://kaiscans.com?p=52249
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MjI0OXw1MjI0OQ==");
        // https://kaiscans.com?p=52658
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MjY1OHw1MjY1OA==");
        // https://kaiscans.com?p=52753
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01Mjc1M3w1Mjc1Mw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://kaiscans.com/wp-content/uploads/2024/01/06-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDYtMS53ZWJw");
        // https://kaiscans.com/wp-content/uploads/2024/01/09-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDktMS53ZWJw");
        // https://kaiscans.com/wp-content/uploads/2024/01/11-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTEtMS5qcGc=");
        // https://kaiscans.com/wp-content/uploads/2023/12/06-86.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDYtODYuanBn");
        // https://kaiscans.com/wp-content/uploads/2023/12/05-88.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDUtODguanBn");
    }
}

