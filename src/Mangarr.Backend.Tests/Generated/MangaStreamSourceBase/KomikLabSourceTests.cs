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
        // https://komiklab.com/manga/last-boss-yamete-mita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikite-mita/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbWFuZ2EvbGFzdC1ib3NzLXlhbWV0ZS1taXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZS1taXRhLw==");
        // https://komiklab.com/manga/isekai-de-cheat-skill-o-te-ni-shita-ore-wa-genjitsu-sekai-o-mo-musou-suru-level-up-wa-jinsei-o-kaeta/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbWFuZ2EvaXNla2FpLWRlLWNoZWF0LXNraWxsLW8tdGUtbmktc2hpdGEtb3JlLXdhLWdlbmppdHN1LXNla2FpLW8tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktby1rYWV0YS8=");
        // https://komiklab.com/manga/dantoudai-no-hanayome-sekai-wo-horobosu-futsutsuka-na-tatsuki-desu-ga/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbWFuZ2EvZGFudG91ZGFpLW5vLWhhbmF5b21lLXNla2FpLXdvLWhvcm9ib3N1LWZ1dHN1dHN1a2EtbmEtdGF0c3VraS1kZXN1LWdhLw==");
        // https://komiklab.com/manga/isekai-nonbiri-sozai-saishu-seikatsu/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbWFuZ2EvaXNla2FpLW5vbmJpcmktc296YWktc2Fpc2h1LXNlaWthdHN1Lw==");
        // https://komiklab.com/manga/the-dreaming-boy-is-a-realist/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbWFuZ2EvdGhlLWRyZWFtaW5nLWJveS1pcy1hLXJlYWxpc3Qv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://komiklab.com/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita-chapter-8-3/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbGFzdC1ib3NzLXlhbWV0ZW1pdGEtc2h1amlua291LW5pLXRhb3NhcmV0YS1mdXJpLXNoaXRlLWppeXV1LW5pLWlraXRlbWl0YS1jaGFwdGVyLTgtMy8=");
        // https://komiklab.com/last-boss-yamete-mita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikite-mita-chapter-12-3/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbGFzdC1ib3NzLXlhbWV0ZS1taXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZS1taXRhLWNoYXB0ZXItMTItMy8=");
        // https://komiklab.com/the-dreaming-boy-is-a-realist-chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vdGhlLWRyZWFtaW5nLWJveS1pcy1hLXJlYWxpc3QtY2hhcHRlci04Lw==");
        // https://komiklab.com/isekai-de-cheat-skill-o-te-ni-shita-ore-wa-genjitsu-sekai-o-mo-musou-suru-level-up-wa-jinsei-o-kaeta-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vaXNla2FpLWRlLWNoZWF0LXNraWxsLW8tdGUtbmktc2hpdGEtb3JlLXdhLWdlbmppdHN1LXNla2FpLW8tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktby1rYWV0YS1jaGFwdGVyLTIwLw==");
        // https://komiklab.com/the-dreaming-boy-is-a-realist-chapter-1-2/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vdGhlLWRyZWFtaW5nLWJveS1pcy1hLXJlYWxpc3QtY2hhcHRlci0xLTIv");
    }

    public static IEnumerable ValidImages()
    {
        // https://i2.wp.com/www.toonix.xyz/cdn_mangaraw/isekai-de-cheat-skill-wo-te-ni-shita-ore-wa-genjitsu-sekai-wo-mo-musou-suru-level-up-wa-jinsei-wo-kaeta/chapter-20/19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2lzZWthaS1kZS1jaGVhdC1za2lsbC13by10ZS1uaS1zaGl0YS1vcmUtd2EtZ2Vuaml0c3Utc2VrYWktd28tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktd28ta2FldGEvY2hhcHRlci0yMC8xOS5qcGc=");
        // https://i2.wp.com/meo3.comick.pictures/2-y8BduU6kIdngp-m.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vbWVvMy5jb21pY2sucGljdHVyZXMvMi15OEJkdVU2a0lkbmdwLW0uanBn");
        // https://i1.wp.com/www.toonix.xyz/cdn_mangaraw/isekai-de-cheat-skill-wo-te-ni-shita-ore-wa-genjitsu-sekai-wo-mo-musou-suru-level-up-wa-jinsei-wo-kaeta/chapter-20/23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMS53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2lzZWthaS1kZS1jaGVhdC1za2lsbC13by10ZS1uaS1zaGl0YS1vcmUtd2EtZ2Vuaml0c3Utc2VrYWktd28tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktd28ta2FldGEvY2hhcHRlci0yMC8yMy5qcGc=");
        // https://i0.wp.com/www.toonix.xyz/cdn_mangaraw/isekai-de-cheat-skill-wo-te-ni-shita-ore-wa-genjitsu-sekai-wo-mo-musou-suru-level-up-wa-jinsei-wo-kaeta/chapter-20/28.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2lzZWthaS1kZS1jaGVhdC1za2lsbC13by10ZS1uaS1zaGl0YS1vcmUtd2EtZ2Vuaml0c3Utc2VrYWktd28tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktd28ta2FldGEvY2hhcHRlci0yMC8yOC5qcGc=");
        // https://i3.wp.com/meo3.comick.pictures/5-Fv5JoaPQCdkpX-m.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vbWVvMy5jb21pY2sucGljdHVyZXMvNS1GdjVKb2FQUUNka3BYLW0uanBn");
    }
}

