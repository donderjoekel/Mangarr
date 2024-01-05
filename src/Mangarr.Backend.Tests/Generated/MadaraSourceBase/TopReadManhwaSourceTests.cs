using System.Collections;

namespace Mangarr.Backend.Tests;

public class TopReadManhwaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "topreadmanhwa";

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
        // https://topreadmanhwa.com/manga/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9uYXVnaHR5LW1hbGUtZnJpZW5kLw==");
        // https://topreadmanhwa.com/manga/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC8=");
        // https://topreadmanhwa.com/manga/payback/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9wYXliYWNrLw==");
        // https://topreadmanhwa.com/manga/since-my-time-is-limited-i-m-entering-a-contract-marriage/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9zaW5jZS1teS10aW1lLWlzLWxpbWl0ZWQtaS1tLWVudGVyaW5nLWEtY29udHJhY3QtbWFycmlhZ2Uv");
        // https://topreadmanhwa.com/manga/a-fool-and-a-girl/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9hLWZvb2wtYW5kLWEtZ2lybC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://topreadmanhwa.com/manga/meat-doll-workshop-in-another-world/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9tZWF0LWRvbGwtd29ya3Nob3AtaW4tYW5vdGhlci13b3JsZC9jaGFwdGVyLTEv");
        // https://topreadmanhwa.com/manga/a-fool-and-a-girl/chapter-26/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9hLWZvb2wtYW5kLWEtZ2lybC9jaGFwdGVyLTI2Lw==");
        // https://topreadmanhwa.com/manga/payback/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9wYXliYWNrL2NoYXB0ZXItMTAv");
        // https://topreadmanhwa.com/manga/payback/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9wYXliYWNrL2NoYXB0ZXItMjUv");
        // https://topreadmanhwa.com/manga/a-fool-and-a-girl/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly90b3ByZWFkbWFuaHdhLmNvbS9tYW5nYS9hLWZvb2wtYW5kLWEtZ2lybC9jaGFwdGVyLTcv");
    }

    public static IEnumerable ValidImages()
    {
        // https://2nd.manhuamanhwa.com/manga_54f619e883af962072faa0e2032c1b0e/chapter_0/chap_0_24.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV81NGY2MTllODgzYWY5NjIwNzJmYWEwZTIwMzJjMWIwZS9jaGFwdGVyXzAvY2hhcF8wXzI0LmpwZw==");
        // https://2nd.manhuamanhwa.com/manga_08af6cf557f9870723efedef29a84bfa/chapter_25/chap_25_16.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV8wOGFmNmNmNTU3Zjk4NzA3MjNlZmVkZWYyOWE4NGJmYS9jaGFwdGVyXzI1L2NoYXBfMjVfMTYuanBn");
        // https://2nd.manhuamanhwa.com/manga_790eacf1faf6db5e63bb55814f315351/chapter_26/chap_26_28.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV83OTBlYWNmMWZhZjZkYjVlNjNiYjU1ODE0ZjMxNTM1MS9jaGFwdGVyXzI2L2NoYXBfMjZfMjguanBn");
        // https://2nd.manhuamanhwa.com/manga_54f619e883af962072faa0e2032c1b0e/chapter_0/chap_0_22.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV81NGY2MTllODgzYWY5NjIwNzJmYWEwZTIwMzJjMWIwZS9jaGFwdGVyXzAvY2hhcF8wXzIyLmpwZw==");
        // https://2nd.manhuamanhwa.com/manga_54f619e883af962072faa0e2032c1b0e/chapter_0/chap_0_23.jpg
        yield return new TestCaseData("aHR0cHM6Ly8ybmQubWFuaHVhbWFuaHdhLmNvbS9tYW5nYV81NGY2MTllODgzYWY5NjIwNzJmYWEwZTIwMzJjMWIwZS9jaGFwdGVyXzAvY2hhcF8wXzIzLmpwZw==");
    }
}

