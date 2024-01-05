using System.Collections;

namespace Mangarr.Backend.Tests;

public class xCaliBRScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "xcalibrscans";

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
        // https://xcalibrscans.com/webcomics/manga/keep-a-low-profile-sect-leader/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dlYmNvbWljcy9tYW5nYS9rZWVwLWEtbG93LXByb2ZpbGUtc2VjdC1sZWFkZXIv");
        // https://xcalibrscans.com/webcomics/manga/the-strongest-emperor-god-resets-his-worthless-life/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dlYmNvbWljcy9tYW5nYS90aGUtc3Ryb25nZXN0LWVtcGVyb3ItZ29kLXJlc2V0cy1oaXMtd29ydGhsZXNzLWxpZmUv");
        // https://xcalibrscans.com/webcomics/manga/earthlings-are-insane/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dlYmNvbWljcy9tYW5nYS9lYXJ0aGxpbmdzLWFyZS1pbnNhbmUv");
        // https://xcalibrscans.com/webcomics/manga/am-i-invincible/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dlYmNvbWljcy9tYW5nYS9hbS1pLWludmluY2libGUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://xcalibrscans.com/earthlings-are-insane-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2VhcnRobGluZ3MtYXJlLWluc2FuZS1jaGFwdGVyLTEv");
        // https://xcalibrscans.com/the-strongest-emperor-god-resets-his-worthless-life-chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3RoZS1zdHJvbmdlc3QtZW1wZXJvci1nb2QtcmVzZXRzLWhpcy13b3J0aGxlc3MtbGlmZS1jaGFwdGVyLTkv");
        // https://xcalibrscans.com/keep-a-low-profile-sect-leader-chapter-187/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2tlZXAtYS1sb3ctcHJvZmlsZS1zZWN0LWxlYWRlci1jaGFwdGVyLTE4Ny8=");
        // https://xcalibrscans.com/earthlings-are-insane-chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2VhcnRobGluZ3MtYXJlLWluc2FuZS1jaGFwdGVyLTIyLw==");
        // https://xcalibrscans.com/earthlings-are-insane-chapter-51/
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL2VhcnRobGluZ3MtYXJlLWluc2FuZS1jaGFwdGVyLTUxLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://xcalibrscans.com/wp-content/uploads/assets/LOW/LOW_187/LOW_1.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvTE9XL0xPV18xODcvTE9XXzEuanBn");
        // https://xcalibrscans.com/wp-content/uploads/assets/LOW/LOW_187/LOW_8.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvTE9XL0xPV18xODcvTE9XXzguanBn");
        // https://xcalibrscans.com/wp-content/uploads/assets/EAI/EAI_01_14cf9bF6dC385ebaA179d614c7e7dA6B/EAI_01_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvRUFJL0VBSV8wMV8xNGNmOWJGNmRDMzg1ZWJhQTE3OWQ2MTRjN2U3ZEE2Qi9FQUlfMDFfNS5qcGc=");
        // https://xcalibrscans.com/wp-content/uploads/assets/LOW/LOW_187/LOW_6.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvTE9XL0xPV18xODcvTE9XXzYuanBn");
        // https://xcalibrscans.com/wp-content/uploads/assets/EAI/EAI_22_h6c5D14a007921B6833c3e1c84313ca8/EAI_22_5.jpg
        yield return new TestCaseData("aHR0cHM6Ly94Y2FsaWJyc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9hc3NldHMvRUFJL0VBSV8yMl9oNmM1RDE0YTAwNzkyMUI2ODMzYzNlMWM4NDMxM2NhOC9FQUlfMjJfNS5qcGc=");
    }
}

