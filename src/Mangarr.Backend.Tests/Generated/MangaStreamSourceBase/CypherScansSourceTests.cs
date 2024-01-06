using System.Collections;

namespace Mangarr.Backend.Tests;

public class CypherScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "cypherscans";

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
        // https://cypherscans.xyz?p=167746
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjc3NDZ8MTY3NzQ2");
        // https://cypherscans.xyz?p=167608
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjc2MDh8MTY3NjA4");
        // https://cypherscans.xyz?p=167184
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjcxODR8MTY3MTg0");
        // https://cypherscans.xyz?p=166833
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjY4MzN8MTY2ODMz");
        // https://cypherscans.xyz?p=166698
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjY2OTh8MTY2Njk4");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://cypherscans.xyz/i-use-my-muscles-to-dominate-the-world-of-cultivating-immortals-chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS11c2UtbXktbXVzY2xlcy10by1kb21pbmF0ZS10aGUtd29ybGQtb2YtY3VsdGl2YXRpbmctaW1tb3J0YWxzLWNoYXB0ZXItMjIvfGh0dHBzOi8vY3lwaGVyc2NhbnMueHl6P3A9MTY3MTg0fDIy");
        // https://cypherscans.xyz/dark-and-light-martial-emperor-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yLWNoYXB0ZXItMi98aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjY2OTh8Mg==");
        // https://cypherscans.xyz/dark-and-light-martial-emperor-chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yLWNoYXB0ZXItOS98aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjY2OTh8OQ==");
        // https://cypherscans.xyz/i-use-my-muscles-to-dominate-the-world-of-cultivating-immortals-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS11c2UtbXktbXVzY2xlcy10by1kb21pbmF0ZS10aGUtd29ybGQtb2YtY3VsdGl2YXRpbmctaW1tb3J0YWxzLWNoYXB0ZXItMjAvfGh0dHBzOi8vY3lwaGVyc2NhbnMueHl6P3A9MTY3MTg0fDIw");
    }

    public static IEnumerable ValidImages()
    {
        // https://cypherscans.xyz/wp-content/uploads/2024/01/10-43.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTAtNDMud2VicA==");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/01-150.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDEtMTUwLndlYnA=");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/02-150.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItMTUwLndlYnA=");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/07-89.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDctODkud2VicA==");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/04-202.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDQtMjAyLndlYnA=");
    }
}

