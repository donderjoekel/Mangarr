using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaryuSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaryu";

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
        // https://mangaryu.com/manga/nameless/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvbmFtZWxlc3Mv");
        // https://mangaryu.com/manga/the-lady-and-the-beast/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvdGhlLWxhZHktYW5kLXRoZS1iZWFzdC8=");
        // https://mangaryu.com/manga/devil-at-the-crossroads/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvZGV2aWwtYXQtdGhlLWNyb3Nzcm9hZHMv");
        // https://mangaryu.com/manga/deliverance_of_the_counterattack/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvZGVsaXZlcmFuY2Vfb2ZfdGhlX2NvdW50ZXJhdHRhY2sv");
        // https://mangaryu.com/manga/half-of-me/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvaGFsZi1vZi1tZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaryu.com/manga/half-of-me/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvaGFsZi1vZi1tZS9jaGFwdGVyLTE5Lw==");
        // https://mangaryu.com/manga/deliverance_of_the_counterattack/chapter-146/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvZGVsaXZlcmFuY2Vfb2ZfdGhlX2NvdW50ZXJhdHRhY2svY2hhcHRlci0xNDYv");
        // https://mangaryu.com/manga/the-lady-and-the-beast/chapter-36/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvdGhlLWxhZHktYW5kLXRoZS1iZWFzdC9jaGFwdGVyLTM2Lw==");
        // https://mangaryu.com/manga/deliverance_of_the_counterattack/chapter-44/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvZGVsaXZlcmFuY2Vfb2ZfdGhlX2NvdW50ZXJhdHRhY2svY2hhcHRlci00NC8=");
        // https://mangaryu.com/manga/deliverance_of_the_counterattack/chapter-144/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXJ5dS5jb20vbWFuZ2EvZGVsaXZlcmFuY2Vfb2ZfdGhlX2NvdW50ZXJhdHRhY2svY2hhcHRlci0xNDQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://image.mangaryu.com/deliverance-of-the-counterattack/chapter-146/017.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5tYW5nYXJ5dS5jb20vZGVsaXZlcmFuY2Utb2YtdGhlLWNvdW50ZXJhdHRhY2svY2hhcHRlci0xNDYvMDE3LmpwZw==");
        // https://image.mangaryu.com/half-of-me/chapter-19/009.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5tYW5nYXJ5dS5jb20vaGFsZi1vZi1tZS9jaGFwdGVyLTE5LzAwOS5qcGc=");
        // https://image.mangaryu.com/deliverance-of-the-counterattack/chapter-144/003.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5tYW5nYXJ5dS5jb20vZGVsaXZlcmFuY2Utb2YtdGhlLWNvdW50ZXJhdHRhY2svY2hhcHRlci0xNDQvMDAzLmpwZw==");
        // https://image.mangaryu.com/deliverance-of-the-counterattack/chapter-146/051.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5tYW5nYXJ5dS5jb20vZGVsaXZlcmFuY2Utb2YtdGhlLWNvdW50ZXJhdHRhY2svY2hhcHRlci0xNDYvMDUxLmpwZw==");
        // https://image.mangaryu.com/wp-content/uploads/WP-manga/data/manga_64f8a6d5cc4a5/52b3d3e27b81a51166bad136a1a4a705/31.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5tYW5nYXJ5dS5jb20vd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjRmOGE2ZDVjYzRhNS81MmIzZDNlMjdiODFhNTExNjZiYWQxMzZhMWE0YTcwNS8zMS53ZWJw");
    }
}

