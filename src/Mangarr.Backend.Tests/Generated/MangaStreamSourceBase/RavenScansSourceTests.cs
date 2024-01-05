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
        // https://ravenscans.com/manga/am-i-invincible/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9tYW5nYS9hbS1pLWludmluY2libGUv");
        // https://ravenscans.com/manga/i-am-the-descendant-of-the-divine-dragon/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9tYW5nYS9pLWFtLXRoZS1kZXNjZW5kYW50LW9mLXRoZS1kaXZpbmUtZHJhZ29uLw==");
        // https://ravenscans.com/manga/the-great-curse/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9tYW5nYS90aGUtZ3JlYXQtY3Vyc2Uv");
        // https://ravenscans.com/manga/i-am-a-sword-immortal/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9tYW5nYS9pLWFtLWEtc3dvcmQtaW1tb3J0YWwv");
        // https://ravenscans.com/manga/my-beautiful-and-wealthy-wife/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9tYW5nYS9teS1iZWF1dGlmdWwtYW5kLXdlYWx0aHktd2lmZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://ravenscans.com/the-great-curse-chapter-3-2/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS90aGUtZ3JlYXQtY3Vyc2UtY2hhcHRlci0zLTIv");
        // https://ravenscans.com/the-great-curse-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS90aGUtZ3JlYXQtY3Vyc2UtY2hhcHRlci0xLw==");
        // https://ravenscans.com/am-i-invincible-chapter-181/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9hbS1pLWludmluY2libGUtY2hhcHRlci0xODEv");
        // https://ravenscans.com/my-beautiful-and-wealthy-wife-chapter-16/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9teS1iZWF1dGlmdWwtYW5kLXdlYWx0aHktd2lmZS1jaGFwdGVyLTE2Lw==");
        // https://ravenscans.com/i-am-the-descendant-of-the-divine-dragon-chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9pLWFtLXRoZS1kZXNjZW5kYW50LW9mLXRoZS1kaXZpbmUtZHJhZ29uLWNoYXB0ZXItMTEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://i3.wp.com/ravenscans.com/wp-content/uploads/2023/10/2-20-19.jpg?resize=960%2C4697&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvMi0yMC0xOS5qcGc/cmVzaXplPTk2MCUyQzQ2OTcmc3NsPTE=");
        // https://i1.wp.com/ravenscans.com/wp-content/uploads/2023/09/2-15-20.jpg?resize=960%2C5663&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMS53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvMi0xNS0yMC5qcGc/cmVzaXplPTk2MCUyQzU2NjMmc3NsPTE=");
        // https://i0.wp.com/ravenscans.com/wp-content/uploads/2023/07/4-18.webp?resize=951%2C5801&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDcvNC0xOC53ZWJwP3Jlc2l6ZT05NTElMkM1ODAxJnNzbD0x");
        // https://i2.wp.com/ravenscans.com/wp-content/uploads/2023/10/2-18-19.jpg?resize=960%2C4697&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTAvMi0xOC0xOS5qcGc/cmVzaXplPTk2MCUyQzQ2OTcmc3NsPTE=");
    }
}

