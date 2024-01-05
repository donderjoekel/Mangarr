using System.Collections;

namespace Mangarr.Backend.Tests;

public class NightScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "nightscans";

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
        // https://nightscans.net/series/full-time-swordsman/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zZXJpZXMvZnVsbC10aW1lLXN3b3Jkc21hbi8=");
        // https://nightscans.net/series/reborn-as-the-heavenly-martial-demon/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zZXJpZXMvcmVib3JuLWFzLXRoZS1oZWF2ZW5seS1tYXJ0aWFsLWRlbW9uLw==");
        // https://nightscans.net/series/sword-breaker/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zZXJpZXMvc3dvcmQtYnJlYWtlci8=");
        // https://nightscans.net/series/strongest-player-returns-after-a-thousand-years/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zZXJpZXMvc3Ryb25nZXN0LXBsYXllci1yZXR1cm5zLWFmdGVyLWEtdGhvdXNhbmQteWVhcnMv");
        // https://nightscans.net/series/my-passive-skills-are-invincible/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zZXJpZXMvbXktcGFzc2l2ZS1za2lsbHMtYXJlLWludmluY2libGUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://nightscans.net/sword-breaker-chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zd29yZC1icmVha2VyLWNoYXB0ZXItMTIv");
        // https://nightscans.net/sword-breaker-chapter-02/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zd29yZC1icmVha2VyLWNoYXB0ZXItMDIv");
        // https://nightscans.net/my-passive-skills-are-invincible-chapter-02/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9teS1wYXNzaXZlLXNraWxscy1hcmUtaW52aW5jaWJsZS1jaGFwdGVyLTAyLw==");
        // https://nightscans.net/sword-breaker-chapter-14/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zd29yZC1icmVha2VyLWNoYXB0ZXItMTQv");
        // https://nightscans.net/sword-breaker-chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zd29yZC1icmVha2VyLWNoYXB0ZXItMTAv");
    }

    public static IEnumerable ValidImages()
    {
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-10_07.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTEwXzA3LndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/11/Passive-skills_17_ch02.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMS9QYXNzaXZlLXNraWxsc18xN19jaDAyLndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-10_06.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTEwXzA2LndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-10_08.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTEwXzA4LndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-14_15.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTE0XzE1LndlYnA=");
    }
}

