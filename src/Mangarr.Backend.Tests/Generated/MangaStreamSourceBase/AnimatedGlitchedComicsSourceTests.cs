using System.Collections;

namespace Mangarr.Backend.Tests;

public class AnimatedGlitchedComicsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "animatedglitchedcomics";

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
        // https://agscomics.com?p=2298
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjI5OHwyMjk4");
        // https://agscomics.com?p=2249
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjI0OXwyMjQ5");
        // https://agscomics.com?p=2226
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjIyNnwyMjI2");
        // https://agscomics.com?p=2106
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MjEwNnwyMTA2");
        // https://agscomics.com?p=1676
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTY3NnwxNjc2");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItMTAvfGh0dHBzOi8vYWdzY29taWNzLmNvbT9wPTE2NzZ8MTA=");
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItMi98aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTY3Nnwy");
        // https://agscomics.com/the-peaceful-travel-diaries-of-the-boy-raised-by-holy-beasts-enjoying-my-slow-life-with-my-friends-using-the-cheat-magic-i-received-from-god-chapter-1-1/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1wZWFjZWZ1bC10cmF2ZWwtZGlhcmllcy1vZi10aGUtYm95LXJhaXNlZC1ieS1ob2x5LWJlYXN0cy1lbmpveWluZy1teS1zbG93LWxpZmUtd2l0aC1teS1mcmllbmRzLXVzaW5nLXRoZS1jaGVhdC1tYWdpYy1pLXJlY2VpdmVkLWZyb20tZ29kLWNoYXB0ZXItMS0xL3xodHRwczovL2Fnc2NvbWljcy5jb20/cD0yMjI2fDEuMQ==");
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItMS98aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTY3Nnwx");
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItMy98aHR0cHM6Ly9hZ3Njb21pY3MuY29tP3A9MTY3Nnwz");
    }

    public static IEnumerable ValidImages()
    {
        // http://agscomics.com/wp-content/uploads/2023/12/08-5.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDgtNS5qcGc=");
        // http://agscomics.com/wp-content/uploads/2024/01/10.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMTAuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/028.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDI4LmpwZw==");
        // http://agscomics.com/wp-content/uploads/2023/12/013.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEzLmpwZw==");
        // http://agscomics.com/wp-content/uploads/2023/12/013-6.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDEzLTYuanBn");
    }
}

