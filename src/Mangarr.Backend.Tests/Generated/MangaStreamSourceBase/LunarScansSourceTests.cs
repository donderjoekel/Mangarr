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
        // https://lunarscan.org?p=7511
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9NzUxMXw3NTEx");
        // https://lunarscan.org?p=7253
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9NzI1M3w3MjUz");
        // https://lunarscan.org?p=7878
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9Nzg3OHw3ODc4");
        // https://lunarscan.org?p=7844
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9Nzg0NHw3ODQ0");
        // https://lunarscan.org?p=8158
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnP3A9ODE1OHw4MTU4");
    }

    public static IEnumerable ValidImages()
    {
        // https://lunarscan.org/wp-content/uploads/2023/12/AG-1-08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL0FHLTEtMDguanBn");
        // https://lunarscan.org/wp-content/uploads/2023/12/PTMT-8-09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BUTVQtOC0wOS5qcGc=");
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-52-02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTUyLTAyLmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2023/12/PTMT-8-04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL1BUTVQtOC0wNC5qcGc=");
        // https://lunarscan.org/wp-content/uploads/2023/11/TLC-4-07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExL1RMQy00LTA3LmpwZw==");
    }
}

