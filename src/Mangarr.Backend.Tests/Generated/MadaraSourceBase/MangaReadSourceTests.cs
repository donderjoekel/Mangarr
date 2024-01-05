using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaReadSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaread";

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
        // https://mangaread.co/manga/yama-no-susume/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EveWFtYS1uby1zdXN1bWUv");
        // https://mangaread.co/manga/komori-san-wa-kotowarenai/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2Eva29tb3JpLXNhbi13YS1rb3Rvd2FyZW5haS8=");
        // https://mangaread.co/manga/tensei-shite-yandere-kouryaku-yaishou-chara-to-shujuu-kankei-ni-natta-kekka/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EvdGVuc2VpLXNoaXRlLXlhbmRlcmUta291cnlha3UteWFpc2hvdS1jaGFyYS10by1zaHVqdXUta2Fua2VpLW5pLW5hdHRhLWtla2thLw==");
        // https://mangaread.co/manga/tensei-oujo-to-tensai-reijou-no-mahou-kakumei/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EvdGVuc2VpLW91am8tdG8tdGVuc2FpLXJlaWpvdS1uby1tYWhvdS1rYWt1bWVpLw==");
        // https://mangaread.co/manga/tenkou-saki-no-seiso-karen-na-bishoujo-ga-mukashi-danshi-to-omotte-issho-ni-asonda-osananajimi-datta-ken/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EvdGVua291LXNha2ktbm8tc2Vpc28ta2FyZW4tbmEtYmlzaG91am8tZ2EtbXVrYXNoaS1kYW5zaGktdG8tb21vdHRlLWlzc2hvLW5pLWFzb25kYS1vc2FuYW5hamltaS1kYXR0YS1rZW4v");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaread.co/manga/tensei-oujo-to-tensai-reijou-no-mahou-kakumei/ch-002/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EvdGVuc2VpLW91am8tdG8tdGVuc2FpLXJlaWpvdS1uby1tYWhvdS1rYWt1bWVpL2NoLTAwMi8=");
        // https://mangaread.co/manga/komori-san-wa-kotowarenai/ch-005/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2Eva29tb3JpLXNhbi13YS1rb3Rvd2FyZW5haS9jaC0wMDUv");
        // https://mangaread.co/manga/komori-san-wa-kotowarenai/ch-002/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2Eva29tb3JpLXNhbi13YS1rb3Rvd2FyZW5haS9jaC0wMDIv");
        // https://mangaread.co/manga/tensei-shite-yandere-kouryaku-yaishou-chara-to-shujuu-kankei-ni-natta-kekka/ch-007/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EvdGVuc2VpLXNoaXRlLXlhbmRlcmUta291cnlha3UteWFpc2hvdS1jaGFyYS10by1zaHVqdXUta2Fua2VpLW5pLW5hdHRhLWtla2thL2NoLTAwNy8=");
        // https://mangaread.co/manga/tensei-shite-yandere-kouryaku-yaishou-chara-to-shujuu-kankei-ni-natta-kekka/ch-006/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJlYWQuY28vbWFuZ2EvdGVuc2VpLXNoaXRlLXlhbmRlcmUta291cnlha3UteWFpc2hvdS1jaGFyYS10by1zaHVqdXUta2Fua2VpLW5pLW5hdHRhLWtla2thL2NoLTAwNi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.mangaread.co/manga_658c5d52525d3/ch-007/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FyZWFkLmNvL21hbmdhXzY1OGM1ZDUyNTI1ZDMvY2gtMDA3LzAwMS5qcGc=");
        // https://cdn.mangaread.co/manga_659472ee0d7e2/ch-005/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FyZWFkLmNvL21hbmdhXzY1OTQ3MmVlMGQ3ZTIvY2gtMDA1LzAwMS5qcGc=");
        // https://cdn.mangaread.co/manga_659472ee0d7e2/ch-002/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FyZWFkLmNvL21hbmdhXzY1OTQ3MmVlMGQ3ZTIvY2gtMDAyLzAwMS5qcGc=");
        // https://cdn.mangaread.co/manga_658b9613b909c/ch-002/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FyZWFkLmNvL21hbmdhXzY1OGI5NjEzYjkwOWMvY2gtMDAyLzAwMS5qcGc=");
        // https://cdn.mangaread.co/manga_658c5d52525d3/ch-006/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2FyZWFkLmNvL21hbmdhXzY1OGM1ZDUyNTI1ZDMvY2gtMDA2LzAwMS5qcGc=");
    }
}

