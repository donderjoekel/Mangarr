using System.Collections;

namespace Mangarr.Backend.Tests;

public class MurimScanSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "murimscan";

    public static IEnumerable ValidSearchResults()
    {
        yield return new TestCaseData("i");
        yield return new TestCaseData("o");
        yield return new TestCaseData("u");
    }

    public static IEnumerable ValidChapterLists()
    {
        // https://murimscan.run/manga/old-newbie-kim-chunshik/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL29sZC1uZXdiaWUta2ltLWNodW5zaGlrLw==");
        // https://murimscan.run/manga/the-bottom-hunter-is-the-strongest-in-modern-times-with-his-return-skill/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL3RoZS1ib3R0b20taHVudGVyLWlzLXRoZS1zdHJvbmdlc3QtaW4tbW9kZXJuLXRpbWVzLXdpdGgtaGlzLXJldHVybi1za2lsbC8=");
        // https://murimscan.run/manga/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL3N0YXJ0aW5nLXdpdGgtdGhlLWhvbHktbWFpZGVuLXN5c3RlbS1ib3VuZC8=");
        // https://murimscan.run/manga/mukuchina-miyashita-san-no-shikiyoku-channel/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL211a3VjaGluYS1taXlhc2hpdGEtc2FuLW5vLXNoaWtpeW9rdS1jaGFubmVsLw==");
        // https://murimscan.run/manga/my-system-is-very-serious/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL215LXN5c3RlbS1pcy12ZXJ5LXNlcmlvdXMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://murimscan.run/manga/old-newbie-kim-chunshik/chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL29sZC1uZXdiaWUta2ltLWNodW5zaGlrL2NoYXB0ZXItOS8=");
        // https://murimscan.run/manga/old-newbie-kim-chunshik/chapter-27/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL29sZC1uZXdiaWUta2ltLWNodW5zaGlrL2NoYXB0ZXItMjcv");
        // https://murimscan.run/manga/old-newbie-kim-chunshik/chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL29sZC1uZXdiaWUta2ltLWNodW5zaGlrL2NoYXB0ZXItMjQv");
        // https://murimscan.run/manga/old-newbie-kim-chunshik/chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL29sZC1uZXdiaWUta2ltLWNodW5zaGlrL2NoYXB0ZXItMTYv");
        // https://murimscan.run/manga/old-newbie-kim-chunshik/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9tdXJpbXNjYW4ucnVuL21hbmdhL29sZC1uZXdiaWUta2ltLWNodW5zaGlrL2NoYXB0ZXItMTkv");
    }

    public static IEnumerable ValidImages()
    {
        // http://s5.imgcdnlevel1.company/imgsrv2/o/old-newbie-kim-chunshik/chapter-16/13.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvby9vbGQtbmV3YmllLWtpbS1jaHVuc2hpay9jaGFwdGVyLTE2LzEzLmpwZw==");
        // http://s5.imgcdnlevel1.company/imgsrv2/o/old-newbie-kim-chunshik/chapter-24/7.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvby9vbGQtbmV3YmllLWtpbS1jaHVuc2hpay9jaGFwdGVyLTI0LzcuanBn");
        // http://s5.imgcdnlevel1.company/imgsrv2/o/old-newbie-kim-chunshik/chapter-24/8.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvby9vbGQtbmV3YmllLWtpbS1jaHVuc2hpay9jaGFwdGVyLTI0LzguanBn");
        // http://s5.imgcdnlevel1.company/imgsrv2/o/old-newbie-kim-chunshik/chapter-27/6.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvby9vbGQtbmV3YmllLWtpbS1jaHVuc2hpay9jaGFwdGVyLTI3LzYuanBn");
        // http://s5.imgcdnlevel1.company/imgsrv2/o/old-newbie-kim-chunshik/chapter-9/14.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvby9vbGQtbmV3YmllLWtpbS1jaHVuc2hpay9jaGFwdGVyLTkvMTQuanBn");
    }
}

