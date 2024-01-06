using System.Collections;

namespace Mangarr.Backend.Tests;

public class RavenScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "ravenscans";

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
        // https://ravenscans.com?p=25987
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI1OTg3fDI1OTg3");
        // https://ravenscans.com?p=23646
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTIzNjQ2fDIzNjQ2");
        // https://ravenscans.com?p=22063
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTIyMDYzfDIyMDYz");
        // https://ravenscans.com?p=21656
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTIxNjU2fDIxNjU2");
        // https://ravenscans.com?p=21313
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTIxMzEzfDIxMzEz");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://ravenscans.com?p=25549
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI1NTQ5fDI1NTQ5");
        // https://ravenscans.com?p=25061
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI1MDYxfDI1MDYx");
        // https://ravenscans.com?p=26917
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI2OTE3fDI2OTE3");
        // https://ravenscans.com?p=25856
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI1ODU2fDI1ODU2");
        // https://ravenscans.com?p=26825
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI2ODI1fDI2ODI1");
    }

    public static IEnumerable ValidImages()
    {
        // https://i3.wp.com/ravenscans.com/wp-content/uploads/2023/10/2-2-8.jpg?resize=960%2C3000&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvMi0yLTguanBnP3Jlc2l6ZT05NjAlMkMzMDAwJnNzbD0x");
        // https://i0.wp.com/ravenscans.com/wp-content/uploads/2023/12/2-20-7.webp?resize=959%2C4907&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMi0yMC03LndlYnA/cmVzaXplPTk1OSUyQzQ5MDcmc3NsPTE=");
        // https://i2.wp.com/ravenscans.com/wp-content/uploads/2023/10/3-20-16.jpg?resize=960%2C3000&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvMy0yMC0xNi5qcGc/cmVzaXplPTk2MCUyQzMwMDAmc3NsPTE=");
    }
}

