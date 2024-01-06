using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaxSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwax";

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
        // https://manhwax.org?p=296829
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjgyOXwyOTY4Mjk=");
        // https://manhwax.org?p=296593
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjU5M3wyOTY1OTM=");
        // https://manhwax.org?p=296416
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjQxNnwyOTY0MTY=");
        // https://manhwax.org?p=296345
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjM0NXwyOTYzNDU=");
        // https://manhwax.org?p=296154
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjE1NHwyOTYxNTQ=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwax.org?p=296675
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjY3NXwyOTY2NzU=");
        // https://manhwax.org?p=296738
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjczOHwyOTY3Mzg=");
        // https://manhwax.org?p=296710
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjcxMHwyOTY3MTA=");
        // https://manhwax.org?p=296194
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjE5NHwyOTYxOTQ=");
        // https://manhwax.org?p=296618
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjYxOHwyOTY2MTg=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img12.imgfx01.xyz/uploads/165/115/104-917.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xMTUvMTA0LTkxNy5qcGc=");
        // https://img12.imgfx02.xyz/uploads/165/58/67-924.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzE2NS81OC82Ny05MjQuanBn");
        // https://img12.imgfx01.xyz/uploads/165/150/86-897.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xNTAvODYtODk3LmpwZw==");
        // https://img12.imgfx01.xyz/uploads/165/150/65-897.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xNTAvNjUtODk3LmpwZw==");
        // https://img12.imgfx02.xyz/uploads/165/58/117-929.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzE2NS81OC8xMTctOTI5LmpwZw==");
    }
}

