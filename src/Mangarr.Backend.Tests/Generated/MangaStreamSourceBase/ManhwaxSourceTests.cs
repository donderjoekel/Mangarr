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
        // https://manhwax.org/manga/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9tYW5nYS9ub3QtYXQtd29yay8=");
        // https://manhwax.org/manga/you-came-during-the-massage-earlier-didnt-you/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9tYW5nYS95b3UtY2FtZS1kdXJpbmctdGhlLW1hc3NhZ2UtZWFybGllci1kaWRudC15b3Uv");
        // https://manhwax.org/manga/our-exchange/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9tYW5nYS9vdXItZXhjaGFuZ2Uv");
        // https://manhwax.org/manga/please-kill-my-husband/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9tYW5nYS9wbGVhc2Uta2lsbC1teS1odXNiYW5kLw==");
        // https://manhwax.org/manga/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9tYW5nYS9tYWtpbmctZnJpZW5kcy13aXRoLXN0cmVhbWVycy1ieS1oYWNraW5nLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwax.org/please-kill-my-husband-chapter-12-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9wbGVhc2Uta2lsbC1teS1odXNiYW5kLWNoYXB0ZXItMTItZW5nbGlzaC8=");
        // https://manhwax.org/our-exchange-chapter-156-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci0xNTYtZW5nbGlzaC8=");
        // https://manhwax.org/our-exchange-chapter-109-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci0xMDktZW5nbGlzaC8=");
        // https://manhwax.org/our-exchange-chapter-19-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9vdXItZXhjaGFuZ2UtY2hhcHRlci0xOS1lbmdsaXNoLw==");
        // https://manhwax.org/please-kill-my-husband-chapter-68-english/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F4Lm9yZy9wbGVhc2Uta2lsbC1teS1odXNiYW5kLWNoYXB0ZXItNjgtZW5nbGlzaC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img12.imgfx01.xyz/uploads/165/156/79-718.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xNTYvNzktNzE4LmpwZw==");
        // https://img12.imgfx02.xyz/uploads/165/19/56-202.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzE2NS8xOS81Ni0yMDIuanBn");
        // https://img12.imgfx02.xyz/uploads/3767/12/26-2cfbb.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzM3NjcvMTIvMjYtMmNmYmIuanBn");
        // https://img12.imgfx01.xyz/uploads/165/156/75-718.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xNTYvNzUtNzE4LmpwZw==");
        // https://img12.imgfx01.xyz/uploads/165/109/45-182.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzE2NS8xMDkvNDUtMTgyLmpwZw==");
    }
}

