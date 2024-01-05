using System.Collections;

namespace Mangarr.Backend.Tests;

public class Hentai3zSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hentai3z";

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
        // https://hentai3z.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol-2000/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sLTIwMDAv");
        // https://hentai3z.xyz/manga/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvbWFraW5nLWZyaWVuZHMtd2l0aC1zdHJlYW1lcnMtYnktaGFja2luZy8=");
        // https://hentai3z.xyz/manga/training-an-evil-young-lady/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdHJhaW5pbmctYW4tZXZpbC15b3VuZy1sYWR5Lw==");
        // https://hentai3z.xyz/manga/the-massage-club-2000/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLW1hc3NhZ2UtY2x1Yi0yMDAwLw==");
        // https://hentai3z.xyz/manga/unlock-her-heart-2000/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdW5sb2NrLWhlci1oZWFydC0yMDAwLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hentai3z.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol-2000/chapter-24/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sLTIwMDAvY2hhcHRlci0yNC8=");
        // https://hentai3z.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol-2000/chapter-55/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sLTIwMDAvY2hhcHRlci01NS8=");
        // https://hentai3z.xyz/manga/the-massage-club-2000/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLW1hc3NhZ2UtY2x1Yi0yMDAwL2NoYXB0ZXItNi8=");
        // https://hentai3z.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol-2000/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sLTIwMDAvY2hhcHRlci0xOC8=");
        // https://hentai3z.xyz/manga/the-secret-affairs-of-the-3rd-generation-chaebol-2000/chapter-6/
        yield return new TestCaseData("aHR0cHM6Ly9oZW50YWkzei54eXovbWFuZ2EvdGhlLXNlY3JldC1hZmZhaXJzLW9mLXRoZS0zcmQtZ2VuZXJhdGlvbi1jaGFlYm9sLTIwMDAvY2hhcHRlci02Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://img.manga18h.com/manga_63b65ac816389/05898b271ace9859c8304e6f907a1380/23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhXzYzYjY1YWM4MTYzODkvMDU4OThiMjcxYWNlOTg1OWM4MzA0ZTZmOTA3YTEzODAvMjMuanBn");
        // https://img.manga18h.com/manga_63b65ac816389/05898b271ace9859c8304e6f907a1380/24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhXzYzYjY1YWM4MTYzODkvMDU4OThiMjcxYWNlOTg1OWM4MzA0ZTZmOTA3YTEzODAvMjQuanBn");
        // https://img.manga18h.com/manga_63b65ac816389/28f1fde2a14e02bacf749a39c16dd71a/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhXzYzYjY1YWM4MTYzODkvMjhmMWZkZTJhMTRlMDJiYWNmNzQ5YTM5YzE2ZGQ3MWEvMTAuanBn");
        // https://img.manga18h.com/manga_63b65ac816389/07fd662ca4d13a61ffc970fabc09dd66/15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhXzYzYjY1YWM4MTYzODkvMDdmZDY2MmNhNGQxM2E2MWZmYzk3MGZhYmMwOWRkNjYvMTUuanBn");
        // https://img.manga18h.com/manga_63b65ac816389/28f1fde2a14e02bacf749a39c16dd71a/07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuZ2ExOGguY29tL21hbmdhXzYzYjY1YWM4MTYzODkvMjhmMWZkZTJhMTRlMDJiYWNmNzQ5YTM5YzE2ZGQ3MWEvMDcuanBn");
    }
}

