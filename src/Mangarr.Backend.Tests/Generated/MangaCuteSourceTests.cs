using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaCuteSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangacute";

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
        // https://mangacute.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0fHBhaW50ZXItb2YtdGhlLW5pZ2h0");
        // https://mangacute.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmV8aS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZQ==");
        // https://mangacute.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2JqLWFsZXh8YmotYWxleA==");
        // https://mangacute.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tLzE5LWRheXN8MTktZGF5cw==");
        // https://mangacute.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZXxkYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmU=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangacute.com/dangerous-convenience-store/chapter-16
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTE2");
        // https://mangacute.com/dangerous-convenience-store/chapter-32
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTMy");
        // https://mangacute.com/painter-of-the-night/chapter-33
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL3BhaW50ZXItb2YtdGhlLW5pZ2h0L2NoYXB0ZXItMzM=");
        // https://mangacute.com/i-can-hear-it-without-a-microphone/chapter-118
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2ktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmUvY2hhcHRlci0xMTg=");
        // https://mangacute.com/dangerous-convenience-store/chapter-11
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWN1dGUuY29tL2Rhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZS9jaGFwdGVyLTEx");
    }

    public static IEnumerable ValidImages()
    {
        // https://s19.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-32/a47603a69f2d_38.jpg?acc=AjDp660hbT6nc0Nd8f2XYQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTkubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItMzIvYTQ3NjAzYTY5ZjJkXzM4LmpwZz9hY2M9QWpEcDY2MGhiVDZuYzBOZDhmMlhZUSZleHA9MTcwNDM3NjgwMA==");
        // https://s12.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-118/f5dc945517b9ba8c7c9ca875ee24b84e.jpeg?acc=IS3RLa21T_LeApcs-H28IQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTIubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTExOC9mNWRjOTQ1NTE3YjliYThjN2M5Y2E4NzVlZTI0Yjg0ZS5qcGVnP2FjYz1JUzNSTGEyMVRfTGVBcGNzLUgyOElRJmV4cD0xNzA0Mzc2ODAw");
        // https://s19.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-11/6.jpg?acc=Z8rFq8KnTpAKFnNbrxeYiQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMTkubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItMTEvNi5qcGc/YWNjPVo4ckZxOEtuVHBBS0ZuTmJyeGVZaVEmZXhwPTE3MDQzNzY4MDA=");
        // https://s5.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-118/ea1648016f9d3390eaef92b133dfe6af.jpeg?acc=FgxSeHRWr_Gi_1rbCBpMNg&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zNS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMTE4L2VhMTY0ODAxNmY5ZDMzOTBlYWVmOTJiMTMzZGZlNmFmLmpwZWc/YWNjPUZneFNlSFJXcl9HaV8xcmJDQnBNTmcmZXhwPTE3MDQzNzY4MDA=");
        // https://s1.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-118/0c7baf8503703c7f9ef8301f0a0e1f9f.jpeg?acc=R5L5Hj5js0-9GXYryob6XQ&exp=1704376800
        yield return new TestCaseData("aHR0cHM6Ly9zMS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMTE4LzBjN2JhZjg1MDM3MDNjN2Y5ZWY4MzAxZjBhMGUxZjlmLmpwZWc/YWNjPVI1TDVIajVqczAtOUdYWXJ5b2I2WFEmZXhwPTE3MDQzNzY4MDA=");
    }
}

