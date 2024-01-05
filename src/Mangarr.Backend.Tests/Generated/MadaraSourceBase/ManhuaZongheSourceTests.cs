using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaZongheSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuazonghe";

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
        // https://www.manhuazonghe.com/manhua/we-are-101/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvd2UtYXJlLTEwMS8=");
        // https://www.manhuazonghe.com/manhua/starting-with-the-holy-maiden-system-bound/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvc3RhcnRpbmctd2l0aC10aGUtaG9seS1tYWlkZW4tc3lzdGVtLWJvdW5kLw==");
        // https://www.manhuazonghe.com/manhua/meat-doll-workshop-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvbWVhdC1kb2xsLXdvcmtzaG9wLWluLWFub3RoZXItd29ybGQv");
        // https://www.manhuazonghe.com/manhua/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvaS1oYXZlLWEtYmxhZGUtdGhhdC1jYW4tY3V0LWhlYXZlbi1hbmQtZWFydGgv");
        // https://www.manhuazonghe.com/manhua/naughty-male-friend/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvbmF1Z2h0eS1tYWxlLWZyaWVuZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.manhuazonghe.com/manhua/starting-with-the-holy-maiden-system-bound/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvc3RhcnRpbmctd2l0aC10aGUtaG9seS1tYWlkZW4tc3lzdGVtLWJvdW5kL2NoYXB0ZXItMC8=");
        // https://www.manhuazonghe.com/manhua/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvaS1oYXZlLWEtYmxhZGUtdGhhdC1jYW4tY3V0LWhlYXZlbi1hbmQtZWFydGgvY2hhcHRlci0xLw==");
        // https://www.manhuazonghe.com/manhua/i-have-a-blade-that-can-cut-heaven-and-earth/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvaS1oYXZlLWEtYmxhZGUtdGhhdC1jYW4tY3V0LWhlYXZlbi1hbmQtZWFydGgvY2hhcHRlci0zLw==");
        // https://www.manhuazonghe.com/manhua/starting-with-the-holy-maiden-system-bound/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvc3RhcnRpbmctd2l0aC10aGUtaG9seS1tYWlkZW4tc3lzdGVtLWJvdW5kL2NoYXB0ZXItMS8=");
        // https://www.manhuazonghe.com/manhua/we-are-101/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHVhem9uZ2hlLmNvbS9tYW5odWEvd2UtYXJlLTEwMS9jaGFwdGVyLTIv");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn-4.manhwatop.com/manga_65977a6805454/34a5b3bcd5455a2bc06dfa5d4039190e/003.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4tNC5tYW5od2F0b3AuY29tL21hbmdhXzY1OTc3YTY4MDU0NTQvMzRhNWIzYmNkNTQ1NWEyYmMwNmRmYTVkNDAzOTE5MGUvMDAzLmpwZw==");
        // https://cdn-4.manhwatop.com/manga_65977ba0c621f/5c6f96b82c58eb5ba038e0ed860f7ced/020.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4tNC5tYW5od2F0b3AuY29tL21hbmdhXzY1OTc3YmEwYzYyMWYvNWM2Zjk2YjgyYzU4ZWI1YmEwMzhlMGVkODYwZjdjZWQvMDIwLmpwZw==");
        // https://cdn-4.manhwatop.com/manga_65977ba0c621f/5c6f96b82c58eb5ba038e0ed860f7ced/015.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4tNC5tYW5od2F0b3AuY29tL21hbmdhXzY1OTc3YmEwYzYyMWYvNWM2Zjk2YjgyYzU4ZWI1YmEwMzhlMGVkODYwZjdjZWQvMDE1LmpwZw==");
        // https://cdn-4.manhwatop.com/manga_65977ba0c621f/5c6f96b82c58eb5ba038e0ed860f7ced/098.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4tNC5tYW5od2F0b3AuY29tL21hbmdhXzY1OTc3YmEwYzYyMWYvNWM2Zjk2YjgyYzU4ZWI1YmEwMzhlMGVkODYwZjdjZWQvMDk4LmpwZw==");
        // https://cdn-4.manhwatop.com/manga_659774441521d/7fe8e1414d6261867c5d85477065d451/08.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4tNC5tYW5od2F0b3AuY29tL21hbmdhXzY1OTc3NDQ0MTUyMWQvN2ZlOGUxNDE0ZDYyNjE4NjdjNWQ4NTQ3NzA2NWQ0NTEvMDgud2VicA==");
    }
}

