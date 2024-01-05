using System.Collections;

namespace Mangarr.Backend.Tests;

public class TopManhuaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "topmanhua";

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
        // https://topmanhua.com/manhua/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC8=");
        // https://topmanhua.com/manhua/please-get-out-of-my-household/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9wbGVhc2UtZ2V0LW91dC1vZi1teS1ob3VzZWhvbGQv");
        // https://topmanhua.com/manhua/reasoning-with-a-beast/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9yZWFzb25pbmctd2l0aC1hLWJlYXN0Lw==");
        // https://topmanhua.com/manhua/unrivaled-gamer-dominating-with-the-exskill-hero-master/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS91bnJpdmFsZWQtZ2FtZXItZG9taW5hdGluZy13aXRoLXRoZS1leHNraWxsLWhlcm8tbWFzdGVyLw==");
        // https://topmanhua.com/manhua/since-my-time-is-limited-im-entering-a-contract-marriage/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9zaW5jZS1teS10aW1lLWlzLWxpbWl0ZWQtaW0tZW50ZXJpbmctYS1jb250cmFjdC1tYXJyaWFnZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://topmanhua.com/manhua/since-my-time-is-limited-im-entering-a-contract-marriage/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9zaW5jZS1teS10aW1lLWlzLWxpbWl0ZWQtaW0tZW50ZXJpbmctYS1jb250cmFjdC1tYXJyaWFnZS9jaGFwdGVyLTEv");
        // https://topmanhua.com/manhua/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC9jaGFwdGVyLTIv");
        // https://topmanhua.com/manhua/reasoning-with-a-beast/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9yZWFzb25pbmctd2l0aC1hLWJlYXN0L2NoYXB0ZXItMy8=");
        // https://topmanhua.com/manhua/please-get-out-of-my-household/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9wbGVhc2UtZ2V0LW91dC1vZi1teS1ob3VzZWhvbGQvY2hhcHRlci0yLw==");
        // https://topmanhua.com/manhua/reasoning-with-a-beast/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly90b3BtYW5odWEuY29tL21hbmh1YS9yZWFzb25pbmctd2l0aC1hLWJlYXN0L2NoYXB0ZXItMi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.topmanhua.com/please-get-out-of-my-household/chapter-2/009.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9wbGVhc2UtZ2V0LW91dC1vZi1teS1ob3VzZWhvbGQvY2hhcHRlci0yLzAwOS5qcGVn");
        // https://cdn.topmanhua.com/reasoning-with-a-beast/chapter-2/001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9yZWFzb25pbmctd2l0aC1hLWJlYXN0L2NoYXB0ZXItMi8wMDEuanBn");
        // https://cdn.topmanhua.com/since-my-time-is-limited-im-entering-a-contract-marriage/chapter-1/003.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9zaW5jZS1teS10aW1lLWlzLWxpbWl0ZWQtaW0tZW50ZXJpbmctYS1jb250cmFjdC1tYXJyaWFnZS9jaGFwdGVyLTEvMDAzLmpwZw==");
        // https://cdn.topmanhua.com/reasoning-with-a-beast/chapter-3/009.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9yZWFzb25pbmctd2l0aC1hLWJlYXN0L2NoYXB0ZXItMy8wMDkuanBn");
        // https://cdn.topmanhua.com/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-2/007.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4udG9wbWFuaHVhLmNvbS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC9jaGFwdGVyLTIvMDA3LmpwZw==");
    }
}

