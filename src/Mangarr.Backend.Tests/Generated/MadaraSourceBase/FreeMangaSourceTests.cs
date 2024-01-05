using System.Collections;

namespace Mangarr.Backend.Tests;

public class FreeMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "freemanga";

    public static IEnumerable ValidSearchResults()
    {
        yield return new TestCaseData("i");
        yield return new TestCaseData("o");
        yield return new TestCaseData("u");
    }

    public static IEnumerable ValidChapterLists()
    {
        // https://freemanga.me/manga/the-chronicles-of-the-misfit-quartet-and-their-unrivaled-synergy/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvdGhlLWNocm9uaWNsZXMtb2YtdGhlLW1pc2ZpdC1xdWFydGV0LWFuZC10aGVpci11bnJpdmFsZWQtc3luZXJneS8=");
        // https://freemanga.me/manga/i-the-invincible-villain-master-with-my-apprentices/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvaS10aGUtaW52aW5jaWJsZS12aWxsYWluLW1hc3Rlci13aXRoLW15LWFwcHJlbnRpY2VzLw==");
        // https://freemanga.me/manga/i-dont-need-your-love-but-your-body/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvaS1kb250LW5lZWQteW91ci1sb3ZlLWJ1dC15b3VyLWJvZHkv");
        // https://freemanga.me/manga/kamen-rider-w-fuuto-tantei/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2Eva2FtZW4tcmlkZXItdy1mdXV0by10YW50ZWkv");
        // https://freemanga.me/manga/hello-im-the-gardener/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvaGVsbG8taW0tdGhlLWdhcmRlbmVyLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://freemanga.me/manga/hello-im-the-gardener/chapter-27/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvaGVsbG8taW0tdGhlLWdhcmRlbmVyL2NoYXB0ZXItMjcv");
        // https://freemanga.me/manga/hello-im-the-gardener/chapter-47/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvaGVsbG8taW0tdGhlLWdhcmRlbmVyL2NoYXB0ZXItNDcv");
        // https://freemanga.me/manga/i-dont-need-your-love-but-your-body/chapter-14/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvaS1kb250LW5lZWQteW91ci1sb3ZlLWJ1dC15b3VyLWJvZHkvY2hhcHRlci0xNC8=");
        // https://freemanga.me/manga/the-chronicles-of-the-misfit-quartet-and-their-unrivaled-synergy/chapter-2-1/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2EvdGhlLWNocm9uaWNsZXMtb2YtdGhlLW1pc2ZpdC1xdWFydGV0LWFuZC10aGVpci11bnJpdmFsZWQtc3luZXJneS9jaGFwdGVyLTItMS8=");
        // https://freemanga.me/manga/kamen-rider-w-fuuto-tantei/vol-3-chapter-20-the-closed-k-2-masked-nights/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVlbWFuZ2EubWUvbWFuZ2Eva2FtZW4tcmlkZXItdy1mdXV0by10YW50ZWkvdm9sLTMtY2hhcHRlci0yMC10aGUtY2xvc2VkLWstMi1tYXNrZWQtbmlnaHRzLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://images.freemanga.me/manga3/i-dont-need-your-love-but-your-body/chapter-14/62863_chapter-14_13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuZnJlZW1hbmdhLm1lL21hbmdhMy9pLWRvbnQtbmVlZC15b3VyLWxvdmUtYnV0LXlvdXItYm9keS9jaGFwdGVyLTE0LzYyODYzX2NoYXB0ZXItMTRfMTMuanBn");
        // https://images.freemanga.me/manga3/hello-im-the-gardener/chapter-47/62859_chapter-47_35.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuZnJlZW1hbmdhLm1lL21hbmdhMy9oZWxsby1pbS10aGUtZ2FyZGVuZXIvY2hhcHRlci00Ny82Mjg1OV9jaGFwdGVyLTQ3XzM1LmpwZw==");
        // https://images.freemanga.me/manga3/hello-im-the-gardener/chapter-27/62859_chapter-27_7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuZnJlZW1hbmdhLm1lL21hbmdhMy9oZWxsby1pbS10aGUtZ2FyZGVuZXIvY2hhcHRlci0yNy82Mjg1OV9jaGFwdGVyLTI3XzcuanBn");
        // https://images.freemanga.me/manga3/hello-im-the-gardener/chapter-27/62859_chapter-27_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuZnJlZW1hbmdhLm1lL21hbmdhMy9oZWxsby1pbS10aGUtZ2FyZGVuZXIvY2hhcHRlci0yNy82Mjg1OV9jaGFwdGVyLTI3XzEwLmpwZw==");
        // https://images.freemanga.me/manga3/hello-im-the-gardener/chapter-27/62859_chapter-27_33.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZXMuZnJlZW1hbmdhLm1lL21hbmdhMy9oZWxsby1pbS10aGUtZ2FyZGVuZXIvY2hhcHRlci0yNy82Mjg1OV9jaGFwdGVyLTI3XzMzLmpwZw==");
    }
}

