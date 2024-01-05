using System.Collections;

namespace Mangarr.Backend.Tests;

public class Hentai4FreeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hentai4free";

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
        // https://hentai4free.net/hentai/incha-no-koi/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL2luY2hhLW5vLWtvaS8=");
        // https://hentai4free.net/hentai/utsu-na-hahaoya-ga-musuko-o-suki-sugiru-ken/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL3V0c3UtbmEtaGFoYW95YS1nYS1tdXN1a28tby1zdWtpLXN1Z2lydS1rZW4v");
        // https://hentai4free.net/hentai/hinatsu-to-oshiri-ai-ni-natta-yoru/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL2hpbmF0c3UtdG8tb3NoaXJpLWFpLW5pLW5hdHRhLXlvcnUv");
        // https://hentai4free.net/hentai/nakanaka-ikenai-futanari-musume/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL25ha2FuYWthLWlrZW5haS1mdXRhbmFyaS1tdXN1bWUv");
        // https://hentai4free.net/hentai/tokkuni-otosareteru-ano-musume/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL3Rva2t1bmktb3Rvc2FyZXRlcnUtYW5vLW11c3VtZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hentai4free.net/hentai/incha-no-koi/incha-no-koi-introverted-love/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL2luY2hhLW5vLWtvaS9pbmNoYS1uby1rb2ktaW50cm92ZXJ0ZWQtbG92ZS8=");
        // https://hentai4free.net/hentai/utsu-na-hahaoya-ga-musuko-o-suki-sugiru-ken/a-depressed-mother-loves-her-son-too-much/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL3V0c3UtbmEtaGFoYW95YS1nYS1tdXN1a28tby1zdWtpLXN1Z2lydS1rZW4vYS1kZXByZXNzZWQtbW90aGVyLWxvdmVzLWhlci1zb24tdG9vLW11Y2gv");
        // https://hentai4free.net/hentai/nakanaka-ikenai-futanari-musume/nakanaka-ikenai-futanari-musume/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL25ha2FuYWthLWlrZW5haS1mdXRhbmFyaS1tdXN1bWUvbmFrYW5ha2EtaWtlbmFpLWZ1dGFuYXJpLW11c3VtZS8=");
        // https://hentai4free.net/hentai/tokkuni-otosareteru-ano-musume/tokkuni-otosareteru-ano-musume/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL3Rva2t1bmktb3Rvc2FyZXRlcnUtYW5vLW11c3VtZS90b2trdW5pLW90b3NhcmV0ZXJ1LWFuby1tdXN1bWUv");
        // https://hentai4free.net/hentai/hinatsu-to-oshiri-ai-ni-natta-yoru/hinatsu-to-oshiri-ai-ni-natta-yoru/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvaGVudGFpL2hpbmF0c3UtdG8tb3NoaXJpLWFpLW5pLW5hdHRhLXlvcnUvaGluYXRzdS10by1vc2hpcmktYWktbmktbmF0dGEteW9ydS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://hentai4free.net/wp-content/uploads/WP-manga/data/manga_65384b0935bf8/cf256062e1fa51be58f702ea828cc956/13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjUzODRiMDkzNWJmOC9jZjI1NjA2MmUxZmE1MWJlNThmNzAyZWE4MjhjYzk1Ni8xMy5qcGc=");
        // https://hentai4free.net/wp-content/uploads/WP-manga/data/manga_6538535d49632/e2ab7301034c1b39b05afaf8421c93b2/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjUzODUzNWQ0OTYzMi9lMmFiNzMwMTAzNGMxYjM5YjA1YWZhZjg0MjFjOTNiMi8xMC5qcGc=");
        // https://hentai4free.net/wp-content/uploads/WP-manga/data/manga_6538c258eed86/238fad3c0d5ac49e9e3671a641feb4d7/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjUzOGMyNThlZWQ4Ni8yMzhmYWQzYzBkNWFjNDllOWUzNjcxYTY0MWZlYjRkNy8wNC5qcGc=");
        // https://hentai4free.net/wp-content/uploads/WP-manga/data/manga_65387a1a4c160/8e45b79c2599d8bdd701f06d414c32af/63.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjUzODdhMWE0YzE2MC84ZTQ1Yjc5YzI1OTlkOGJkZDcwMWYwNmQ0MTRjMzJhZi82My5qcGc=");
        // https://hentai4free.net/wp-content/uploads/WP-manga/data/manga_65384b0935bf8/cf256062e1fa51be58f702ea828cc956/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWk0ZnJlZS5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjUzODRiMDkzNWJmOC9jZjI1NjA2MmUxZmE1MWJlNThmNzAyZWE4MjhjYzk1Ni8wNi5qcGc=");
    }
}

