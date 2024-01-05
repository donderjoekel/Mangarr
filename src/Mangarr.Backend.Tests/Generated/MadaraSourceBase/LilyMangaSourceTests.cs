using System.Collections;

namespace Mangarr.Backend.Tests;

public class LilyMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "lilymanga";

    public static IEnumerable ValidSearchResults()
    {
        yield return new TestCaseData("a");
        yield return new TestCaseData("i");
        yield return new TestCaseData("o");
        yield return new TestCaseData("u");
    }

    public static IEnumerable ValidChapterLists()
    {
        // https://lilymanga.net/ys/because-you-dazzled-me/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL2JlY2F1c2UteW91LWRhenpsZWQtbWUv");
        // https://lilymanga.net/ys/ubai-ai/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL3ViYWktYWkv");
        // https://lilymanga.net/ys/area-of-x/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL2FyZWEtb2YteC8=");
        // https://lilymanga.net/ys/immortal-parody/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL2ltbW9ydGFsLXBhcm9keS8=");
        // https://lilymanga.net/ys/relationship-users-manual/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL3JlbGF0aW9uc2hpcC11c2Vycy1tYW51YWwv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://lilymanga.net/ys/relationship-users-manual/episode-05/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL3JlbGF0aW9uc2hpcC11c2Vycy1tYW51YWwvZXBpc29kZS0wNS8=");
        // https://lilymanga.net/ys/ubai-ai/chapter-02/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL3ViYWktYWkvY2hhcHRlci0wMi8=");
        // https://lilymanga.net/ys/immortal-parody/episode-01/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL2ltbW9ydGFsLXBhcm9keS9lcGlzb2RlLTAxLw==");
        // https://lilymanga.net/ys/because-you-dazzled-me/chapter-05/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL2JlY2F1c2UteW91LWRhenpsZWQtbWUvY2hhcHRlci0wNS8=");
        // https://lilymanga.net/ys/area-of-x/episode-02/
        yield return new TestCaseData("aHR0cHM6Ly9saWx5bWFuZ2EubmV0L3lzL2FyZWEtb2YteC9lcGlzb2RlLTAyLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://lily.amys.cf/manga_657b74be4a86d/9d393c05388f91ce8e49bd7caad07a4b/021.webp
        yield return new TestCaseData("aHR0cHM6Ly9saWx5LmFteXMuY2YvbWFuZ2FfNjU3Yjc0YmU0YTg2ZC85ZDM5M2MwNTM4OGY5MWNlOGU0OWJkN2NhYWQwN2E0Yi8wMjEud2VicA==");
        // https://lily.amys.cf/manga_657b71b8a68c6/934932a8556fb3a330a8fe4ec1086339/007.webp
        yield return new TestCaseData("aHR0cHM6Ly9saWx5LmFteXMuY2YvbWFuZ2FfNjU3YjcxYjhhNjhjNi85MzQ5MzJhODU1NmZiM2EzMzBhOGZlNGVjMTA4NjMzOS8wMDcud2VicA==");
        // https://lily.amys.cf/manga_657b74be4a86d/9d393c05388f91ce8e49bd7caad07a4b/017.webp
        yield return new TestCaseData("aHR0cHM6Ly9saWx5LmFteXMuY2YvbWFuZ2FfNjU3Yjc0YmU0YTg2ZC85ZDM5M2MwNTM4OGY5MWNlOGU0OWJkN2NhYWQwN2E0Yi8wMTcud2VicA==");
        // https://lily.amys.cf/manga_656a560a3d393/0ebd1715946708ca962c4115873e7498/013.webp
        yield return new TestCaseData("aHR0cHM6Ly9saWx5LmFteXMuY2YvbWFuZ2FfNjU2YTU2MGEzZDM5My8wZWJkMTcxNTk0NjcwOGNhOTYyYzQxMTU4NzNlNzQ5OC8wMTMud2VicA==");
        // https://lily.amys.cf/manga_656b86986500b/22b945f5d3e6f65c466afa654da89658/6.webp
        yield return new TestCaseData("aHR0cHM6Ly9saWx5LmFteXMuY2YvbWFuZ2FfNjU2Yjg2OTg2NTAwYi8yMmI5NDVmNWQzZTZmNjVjNDY2YWZhNjU0ZGE4OTY1OC82LndlYnA=");
    }
}

