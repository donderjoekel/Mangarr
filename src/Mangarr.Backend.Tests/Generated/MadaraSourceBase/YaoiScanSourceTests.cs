using System.Collections;

namespace Mangarr.Backend.Tests;

public class YaoiScanSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "yaoiscan";

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
        // https://yaoiscan.com/read/betrayal-of-dignity/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9iZXRyYXlhbC1vZi1kaWduaXR5Lw==");
        // https://yaoiscan.com/read/is-it-because-im-cute/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9pcy1pdC1iZWNhdXNlLWltLWN1dGUv");
        // https://yaoiscan.com/read/hygieia/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9oeWdpZWlhLw==");
        // https://yaoiscan.com/read/defence-mechanism-sms/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9kZWZlbmNlLW1lY2hhbmlzbS1zbXMv");
        // https://yaoiscan.com/read/my-one-and-only-cat/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9teS1vbmUtYW5kLW9ubHktY2F0Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://yaoiscan.com/read/betrayal-of-dignity/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9iZXRyYXlhbC1vZi1kaWduaXR5L2NoYXB0ZXItMTgv");
        // https://yaoiscan.com/read/betrayal-of-dignity/chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9iZXRyYXlhbC1vZi1kaWduaXR5L2NoYXB0ZXItMjAv");
        // https://yaoiscan.com/read/is-it-because-im-cute/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9pcy1pdC1iZWNhdXNlLWltLWN1dGUvY2hhcHRlci0yLw==");
        // https://yaoiscan.com/read/my-one-and-only-cat/chapter-44/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9teS1vbmUtYW5kLW9ubHktY2F0L2NoYXB0ZXItNDQv");
        // https://yaoiscan.com/read/betrayal-of-dignity/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly95YW9pc2Nhbi5jb20vcmVhZC9iZXRyYXlhbC1vZi1kaWduaXR5L2NoYXB0ZXItMC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img4.yaoiscan.com/site-2/my-one-and-only-cat-14035/chapter-44/39.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWc0Lnlhb2lzY2FuLmNvbS9zaXRlLTIvbXktb25lLWFuZC1vbmx5LWNhdC0xNDAzNS9jaGFwdGVyLTQ0LzM5LmpwZw==");
        // https://img4.yaoiscan.com/site-2/betrayal-of-dignity-14068/chapter-18/21.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWc0Lnlhb2lzY2FuLmNvbS9zaXRlLTIvYmV0cmF5YWwtb2YtZGlnbml0eS0xNDA2OC9jaGFwdGVyLTE4LzIxLmpwZw==");
        // https://img4.yaoiscan.com/site-2/betrayal-of-dignity-14068/chapter-20/40.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWc0Lnlhb2lzY2FuLmNvbS9zaXRlLTIvYmV0cmF5YWwtb2YtZGlnbml0eS0xNDA2OC9jaGFwdGVyLTIwLzQwLmpwZw==");
        // https://img4.yaoiscan.com/site-2/my-one-and-only-cat-14035/chapter-44/24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWc0Lnlhb2lzY2FuLmNvbS9zaXRlLTIvbXktb25lLWFuZC1vbmx5LWNhdC0xNDAzNS9jaGFwdGVyLTQ0LzI0LmpwZw==");
        // https://img4.yaoiscan.com/site-2/my-one-and-only-cat-14035/chapter-44/41.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWc0Lnlhb2lzY2FuLmNvbS9zaXRlLTIvbXktb25lLWFuZC1vbmx5LWNhdC0xNDAzNS9jaGFwdGVyLTQ0LzQxLmpwZw==");
    }
}

