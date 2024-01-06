using System.Collections;

namespace Mangarr.Backend.Tests;

public class AnimatedGlitchedScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "anigliscans";

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
        // https://anigliscans.xyz?p=47169
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NzE2OXw0NzE2OQ==");
        // https://anigliscans.xyz?p=46620
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjYyMHw0NjYyMA==");
        // https://anigliscans.xyz?p=46028
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjAyOHw0NjAyOA==");
        // https://anigliscans.xyz?p=45570
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NTU3MHw0NTU3MA==");
        // https://anigliscans.xyz?p=43278
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00MzI3OHw0MzI3OA==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://anigliscans.xyz?p=46642
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjY0Mnw0NjY0Mg==");
        // https://anigliscans.xyz?p=43280
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00MzI4MHw0MzI4MA==");
        // https://anigliscans.xyz?p=46254
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjI1NHw0NjI1NA==");
        // https://anigliscans.xyz?p=46289
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NjI4OXw0NjI4OQ==");
        // https://anigliscans.xyz?p=45572
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXo/cD00NTU3Mnw0NTU3Mg==");
    }

    public static IEnumerable ValidImages()
    {
        // https://anigliscans.xyz/wp-content/uploads/2023/11/01-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTEvMDEtMS5qcGc=");
        // https://anigliscans.xyz/wp-content/uploads/2023/11/04-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTEvMDQtMS5qcGc=");
        // https://anigliscans.xyz/wp-content/uploads/2023/11/17.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTEvMTcuanBn");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/11-10.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTEtMTAuanBlZw==");
        // https://anigliscans.xyz/wp-content/uploads/2023/12/02-12.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9hbmlnbGlzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDItMTIuanBlZw==");
    }
}

