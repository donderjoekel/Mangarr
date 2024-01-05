using System.Collections;

namespace Mangarr.Backend.Tests;

public class ArcanescansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "arcanescans";

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
        // https://arcanescans.com/manga/when-i-stopped-being-a-licking-dog-i-became-a-billionaire/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2Evd2hlbi1pLXN0b3BwZWQtYmVpbmctYS1saWNraW5nLWRvZy1pLWJlY2FtZS1hLWJpbGxpb25haXJlLw==");
        // https://arcanescans.com/manga/serving-the-heavens-is-my-destiny/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2Evc2VydmluZy10aGUtaGVhdmVucy1pcy1teS1kZXN0aW55Lw==");
        // https://arcanescans.com/manga/infinite-archives/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvaW5maW5pdGUtYXJjaGl2ZXMv");
        // https://arcanescans.com/manga/unrivaled-in-the-world-of-superpowers/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvdW5yaXZhbGVkLWluLXRoZS13b3JsZC1vZi1zdXBlcnBvd2Vycy8=");
        // https://arcanescans.com/manga/fairy-wait-a-moment-please-listen-to-my-argument/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvZmFpcnktd2FpdC1hLW1vbWVudC1wbGVhc2UtbGlzdGVuLXRvLW15LWFyZ3VtZW50Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://arcanescans.com/manga/infinite-archives/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvaW5maW5pdGUtYXJjaGl2ZXMvY2hhcHRlci00Lw==");
        // https://arcanescans.com/manga/infinite-archives/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvaW5maW5pdGUtYXJjaGl2ZXMvY2hhcHRlci0xLw==");
        // https://arcanescans.com/manga/fairy-wait-a-moment-please-listen-to-my-argument/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvZmFpcnktd2FpdC1hLW1vbWVudC1wbGVhc2UtbGlzdGVuLXRvLW15LWFyZ3VtZW50L2NoYXB0ZXItMi8=");
        // https://arcanescans.com/manga/unrivaled-in-the-world-of-superpowers/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2EvdW5yaXZhbGVkLWluLXRoZS13b3JsZC1vZi1zdXBlcnBvd2Vycy9jaGFwdGVyLTIv");
        // https://arcanescans.com/manga/serving-the-heavens-is-my-destiny/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vbWFuZ2Evc2VydmluZy10aGUtaGVhdmVucy1pcy1teS1kZXN0aW55L2NoYXB0ZXItMy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://arcanescans.com/wp-content/uploads/WP-manga/data/manga_65515a51afe86/0f49f28cc1f3055ab73aba868878ed67/1.webp
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1MTVhNTFhZmU4Ni8wZjQ5ZjI4Y2MxZjMwNTVhYjczYWJhODY4ODc4ZWQ2Ny8xLndlYnA=");
        // https://arcanescans.com/wp-content/uploads/WP-manga/data/manga_6551225e0ea29/865ca07cc3271f0e064522929f7dc73b/3.webp
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1MTIyNWUwZWEyOS84NjVjYTA3Y2MzMjcxZjBlMDY0NTIyOTI5ZjdkYzczYi8zLndlYnA=");
        // https://arcanescans.com/wp-content/uploads/WP-manga/data/manga_6558876680edb/9d6308ef8bac65affa2b5a8cfe35ce64/1.webp
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1ODg3NjY4MGVkYi85ZDYzMDhlZjhiYWM2NWFmZmEyYjVhOGNmZTM1Y2U2NC8xLndlYnA=");
        // https://arcanescans.com/wp-content/uploads/WP-manga/data/manga_654b84df0b8a4/890d36e4069b2d50ca03c1fb364fb3fd/4.webp
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU0Yjg0ZGYwYjhhNC84OTBkMzZlNDA2OWIyZDUwY2EwM2MxZmIzNjRmYjNmZC80LndlYnA=");
        // https://arcanescans.com/wp-content/uploads/WP-manga/data/manga_65515a51afe86/92c30cf845401517601fe0bbb898dff7/4.webp
        yield return new TestCaseData("aHR0cHM6Ly9hcmNhbmVzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1MTVhNTFhZmU4Ni85MmMzMGNmODQ1NDAxNTE3NjAxZmUwYmJiODk4ZGZmNy80LndlYnA=");
    }
}

