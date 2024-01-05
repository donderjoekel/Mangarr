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
        // https://www.webtoons.com/en/fantasy/from-a-knight-to-a-lady/episode-53/viewer?title_no=3164&episode_no=53
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2ZhbnRhc3kvZnJvbS1hLWtuaWdodC10by1hLWxhZHkvZXBpc29kZS01My92aWV3ZXI/dGl0bGVfbm89MzE2NCZlcGlzb2RlX25vPTUz");
        // https://www.webtoons.com/en/fantasy/from-a-knight-to-a-lady/episode-99/viewer?title_no=3164&episode_no=100
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2ZhbnRhc3kvZnJvbS1hLWtuaWdodC10by1hLWxhZHkvZXBpc29kZS05OS92aWV3ZXI/dGl0bGVfbm89MzE2NCZlcGlzb2RlX25vPTEwMA==");
        // https://www.webtoons.com/en/fantasy/surviving-the-game-as-a-barbarian/episode-16/viewer?title_no=5515&episode_no=16
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2ZhbnRhc3kvc3Vydml2aW5nLXRoZS1nYW1lLWFzLWEtYmFyYmFyaWFuL2VwaXNvZGUtMTYvdmlld2VyP3RpdGxlX25vPTU1MTUmZXBpc29kZV9ubz0xNg==");
        // https://www.webtoons.com/en/drama/a-mans-man/episode-52/viewer?title_no=2876&episode_no=52
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2RyYW1hL2EtbWFucy1tYW4vZXBpc29kZS01Mi92aWV3ZXI/dGl0bGVfbm89Mjg3NiZlcGlzb2RlX25vPTUy");
        // https://www.webtoons.com/en/drama/a-mans-man/episode-109/viewer?title_no=2876&episode_no=109
        yield return new TestCaseData("aHR0cHM6Ly93d3cud2VidG9vbnMuY29tL2VuL2RyYW1hL2EtbWFucy1tYW4vZXBpc29kZS0xMDkvdmlld2VyP3RpdGxlX25vPTI4NzYmZXBpc29kZV9ubz0xMDk=");
    }

    public static IEnumerable ValidImages()
    {
        // https://webtoon-phinf.pstatic.net/20230819_275/1692386301874Fw3hQ_JPEG/1692386301864182_Surviving_the_Game_as_a_Barbarian__Ep__16_____0094.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwODE5XzI3NS8xNjkyMzg2MzAxODc0RnczaFFfSlBFRy8xNjkyMzg2MzAxODY0MTgyX1N1cnZpdmluZ190aGVfR2FtZV9hc19hX0JhcmJhcmlhbl9fRXBfXzE2X19fX18wMDk0LmpwZz90eXBlPXE5MA==");
        // https://webtoon-phinf.pstatic.net/20220420_292/1650449570991W3a9f_JPEG/16504495709822876523.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjIwNDIwXzI5Mi8xNjUwNDQ5NTcwOTkxVzNhOWZfSlBFRy8xNjUwNDQ5NTcwOTgyMjg3NjUyMy5qcGc/dHlwZT1xOTA=");
        // https://webtoon-phinf.pstatic.net/20230819_295/1692386295037G9cxd_JPEG/16923862950197024_Surviving_the_Game_as_a_Barbarian__Ep__16_____0048.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwODE5XzI5NS8xNjkyMzg2Mjk1MDM3RzljeGRfSlBFRy8xNjkyMzg2Mjk1MDE5NzAyNF9TdXJ2aXZpbmdfdGhlX0dhbWVfYXNfYV9CYXJiYXJpYW5fX0VwX18xNl9fX19fMDA0OC5qcGc/dHlwZT1xOTA=");
        // https://webtoon-phinf.pstatic.net/20230228_285/1677589914925bgRu4_JPEG/16775899149205467_109_003_07.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwMjI4XzI4NS8xNjc3NTg5OTE0OTI1YmdSdTRfSlBFRy8xNjc3NTg5OTE0OTIwNTQ2N18xMDlfMDAzXzA3LmpwZz90eXBlPXE5MA==");
        // https://webtoon-phinf.pstatic.net/20230228_77/1677589912100kT4co_JPEG/16775899120931226_109_006_05.jpg?type=q90
        yield return new TestCaseData("aHR0cHM6Ly93ZWJ0b29uLXBoaW5mLnBzdGF0aWMubmV0LzIwMjMwMjI4Xzc3LzE2Nzc1ODk5MTIxMDBrVDRjb19KUEVHLzE2Nzc1ODk5MTIwOTMxMjI2XzEwOV8wMDZfMDUuanBnP3R5cGU9cTkw");
    }
}

