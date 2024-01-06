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
        // https://nightscans.net?p=64712
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY0NzEyfDY0NzEy");
        // https://nightscans.net?p=68388
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY4Mzg4fDY4Mzg4");
        // https://nightscans.net?p=65611
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY1NjExfDY1NjEx");
        // https://nightscans.net?p=69159
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY5MTU5fDY5MTU5");
        // https://nightscans.net?p=66206
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldD9wPTY2MjA2fDY2MjA2");
    }

    public static IEnumerable ValidImages()
    {
        // https://nightscans.net/wp-content/uploads/2023/12/RATHMD_Chapter-00_00.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9SQVRITURfQ2hhcHRlci0wMF8wMC53ZWJw");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-07_11.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTA3XzExLndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/SB_Chapter-07_01.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9TQl9DaGFwdGVyLTA3XzAxLndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/MPSAI_Chapter-06_02.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9NUFNBSV9DaGFwdGVyLTA2XzAyLndlYnA=");
        // https://nightscans.net/wp-content/uploads/2023/12/MPSAI_Chapter-06_01.webp
        yield return new TestCaseData("aHR0cHM6Ly9uaWdodHNjYW5zLm5ldC93cC1jb250ZW50L3VwbG9hZHMvMjAyMy8xMi9NUFNBSV9DaGFwdGVyLTA2XzAxLndlYnA=");
    }
}

