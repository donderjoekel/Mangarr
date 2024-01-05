using System.Collections;

namespace Mangarr.Backend.Tests;

public class TheBlankScanlationSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "theblankscanlation";

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
        // https://theblank.net/manga/romance-camping/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evcm9tYW5jZS1jYW1waW5nLw==");
        // https://theblank.net/manga/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evbm90LWF0LXdvcmsv");
        // https://theblank.net/manga/osaka/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evb3Nha2Ev");
        // https://theblank.net/manga/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2EvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://theblank.net/manga/after-work-love-affairs/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2EvYWZ0ZXItd29yay1sb3ZlLWFmZmFpcnMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://theblank.net/manga/osaka/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evb3Nha2EvY2hhcHRlci03Lw==");
        // https://theblank.net/manga/after-work-love-affairs/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2EvYWZ0ZXItd29yay1sb3ZlLWFmZmFpcnMvY2hhcHRlci0xLw==");
        // https://theblank.net/manga/osaka/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evb3Nha2EvY2hhcHRlci0yNS8=");
        // https://theblank.net/manga/osaka/chapter-19/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evb3Nha2EvY2hhcHRlci0xOS8=");
        // https://theblank.net/manga/not-at-work/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvbWFuZ2Evbm90LWF0LXdvcmsvY2hhcHRlci0xLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://theblank.net/wp-content/uploads/WP-manga/data/manga_65941adb70e9d/f91e7e4e465380317a6cf80b3373650f/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDFhZGI3MGU5ZC9mOTFlN2U0ZTQ2NTM4MDMxN2E2Y2Y4MGIzMzczNjUwZi8wOS5qcGc=");
        // https://theblank.net/wp-content/uploads/WP-manga/data/manga_65941adb70e9d/f91e7e4e465380317a6cf80b3373650f/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDFhZGI3MGU5ZC9mOTFlN2U0ZTQ2NTM4MDMxN2E2Y2Y4MGIzMzczNjUwZi8xMC5qcGc=");
        // https://theblank.net/wp-content/uploads/WP-manga/data/manga_65941adb70e9d/f91e7e4e465380317a6cf80b3373650f/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDFhZGI3MGU5ZC9mOTFlN2U0ZTQ2NTM4MDMxN2E2Y2Y4MGIzMzczNjUwZi8wOC5qcGc=");
        // https://theblank.net/wp-content/uploads/WP-manga/data/manga_65941adb70e9d/f91e7e4e465380317a6cf80b3373650f/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDFhZGI3MGU5ZC9mOTFlN2U0ZTQ2NTM4MDMxN2E2Y2Y4MGIzMzczNjUwZi8wNS5qcGc=");
        // https://theblank.net/wp-content/uploads/WP-manga/data/manga_65941adb70e9d/1e4b8a25b441cbc88a8d62d4d0e3aedc/15.jpg
        yield return new TestCaseData("aHR0cHM6Ly90aGVibGFuay5uZXQvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU5NDFhZGI3MGU5ZC8xZTRiOGEyNWI0NDFjYmM4OGE4ZDYyZDRkMGUzYWVkYy8xNS5qcGc=");
    }
}

