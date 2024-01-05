using System.Collections;

namespace Mangarr.Backend.Tests;

public class FreakScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "freakscans";

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
        // https://freakscans.com/manga/the-demon-emperor-hopes-for-a-hero/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9tYW5nYS90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLw==");
        // https://freakscans.com/manga/0-kill-assassine/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9tYW5nYS8wLWtpbGwtYXNzYXNzaW5lLw==");
        // https://freakscans.com/manga/potion-witch/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9tYW5nYS9wb3Rpb24td2l0Y2gv");
        // https://freakscans.com/manga/utori-the-legacy/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9tYW5nYS91dG9yaS10aGUtbGVnYWN5Lw==");
        // https://freakscans.com/manga/legend-of-the-holy-sword/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9tYW5nYS9sZWdlbmQtb2YtdGhlLWhvbHktc3dvcmQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://freakscans.com/the-demon-emperor-hopes-for-a-hero-ch-02/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLWNoLTAyLw==");
        // https://freakscans.com/potion-witch-ch-01/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS9wb3Rpb24td2l0Y2gtY2gtMDEv");
        // https://freakscans.com/0-kill-assassine-ch-02/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS8wLWtpbGwtYXNzYXNzaW5lLWNoLTAyLw==");
        // https://freakscans.com/0-kill-assassine-ch-03/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS8wLWtpbGwtYXNzYXNzaW5lLWNoLTAzLw==");
        // https://freakscans.com/the-demon-emperor-hopes-for-a-hero-ch-01/
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbS90aGUtZGVtb24tZW1wZXJvci1ob3Blcy1mb3ItYS1oZXJvLWNoLTAxLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://i3.wp.com/freakscans.com/wp-content/uploads/2023/12/08-120.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDgtMTIwLmpwZw==");
        // https://i2.wp.com/freakscans.com/wp-content/uploads/2023/12/17-19.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTctMTkuanBn");
        // https://i3.wp.com/freakscans.com/wp-content/uploads/2023/12/03-135.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDMtMTM1LmpwZw==");
        // https://i3.wp.com/freakscans.com/wp-content/uploads/2023/12/16-24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTYtMjQuanBn");
        // https://i0.wp.com/freakscans.com/wp-content/uploads/2023/12/06-135.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDYtMTM1LmpwZw==");
    }
}

