using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaPlusSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuaplus";

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
        // https://manhuaplus.com/manga/the-legendary-mechanic/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS90aGUtbGVnZW5kYXJ5LW1lY2hhbmljLw==");
        // https://manhuaplus.com/manga/spare-me-great-lord/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9zcGFyZS1tZS1ncmVhdC1sb3JkLw==");
        // https://manhuaplus.com/manga/master-this-villainous-disciple-is-not-the-holy-child/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9tYXN0ZXItdGhpcy12aWxsYWlub3VzLWRpc2NpcGxlLWlzLW5vdC10aGUtaG9seS1jaGlsZC8=");
        // https://manhuaplus.com/manga/disastrous-necromancer/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9kaXNhc3Ryb3VzLW5lY3JvbWFuY2VyLw==");
        // https://manhuaplus.com/manga/dragon-master/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9kcmFnb24tbWFzdGVyLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuaplus.com/manga/dragon-master/chapter-242/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9kcmFnb24tbWFzdGVyL2NoYXB0ZXItMjQyLw==");
        // https://manhuaplus.com/manga/master-this-villainous-disciple-is-not-the-holy-child/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9tYXN0ZXItdGhpcy12aWxsYWlub3VzLWRpc2NpcGxlLWlzLW5vdC10aGUtaG9seS1jaGlsZC9jaGFwdGVyLTcv");
        // https://manhuaplus.com/manga/disastrous-necromancer/chapter-27/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9kaXNhc3Ryb3VzLW5lY3JvbWFuY2VyL2NoYXB0ZXItMjcv");
        // https://manhuaplus.com/manga/spare-me-great-lord/chapter-583/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9zcGFyZS1tZS1ncmVhdC1sb3JkL2NoYXB0ZXItNTgzLw==");
        // https://manhuaplus.com/manga/dragon-master/chapter-203/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFwbHVzLmNvbS9tYW5nYS9kcmFnb24tbWFzdGVyL2NoYXB0ZXItMjAzLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.manhuaplus.com/2023/10/14/P3pD9.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhcGx1cy5jb20vMjAyMy8xMC8xNC9QM3BEOS5qcGc=");
        // https://cdn.manhuaplus.com/2023/09/27/Opps1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhcGx1cy5jb20vMjAyMy8wOS8yNy9PcHBzMS5qcGc=");
        // https://cdn.manhuaplus.com/2023/07/07/LGaNk.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhcGx1cy5jb20vMjAyMy8wNy8wNy9MR2FOay5qcGc=");
        // https://cdn.manhuaplus.com/2023/09/13/OZOV1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhcGx1cy5jb20vMjAyMy8wOS8xMy9PWk9WMS5qcGc=");
        // https://cdn.manhuaplus.com/2023/09/13/OZs7m.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhcGx1cy5jb20vMjAyMy8wOS8xMy9PWnM3bS5qcGc=");
    }
}

