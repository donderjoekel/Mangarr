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
        // https://agscomics.com/series/the-banished-noble-uses-the-trash-skill-ancient-summoning-to-summon-heroes-and-bring-life-to-the-borderlands-when-i-summoned-the-heroes-they-adored-me-so-they-made-my-territory-th/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3Nlcmllcy90aGUtYmFuaXNoZWQtbm9ibGUtdXNlcy10aGUtdHJhc2gtc2tpbGwtYW5jaWVudC1zdW1tb25pbmctdG8tc3VtbW9uLWhlcm9lcy1hbmQtYnJpbmctbGlmZS10by10aGUtYm9yZGVybGFuZHMtd2hlbi1pLXN1bW1vbmVkLXRoZS1oZXJvZXMtdGhleS1hZG9yZWQtbWUtc28tdGhleS1tYWRlLW15LXRlcnJpdG9yeS10aC8=");
        // https://agscomics.com/series/the-peaceful-travel-diaries-of-the-boy-raised-by-holy-beasts-enjoying-my-slow-life-with-my-friends-using-the-cheat-magic-i-received-from-god/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3Nlcmllcy90aGUtcGVhY2VmdWwtdHJhdmVsLWRpYXJpZXMtb2YtdGhlLWJveS1yYWlzZWQtYnktaG9seS1iZWFzdHMtZW5qb3lpbmctbXktc2xvdy1saWZlLXdpdGgtbXktZnJpZW5kcy11c2luZy10aGUtY2hlYXQtbWFnaWMtaS1yZWNlaXZlZC1mcm9tLWdvZC8=");
        // https://agscomics.com/series/laura-the-princess-of-revenge-i-no-longer-need-this-country-after-they-sacrificed-my-sister/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3Nlcmllcy9sYXVyYS10aGUtcHJpbmNlc3Mtb2YtcmV2ZW5nZS1pLW5vLWxvbmdlci1uZWVkLXRoaXMtY291bnRyeS1hZnRlci10aGV5LXNhY3JpZmljZWQtbXktc2lzdGVyLw==");
        // https://agscomics.com/series/the-reproducer-of-creation-magic/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3Nlcmllcy90aGUtcmVwcm9kdWNlci1vZi1jcmVhdGlvbi1tYWdpYy8=");
        // https://agscomics.com/series/reincarnated-as-the-mastermind-of-the-story/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3Nlcmllcy9yZWluY2FybmF0ZWQtYXMtdGhlLW1hc3Rlcm1pbmQtb2YtdGhlLXN0b3J5Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://agscomics.com/reincarnated-as-the-mastermind-of-the-story-13/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3JlaW5jYXJuYXRlZC1hcy10aGUtbWFzdGVybWluZC1vZi10aGUtc3RvcnktMTMv");
        // https://agscomics.com/the-peaceful-travel-diaries-of-the-boy-raised-by-holy-beasts-enjoying-my-slow-life-with-my-friends-using-the-cheat-magic-i-received-from-god-chapter-1-1/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1wZWFjZWZ1bC10cmF2ZWwtZGlhcmllcy1vZi10aGUtYm95LXJhaXNlZC1ieS1ob2x5LWJlYXN0cy1lbmpveWluZy1teS1zbG93LWxpZmUtd2l0aC1teS1mcmllbmRzLXVzaW5nLXRoZS1jaGVhdC1tYWdpYy1pLXJlY2VpdmVkLWZyb20tZ29kLWNoYXB0ZXItMS0xLw==");
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItMi8=");
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItNS8=");
        // https://agscomics.com/the-reproducer-of-creation-magic-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9hZ3Njb21pY3MuY29tL3RoZS1yZXByb2R1Y2VyLW9mLWNyZWF0aW9uLW1hZ2ljLWNoYXB0ZXItNy8=");
    }

    public static IEnumerable ValidImages()
    {
        // http://agscomics.com/wp-content/uploads/2023/12/014-9.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDE0LTkuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/37-1.jpeg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMzctMS5qcGVn");
        // http://agscomics.com/wp-content/uploads/2023/12/15-2.jpeg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMTUtMi5qcGVn");
        // http://agscomics.com/wp-content/uploads/2023/12/003-9.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDAzLTkuanBn");
        // http://agscomics.com/wp-content/uploads/2023/12/016-2.jpg
        yield return new TestCaseData("aHR0cDovL2Fnc2NvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvMDE2LTIuanBn");
    }
}

