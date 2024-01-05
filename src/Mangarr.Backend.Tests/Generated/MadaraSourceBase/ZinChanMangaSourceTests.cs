using System.Collections;

namespace Mangarr.Backend.Tests;

public class ZinChanMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "zinchanmanga";

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
        // https://zinchanmanga.com/manga/backyard-guest/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2JhY2t5YXJkLWd1ZXN0Lw==");
        // https://zinchanmanga.com/manga/awful-boss/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2F3ZnVsLWJvc3Mv");
        // https://zinchanmanga.com/manga/my-dear-neighbor/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL215LWRlYXItbmVpZ2hib3Iv");
        // https://zinchanmanga.com/manga/dear-teddy-bear/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2RlYXItdGVkZHktYmVhci8=");
        // https://zinchanmanga.com/manga/alpha/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2FscGhhLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://zinchanmanga.com/manga/awful-boss/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2F3ZnVsLWJvc3MvY2hhcHRlci0yLw==");
        // https://zinchanmanga.com/manga/backyard-guest/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2JhY2t5YXJkLWd1ZXN0L2NoYXB0ZXItMy8=");
        // https://zinchanmanga.com/manga/dear-teddy-bear/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2RlYXItdGVkZHktYmVhci9jaGFwdGVyLTMv");
        // https://zinchanmanga.com/manga/awful-boss/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL21hbmdhL2F3ZnVsLWJvc3MvY2hhcHRlci0xLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://zinchanmanga.com/wp-content/uploads/WP-manga/data/manga_658d33b69d97f/6016503e4e52b3d3e2c037efda6bd865/023.webp
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OGQzM2I2OWQ5N2YvNjAxNjUwM2U0ZTUyYjNkM2UyYzAzN2VmZGE2YmQ4NjUvMDIzLndlYnA=");
        // https://zinchanmanga.com/wp-content/uploads/WP-manga/data/manga_65914dbf4d947/d89230406a857a76a8f14aa19f4b8fa6/33.jpg
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTE0ZGJmNGQ5NDcvZDg5MjMwNDA2YTg1N2E3NmE4ZjE0YWExOWY0YjhmYTYvMzMuanBn");
        // https://zinchanmanga.com/wp-content/uploads/WP-manga/data/manga_65914dbf4d947/d89230406a857a76a8f14aa19f4b8fa6/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTE0ZGJmNGQ5NDcvZDg5MjMwNDA2YTg1N2E3NmE4ZjE0YWExOWY0YjhmYTYvMTAuanBn");
        // https://zinchanmanga.com/wp-content/uploads/WP-manga/data/manga_658d33b69d97f/06b2f1ddf598c4e8d4a85c8c3c9fbdb9/036.webp
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OGQzM2I2OWQ5N2YvMDZiMmYxZGRmNTk4YzRlOGQ0YTg1YzhjM2M5ZmJkYjkvMDM2LndlYnA=");
        // https://zinchanmanga.com/wp-content/uploads/WP-manga/data/manga_6582db6edf429/fa45f6c59a2ddcc0faaea329c0e36d2a/7-(1).jpg
        yield return new TestCaseData("aHR0cHM6Ly96aW5jaGFubWFuZ2EuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1ODJkYjZlZGY0MjkvZmE0NWY2YzU5YTJkZGNjMGZhYWVhMzI5YzBlMzZkMmEvNy0oMSkuanBn");
    }
}

