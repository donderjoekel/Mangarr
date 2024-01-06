using System.Collections;

namespace Mangarr.Backend.Tests;

public class LunarScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "lunarscans";

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
        // https://lunarscan.org?p=8306
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9ODMwNnw4MzA2");
        // https://lunarscan.org?p=8029
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9ODAyOXw4MDI5");
        // https://lunarscan.org?p=7868
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9Nzg2OHw3ODY4");
        // https://lunarscan.org?p=7422
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9NzQyMnw3NDIy");
        // https://lunarscan.org?p=7089
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9NzA4OXw3MDg5");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://lunarscan.org/pervert-addiction-chapter-44/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3BlcnZlcnQtYWRkaWN0aW9uLWNoYXB0ZXItNDQvfGh0dHBzOi8vbHVuYXJzY2FuLm9yZz9wPTgwMjl8NDQ=");
        // https://lunarscan.org/im-the-leader-of-a-cult-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL2ltLXRoZS1sZWFkZXItb2YtYS1jdWx0LWNoYXB0ZXItMS98aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9NzA4OXwx");
        // https://lunarscan.org/corruption-obscene-tales-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL2NvcnJ1cHRpb24tb2JzY2VuZS10YWxlcy1jaGFwdGVyLTEvfGh0dHBzOi8vbHVuYXJzY2FuLm9yZz9wPTgzMDZ8MQ==");
        // https://lunarscan.org/pervert-addiction-chapter-41/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3BlcnZlcnQtYWRkaWN0aW9uLWNoYXB0ZXItNDEvfGh0dHBzOi8vbHVuYXJzY2FuLm9yZz9wPTgwMjl8NDE=");
        // https://lunarscan.org/pervert-addiction-chapter-54/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3BlcnZlcnQtYWRkaWN0aW9uLWNoYXB0ZXItNTQvfGh0dHBzOi8vbHVuYXJzY2FuLm9yZz9wPTgwMjl8NTQ=");
    }

    public static IEnumerable ValidImages()
    {
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-44-08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTQ0LTA4LmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2024/01/COT-1-05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL0NPVC0xLTA1LmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-44-07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTQ0LTA3LmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-41-07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTQxLTA3LmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-54-06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTU0LTA2LmpwZw==");
    }
}

