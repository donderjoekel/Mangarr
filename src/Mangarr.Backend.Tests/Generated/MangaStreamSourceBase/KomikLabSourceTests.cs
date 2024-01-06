using System.Collections;

namespace Mangarr.Backend.Tests;

public class KomikLabSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "komiklab";

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
        // https://komiklab.com?p=2288
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMjg4fDIyODg=");
        // https://komiklab.com?p=2234
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMjM0fDIyMzQ=");
        // https://komiklab.com?p=2015
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMDE1fDIwMTU=");
        // https://komiklab.com?p=2009
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMDA5fDIwMDk=");
        // https://komiklab.com?p=1962
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0xOTYyfDE5NjI=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://komiklab.com?p=2329
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMzI5fDIzMjk=");
        // https://komiklab.com?p=2355
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMzU1fDIzNTU=");
        // https://komiklab.com?p=2349
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMzQ5fDIzNDk=");
        // https://komiklab.com?p=2258
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMjU4fDIyNTg=");
        // https://komiklab.com?p=2302
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMzAyfDIzMDI=");
    }

    public static IEnumerable ValidImages()
    {
        // https://i1.wp.com/www.toonix.xyz/cdn_mangaraw/isekai-de-cheat-skill-wo-te-ni-shita-ore-wa-genjitsu-sekai-wo-mo-musou-suru-level-up-wa-jinsei-wo-kaeta/chapter-10/25.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMS53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2lzZWthaS1kZS1jaGVhdC1za2lsbC13by10ZS1uaS1zaGl0YS1vcmUtd2EtZ2Vuaml0c3Utc2VrYWktd28tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktd28ta2FldGEvY2hhcHRlci0xMC8yNS5qcGc=");
        // https://i0.wp.com/www.toonix.xyz/cdn_mangaraw/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita/chapter-2-1/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2xhc3QtYm9zcy15YW1ldGVtaXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZW1pdGEvY2hhcHRlci0yLTEvOS5qcGc=");
        // https://i0.wp.com/www.toonix.xyz/cdn_mangaraw/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita/chapter-13.1/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2xhc3QtYm9zcy15YW1ldGVtaXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZW1pdGEvY2hhcHRlci0xMy4xLzkuanBn");
        // https://i2.wp.com/www.toonix.xyz/cdn_mangaraw/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita/chapter-8.2/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2xhc3QtYm9zcy15YW1ldGVtaXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZW1pdGEvY2hhcHRlci04LjIvMDQuanBn");
        // https://i0.wp.com/www.toonix.xyz/cdn_mangaraw/isekai-de-cheat-skill-wo-te-ni-shita-ore-wa-genjitsu-sekai-wo-mo-musou-suru-level-up-wa-jinsei-wo-kaeta/chapter-10/32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2lzZWthaS1kZS1jaGVhdC1za2lsbC13by10ZS1uaS1zaGl0YS1vcmUtd2EtZ2Vuaml0c3Utc2VrYWktd28tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktd28ta2FldGEvY2hhcHRlci0xMC8zMi5qcGc=");
    }
}

