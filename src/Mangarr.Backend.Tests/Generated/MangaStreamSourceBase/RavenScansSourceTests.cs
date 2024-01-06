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
        // https://ravenscans.com/i-am-the-descendant-of-the-divine-dragon-chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9pLWFtLXRoZS1kZXNjZW5kYW50LW9mLXRoZS1kaXZpbmUtZHJhZ29uLWNoYXB0ZXItMTkvfGh0dHBzOi8vcmF2ZW5zY2Fucy5jb20/cD0yMzY0NnwxOQ==");
        // https://ravenscans.com/am-i-invincible-chapter-181/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9hbS1pLWludmluY2libGUtY2hhcHRlci0xODEvfGh0dHBzOi8vcmF2ZW5zY2Fucy5jb20/cD0yNTk4N3wxODE=");
        // https://ravenscans.com/i-am-the-descendant-of-the-divine-dragon-chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9pLWFtLXRoZS1kZXNjZW5kYW50LW9mLXRoZS1kaXZpbmUtZHJhZ29uLWNoYXB0ZXItNC98aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTIzNjQ2fDQ=");
        // https://ravenscans.com/am-i-invincible-chapter-chapter-176/
        yield return new TestCaseData("aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbS9hbS1pLWludmluY2libGUtY2hhcHRlci1jaGFwdGVyLTE3Ni98aHR0cHM6Ly9yYXZlbnNjYW5zLmNvbT9wPTI1OTg3fDE3Ng==");
    }

    public static IEnumerable ValidImages()
    {
        // https://i0.wp.com/ravenscans.com/wp-content/uploads/2023/11/2-16-13.jpg?resize=960%2C5806&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTEvMi0xNi0xMy5qcGc/cmVzaXplPTk2MCUyQzU4MDYmc3NsPTE=");
        // https://i2.wp.com/ravenscans.com/wp-content/uploads/2023/09/raven-11.jpg?resize=611%2C611&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMi53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDkvcmF2ZW4tMTEuanBnP3Jlc2l6ZT02MTElMkM2MTEmc3NsPTE=");
        // https://i3.wp.com/ravenscans.com/wp-content/uploads/2023/11/3-1.jpg?resize=960%2C4257&ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMy53cC5jb20vcmF2ZW5zY2Fucy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTEvMy0xLmpwZz9yZXNpemU9OTYwJTJDNDI1NyZzc2w9MQ==");
    }
}

