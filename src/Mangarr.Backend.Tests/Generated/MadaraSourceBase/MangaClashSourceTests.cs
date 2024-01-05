using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaClashSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaclash";

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
        // https://mangaclash.com/manga/soul-land-v/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9zb3VsLWxhbmQtdi8=");
        // https://mangaclash.com/manga/return-of-top-class-master/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9yZXR1cm4tb2YtdG9wLWNsYXNzLW1hc3Rlci8=");
        // https://mangaclash.com/manga/shuufuku-sukiru-ga-bannou-chiito-ka-shitanode-buki-ya-demo-hirakou-ka-to-omoimasu/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9zaHV1ZnVrdS1zdWtpcnUtZ2EtYmFubm91LWNoaWl0by1rYS1zaGl0YW5vZGUtYnVraS15YS1kZW1vLWhpcmFrb3Uta2EtdG8tb21vaW1hc3Uv");
        // https://mangaclash.com/manga/useless-wizard/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS91c2VsZXNzLXdpemFyZC8=");
        // https://mangaclash.com/manga/conqueror-of-modern-martial-arts-kang-haejin/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9jb25xdWVyb3Itb2YtbW9kZXJuLW1hcnRpYWwtYXJ0cy1rYW5nLWhhZWppbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaclash.com/manga/useless-wizard/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS91c2VsZXNzLXdpemFyZC9jaGFwdGVyLTQv");
        // https://mangaclash.com/manga/soul-land-v/chapter-39/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9zb3VsLWxhbmQtdi9jaGFwdGVyLTM5Lw==");
        // https://mangaclash.com/manga/soul-land-v/chapter-54/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9zb3VsLWxhbmQtdi9jaGFwdGVyLTU0Lw==");
        // https://mangaclash.com/manga/soul-land-v/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9zb3VsLWxhbmQtdi9jaGFwdGVyLTI1Lw==");
        // https://mangaclash.com/manga/soul-land-v/chapter-88/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWNsYXNoLmNvbS9tYW5nYS9zb3VsLWxhbmQtdi9jaGFwdGVyLTg4Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn3.mangaclash.com/temp/manga_659620e37305f/f7ea3235a25f2d52bd776307fdae9cd6/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdhY2xhc2guY29tL3RlbXAvbWFuZ2FfNjU5NjIwZTM3MzA1Zi9mN2VhMzIzNWEyNWYyZDUyYmQ3NzYzMDdmZGFlOWNkNi80LmpwZw==");
        // https://cdn3.mangaclash.com/temp/manga_659620e37305f/96390f27edcefe58419a8fb477e44574/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdhY2xhc2guY29tL3RlbXAvbWFuZ2FfNjU5NjIwZTM3MzA1Zi85NjM5MGYyN2VkY2VmZTU4NDE5YThmYjQ3N2U0NDU3NC84LmpwZw==");
        // https://cdn3.mangaclash.com/temp/manga_6595524380936/5bba4b0c0380a57f0b5776dfbb791a04/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdhY2xhc2guY29tL3RlbXAvbWFuZ2FfNjU5NTUyNDM4MDkzNi81YmJhNGIwYzAzODBhNTdmMGI1Nzc2ZGZiYjc5MWEwNC8xMS5qcGc=");
        // https://cdn3.mangaclash.com/temp/manga_659620e37305f/96390f27edcefe58419a8fb477e44574/9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdhY2xhc2guY29tL3RlbXAvbWFuZ2FfNjU5NjIwZTM3MzA1Zi85NjM5MGYyN2VkY2VmZTU4NDE5YThmYjQ3N2U0NDU3NC85LmpwZw==");
        // https://cdn3.mangaclash.com/temp/manga_659620e37305f/f7ea3235a25f2d52bd776307fdae9cd6/7.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdhY2xhc2guY29tL3RlbXAvbWFuZ2FfNjU5NjIwZTM3MzA1Zi9mN2VhMzIzNWEyNWYyZDUyYmQ3NzYzMDdmZGFlOWNkNi83LmpwZw==");
    }
}

