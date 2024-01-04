using System.Collections;

namespace Mangarr.Backend.Tests;

public class WebtoonSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "webtoons";

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
        // https://webtoons.com/episodeList?titleNo=5732
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29ucy5jb20vZXBpc29kZUxpc3Q/dGl0bGVObz01NzMy");
        // https://webtoons.com/episodeList?titleNo=1390
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29ucy5jb20vZXBpc29kZUxpc3Q/dGl0bGVObz0xMzkw");
        // https://webtoons.com/episodeList?titleNo=5515
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29ucy5jb20vZXBpc29kZUxpc3Q/dGl0bGVObz01NTE1");
        // https://webtoons.com/episodeList?titleNo=3164
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29ucy5jb20vZXBpc29kZUxpc3Q/dGl0bGVObz0zMTY0");
        // https://webtoons.com/episodeList?titleNo=2876
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29ucy5jb20vZXBpc29kZUxpc3Q/dGl0bGVObz0yODc2");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.webtoons.com/en/romance/a-good-day-tobe-a-dog/ep-4-/viewer?title_no=1390&episode_no=4
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL3JvbWFuY2UvYS1nb29kLWRheS10b2JlLWEtZG9nL2VwLTQtL3ZpZXdlcj90aXRsZV9ubz0xMzkwJmVwaXNvZGVfbm89NA==");
        // https://www.webtoons.com/en/drama/a-mans-man/episode-1/viewer?title_no=2876&episode_no=1
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2RyYW1hL2EtbWFucy1tYW4vZXBpc29kZS0xL3ZpZXdlcj90aXRsZV9ubz0yODc2JmVwaXNvZGVfbm89MQ==");
        // https://www.webtoons.com/en/drama/a-mans-man/episode-41/viewer?title_no=2876&episode_no=41
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2RyYW1hL2EtbWFucy1tYW4vZXBpc29kZS00MS92aWV3ZXI/dGl0bGVfbm89Mjg3NiZlcGlzb2RlX25vPTQx");
        // https://www.webtoons.com/en/drama/a-mans-man/episode-126/viewer?title_no=2876&episode_no=126
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2RyYW1hL2EtbWFucy1tYW4vZXBpc29kZS0xMjYvdmlld2VyP3RpdGxlX25vPTI4NzYmZXBpc29kZV9ubz0xMjY=");
        // https://www.webtoons.com/en/fantasy/surviving-the-game-as-a-barbarian/episode-2/viewer?title_no=5515&episode_no=2
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2ZhbnRhc3kvc3Vydml2aW5nLXRoZS1nYW1lLWFzLWEtYmFyYmFyaWFuL2VwaXNvZGUtMi92aWV3ZXI/dGl0bGVfbm89NTUxNSZlcGlzb2RlX25vPTI=");
    }

    public static IEnumerable ValidImages()
    {
        // https://webtoon-phinf.pstatic.net/20210617_120/1623883692282ql9gC_JPEG/1623883692220287615.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjEwNjE3XzEyMC8xNjIzODgzNjkyMjgycWw5Z0NfSlBFRy8xNjIzODgzNjkyMjIwMjg3NjE1LmpwZz90eXBlPXE5MA==");
        // https://webtoon-phinf.pstatic.net/20230811_59/1691688163460WUXf4_JPEG/16916881634459091__LICO_______0020.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwODExXzU5LzE2OTE2ODgxNjM0NjBXVVhmNF9KUEVHLzE2OTE2ODgxNjM0NDU5MDkxX19MSUNPX19fX19fXzAwMjAuanBnP3R5cGU9cTkw");
        // https://webtoon-phinf.pstatic.net/20180516_270/1526443930937rH8jC_JPEG/1526443930918139049.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMTgwNTE2XzI3MC8xNTI2NDQzOTMwOTM3ckg4akNfSlBFRy8xNTI2NDQzOTMwOTE4MTM5MDQ5LmpwZz90eXBlPXE5MA==");
        // https://webtoon-phinf.pstatic.net/20230919_273/1695062188543NxANd_JPEG/16950621884806853_A_Man_s_Man_Episode_126_0035.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwOTE5XzI3My8xNjk1MDYyMTg4NTQzTnhBTmRfSlBFRy8xNjk1MDYyMTg4NDgwNjg1M19BX01hbl9zX01hbl9FcGlzb2RlXzEyNl8wMDM1LmpwZz90eXBlPXE5MA==");
        // https://webtoon-phinf.pstatic.net/20230919_267/1695062189512Swai0_JPEG/16950621894663750_A_Man_s_Man_Episode_126_0021.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwOTE5XzI2Ny8xNjk1MDYyMTg5NTEyU3dhaTBfSlBFRy8xNjk1MDYyMTg5NDY2Mzc1MF9BX01hbl9zX01hbl9FcGlzb2RlXzEyNl8wMDIxLmpwZz90eXBlPXE5MA==");
    }
}

