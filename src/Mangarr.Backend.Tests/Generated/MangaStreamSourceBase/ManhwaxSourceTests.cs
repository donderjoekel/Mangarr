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
        // https://manhwax.org/you-came-during-the-massage-earlier-didnt-you-chapter-19-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3UtY2hhcHRlci0xOS1lbmdsaXNoL3xodHRwczovL21hbmh3YXgub3JnP3A9Mjk2NDE2fDE5");
        // https://manhwax.org/our-exchange-chapter-87-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci04Ny1lbmdsaXNoL3xodHRwczovL21hbmh3YXgub3JnP3A9Mjk2MzQ1fDg3");
        // https://manhwax.org/our-exchange-chapter-111-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci0xMTEtZW5nbGlzaC98aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjM0NXwxMTE=");
        // https://manhwax.org/our-exchange-chapter-131-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci0xMzEtZW5nbGlzaC98aHR0cHM6Ly9tYW5od2F4Lm9yZz9wPTI5NjM0NXwxMzE=");
        // https://manhwax.org/our-exchange-chapter-47-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci00Ny1lbmdsaXNoL3xodHRwczovL21hbmh3YXgub3JnP3A9Mjk2MzQ1fDQ3");
    }

    public static IEnumerable ValidImages()
    {
        // https://img12.imgfx01.xyz/uploads/165/131/78-014.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xMzEvNzgtMDE0LmpwZw==");
        // https://img12.imgfx02.xyz/uploads/165/111/98-124.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzE2NS8xMTEvOTgtMTI0LmpwZw==");
        // https://img12.imgfx02.xyz/uploads/165/47/102-051.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzE2NS80Ny8xMDItMDUxLmpwZw==");
        // https://img12.imgfx01.xyz/uploads/165/87/25-863.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS84Ny8yNS04NjMuanBn");
        // https://img12.imgfx01.xyz/uploads/165/131/109-014.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xMzEvMTA5LTAxNC5qcGc=");
    }
}

