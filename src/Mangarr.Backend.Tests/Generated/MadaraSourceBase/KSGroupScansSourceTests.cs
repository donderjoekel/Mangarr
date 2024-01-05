using System.Collections;

namespace Mangarr.Backend.Tests;

public class KSGroupScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "ksgroupscans";

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
        // https://ksgroupscans.com/manga/welcome-to-the-ant-nest-dungeon/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3dlbGNvbWUtdG8tdGhlLWFudC1uZXN0LWR1bmdlb24v");
        // https://ksgroupscans.com/manga/kono-hi-itsuwari-no-yuusha-de-aru-ore-wa-shin-no-yuusha-de-aru-kare-wo-party-kara-tsuihou-shita/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL2tvbm8taGktaXRzdXdhcmktbm8teXV1c2hhLWRlLWFydS1vcmUtd2Etc2hpbi1uby15dXVzaGEtZGUtYXJ1LWthcmUtd28tcGFydHkta2FyYS10c3VpaG91LXNoaXRhLw==");
        // https://ksgroupscans.com/manga/botsuraku-yotei-no-kizoku-dakedo-himadatta-kara-mahou-wo-kiwamete-mita-chris-wa-goshujin-sama-ga-daisuki/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL2JvdHN1cmFrdS15b3RlaS1uby1raXpva3UtZGFrZWRvLWhpbWFkYXR0YS1rYXJhLW1haG91LXdvLWtpd2FtZXRlLW1pdGEtY2hyaXMtd2EtZ29zaHVqaW4tc2FtYS1nYS1kYWlzdWtpLw==");
        // https://ksgroupscans.com/manga/izumi-and-the-dragon-book/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL2l6dW1pLWFuZC10aGUtZHJhZ29uLWJvb2sv");
        // https://ksgroupscans.com/manga/saikyou-de-saisoku-no-mugen-level-up/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3NhaWt5b3UtZGUtc2Fpc29rdS1uby1tdWdlbi1sZXZlbC11cC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://ksgroupscans.com/manga/welcome-to-the-ant-nest-dungeon/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3dlbGNvbWUtdG8tdGhlLWFudC1uZXN0LWR1bmdlb24vY2hhcHRlci0xLw==");
        // https://ksgroupscans.com/manga/saikyou-de-saisoku-no-mugen-level-up/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3NhaWt5b3UtZGUtc2Fpc29rdS1uby1tdWdlbi1sZXZlbC11cC9jaGFwdGVyLTcv");
        // https://ksgroupscans.com/manga/welcome-to-the-ant-nest-dungeon/chapter-2-1/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3dlbGNvbWUtdG8tdGhlLWFudC1uZXN0LWR1bmdlb24vY2hhcHRlci0yLTEv");
        // https://ksgroupscans.com/manga/saikyou-de-saisoku-no-mugen-level-up/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3NhaWt5b3UtZGUtc2Fpc29rdS1uby1tdWdlbi1sZXZlbC11cC9jaGFwdGVyLTgv");
        // https://ksgroupscans.com/manga/saikyou-de-saisoku-no-mugen-level-up/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL21hbmdhL3NhaWt5b3UtZGUtc2Fpc29rdS1uby1tdWdlbi1sZXZlbC11cC9jaGFwdGVyLTQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://ksgroupscans.com/wp-content/uploads/WP-manga/data/manga_65354e9c59720/e8c5f20f7f27a0d9a47749c15dd725a4/27.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MzU0ZTljNTk3MjAvZThjNWYyMGY3ZjI3YTBkOWE0Nzc0OWMxNWRkNzI1YTQvMjcuanBn");
        // https://ksgroupscans.com/wp-content/uploads/WP-manga/data/manga_65354e9c59720/e8c5f20f7f27a0d9a47749c15dd725a4/32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MzU0ZTljNTk3MjAvZThjNWYyMGY3ZjI3YTBkOWE0Nzc0OWMxNWRkNzI1YTQvMzIuanBn");
        // https://ksgroupscans.com/wp-content/uploads/WP-manga/data/manga_65354e9c59720/e13be24dc2ab69cf7d8102dd093561a1/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MzU0ZTljNTk3MjAvZTEzYmUyNGRjMmFiNjljZjdkODEwMmRkMDkzNTYxYTEvMDQuanBn");
        // https://ksgroupscans.com/wp-content/uploads/WP-manga/data/manga_65354e9c59720/e8c5f20f7f27a0d9a47749c15dd725a4/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MzU0ZTljNTk3MjAvZThjNWYyMGY3ZjI3YTBkOWE0Nzc0OWMxNWRkNzI1YTQvMDEuanBn");
        // https://ksgroupscans.com/wp-content/uploads/WP-manga/data/manga_65354e9c59720/e13be24dc2ab69cf7d8102dd093561a1/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9rc2dyb3Vwc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MzU0ZTljNTk3MjAvZTEzYmUyNGRjMmFiNjljZjdkODEwMmRkMDkzNTYxYTEvMTAuanBn");
    }
}

