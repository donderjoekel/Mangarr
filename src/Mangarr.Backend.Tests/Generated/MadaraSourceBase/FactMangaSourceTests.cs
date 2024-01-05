using System.Collections;

namespace Mangarr.Backend.Tests;

public class FactMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "factmanga";

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
        // https://factmanga.com/manga/shuufuku-sukiru-ga-bannou-chiito-ka-shitanode-buki-ya-demo-hirakou-ka-to-omoimasu/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL3NodXVmdWt1LXN1a2lydS1nYS1iYW5ub3UtY2hpaXRvLWthLXNoaXRhbm9kZS1idWtpLXlhLWRlbW8taGlyYWtvdS1rYS10by1vbW9pbWFzdS8=");
        // https://factmanga.com/manga/unique-skill-tame-encyclopedia/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL3VuaXF1ZS1za2lsbC10YW1lLWVuY3ljbG9wZWRpYS8=");
        // https://factmanga.com/manga/the-strongest-solo-life-in-another-world-of-a-point-gifter-experience-value-distributor/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL3RoZS1zdHJvbmdlc3Qtc29sby1saWZlLWluLWFub3RoZXItd29ybGQtb2YtYS1wb2ludC1naWZ0ZXItZXhwZXJpZW5jZS12YWx1ZS1kaXN0cmlidXRvci8=");
        // https://factmanga.com/manga/i-became-the-youngest-prince-in-the-novel/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL2ktYmVjYW1lLXRoZS15b3VuZ2VzdC1wcmluY2UtaW4tdGhlLW5vdmVsLw==");
        // https://factmanga.com/manga/another-world-survival-of-trading-company-man/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL2Fub3RoZXItd29ybGQtc3Vydml2YWwtb2YtdHJhZGluZy1jb21wYW55LW1hbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://factmanga.com/manga/another-world-survival-of-trading-company-man/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL2Fub3RoZXItd29ybGQtc3Vydml2YWwtb2YtdHJhZGluZy1jb21wYW55LW1hbi9jaGFwdGVyLTE5Lw==");
        // https://factmanga.com/manga/i-became-the-youngest-prince-in-the-novel/chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL2ktYmVjYW1lLXRoZS15b3VuZ2VzdC1wcmluY2UtaW4tdGhlLW5vdmVsL2NoYXB0ZXItMTEv");
        // https://factmanga.com/manga/shuufuku-sukiru-ga-bannou-chiito-ka-shitanode-buki-ya-demo-hirakou-ka-to-omoimasu/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL3NodXVmdWt1LXN1a2lydS1nYS1iYW5ub3UtY2hpaXRvLWthLXNoaXRhbm9kZS1idWtpLXlhLWRlbW8taGlyYWtvdS1rYS10by1vbW9pbWFzdS9jaGFwdGVyLTgv");
        // https://factmanga.com/manga/another-world-survival-of-trading-company-man/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL2Fub3RoZXItd29ybGQtc3Vydml2YWwtb2YtdHJhZGluZy1jb21wYW55LW1hbi9jaGFwdGVyLTIxLw==");
        // https://factmanga.com/manga/another-world-survival-of-trading-company-man/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL21hbmdhL2Fub3RoZXItd29ybGQtc3Vydml2YWwtb2YtdHJhZGluZy1jb21wYW55LW1hbi9jaGFwdGVyLTkv");
    }

    public static IEnumerable ValidImages()
    {
        // https://factmanga.com/wp-content/uploads/WP-manga/data/manga_6597037fb5739/f7c80467c0fd702b576c8502ea767232/012.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTcwMzdmYjU3MzkvZjdjODA0NjdjMGZkNzAyYjU3NmM4NTAyZWE3NjcyMzIvMDEyLmpwZw==");
        // https://factmanga.com/wp-content/uploads/WP-manga/data/manga_6597037fb5739/f7c80467c0fd702b576c8502ea767232/013.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTcwMzdmYjU3MzkvZjdjODA0NjdjMGZkNzAyYjU3NmM4NTAyZWE3NjcyMzIvMDEzLmpwZw==");
        // https://factmanga.com/wp-content/uploads/WP-manga/data/manga_6597037fb5739/f7c80467c0fd702b576c8502ea767232/009.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTcwMzdmYjU3MzkvZjdjODA0NjdjMGZkNzAyYjU3NmM4NTAyZWE3NjcyMzIvMDA5LmpwZw==");
        // https://factmanga.com/wp-content/uploads/WP-manga/data/manga_65808d9b9870c/4fa7dd7a1db2340a3b10306070d0ef35/026.png
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1ODA4ZDliOTg3MGMvNGZhN2RkN2ExZGIyMzQwYTNiMTAzMDYwNzBkMGVmMzUvMDI2LnBuZw==");
        // https://factmanga.com/wp-content/uploads/WP-manga/data/manga_65808d9b9870c/4fa7dd7a1db2340a3b10306070d0ef35/017.png
        yield return new TestCaseData("aHR0cHM6Ly9mYWN0bWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1ODA4ZDliOTg3MGMvNGZhN2RkN2ExZGIyMzQwYTNiMTAzMDYwNzBkMGVmMzUvMDE3LnBuZw==");
    }
}

