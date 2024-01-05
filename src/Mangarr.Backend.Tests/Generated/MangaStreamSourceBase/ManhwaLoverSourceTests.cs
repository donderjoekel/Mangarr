using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaLoverSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwalover";

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
        // https://www.manhwalover.com/manga/moby-dick/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL21hbmdhL21vYnktZGljay8=");
        // https://www.manhwalover.com/manga/a-wonderful-new-world/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL21hbmdhL2Etd29uZGVyZnVsLW5ldy13b3JsZC8=");
        // https://www.manhwalover.com/manga/you-came-during-the-massage-earlier-didnt-you/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL21hbmdhL3lvdS1jYW1lLWR1cmluZy10aGUtbWFzc2FnZS1lYXJsaWVyLWRpZG50LXlvdS8=");
        // https://www.manhwalover.com/manga/playing-a-game-with-my-busty-manager/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL21hbmdhL3BsYXlpbmctYS1nYW1lLXdpdGgtbXktYnVzdHktbWFuYWdlci8=");
        // https://www.manhwalover.com/manga/our-exchange/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL21hbmdhL291ci1leGNoYW5nZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-70-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTcwLWVuZ2xpc2gv");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-6-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTYtZW5nbGlzaC8=");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-81-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTgxLWVuZ2xpc2gv");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-195-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTE5NS1lbmdsaXNoLw==");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-183-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTE4My1lbmdsaXNoLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://img12.imgfx02.xyz/uploads/63/81/9-368.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzYzLzgxLzktMzY4LmpwZw==");
        // https://img12.imgfx01.xyz/uploads/63/70/7-375.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzYzLzcwLzctMzc1LmpwZw==");
        // https://img12.imgfx02.xyz/uploads/63/81/14-368.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzYzLzgxLzE0LTM2OC5qcGc=");
        // https://img12.imgfx02.xyz/uploads/63/81/10-368.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei91cGxvYWRzLzYzLzgxLzEwLTM2OC5qcGc=");
        // https://img12.imgfx02.xyz/chapters/63/195/9-04550.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei9jaGFwdGVycy82My8xOTUvOS0wNDU1MC5qcGc=");
    }
}

