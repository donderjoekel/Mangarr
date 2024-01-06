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
        // https://cypherscans.xyz?p=167051
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjcwNTF8MTY3MDUx");
        // https://cypherscans.xyz?p=167241
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjcyNDF8MTY3MjQx");
        // https://cypherscans.xyz?p=167074
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjcwNzR8MTY3MDc0");
        // https://cypherscans.xyz?p=166887
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjY4ODd8MTY2ODg3");
        // https://cypherscans.xyz?p=167266
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXo/cD0xNjcyNjZ8MTY3MjY2");
    }

    public static IEnumerable ValidImages()
    {
        // https://cypherscans.xyz/wp-content/uploads/2024/01/02-179.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDItMTc5LndlYnA=");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/13-19.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTMtMTkud2VicA==");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/04-171.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDQtMTcxLndlYnA=");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/10-54.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTAtNTQud2VicA==");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/12-37.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTItMzcud2VicA==");
    }
}

