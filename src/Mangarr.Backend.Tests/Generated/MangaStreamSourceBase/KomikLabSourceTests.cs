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
        // https://komiklab.com/the-dreaming-boy-is-a-realist-chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vdGhlLWRyZWFtaW5nLWJveS1pcy1hLXJlYWxpc3QtY2hhcHRlci0xMi98aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0xOTYyfDEy");
        // https://komiklab.com/last-boss-yamete-mita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikite-mita-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbGFzdC1ib3NzLXlhbWV0ZS1taXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZS1taXRhLWNoYXB0ZXItMS98aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMjg4fDEuMQ==");
        // https://komiklab.com/the-dreaming-boy-is-a-realist-chapter-5-1/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vdGhlLWRyZWFtaW5nLWJveS1pcy1hLXJlYWxpc3QtY2hhcHRlci01LTEvfGh0dHBzOi8va29taWtsYWIuY29tP3A9MTk2Mnw1LjE=");
        // https://komiklab.com/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita-chapter-2-2/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vbGFzdC1ib3NzLXlhbWV0ZW1pdGEtc2h1amlua291LW5pLXRhb3NhcmV0YS1mdXJpLXNoaXRlLWppeXV1LW5pLWlraXRlbWl0YS1jaGFwdGVyLTItMi98aHR0cHM6Ly9rb21pa2xhYi5jb20/cD0yMjg4fDIuMg==");
        // https://komiklab.com/isekai-de-cheat-skill-o-te-ni-shita-ore-wa-genjitsu-sekai-o-mo-musou-suru-level-up-wa-jinsei-o-kaeta-chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9rb21pa2xhYi5jb20vaXNla2FpLWRlLWNoZWF0LXNraWxsLW8tdGUtbmktc2hpdGEtb3JlLXdhLWdlbmppdHN1LXNla2FpLW8tbW8tbXVzb3Utc3VydS1sZXZlbC11cC13YS1qaW5zZWktby1rYWV0YS1jaGFwdGVyLTIyL3xodHRwczovL2tvbWlrbGFiLmNvbT9wPTIyMzR8MjI=");
    }

    public static IEnumerable ValidImages()
    {
        // https://i1.wp.com/www.toonix.xyz/cdn_mangaraw/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita/chapter-2-2/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMS53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2xhc3QtYm9zcy15YW1ldGVtaXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZW1pdGEvY2hhcHRlci0yLTIvNC5qcGc=");
        // https://i1.wp.com/www.toonix.xyz/cdn_mangaraw/i-got-a-cheat-ability-in-a-different/chapter-22/1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMS53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2ktZ290LWEtY2hlYXQtYWJpbGl0eS1pbi1hLWRpZmZlcmVudC9jaGFwdGVyLTIyLzEuanBn");
        // https://i0.wp.com/www.toonix.xyz/cdn_mangaraw/last-boss-yametemita-shujinkou-ni-taosareta-furi-shite-jiyuu-ni-ikitemita/chapter-2-2/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd3d3LnRvb25peC54eXovY2RuX21hbmdhcmF3L2xhc3QtYm9zcy15YW1ldGVtaXRhLXNodWppbmtvdS1uaS10YW9zYXJldGEtZnVyaS1zaGl0ZS1qaXl1dS1uaS1pa2l0ZW1pdGEvY2hhcHRlci0yLTIvOS5qcGc=");
    }
}

