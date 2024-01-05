using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaBeeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangabee";

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
        // https://mangabee.net/manga/the-one-who-gave-me-love-was-the-duke-of-death/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvdGhlLW9uZS13aG8tZ2F2ZS1tZS1sb3ZlLXdhcy10aGUtZHVrZS1vZi1kZWF0aC8=");
        // https://mangabee.net/manga/haraguro-onzoushi-wa-tsuma-wo-asera-shite-nakasetai-keiyaku-kekkon-wa-amai-wana/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvaGFyYWd1cm8tb256b3VzaGktd2EtdHN1bWEtd28tYXNlcmEtc2hpdGUtbmFrYXNldGFpLWtlaXlha3Uta2Vra29uLXdhLWFtYWktd2FuYS8=");
        // https://mangabee.net/manga/the-board-king/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvdGhlLWJvYXJkLWtpbmcv");
        // https://mangabee.net/manga/don-t-think-that-i-ll-always-be-a-cute-girl/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvZG9uLXQtdGhpbmstdGhhdC1pLWxsLWFsd2F5cy1iZS1hLWN1dGUtZ2lybC8=");
        // https://mangabee.net/manga/dead-but-not-gone/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvZGVhZC1idXQtbm90LWdvbmUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangabee.net/manga/the-one-who-gave-me-love-was-the-duke-of-death/chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvdGhlLW9uZS13aG8tZ2F2ZS1tZS1sb3ZlLXdhcy10aGUtZHVrZS1vZi1kZWF0aC9jaGFwdGVyLTEzLw==");
        // https://mangabee.net/manga/the-one-who-gave-me-love-was-the-duke-of-death/chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvdGhlLW9uZS13aG8tZ2F2ZS1tZS1sb3ZlLXdhcy10aGUtZHVrZS1vZi1kZWF0aC9jaGFwdGVyLTIyLw==");
        // https://mangabee.net/manga/dead-but-not-gone/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvZGVhZC1idXQtbm90LWdvbmUvY2hhcHRlci00Lw==");
        // https://mangabee.net/manga/don-t-think-that-i-ll-always-be-a-cute-girl/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvZG9uLXQtdGhpbmstdGhhdC1pLWxsLWFsd2F5cy1iZS1hLWN1dGUtZ2lybC9jaGFwdGVyLTIv");
        // https://mangabee.net/manga/don-t-think-that-i-ll-always-be-a-cute-girl/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJlZS5uZXQvbWFuZ2EvZG9uLXQtdGhpbmstdGhhdC1pLWxsLWFsd2F5cy1iZS1hLWN1dGUtZ2lybC9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn2.mangagg.com/manga_5de89937c146d16084648eea9295aa35/chapter_21/chap_21_43.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzVkZTg5OTM3YzE0NmQxNjA4NDY0OGVlYTkyOTVhYTM1L2NoYXB0ZXJfMjEvY2hhcF8yMV80My5qcGc=");
        // https://cdn2.mangagg.com/manga_5de89937c146d16084648eea9295aa35/chapter_12/chap_12_21.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzVkZTg5OTM3YzE0NmQxNjA4NDY0OGVlYTkyOTVhYTM1L2NoYXB0ZXJfMTIvY2hhcF8xMl8yMS5qcGc=");
        // https://cdn2.mangagg.com/manga_2ee7d49cbf53f1079bfd51cce6a1c06f/chapter_3/chap_3_69.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzJlZTdkNDljYmY1M2YxMDc5YmZkNTFjY2U2YTFjMDZmL2NoYXB0ZXJfMy9jaGFwXzNfNjkuanBn");
        // https://cdn2.mangagg.com/manga_5de89937c146d16084648eea9295aa35/chapter_12/chap_12_20.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzVkZTg5OTM3YzE0NmQxNjA4NDY0OGVlYTkyOTVhYTM1L2NoYXB0ZXJfMTIvY2hhcF8xMl8yMC5qcGc=");
        // https://cdn2.mangagg.com/manga_5de89937c146d16084648eea9295aa35/chapter_21/chap_21_33.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4yLm1hbmdhZ2cuY29tL21hbmdhXzVkZTg5OTM3YzE0NmQxNjA4NDY0OGVlYTkyOTVhYTM1L2NoYXB0ZXJfMjEvY2hhcF8yMV8zMy5qcGc=");
    }
}

