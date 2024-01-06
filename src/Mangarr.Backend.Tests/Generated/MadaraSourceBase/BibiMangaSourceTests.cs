using System.Collections;

namespace Mangarr.Backend.Tests;

public class BibiMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "bibimanga";

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
        // https://bibimanga.com/manga/regressor-of-the-fallen-family/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlZ3Jlc3Nvci1vZi10aGUtZmFsbGVuLWZhbWlseS8=");
        // https://bibimanga.com/manga/return-of-top-class-master/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JldHVybi1vZi10b3AtY2xhc3MtbWFzdGVyLw==");
        // https://bibimanga.com/manga/utori-the-legacy/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3V0b3JpLXRoZS1sZWdhY3kv");
        // https://bibimanga.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLw==");
        // https://bibimanga.com/manga/aitsu-janakute-ore-ni-oborete%ef%bc%9f%ef%bd%9e-ano-yoru-kara-joushi-no-netsu-ga-kietekurenai/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2FpdHN1LWphbmFrdXRlLW9yZS1uaS1vYm9yZXRlJWVmJWJjJTlmJWVmJWJkJTllLWFuby15b3J1LWthcmEtam91c2hpLW5vLW5ldHN1LWdhLWtpZXRla3VyZW5haS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://bibimanga.com/manga/return-of-top-class-master/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JldHVybi1vZi10b3AtY2xhc3MtbWFzdGVyL2NoYXB0ZXItMS8=");
        // https://bibimanga.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItNS8=");
        // https://bibimanga.com/manga/aitsu-janakute-ore-ni-oborete%ef%bc%9f%ef%bd%9e-ano-yoru-kara-joushi-no-netsu-ga-kietekurenai/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2FpdHN1LWphbmFrdXRlLW9yZS1uaS1vYm9yZXRlJWVmJWJjJTlmJWVmJWJkJTllLWFuby15b3J1LWthcmEtam91c2hpLW5vLW5ldHN1LWdhLWtpZXRla3VyZW5haS9jaGFwdGVyLTMv");
        // https://bibimanga.com/manga/regressor-of-the-fallen-family/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL3JlZ3Jlc3Nvci1vZi10aGUtZmFsbGVuLWZhbWlseS9jaGFwdGVyLTUv");
        // https://bibimanga.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL21hbmdhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoL2NoYXB0ZXItMi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/regressor-of-the-fallen-family-198482/chapter-5/12.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3JlZ3Jlc3Nvci1vZi10aGUtZmFsbGVuLWZhbWlseS0xOTg0ODIvY2hhcHRlci01LzEyLmpwZw==");
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/regressor-of-the-fallen-family-198482/chapter-5/13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL3JlZ3Jlc3Nvci1vZi10aGUtZmFsbGVuLWZhbWlseS0xOTg0ODIvY2hhcHRlci01LzEzLmpwZw==");
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/i-have-a-blade-that-can-cut-heaven-and-earth-198480/chapter-2/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLTE5ODQ4MC9jaGFwdGVyLTIvNC5qcGc=");
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/i-have-a-blade-that-can-cut-heaven-and-earth-198480/chapter-5/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2ktaGF2ZS1hLWJsYWRlLXRoYXQtY2FuLWN1dC1oZWF2ZW4tYW5kLWVhcnRoLTE5ODQ4MC9jaGFwdGVyLTUvOS5qcGc=");
        // https://bibimanga.com/wp-content/uploads/WP-manga/data/aitsu-janakute-ore-ni-oborete-ano-yoru-kara-joushi-no-netsu-ga-kietekurenai-198476/chapter-3/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9iaWJpbWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL2FpdHN1LWphbmFrdXRlLW9yZS1uaS1vYm9yZXRlLWFuby15b3J1LWthcmEtam91c2hpLW5vLW5ldHN1LWdhLWtpZXRla3VyZW5haS0xOTg0NzYvY2hhcHRlci0zLzguanBn");
    }
}

