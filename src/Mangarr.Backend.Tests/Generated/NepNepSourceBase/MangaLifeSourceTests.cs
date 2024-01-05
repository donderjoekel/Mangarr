using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaLifeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangalife";

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
        // https://manga4life.com/manga/Killstagram
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9tYW5nYS9LaWxsc3RhZ3JhbXxLaWxsc3RhZ3JhbQ==");
        // https://manga4life.com/manga/Tic-Neesan
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9tYW5nYS9UaWMtTmVlc2FufFRpYy1OZWVzYW4=");
        // https://manga4life.com/manga/Anima
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9tYW5nYS9BbmltYXxBbmltYQ==");
        // https://manga4life.com/manga/C-Sword-And-Cornett
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9tYW5nYS9DLVN3b3JkLUFuZC1Db3JuZXR0fEMtU3dvcmQtQW5kLUNvcm5ldHQ=");
        // https://manga4life.com/manga/1-nen-A-gumi-No-Monster
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9tYW5nYS8xLW5lbi1BLWd1bWktTm8tTW9uc3RlcnwxLW5lbi1BLWd1bWktTm8tTW9uc3Rlcg==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manga4life.com/read-online/Killstagram-chapter-36.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9yZWFkLW9ubGluZS9LaWxsc3RhZ3JhbS1jaGFwdGVyLTM2Lmh0bWx8S2lsbHN0YWdyYW0=");
        // https://manga4life.com/read-online/Tic-Neesan-chapter-96.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9yZWFkLW9ubGluZS9UaWMtTmVlc2FuLWNoYXB0ZXItOTYuaHRtbHxUaWMtTmVlc2Fu");
        // https://manga4life.com/read-online/Tic-Neesan-chapter-75.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9yZWFkLW9ubGluZS9UaWMtTmVlc2FuLWNoYXB0ZXItNzUuaHRtbHxUaWMtTmVlc2Fu");
        // https://manga4life.com/read-online/C-Sword-And-Cornett-chapter-8.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9yZWFkLW9ubGluZS9DLVN3b3JkLUFuZC1Db3JuZXR0LWNoYXB0ZXItOC5odG1sfEMtU3dvcmQtQW5kLUNvcm5ldHQ=");
        // https://manga4life.com/read-online/Tic-Neesan-chapter-90.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTRsaWZlLmNvbS9yZWFkLW9ubGluZS9UaWMtTmVlc2FuLWNoYXB0ZXItOTAuaHRtbHxUaWMtTmVlc2Fu");
    }

    public static IEnumerable ValidImages()
    {
        // https://scans.lastation.us/manga/C-Sword-And-Cornett/0008-014.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvQy1Td29yZC1BbmQtQ29ybmV0dC8wMDA4LTAxNC5wbmc=");
        // https://scans.lastation.us/manga/C-Sword-And-Cornett/0008-016.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvQy1Td29yZC1BbmQtQ29ybmV0dC8wMDA4LTAxNi5wbmc=");
        // https://scans.lastation.us/manga/C-Sword-And-Cornett/0008-021.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvQy1Td29yZC1BbmQtQ29ybmV0dC8wMDA4LTAyMS5wbmc=");
        // https://official.lowee.us/manga/Killstagram/0036-086.png
        yield return new TestCaseData("aHR0cHM6Ly9vZmZpY2lhbC5sb3dlZS51cy9tYW5nYS9LaWxsc3RhZ3JhbS8wMDM2LTA4Ni5wbmc=");
        // https://official.lowee.us/manga/Killstagram/0036-039.png
        yield return new TestCaseData("aHR0cHM6Ly9vZmZpY2lhbC5sb3dlZS51cy9tYW5nYS9LaWxsc3RhZ3JhbS8wMDM2LTAzOS5wbmc=");
    }
}

