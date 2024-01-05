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
        // https://lunarscan.org/series/corruption-obscene-tales/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3Nlcmllcy9jb3JydXB0aW9uLW9ic2NlbmUtdGFsZXMv");
        // https://lunarscan.org/series/pervert-addiction/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3Nlcmllcy9wZXJ2ZXJ0LWFkZGljdGlvbi8=");
        // https://lunarscan.org/series/a-gift/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3Nlcmllcy9hLWdpZnQv");
        // https://lunarscan.org/series/could-you-please-touch-me-there/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3Nlcmllcy9jb3VsZC15b3UtcGxlYXNlLXRvdWNoLW1lLXRoZXJlLw==");
        // https://lunarscan.org/series/im-the-leader-of-a-cult/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3Nlcmllcy9pbS10aGUtbGVhZGVyLW9mLWEtY3VsdC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://lunarscan.org/could-you-please-touch-me-there-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUtY2hhcHRlci01Lw==");
        // https://lunarscan.org/im-the-leader-of-a-cult-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL2ltLXRoZS1sZWFkZXItb2YtYS1jdWx0LWNoYXB0ZXItNy8=");
        // https://lunarscan.org/pervert-addiction-chapter-43/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3BlcnZlcnQtYWRkaWN0aW9uLWNoYXB0ZXItNDMv");
        // https://lunarscan.org/pervert-addiction-chapter-41/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3BlcnZlcnQtYWRkaWN0aW9uLWNoYXB0ZXItNDEv");
        // https://lunarscan.org/could-you-please-touch-me-there-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL2NvdWxkLXlvdS1wbGVhc2UtdG91Y2gtbWUtdGhlcmUtY2hhcHRlci0zLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://lunarscan.org/wp-content/uploads/2023/11/TLC-7-06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExL1RMQy03LTA2LmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2023/11/PTMT-3-02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExL1BUTVQtMy0wMi5qcGc=");
        // https://lunarscan.org/wp-content/uploads/2023/11/PTMT-3-07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzExL1BUTVQtMy0wNy5qcGc=");
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-41-03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTQxLTAzLmpwZw==");
        // https://lunarscan.org/wp-content/uploads/2024/01/PA-41-02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sdW5hcnNjYW4ub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDI0LzAxL1BBLTQxLTAyLmpwZw==");
    }
}

