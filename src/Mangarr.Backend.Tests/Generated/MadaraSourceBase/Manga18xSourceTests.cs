using System.Collections;

namespace Mangarr.Backend.Tests;

public class Manga18xSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manga18x";

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
        // https://manga18x.net/manga/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EvbWFraW5nLWZyaWVuZHMtd2l0aC1zdHJlYW1lcnMtYnktaGFja2luZy8=");
        // https://manga18x.net/manga/boss-give-me-your-daughter/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EvYm9zcy1naXZlLW1lLXlvdXItZGF1Z2h0ZXIv");
        // https://manga18x.net/manga/you-came-during-the-massage-earlier-didnt-you/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91Lw==");
        // https://manga18x.net/manga/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://manga18x.net/manga/playing-a-game-with-my-busty-manager/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EvcGxheWluZy1hLWdhbWUtd2l0aC1teS1idXN0eS1tYW5hZ2VyLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manga18x.net/manga/you-came-during-the-massage-earlier-didnt-you/chapter-22/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMjIv");
        // https://manga18x.net/manga/boss-give-me-your-daughter/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EvYm9zcy1naXZlLW1lLXlvdXItZGF1Z2h0ZXIvY2hhcHRlci03Lw==");
        // https://manga18x.net/manga/you-came-during-the-massage-earlier-didnt-you/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMTAv");
        // https://manga18x.net/manga/boss-give-me-your-daughter/chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EvYm9zcy1naXZlLW1lLXlvdXItZGF1Z2h0ZXIvY2hhcHRlci0xMi8=");
        // https://manga18x.net/manga/you-came-during-the-massage-earlier-didnt-you/chapter-27/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYTE4eC5uZXQvbWFuZ2EveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMjcv");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.manga18x.net/boss-give-me-your-daughter/chapter-7/9-35121.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2ExOHgubmV0L2Jvc3MtZ2l2ZS1tZS15b3VyLWRhdWdodGVyL2NoYXB0ZXItNy85LTM1MTIxLmpwZw==");
        // https://cdn.manga18x.net/you-came-during-the-massage-earlier-didnt-you/chapter-10/2-70d9b.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2ExOHgubmV0L3lvdS1jYW1lLWR1cmluZy10aGUtbWFzc2FnZS1lYXJsaWVyLWRpZG50LXlvdS9jaGFwdGVyLTEwLzItNzBkOWIuanBn");
        // https://cdn.manga18x.net/you-came-during-the-massage-earlier-didnt-you/chapter-27/1-11fcf.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2ExOHgubmV0L3lvdS1jYW1lLWR1cmluZy10aGUtbWFzc2FnZS1lYXJsaWVyLWRpZG50LXlvdS9jaGFwdGVyLTI3LzEtMTFmY2YuanBn");
        // https://cdn.manga18x.net/you-came-during-the-massage-earlier-didnt-you/chapter-27/6-11fcf.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2ExOHgubmV0L3lvdS1jYW1lLWR1cmluZy10aGUtbWFzc2FnZS1lYXJsaWVyLWRpZG50LXlvdS9jaGFwdGVyLTI3LzYtMTFmY2YuanBn");
        // https://cdn.manga18x.net/boss-give-me-your-daughter/chapter-12/4-92739.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuZ2ExOHgubmV0L2Jvc3MtZ2l2ZS1tZS15b3VyLWRhdWdodGVyL2NoYXB0ZXItMTIvNC05MjczOS5qcGc=");
    }
}

