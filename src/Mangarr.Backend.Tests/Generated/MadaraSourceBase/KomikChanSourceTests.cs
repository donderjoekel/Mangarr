using System.Collections;

namespace Mangarr.Backend.Tests;

public class KomikChanSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "komikchan";

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
        // https://komikchan.com/manga/ashtarte/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL2FzaHRhcnRlLw==");
        // https://komikchan.com/manga/isekai-apocalypse-mynoghra-the-conquest-of-the-world-starts-with-the-civilization-of-ruin/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL2lzZWthaS1hcG9jYWx5cHNlLW15bm9naHJhLXRoZS1jb25xdWVzdC1vZi10aGUtd29ybGQtc3RhcnRzLXdpdGgtdGhlLWNpdmlsaXphdGlvbi1vZi1ydWluLw==");
        // https://komikchan.com/manga/to-be-the-castellan-king/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL3RvLWJlLXRoZS1jYXN0ZWxsYW4ta2luZy8=");
        // https://komikchan.com/manga/kamen-rider-kuuga/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL2thbWVuLXJpZGVyLWt1dWdhLw==");
        // https://komikchan.com/manga/negative-hero-and-demon-kings-general/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL25lZ2F0aXZlLWhlcm8tYW5kLWRlbW9uLWtpbmdzLWdlbmVyYWwv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://komikchan.com/manga/to-be-the-castellan-king/chapter-81/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL3RvLWJlLXRoZS1jYXN0ZWxsYW4ta2luZy9jaGFwdGVyLTgxLw==");
        // https://komikchan.com/manga/isekai-apocalypse-mynoghra-the-conquest-of-the-world-starts-with-the-civilization-of-ruin/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL2lzZWthaS1hcG9jYWx5cHNlLW15bm9naHJhLXRoZS1jb25xdWVzdC1vZi10aGUtd29ybGQtc3RhcnRzLXdpdGgtdGhlLWNpdmlsaXphdGlvbi1vZi1ydWluL2NoYXB0ZXItNS8=");
        // https://komikchan.com/manga/to-be-the-castellan-king/chapter-407/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL3RvLWJlLXRoZS1jYXN0ZWxsYW4ta2luZy9jaGFwdGVyLTQwNy8=");
        // https://komikchan.com/manga/to-be-the-castellan-king/chapter-375/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL3RvLWJlLXRoZS1jYXN0ZWxsYW4ta2luZy9jaGFwdGVyLTM3NS8=");
        // https://komikchan.com/manga/negative-hero-and-demon-kings-general/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2NoYW4uY29tL21hbmdhL25lZ2F0aXZlLWhlcm8tYW5kLWRlbW9uLWtpbmdzLWdlbmVyYWwvY2hhcHRlci0yLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://yuucdn.com/wp-content/uploads/images/t/to-be-the-castellan-king/chapter-375/1-63983a7b90b72.jpg
        yield return new TestCaseData("aHR0cHM6Ly95dXVjZG4uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9pbWFnZXMvdC90by1iZS10aGUtY2FzdGVsbGFuLWtpbmcvY2hhcHRlci0zNzUvMS02Mzk4M2E3YjkwYjcyLmpwZw==");
        // https://cdnkuma.my.id/wp-content/uploads/images/to-be-the-castellan-king/chapter-81/1.png
        yield return new TestCaseData("aHR0cHM6Ly9jZG5rdW1hLm15LmlkL3dwLWNvbnRlbnQvdXBsb2Fkcy9pbWFnZXMvdG8tYmUtdGhlLWNhc3RlbGxhbi1raW5nL2NoYXB0ZXItODEvMS5wbmc=");
        // https://cdnkuma.my.id/wp-content/uploads/images/isekai-apocalypse-mynoghra-the-conquest-of-the-world-starts-with-the-civilization-of-ruin/chapter-5/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG5rdW1hLm15LmlkL3dwLWNvbnRlbnQvdXBsb2Fkcy9pbWFnZXMvaXNla2FpLWFwb2NhbHlwc2UtbXlub2docmEtdGhlLWNvbnF1ZXN0LW9mLXRoZS13b3JsZC1zdGFydHMtd2l0aC10aGUtY2l2aWxpemF0aW9uLW9mLXJ1aW4vY2hhcHRlci01LzEuanBn");
        // https://yuucdn.com/wp-content/uploads/images/n/negative-hero-and-demon-kings-general/chapter-2/1-6332daf8d8b78.png
        yield return new TestCaseData("aHR0cHM6Ly95dXVjZG4uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9pbWFnZXMvbi9uZWdhdGl2ZS1oZXJvLWFuZC1kZW1vbi1raW5ncy1nZW5lcmFsL2NoYXB0ZXItMi8xLTYzMzJkYWY4ZDhiNzgucG5n");
        // https://yuucdn.com/wp-content/uploads/images/t/to-be-the-castellan-king/chapter-407/1-64eddefdd4d82.jpg
        yield return new TestCaseData("aHR0cHM6Ly95dXVjZG4uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9pbWFnZXMvdC90by1iZS10aGUtY2FzdGVsbGFuLWtpbmcvY2hhcHRlci00MDcvMS02NGVkZGVmZGQ0ZDgyLmpwZw==");
    }
}

