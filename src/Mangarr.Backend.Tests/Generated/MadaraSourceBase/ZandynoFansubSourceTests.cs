using System.Collections;

namespace Mangarr.Backend.Tests;

public class ZandynoFansubSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "zandynofansub";

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
        // https://zandynofansub.aishiteru.org/series/kurikaeshi-ai-no-oto/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL2t1cmlrYWVzaGktYWktbm8tb3RvLw==");
        // https://zandynofansub.aishiteru.org/series/we-started-living-together/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3dlLXN0YXJ0ZWQtbGl2aW5nLXRvZ2V0aGVyLw==");
        // https://zandynofansub.aishiteru.org/series/tama-ni-wa-onsen-demo/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3RhbWEtbmktd2Etb25zZW4tZGVtby8=");
        // https://zandynofansub.aishiteru.org/series/sayonara-lazy-days/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3NheW9uYXJhLWxhenktZGF5cy8=");
        // https://zandynofansub.aishiteru.org/series/rot-off-and-drop-away/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3JvdC1vZmYtYW5kLWRyb3AtYXdheS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://zandynofansub.aishiteru.org/series/rot-off-and-drop-away/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3JvdC1vZmYtYW5kLWRyb3AtYXdheS9vbmVzaG90Lw==");
        // https://zandynofansub.aishiteru.org/series/kurikaeshi-ai-no-oto/volume-1/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL2t1cmlrYWVzaGktYWktbm8tb3RvL3ZvbHVtZS0xL2NoYXB0ZXItMS8=");
        // https://zandynofansub.aishiteru.org/series/we-started-living-together/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3dlLXN0YXJ0ZWQtbGl2aW5nLXRvZ2V0aGVyL29uZXNob3Qv");
        // https://zandynofansub.aishiteru.org/series/sayonara-lazy-days/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3NheW9uYXJhLWxhenktZGF5cy9vbmVzaG90Lw==");
        // https://zandynofansub.aishiteru.org/series/tama-ni-wa-onsen-demo/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvc2VyaWVzL3RhbWEtbmktd2Etb25zZW4tZGVtby9vbmVzaG90Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://zandynofansub.aishiteru.org/wp-content/uploads/WP-manga/data/manga_629eb7b6cb015/52c4f172652a960db10243630df21037/01.png
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjI5ZWI3YjZjYjAxNS81MmM0ZjE3MjY1MmE5NjBkYjEwMjQzNjMwZGYyMTAzNy8wMS5wbmc=");
        // https://zandynofansub.aishiteru.org/wp-content/uploads/WP-manga/data/manga_629ec571b8732/d4207a95355b08b876296e1d56972927/16.jpg
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjI5ZWM1NzFiODczMi9kNDIwN2E5NTM1NWIwOGI4NzYyOTZlMWQ1Njk3MjkyNy8xNi5qcGc=");
        // https://zandynofansub.aishiteru.org/wp-content/uploads/WP-manga/data/manga_629eb6a29bcaf/fa0e4aeae6fc070472822b4255594ac1/12.png
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjI5ZWI2YTI5YmNhZi9mYTBlNGFlYWU2ZmMwNzA0NzI4MjJiNDI1NTU5NGFjMS8xMi5wbmc=");
        // https://zandynofansub.aishiteru.org/wp-content/uploads/WP-manga/data/manga_629eb7b6cb015/52c4f172652a960db10243630df21037/47.png
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjI5ZWI3YjZjYjAxNS81MmM0ZjE3MjY1MmE5NjBkYjEwMjQzNjMwZGYyMTAzNy80Ny5wbmc=");
        // https://zandynofansub.aishiteru.org/wp-content/uploads/WP-manga/data/manga_629eb6a29bcaf/fa0e4aeae6fc070472822b4255594ac1/24.png
        yield return new TestCaseData("aHR0cHM6Ly96YW5keW5vZmFuc3ViLmFpc2hpdGVydS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjI5ZWI2YTI5YmNhZi9mYTBlNGFlYWU2ZmMwNzA0NzI4MjJiNDI1NTU5NGFjMS8yNC5wbmc=");
    }
}

