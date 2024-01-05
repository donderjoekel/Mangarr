using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuagaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuaga";

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
        // https://manhuaga.com/manga/my-7-wives-are-forcing-me-to-die/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvbXktNy13aXZlcy1hcmUtZm9yY2luZy1tZS10by1kaWUv");
        // https://manhuaga.com/manga/rule-as-a-monarch-under-the-skirts/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvcnVsZS1hcy1hLW1vbmFyY2gtdW5kZXItdGhlLXNraXJ0cy8=");
        // https://manhuaga.com/manga/cursed-by-heaven-instead-i-become-stronger/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvY3Vyc2VkLWJ5LWhlYXZlbi1pbnN0ZWFkLWktYmVjb21lLXN0cm9uZ2VyLw==");
        // https://manhuaga.com/manga/my-girlfriend-is-a-wicked-lady/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvbXktZ2lybGZyaWVuZC1pcy1hLXdpY2tlZC1sYWR5Lw==");
        // https://manhuaga.com/manga/ill-pay-for-your-life-lets-both-go-crazy-together/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvaWxsLXBheS1mb3IteW91ci1saWZlLWxldHMtYm90aC1nby1jcmF6eS10b2dldGhlci8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuaga.com/manga/cursed-by-heaven-instead-i-become-stronger/chapter-33/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvY3Vyc2VkLWJ5LWhlYXZlbi1pbnN0ZWFkLWktYmVjb21lLXN0cm9uZ2VyL2NoYXB0ZXItMzMv");
        // https://manhuaga.com/manga/rule-as-a-monarch-under-the-skirts/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvcnVsZS1hcy1hLW1vbmFyY2gtdW5kZXItdGhlLXNraXJ0cy9jaGFwdGVyLTE4Lw==");
        // https://manhuaga.com/manga/rule-as-a-monarch-under-the-skirts/chapter-28/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvcnVsZS1hcy1hLW1vbmFyY2gtdW5kZXItdGhlLXNraXJ0cy9jaGFwdGVyLTI4Lw==");
        // https://manhuaga.com/manga/cursed-by-heaven-instead-i-become-stronger/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvY3Vyc2VkLWJ5LWhlYXZlbi1pbnN0ZWFkLWktYmVjb21lLXN0cm9uZ2VyL2NoYXB0ZXItMTAv");
        // https://manhuaga.com/manga/rule-as-a-monarch-under-the-skirts/chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vbWFuZ2EvcnVsZS1hcy1hLW1vbmFyY2gtdW5kZXItdGhlLXNraXJ0cy9jaGFwdGVyLTEyLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://manhuaga.com/wp-content/uploads/WP-manga/data/manga_6594ca20e14fd/049ee8baa22061a5660e9f84da64db1b/5-MOnxWQGBKo953.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NGNhMjBlMTRmZC8wNDllZThiYWEyMjA2MWE1NjYwZTlmODRkYTY0ZGIxYi81LU1PbnhXUUdCS285NTMuanBn");
        // https://manhuaga.com/wp-content/uploads/WP-manga/data/manga_6594ca20e14fd/066566d1218f5c7e8d8f5fc351ac6794/3-iyZmC5GTmti32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NGNhMjBlMTRmZC8wNjY1NjZkMTIxOGY1YzdlOGQ4ZjVmYzM1MWFjNjc5NC8zLWl5Wm1DNUdUbXRpMzIuanBn");
        // https://manhuaga.com/wp-content/uploads/WP-manga/data/manga_6565cab298b5f/a32b2dd9b01ab8a3c8f1273d0d0a7398/7-sCcQumWXO94Pm.png
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU2NWNhYjI5OGI1Zi9hMzJiMmRkOWIwMWFiOGEzYzhmMTI3M2QwZDBhNzM5OC83LXNDY1F1bVdYTzk0UG0ucG5n");
        // https://manhuaga.com/wp-content/uploads/WP-manga/data/manga_6565cab298b5f/9a5d92b64c30cdee6ed966b387d32408/3-InDSl71ovIB-X.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU2NWNhYjI5OGI1Zi85YTVkOTJiNjRjMzBjZGVlNmVkOTY2YjM4N2QzMjQwOC8zLUluRFNsNzFvdklCLVguanBn");
        // https://manhuaga.com/wp-content/uploads/WP-manga/data/manga_6594ca20e14fd/049ee8baa22061a5660e9f84da64db1b/8-qo6Pnk5xeTyzQ.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFnYS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NGNhMjBlMTRmZC8wNDllZThiYWEyMjA2MWE1NjYwZTlmODRkYTY0ZGIxYi84LXFvNlBuazV4ZVR5elEuanBn");
    }
}

