using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaSeeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangasee";

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
        // https://mangasee123.com/manga/Killstagram
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vbWFuZ2EvS2lsbHN0YWdyYW18S2lsbHN0YWdyYW0=");
        // https://mangasee123.com/manga/Tic-Neesan
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vbWFuZ2EvVGljLU5lZXNhbnxUaWMtTmVlc2Fu");
        // https://mangasee123.com/manga/Anima
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vbWFuZ2EvQW5pbWF8QW5pbWE=");
        // https://mangasee123.com/manga/C-Sword-And-Cornett
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vbWFuZ2EvQy1Td29yZC1BbmQtQ29ybmV0dHxDLVN3b3JkLUFuZC1Db3JuZXR0");
        // https://mangasee123.com/manga/1-nen-A-gumi-No-Monster
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vbWFuZ2EvMS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXJ8MS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXI=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangasee123.com/read-online/Tic-Neesan-chapter-78.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vcmVhZC1vbmxpbmUvVGljLU5lZXNhbi1jaGFwdGVyLTc4Lmh0bWx8VGljLU5lZXNhbg==");
        // https://mangasee123.com/read-online/C-Sword-And-Cornett-chapter-42.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vcmVhZC1vbmxpbmUvQy1Td29yZC1BbmQtQ29ybmV0dC1jaGFwdGVyLTQyLmh0bWx8Qy1Td29yZC1BbmQtQ29ybmV0dA==");
        // https://mangasee123.com/read-online/1-nen-A-gumi-No-Monster-chapter-44.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vcmVhZC1vbmxpbmUvMS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXItY2hhcHRlci00NC5odG1sfDEtbmVuLUEtZ3VtaS1Oby1Nb25zdGVy");
        // https://mangasee123.com/read-online/C-Sword-And-Cornett-chapter-14.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vcmVhZC1vbmxpbmUvQy1Td29yZC1BbmQtQ29ybmV0dC1jaGFwdGVyLTE0Lmh0bWx8Qy1Td29yZC1BbmQtQ29ybmV0dA==");
        // https://mangasee123.com/read-online/1-nen-A-gumi-No-Monster-chapter-30.html
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXNlZTEyMy5jb20vcmVhZC1vbmxpbmUvMS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXItY2hhcHRlci0zMC5odG1sfDEtbmVuLUEtZ3VtaS1Oby1Nb25zdGVy");
    }

    public static IEnumerable ValidImages()
    {
        // https://scans.lastation.us/manga/1-nen-A-gumi-No-Monster/0030-003.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvMS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXIvMDAzMC0wMDMucG5n");
        // https://scans.lastation.us/manga/1-nen-A-gumi-No-Monster/0044-020.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvMS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXIvMDA0NC0wMjAucG5n");
        // https://scans.lastation.us/manga/C-Sword-And-Cornett/0014-013.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvQy1Td29yZC1BbmQtQ29ybmV0dC8wMDE0LTAxMy5wbmc=");
        // https://scans.lastation.us/manga/1-nen-A-gumi-No-Monster/0030-002.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvMS1uZW4tQS1ndW1pLU5vLU1vbnN0ZXIvMDAzMC0wMDIucG5n");
        // https://scans.lastation.us/manga/C-Sword-And-Cornett/0014-019.png
        yield return new TestCaseData("aHR0cHM6Ly9zY2Fucy5sYXN0YXRpb24udXMvbWFuZ2EvQy1Td29yZC1BbmQtQ29ybmV0dC8wMDE0LTAxOS5wbmc=");
    }
}

