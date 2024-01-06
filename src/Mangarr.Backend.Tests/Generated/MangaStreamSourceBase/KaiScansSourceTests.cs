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
        // https://kaiscans.com/raising-my-fiance-with-money-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vcmFpc2luZy1teS1maWFuY2Utd2l0aC1tb25leS1jaGFwdGVyLTMvfGh0dHBzOi8va2Fpc2NhbnMuY29tP3A9NTIyMDd8Mw==");
        // https://kaiscans.com/im-the-strongest-boss-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vaW0tdGhlLXN0cm9uZ2VzdC1ib3NzLWNoYXB0ZXItMi98aHR0cHM6Ly9rYWlzY2Fucy5jb20/cD01MTQyMnwy");
        // https://kaiscans.com/reclusive-mage-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vcmVjbHVzaXZlLW1hZ2UtY2hhcHRlci0zL3xodHRwczovL2thaXNjYW5zLmNvbT9wPTUxOTg1fDM=");
        // https://kaiscans.com/raising-my-fiance-with-money-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vcmFpc2luZy1teS1maWFuY2Utd2l0aC1tb25leS1jaGFwdGVyLTEvfGh0dHBzOi8va2Fpc2NhbnMuY29tP3A9NTIyMDd8MQ==");
        // https://kaiscans.com/raising-my-fiance-with-money-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vcmFpc2luZy1teS1maWFuY2Utd2l0aC1tb25leS1jaGFwdGVyLTQvfGh0dHBzOi8va2Fpc2NhbnMuY29tP3A9NTIyMDd8NA==");
    }

    public static IEnumerable ValidImages()
    {
        // https://kaiscans.com/wp-content/uploads/2024/01/00-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDAtMS5qcGc=");
        // https://kaiscans.com/wp-content/uploads/2024/01/02-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItMS5qcGc=");
        // https://kaiscans.com/wp-content/uploads/2024/01/08-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDgtMS53ZWJw");
        // https://kaiscans.com/wp-content/uploads/2024/01/19-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTktMS5qcGc=");
        // https://kaiscans.com/wp-content/uploads/2024/01/07-1.webp
        yield return new TestCaseData("aHR0cHM6Ly9rYWlzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDctMS53ZWJw");
    }
}

