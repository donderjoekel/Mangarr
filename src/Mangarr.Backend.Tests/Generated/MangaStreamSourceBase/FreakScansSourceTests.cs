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
        // https://freakscans.com?p=24923
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0OTIzfDI0OTIz");
        // https://freakscans.com?p=24841
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0ODQxfDI0ODQx");
        // https://freakscans.com?p=24069
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0MDY5fDI0MDY5");
        // https://freakscans.com?p=23965
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTY1fDIzOTY1");
        // https://freakscans.com?p=23932
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTMyfDIzOTMy");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://freakscans.com?p=24087
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0MDg3fDI0MDg3");
        // https://freakscans.com?p=23956
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTU2fDIzOTU2");
        // https://freakscans.com?p=24942
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTI0OTQyfDI0OTQy");
        // https://freakscans.com?p=23946
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTQ2fDIzOTQ2");
        // https://freakscans.com?p=23967
        yield return new TestCaseData("aHR0cHM6Ly9mcmVha3NjYW5zLmNvbT9wPTIzOTY3fDIzOTY3");
    }

    public static IEnumerable ValidImages()
    {
        // https://i0.wp.com/freakscans.com/wp-content/uploads/2023/12/05-126.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDUtMTI2LmpwZw==");
        // https://i2.wp.com/freakscans.com/wp-content/uploads/2023/07/100.5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDcvMTAwLjUuanBn");
        // https://i0.wp.com/freakscans.com/wp-content/uploads/2023/12/06-128.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDYtMTI4LmpwZw==");
        // https://i2.wp.com/freakscans.com/wp-content/uploads/2023/11/100.5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTEvMTAwLjUuanBn");
        // https://i0.wp.com/freakscans.com/wp-content/uploads/2024/01/04-41.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vZnJlYWtzY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDQtNDEuanBn");
    }
}

