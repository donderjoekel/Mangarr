using System.Collections;

namespace Mangarr.Backend.Tests;

public class PMScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "pmscans";

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
        // https://rackusreads.com/manga/a-streamer-in-the-past/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvYS1zdHJlYW1lci1pbi10aGUtcGFzdC8=");
        // https://rackusreads.com/manga/his-name-is-bryan/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlzLW5hbWUtaXMtYnJ5YW4v");
        // https://rackusreads.com/manga/kangtawoo/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2Eva2FuZ3Rhd29vLw==");
        // https://rackusreads.com/manga/zephyr-impact-war/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvemVwaHlyLWltcGFjdC13YXIv");
        // https://rackusreads.com/manga/high-school-lunch-dad/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlnaC1zY2hvb2wtbHVuY2gtZGFkLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://rackusreads.com/manga/his-name-is-bryan/chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlzLW5hbWUtaXMtYnJ5YW4vY2hhcHRlci0xMS8=");
        // https://rackusreads.com/manga/high-school-lunch-dad/chapter-85/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlnaC1zY2hvb2wtbHVuY2gtZGFkL2NoYXB0ZXItODUv");
        // https://rackusreads.com/manga/his-name-is-bryan/chapter-03/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlzLW5hbWUtaXMtYnJ5YW4vY2hhcHRlci0wMy8=");
        // https://rackusreads.com/manga/his-name-is-bryan/chapter-05/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlzLW5hbWUtaXMtYnJ5YW4vY2hhcHRlci0wNS8=");
        // https://rackusreads.com/manga/high-school-lunch-dad/chapter-68-use-me-as-your-shield/
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vbWFuZ2EvaGlnaC1zY2hvb2wtbHVuY2gtZGFkL2NoYXB0ZXItNjgtdXNlLW1lLWFzLXlvdXItc2hpZWxkLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://rackusreads.com/wp-content/uploads/WP-manga/data/manga_647a88e40dd24/29c18acade6ac6cfecbea714c463dee6/HLD-CH85-04.webp
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjQ3YTg4ZTQwZGQyNC8yOWMxOGFjYWRlNmFjNmNmZWNiZWE3MTRjNDYzZGVlNi9ITEQtQ0g4NS0wNC53ZWJw");
        // https://rackusreads.com/wp-content/uploads/WP-manga/data/manga_64ad73a9847ef/40fd279087a56b746873b9970a572657/Z-END-CREDITS.webp
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjRhZDczYTk4NDdlZi80MGZkMjc5MDg3YTU2Yjc0Njg3M2I5OTcwYTU3MjY1Ny9aLUVORC1DUkVESVRTLndlYnA=");
        // https://rackusreads.com/wp-content/uploads/WP-manga/data/manga_647a88e40dd24/29c18acade6ac6cfecbea714c463dee6/HLD-CH85-01.webp
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjQ3YTg4ZTQwZGQyNC8yOWMxOGFjYWRlNmFjNmNmZWNiZWE3MTRjNDYzZGVlNi9ITEQtQ0g4NS0wMS53ZWJw");
        // https://rackusreads.com/wp-content/uploads/WP-manga/data/manga_647a88e40dd24/29c18acade6ac6cfecbea714c463dee6/HLD-CH85-06.webp
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjQ3YTg4ZTQwZGQyNC8yOWMxOGFjYWRlNmFjNmNmZWNiZWE3MTRjNDYzZGVlNi9ITEQtQ0g4NS0wNi53ZWJw");
        // https://rackusreads.com/wp-content/uploads/WP-manga/data/manga_647a88e40dd24/9a806f8a8f621be31a996c83276a8050/HLD-CH68-10.webp
        yield return new TestCaseData("aHR0cHM6Ly9yYWNrdXNyZWFkcy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjQ3YTg4ZTQwZGQyNC85YTgwNmY4YThmNjIxYmUzMWE5OTZjODMyNzZhODA1MC9ITEQtQ0g2OC0xMC53ZWJw");
    }
}

