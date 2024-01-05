using System.Collections;

namespace Mangarr.Backend.Tests;

public class ShootingStarScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "shootingstarscans";

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
        // https://shootingstarscans.com/manhua/lemon-season-2/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2xlbW9uLXNlYXNvbi0yLw==");
        // https://shootingstarscans.com/manhua/daydreaming-in-the-hidden-mountain/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2RheWRyZWFtaW5nLWluLXRoZS1oaWRkZW4tbW91bnRhaW4v");
        // https://shootingstarscans.com/manhua/ayeshahs-secret/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2F5ZXNoYWhzLXNlY3JldC8=");
        // https://shootingstarscans.com/manhua/escape-from-the-triplets/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2VzY2FwZS1mcm9tLXRoZS10cmlwbGV0cy8=");
        // https://shootingstarscans.com/manhua/the-wolf-and-the-caged-bird/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL3RoZS13b2xmLWFuZC10aGUtY2FnZWQtYmlyZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://shootingstarscans.com/manhua/ayeshahs-secret/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2F5ZXNoYWhzLXNlY3JldC9jaGFwdGVyLTcv");
        // https://shootingstarscans.com/manhua/daydreaming-in-the-hidden-mountain/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2RheWRyZWFtaW5nLWluLXRoZS1oaWRkZW4tbW91bnRhaW4vY2hhcHRlci00Lw==");
        // https://shootingstarscans.com/manhua/daydreaming-in-the-hidden-mountain/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL2RheWRyZWFtaW5nLWluLXRoZS1oaWRkZW4tbW91bnRhaW4vY2hhcHRlci0xLw==");
        // https://shootingstarscans.com/manhua/the-wolf-and-the-caged-bird/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vbWFuaHVhL3RoZS13b2xmLWFuZC10aGUtY2FnZWQtYmlyZC9jaGFwdGVyLTMv");
    }

    public static IEnumerable ValidImages()
    {
        // https://shootingstarscans.com/wp-content/uploads/WP-manga/data/manga_63987b5abe883/60768126385185534767862d472fde03/36.webp
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjM5ODdiNWFiZTg4My82MDc2ODEyNjM4NTE4NTUzNDc2Nzg2MmQ0NzJmZGUwMy8zNi53ZWJw");
        // https://shootingstarscans.com/wp-content/uploads/WP-manga/data/manga_63987b5abe883/d6e9c807542bc0706dd52d9cf818001c/01.webp
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjM5ODdiNWFiZTg4My9kNmU5YzgwNzU0MmJjMDcwNmRkNTJkOWNmODE4MDAxYy8wMS53ZWJw");
        // https://shootingstarscans.com/wp-content/uploads/WP-manga/data/manga_63987b5abe883/60768126385185534767862d472fde03/23.webp
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjM5ODdiNWFiZTg4My82MDc2ODEyNjM4NTE4NTUzNDc2Nzg2MmQ0NzJmZGUwMy8yMy53ZWJw");
        // https://shootingstarscans.com/wp-content/uploads/WP-manga/data/manga_638d341bb3c70/d23bfd32d995640962dc2c214dcf9bf7/12.webp
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjM4ZDM0MWJiM2M3MC9kMjNiZmQzMmQ5OTU2NDA5NjJkYzJjMjE0ZGNmOWJmNy8xMi53ZWJw");
        // https://shootingstarscans.com/wp-content/uploads/WP-manga/data/manga_638d341bb3c70/d23bfd32d995640962dc2c214dcf9bf7/17.webp
        yield return new TestCaseData("aHR0cHM6Ly9zaG9vdGluZ3N0YXJzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjM4ZDM0MWJiM2M3MC9kMjNiZmQzMmQ5OTU2NDA5NjJkYzJjMjE0ZGNmOWJmNy8xNy53ZWJw");
    }
}

