using System.Collections;

namespace Mangarr.Backend.Tests;

public class ZeroScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "zeroscans";

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
        // https://zeroscans.com/comics/second-life-ranker
        yield return new TestCaseData("aHR0cHM6Ly96ZXJvc2NhbnMuY29tL2NvbWljcy9zZWNvbmQtbGlmZS1yYW5rZXJ8c2Vjb25kLWxpZmUtcmFua2VyfDc=");
        // https://zeroscans.com/comics/loyal-sword
        yield return new TestCaseData("aHR0cHM6Ly96ZXJvc2NhbnMuY29tL2NvbWljcy9sb3lhbC1zd29yZHxsb3lhbC1zd29yZHw4Ng==");
        // https://zeroscans.com/comics/the-undefeatable-swordsman
        yield return new TestCaseData("aHR0cHM6Ly96ZXJvc2NhbnMuY29tL2NvbWljcy90aGUtdW5kZWZlYXRhYmxlLXN3b3Jkc21hbnx0aGUtdW5kZWZlYXRhYmxlLXN3b3Jkc21hbnw2Mw==");
        // https://zeroscans.com/comics/fist-demon-of-mount-hua
        yield return new TestCaseData("aHR0cHM6Ly96ZXJvc2NhbnMuY29tL2NvbWljcy9maXN0LWRlbW9uLW9mLW1vdW50LWh1YXxmaXN0LWRlbW9uLW9mLW1vdW50LWh1YXwyNQ==");
        // https://zeroscans.com/comics/hero-i-quit-a-long-time-ago-hero-return
        yield return new TestCaseData("aHR0cHM6Ly96ZXJvc2NhbnMuY29tL2NvbWljcy9oZXJvLWktcXVpdC1hLWxvbmctdGltZS1hZ28taGVyby1yZXR1cm58aGVyby1pLXF1aXQtYS1sb25nLXRpbWUtYWdvLWhlcm8tcmV0dXJufDg=");
    }

    public static IEnumerable ValidPageLists()
    {
        // second-life-ranker/5462
        yield return new TestCaseData("c2Vjb25kLWxpZmUtcmFua2VyLzU0NjI=");
        // fist-demon-of-mount-hua/2059
        yield return new TestCaseData("ZmlzdC1kZW1vbi1vZi1tb3VudC1odWEvMjA1OQ==");
        // fist-demon-of-mount-hua/2017
        yield return new TestCaseData("ZmlzdC1kZW1vbi1vZi1tb3VudC1odWEvMjAxNw==");
        // the-undefeatable-swordsman/4784
        yield return new TestCaseData("dGhlLXVuZGVmZWF0YWJsZS1zd29yZHNtYW4vNDc4NA==");
        // hero-i-quit-a-long-time-ago-hero-return/829
        yield return new TestCaseData("aGVyby1pLXF1aXQtYS1sb25nLXRpbWUtYWdvLWhlcm8tcmV0dXJuLzgyOQ==");
    }

    public static IEnumerable ValidImages()
    {
        // https://api.zeroscans.com/storage/100251/SNxzKmz4YfBYevbQ0hNQANhf2DifsV5muRGhL4Xb2.png
        yield return new TestCaseData("aHR0cHM6Ly9hcGkuemVyb3NjYW5zLmNvbS9zdG9yYWdlLzEwMDI1MS9TTnh6S216NFlmQllldmJRMGhOUUFOaGYyRGlmc1Y1bXVSR2hMNFhiMi5wbmc=");
        // https://api.zeroscans.com/storage/31453/88efbccaa719785c50a02e5d3cf45c27.png
        yield return new TestCaseData("aHR0cHM6Ly9hcGkuemVyb3NjYW5zLmNvbS9zdG9yYWdlLzMxNDUzLzg4ZWZiY2NhYTcxOTc4NWM1MGEwMmU1ZDNjZjQ1YzI3LnBuZw==");
        // https://api.zeroscans.com/storage/31451/a6555a8142094defe4ecde5e6c6328b0.png
        yield return new TestCaseData("aHR0cHM6Ly9hcGkuemVyb3NjYW5zLmNvbS9zdG9yYWdlLzMxNDUxL2E2NTU1YTgxNDIwOTRkZWZlNGVjZGU1ZTZjNjMyOGIwLnBuZw==");
        // https://api.zeroscans.com/storage/78944/m7Cwxt7JMR1EYga6YaAmVW3s0pYno0FQ4GkCxCN12.png
        yield return new TestCaseData("aHR0cHM6Ly9hcGkuemVyb3NjYW5zLmNvbS9zdG9yYWdlLzc4OTQ0L203Q3d4dDdKTVIxRVlnYTZZYUFtVlczczBwWW5vMEZRNEdrQ3hDTjEyLnBuZw==");
        // https://api.zeroscans.com/storage/78932/e1Y2lw4V86q0tca47CzvEHNMBfUmVnuHaTeHUY6g1.png
        yield return new TestCaseData("aHR0cHM6Ly9hcGkuemVyb3NjYW5zLmNvbS9zdG9yYWdlLzc4OTMyL2UxWTJsdzRWODZxMHRjYTQ3Q3p2RUhOTUJmVW1WbnVIYVRlSFVZNmcxLnBuZw==");
    }
}

