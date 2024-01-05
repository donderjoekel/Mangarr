using System.Collections;

namespace Mangarr.Backend.Tests;

public class NovelCrowSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "novelcrow";

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
        // https://novelcrow.com/comic/human-resources-gashousesushiart/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2h1bWFuLXJlc291cmNlcy1nYXNob3VzZXN1c2hpYXJ0Lw==");
        // https://novelcrow.com/comic/house-party-kappa-gashousesushiart/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2hvdXNlLXBhcnR5LWthcHBhLWdhc2hvdXNlc3VzaGlhcnQv");
        // https://novelcrow.com/comic/jessie-ntrs-tifa-from-cloud-salamandraninja/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2plc3NpZS1udHJzLXRpZmEtZnJvbS1jbG91ZC1zYWxhbWFuZHJhbmluamEv");
        // https://novelcrow.com/comic/the-escort-and-the-flower-girl-final-fantasy-vii-aoin/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL3RoZS1lc2NvcnQtYW5kLXRoZS1mbG93ZXItZ2lybC1maW5hbC1mYW50YXN5LXZpaS1hb2luLw==");
        // https://novelcrow.com/comic/carnal-science-james-lemay/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2Nhcm5hbC1zY2llbmNlLWphbWVzLWxlbWF5Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://novelcrow.com/comic/carnal-science-james-lemay/1-carnal-science-chapter-1-james-lemay/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2Nhcm5hbC1zY2llbmNlLWphbWVzLWxlbWF5LzEtY2FybmFsLXNjaWVuY2UtY2hhcHRlci0xLWphbWVzLWxlbWF5Lw==");
        // https://novelcrow.com/comic/the-escort-and-the-flower-girl-final-fantasy-vii-aoin/1-the-escort-and-the-flower-girl-chapter-1-aoin/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL3RoZS1lc2NvcnQtYW5kLXRoZS1mbG93ZXItZ2lybC1maW5hbC1mYW50YXN5LXZpaS1hb2luLzEtdGhlLWVzY29ydC1hbmQtdGhlLWZsb3dlci1naXJsLWNoYXB0ZXItMS1hb2luLw==");
        // https://novelcrow.com/comic/jessie-ntrs-tifa-from-cloud-salamandraninja/2-jessie-ntrs-tifa-from-cloud-part-2-salamandraninja/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2plc3NpZS1udHJzLXRpZmEtZnJvbS1jbG91ZC1zYWxhbWFuZHJhbmluamEvMi1qZXNzaWUtbnRycy10aWZhLWZyb20tY2xvdWQtcGFydC0yLXNhbGFtYW5kcmFuaW5qYS8=");
        // https://novelcrow.com/comic/carnal-science-james-lemay/3-carnal-science-chapter-3-james-lemay/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2Nhcm5hbC1zY2llbmNlLWphbWVzLWxlbWF5LzMtY2FybmFsLXNjaWVuY2UtY2hhcHRlci0zLWphbWVzLWxlbWF5Lw==");
        // https://novelcrow.com/comic/human-resources-gashousesushiart/1-human-resources-chapter-1-gashousesushiart/
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL2NvbWljL2h1bWFuLXJlc291cmNlcy1nYXNob3VzZXN1c2hpYXJ0LzEtaHVtYW4tcmVzb3VyY2VzLWNoYXB0ZXItMS1nYXNob3VzZXN1c2hpYXJ0Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://novelcrow.com/wp-content/uploads/WP-manga/data/manga_6597d216c26a4/f5ef0447556d4205686aa7770d2e21a1/02：2_2.webp
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTdkMjE2YzI2YTQvZjVlZjA0NDc1NTZkNDIwNTY4NmFhNzc3MGQyZTIxYTEvMDLvvJoyXzIud2VicA==");
        // https://novelcrow.com/wp-content/uploads/WP-manga/data/manga_6597d216c26a4/f5ef0447556d4205686aa7770d2e21a1/53：53_53.webp
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTdkMjE2YzI2YTQvZjVlZjA0NDc1NTZkNDIwNTY4NmFhNzc3MGQyZTIxYTEvNTPvvJo1M181My53ZWJw");
        // https://novelcrow.com/wp-content/uploads/WP-manga/data/manga_6597d216c26a4/f5ef0447556d4205686aa7770d2e21a1/31：31_31.webp
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTdkMjE2YzI2YTQvZjVlZjA0NDc1NTZkNDIwNTY4NmFhNzc3MGQyZTIxYTEvMzHvvJozMV8zMS53ZWJw");
        // https://novelcrow.com/wp-content/uploads/WP-manga/data/manga_6597d216c26a4/f5ef0447556d4205686aa7770d2e21a1/50：50_50.webp
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTdkMjE2YzI2YTQvZjVlZjA0NDc1NTZkNDIwNTY4NmFhNzc3MGQyZTIxYTEvNTDvvJo1MF81MC53ZWJw");
        // https://novelcrow.com/wp-content/uploads/WP-manga/data/manga_6597bece78442/f27bdf33978e2437eff29cf661a66c30/27-FF7-NTR-91_39.webp
        yield return new TestCaseData("aHR0cHM6Ly9ub3ZlbGNyb3cuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTdiZWNlNzg0NDIvZjI3YmRmMzM5NzhlMjQzN2VmZjI5Y2Y2NjFhNjZjMzAvMjctRkY3LU5UUi05MV8zOS53ZWJw");
    }
}

