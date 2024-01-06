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
        // https://manhwalover.com?p=282206
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIyMDZ8MjgyMjA2");
        // https://manhwalover.com?p=282164
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIxNjR8MjgyMTY0");
        // https://manhwalover.com?p=282161
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIxNjF8MjgyMTYx");
        // https://manhwalover.com?p=282073
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODIwNzN8MjgyMDcz");
        // https://manhwalover.com?p=281799
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2Fsb3Zlci5jb20/cD0yODE3OTl8MjgxNzk5");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-65-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTY1LWVuZ2xpc2gvfGh0dHBzOi8vbWFuaHdhbG92ZXIuY29tP3A9MjgxNzk5fDY1");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-62-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTYyLWVuZ2xpc2gvfGh0dHBzOi8vbWFuaHdhbG92ZXIuY29tP3A9MjgxNzk5fDYy");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-195-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTE5NS1lbmdsaXNoL3xodHRwczovL21hbmh3YWxvdmVyLmNvbT9wPTI4MTc5OXwxOTU=");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-212-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTIxMi1lbmdsaXNoL3xodHRwczovL21hbmh3YWxvdmVyLmNvbT9wPTI4MTc5OXwyMTI=");
        // https://www.manhwalover.com/a-wonderful-new-world-chapter-188-english/
        yield return new TestCaseData("aHR0cHM6Ly93d3cubWFuaHdhbG92ZXIuY29tL2Etd29uZGVyZnVsLW5ldy13b3JsZC1jaGFwdGVyLTE4OC1lbmdsaXNoL3xodHRwczovL21hbmh3YWxvdmVyLmNvbT9wPTI4MTc5OXwxODg=");
    }

    public static IEnumerable ValidImages()
    {
        // https://img12.imgfx02.xyz/chapters/63/195/2-04550.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei9jaGFwdGVycy82My8xOTUvMi0wNDU1MC5qcGc=");
        // https://img12.imgfx01.xyz/chapters/63/188/15-36346.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei9jaGFwdGVycy82My8xODgvMTUtMzYzNDYuanBn");
        // https://img12.imgfx02.xyz/chapters/63/195/8-04550.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAyLnh5ei9jaGFwdGVycy82My8xOTUvOC0wNDU1MC5qcGc=");
        // https://img12.imgfx01.xyz/uploads/63/62/1-378.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzYzLzYyLzEtMzc4LmpwZw==");
        // https://img12.imgfx01.xyz/uploads/63/62/11-378.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbWcxMi5pbWdmeDAxLnh5ei91cGxvYWRzLzYzLzYyLzExLTM3OC5qcGc=");
    }
}

