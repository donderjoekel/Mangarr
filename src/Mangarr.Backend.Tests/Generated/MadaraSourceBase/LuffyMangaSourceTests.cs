using System.Collections;

namespace Mangarr.Backend.Tests;

public class LuffyMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "luffymanga";

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
        // https://luffymanga.com/manga/leviathan-2/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS9sZXZpYXRoYW4tMi8=");
        // https://luffymanga.com/manga/the-beginning-after-the-end/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS90aGUtYmVnaW5uaW5nLWFmdGVyLXRoZS1lbmQv");
        // https://luffymanga.com/manga/leviathan/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS9sZXZpYXRoYW4v");
        // https://luffymanga.com/manga/nano-machine/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS9uYW5vLW1hY2hpbmUv");
        // https://luffymanga.com/manga/the-great-mage-returns-after-4000-years/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS90aGUtZ3JlYXQtbWFnZS1yZXR1cm5zLWFmdGVyLTQwMDAteWVhcnMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://luffymanga.com/manga/the-great-mage-returns-after-4000-years/chapter-63/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS90aGUtZ3JlYXQtbWFnZS1yZXR1cm5zLWFmdGVyLTQwMDAteWVhcnMvY2hhcHRlci02My8=");
        // https://luffymanga.com/manga/nano-machine/chapter-62/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS9uYW5vLW1hY2hpbmUvY2hhcHRlci02Mi8=");
        // https://luffymanga.com/manga/the-great-mage-returns-after-4000-years/chapter-31/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS90aGUtZ3JlYXQtbWFnZS1yZXR1cm5zLWFmdGVyLTQwMDAteWVhcnMvY2hhcHRlci0zMS8=");
        // https://luffymanga.com/manga/leviathan-2/chapter-31/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS9sZXZpYXRoYW4tMi9jaGFwdGVyLTMxLw==");
        // https://luffymanga.com/manga/nano-machine/chapter-161/
        yield return new TestCaseData("aHR0cHM6Ly9sdWZmeW1hbmdhLmNvbS9tYW5nYS9uYW5vLW1hY2hpbmUvY2hhcHRlci0xNjEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://i0.wp.com/luffymanga.com/wp-content/uploads/WP-manga/data/manga_654f441dcd7ab/f1d58d69183d0ffd355854b885995c34/9.webp?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vbHVmZnltYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU0ZjQ0MWRjZDdhYi9mMWQ1OGQ2OTE4M2QwZmZkMzU1ODU0Yjg4NTk5NWMzNC85LndlYnA/c3NsPTE=");
        // https://i0.wp.com/luffymanga.com/wp-content/uploads/WP-manga/data/manga_654f441dcd7ab/e9b28b934574db2f3d37d93308392434/11.webp?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vbHVmZnltYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU0ZjQ0MWRjZDdhYi9lOWIyOGI5MzQ1NzRkYjJmM2QzN2Q5MzMwODM5MjQzNC8xMS53ZWJwP3NzbD0x");
        // https://i0.wp.com/luffymanga.com/wp-content/uploads/WP-manga/data/manga_654f42febc536/badf2a0e46bdb2fe0fca4de0b8ae1c4b/05.webp?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vbHVmZnltYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU0ZjQyZmViYzUzNi9iYWRmMmEwZTQ2YmRiMmZlMGZjYTRkZTBiOGFlMWM0Yi8wNS53ZWJwP3NzbD0x");
        // https://i0.wp.com/luffymanga.com/wp-content/uploads/WP-manga/data/manga_654f441dcd7ab/e9b28b934574db2f3d37d93308392434/17.webp?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vbHVmZnltYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU0ZjQ0MWRjZDdhYi9lOWIyOGI5MzQ1NzRkYjJmM2QzN2Q5MzMwODM5MjQzNC8xNy53ZWJwP3NzbD0x");
        // https://i0.wp.com/luffymanga.com/wp-content/uploads/WP-manga/data/manga_654f42febc536/badf2a0e46bdb2fe0fca4de0b8ae1c4b/07.webp?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vbHVmZnltYW5nYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU0ZjQyZmViYzUzNi9iYWRmMmEwZTQ2YmRiMmZlMGZjYTRkZTBiOGFlMWM0Yi8wNy53ZWJwP3NzbD0x");
    }
}

