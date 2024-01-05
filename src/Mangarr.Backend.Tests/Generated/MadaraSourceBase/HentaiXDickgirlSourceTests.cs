using System.Collections;

namespace Mangarr.Backend.Tests;

public class HentaiXDickgirlSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hentaixdickgirl";

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
        // https://hentaixdickgirl.com/manga/kara-north-chloe/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2thcmEtbm9ydGgtY2hsb2Uv");
        // https://hentaixdickgirl.com/manga/gokubuto-kuro-inubou-fate-grand-order/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2dva3VidXRvLWt1cm8taW51Ym91LWZhdGUtZ3JhbmQtb3JkZXIv");
        // https://hentaixdickgirl.com/manga/inran-maso-josouko-ikuko-chan-no-mousou-sm-nikki/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2lucmFuLW1hc28tam9zb3Vrby1pa3Vrby1jaGFuLW5vLW1vdXNvdS1zbS1uaWtraS8=");
        // https://hentaixdickgirl.com/manga/futanari-futago-miko-tamahou-chan-to-tamaran-chan/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2Z1dGFuYXJpLWZ1dGFnby1taWtvLXRhbWFob3UtY2hhbi10by10YW1hcmFuLWNoYW4v");
        // https://hentaixdickgirl.com/manga/heaven-vii-final-fantasy-vii/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2hlYXZlbi12aWktZmluYWwtZmFudGFzeS12aWkv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hentaixdickgirl.com/manga/futanari-futago-miko-tamahou-chan-to-tamaran-chan/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2Z1dGFuYXJpLWZ1dGFnby1taWtvLXRhbWFob3UtY2hhbi10by10YW1hcmFuLWNoYW4vb25lc2hvdC8=");
        // https://hentaixdickgirl.com/manga/inran-maso-josouko-ikuko-chan-no-mousou-sm-nikki/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2lucmFuLW1hc28tam9zb3Vrby1pa3Vrby1jaGFuLW5vLW1vdXNvdS1zbS1uaWtraS9vbmVzaG90Lw==");
        // https://hentaixdickgirl.com/manga/gokubuto-kuro-inubou-fate-grand-order/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2dva3VidXRvLWt1cm8taW51Ym91LWZhdGUtZ3JhbmQtb3JkZXIvb25lc2hvdC8=");
        // https://hentaixdickgirl.com/manga/kara-north-chloe/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2thcmEtbm9ydGgtY2hsb2Uvb25lc2hvdC8=");
        // https://hentaixdickgirl.com/manga/heaven-vii-final-fantasy-vii/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL21hbmdhL2hlYXZlbi12aWktZmluYWwtZmFudGFzeS12aWkvb25lc2hvdC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_65945b4c2e133/5171df78f3770fee24a977ddb6b957c5/PG_01_1_Kara_North_Chloe_1.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTQ1YjRjMmUxMzMvNTE3MWRmNzhmMzc3MGZlZTI0YTk3N2RkYjZiOTU3YzUvUEdfMDFfMV9LYXJhX05vcnRoX0NobG9lXzEud2VicA==");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_6594564609115/7b4131fe425ab14c517b5e47e27e451f/PG_027.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTQ1NjQ2MDkxMTUvN2I0MTMxZmU0MjVhYjE0YzUxN2I1ZTQ3ZTI3ZTQ1MWYvUEdfMDI3LndlYnA=");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_659453925b8c9/ad0e28cdcc75f0a28845f43129e1fd0b/PG_09_feb528a6_c4db_4531_bee4_2c86ea2ad502.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTQ1MzkyNWI4YzkvYWQwZTI4Y2RjYzc1ZjBhMjg4NDVmNDMxMjllMWZkMGIvUEdfMDlfZmViNTI4YTZfYzRkYl80NTMxX2JlZTRfMmM4NmVhMmFkNTAyLndlYnA=");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_6594564609115/7b4131fe425ab14c517b5e47e27e451f/PG_031.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTQ1NjQ2MDkxMTUvN2I0MTMxZmU0MjVhYjE0YzUxN2I1ZTQ3ZTI3ZTQ1MWYvUEdfMDMxLndlYnA=");
        // https://hentaixdickgirl.com/wp-content/uploads/WP-manga/data/manga_65945b4c2e133/5171df78f3770fee24a977ddb6b957c5/PG_07_1_Kara_North_Chloe_7.webp
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWl4ZGlja2dpcmwuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTQ1YjRjMmUxMzMvNTE3MWRmNzhmMzc3MGZlZTI0YTk3N2RkYjZiOTU3YzUvUEdfMDdfMV9LYXJhX05vcnRoX0NobG9lXzcud2VicA==");
    }
}

