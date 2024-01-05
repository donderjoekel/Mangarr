using System.Collections;

namespace Mangarr.Backend.Tests;

public class ParagonScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "paragonscans";

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
        // https://paragonscans.com/mangax/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9zdGFydGluZy13aXRoLXRoZS1ob2x5LW1haWRlbi1zeXN0ZW0tYm91bmQv");
        // https://paragonscans.com/mangax/mukuchina-miyashita-san-no-shikiyoku-channel/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9tdWt1Y2hpbmEtbWl5YXNoaXRhLXNhbi1uby1zaGlraXlva3UtY2hhbm5lbC8=");
        // https://paragonscans.com/mangax/emperor-qin-returns-i-am-the-eternal-immortal-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9lbXBlcm9yLXFpbi1yZXR1cm5zLWktYW0tdGhlLWV0ZXJuYWwtaW1tb3J0YWwtZW1wZXJvci8=");
        // https://paragonscans.com/mangax/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzLw==");
        // https://paragonscans.com/mangax/reincarnator-manhwa/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9yZWluY2FybmF0b3ItbWFuaHdhLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://paragonscans.com/mangax/mr-devourer-please-act-like-a-final-boss/chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMjIv");
        // https://paragonscans.com/mangax/reincarnator-manhwa/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9yZWluY2FybmF0b3ItbWFuaHdhL2NoYXB0ZXItMi8=");
        // https://paragonscans.com/mangax/mukuchina-miyashita-san-no-shikiyoku-channel/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9tdWt1Y2hpbmEtbWl5YXNoaXRhLXNhbi1uby1zaGlraXlva3UtY2hhbm5lbC9jaGFwdGVyLTIv");
        // https://paragonscans.com/mangax/mr-devourer-please-act-like-a-final-boss/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItOC8=");
        // https://paragonscans.com/mangax/emperor-qin-returns-i-am-the-eternal-immortal-emperor/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9wYXJhZ29uc2NhbnMuY29tL21hbmdheC9lbXBlcm9yLXFpbi1yZXR1cm5zLWktYW0tdGhlLWV0ZXJuYWwtaW1tb3J0YWwtZW1wZXJvci9jaGFwdGVyLTEv");
    }

    public static IEnumerable ValidImages()
    {
        // http://s5.imgcdnlevel1.company/imgsrv2/r/reincarnator-manhwa/chapter-2/12.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvci9yZWluY2FybmF0b3ItbWFuaHdhL2NoYXB0ZXItMi8xMi5qcGc=");
        // http://s5.imgcdnlevel1.company/imgsrv2/m/mr-devourer-please-act-like-a-final-boss/chapter-8/4.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvbS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItOC80LmpwZw==");
        // http://s5.imgcdnlevel1.company/imgsrv2/r/reincarnator-manhwa/chapter-2/10.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvci9yZWluY2FybmF0b3ItbWFuaHdhL2NoYXB0ZXItMi8xMC5qcGc=");
        // http://s5.imgcdnlevel1.company/imgsrv2/m/mr-devourer-please-act-like-a-final-boss/chapter-8/16.png
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvbS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItOC8xNi5wbmc=");
        // http://s5.imgcdnlevel1.company/imgsrv2/m/mr-devourer-please-act-like-a-final-boss/chapter-22/18.jpg
        yield return new TestCaseData("aHR0cDovL3M1LmltZ2NkbmxldmVsMS5jb21wYW55L2ltZ3NydjIvbS9tci1kZXZvdXJlci1wbGVhc2UtYWN0LWxpa2UtYS1maW5hbC1ib3NzL2NoYXB0ZXItMjIvMTguanBn");
    }
}

