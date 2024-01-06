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
        // https://nightscans.net?p=68017
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY4MDE3fDY4MDE3");
        // https://nightscans.net?p=66108
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY2MTA4fDY2MTA4");
        // https://nightscans.net?p=65136
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY1MTM2fDY1MTM2");
        // https://nightscans.net?p=64707
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY0NzA3fDY0NzA3");
        // https://nightscans.net?p=62920
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTYyOTIwfDYyOTIw");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://nightscans.net/strongest-player-returns-after-a-thousand-years-chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zdHJvbmdlc3QtcGxheWVyLXJldHVybnMtYWZ0ZXItYS10aG91c2FuZC15ZWFycy1jaGFwdGVyLTEyL3xodHRwczovL25pZ2h0c2NhbnMubmV0P3A9NjQ3MDd8MTI=");
        // https://nightscans.net/sword-breaker-chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zd29yZC1icmVha2VyLWNoYXB0ZXItMjAvfGh0dHBzOi8vbmlnaHRzY2Fucy5uZXQ/cD02NTEzNnwyMA==");
        // https://nightscans.net/strongest-player-returns-after-a-thousand-years-chapter-15/
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC9zdHJvbmdlc3QtcGxheWVyLXJldHVybnMtYWZ0ZXItYS10aG91c2FuZC15ZWFycy1jaGFwdGVyLTE1L3xodHRwczovL25pZ2h0c2NhbnMubmV0P3A9NjQ3MDd8MTU=");
    }

    public static IEnumerable ValidImages()
    {
        // https://nightscans.net/wp-content/uploads/2023/12/SPRAATY_Chapter-12_10.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TUFJBQVRZX0NoYXB0ZXItMTJfMTAud2VicA==");
        // https://nightscans.net/wp-content/uploads/2023/12/SPRAATY_Chapter-15_11.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TUFJBQVRZX0NoYXB0ZXItMTVfMTEud2VicA==");
        // https://nightscans.net/wp-content/uploads/2023/12/SPRAATY_Chapter-15_06.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TUFJBQVRZX0NoYXB0ZXItMTVfMDYud2VicA==");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-20_16.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTIwXzE2LndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-20_06.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTIwXzA2LndlYnA=");
    }
}

