using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaKomiSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangakomi";

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
        // https://mangakomi.io/manga/betrayal-of-dignity/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvYmV0cmF5YWwtb2YtZGlnbml0eS8=");
        // https://mangakomi.io/manga/conqueror-of-modern-martial-arts-kang-haejin/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvY29ucXVlcm9yLW9mLW1vZGVybi1tYXJ0aWFsLWFydHMta2FuZy1oYWVqaW4v");
        // https://mangakomi.io/manga/plunder-countless-talents-i-became-a-god/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvcGx1bmRlci1jb3VudGxlc3MtdGFsZW50cy1pLWJlY2FtZS1hLWdvZC8=");
        // https://mangakomi.io/manga/mr-devourer-please-act-like-a-final-boss/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy8=");
        // https://mangakomi.io/manga/is-it-because-im-cute/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvaXMtaXQtYmVjYXVzZS1pbS1jdXRlLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangakomi.io/manga/is-it-because-im-cute/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvaXMtaXQtYmVjYXVzZS1pbS1jdXRlL2NoYXB0ZXItMi8=");
        // https://mangakomi.io/manga/betrayal-of-dignity/chapter-39/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvYmV0cmF5YWwtb2YtZGlnbml0eS9jaGFwdGVyLTM5Lw==");
        // https://mangakomi.io/manga/plunder-countless-talents-i-became-a-god/chapter-75/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvcGx1bmRlci1jb3VudGxlc3MtdGFsZW50cy1pLWJlY2FtZS1hLWdvZC9jaGFwdGVyLTc1Lw==");
        // https://mangakomi.io/manga/mr-devourer-please-act-like-a-final-boss/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy9jaGFwdGVyLTUv");
        // https://mangakomi.io/manga/plunder-countless-talents-i-became-a-god/chapter-26/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWtvbWkuaW8vbWFuZ2EvcGx1bmRlci1jb3VudGxlc3MtdGFsZW50cy1pLWJlY2FtZS1hLWdvZC9jaGFwdGVyLTI2Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn3.mangakomicdn.com/temp/manga_659189243eb6e/4d3d99928a3fed610ae681639503d395/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdha29taWNkbi5jb20vdGVtcC9tYW5nYV82NTkxODkyNDNlYjZlLzRkM2Q5OTkyOGEzZmVkNjEwYWU2ODE2Mzk1MDNkMzk1LzQuanBn");
        // https://cdn3.mangakomicdn.com/temp/manga_6596690a9bf83/bd0526397704663ec72e397c54aa8427/61.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdha29taWNkbi5jb20vdGVtcC9tYW5nYV82NTk2NjkwYTliZjgzL2JkMDUyNjM5NzcwNDY2M2VjNzJlMzk3YzU0YWE4NDI3LzYxLmpwZw==");
        // https://cdn3.mangakomicdn.com/temp/manga_6596690a9bf83/bd0526397704663ec72e397c54aa8427/30.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdha29taWNkbi5jb20vdGVtcC9tYW5nYV82NTk2NjkwYTliZjgzL2JkMDUyNjM5NzcwNDY2M2VjNzJlMzk3YzU0YWE4NDI3LzMwLmpwZw==");
        // https://cdn3.mangakomicdn.com/temp/manga_65902a92ad483/2278d05c2004737c6cb3068565ec8692/22.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdha29taWNkbi5jb20vdGVtcC9tYW5nYV82NTkwMmE5MmFkNDgzLzIyNzhkMDVjMjAwNDczN2M2Y2IzMDY4NTY1ZWM4NjkyLzIyLndlYnA=");
        // https://cdn3.mangakomicdn.com/temp/manga_6596690a9bf83/bd0526397704663ec72e397c54aa8427/11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4zLm1hbmdha29taWNkbi5jb20vdGVtcC9tYW5nYV82NTk2NjkwYTliZjgzL2JkMDUyNjM5NzcwNDY2M2VjNzJlMzk3YzU0YWE4NDI3LzExLmpwZw==");
    }
}

