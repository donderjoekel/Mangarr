using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhwaTubeSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwatube";

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
        // https://manhwatube.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodHxwYWludGVyLW9mLXRoZS1uaWdodA==");
        // https://manhwatube.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lfGktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmU=");
        // https://manhwatube.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9iai1hbGV4fGJqLWFsZXg=");
        // https://manhwatube.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS8xOS1kYXlzfDE5LWRheXM=");
        // https://manhwatube.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmV8ZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3Jl");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwatube.com/i-can-hear-it-without-a-microphone/chapter-40
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNDA=");
        // https://manhwatube.com/dangerous-convenience-store/chapter-16
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci0xNg==");
        // https://manhwatube.com/painter-of-the-night/chapter-90-v2
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTkwLXYy");
        // https://manhwatube.com/painter-of-the-night/chapter-93
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTkz");
        // https://manhwatube.com/i-can-hear-it-without-a-microphone/chapter-87
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2F0dWJlLmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItODc=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s17.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-40/69b8ea56217d_44.jpg?acc=O7m8xhmdhLHVWPH-TSBTzQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTcubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTQwLzY5YjhlYTU2MjE3ZF80NC5qcGc/YWNjPU83bTh4aG1kaExIVldQSC1UU0JUelEmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s15.mbbcdn.com/res/manga/painter-of-the-night/chapter-93/e5a2db1d9525_1642920693354_29.jpg?acc=VplGlfcZ9C2wgNEI5Pr9MA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci05My9lNWEyZGIxZDk1MjVfMTY0MjkyMDY5MzM1NF8yOS5qcGc/YWNjPVZwbEdsZmNaOUMyd2dORUk1UHI5TUEmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s4.mbbcdn.com/res/manga/painter-of-the-night/chapter-90-v2/856090df1153_6.jpg?acc=XTCHfGUxYNqrXr37gkaRIw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNC5tYmJjZG4uY29tL3Jlcy9tYW5nYS9wYWludGVyLW9mLXRoZS1uaWdodC9jaGFwdGVyLTkwLXYyLzg1NjA5MGRmMTE1M182LmpwZz9hY2M9WFRDSGZHVXhZTnFyWHIzN2drYVJJdyZleHA9MTcwNDQ4NDgwMA==");
        // https://s16.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-40/98167c9c9943_23.jpg?acc=X5jo8LkaszlrZhNch_X8dQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTYubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTQwLzk4MTY3YzljOTk0M18yMy5qcGc/YWNjPVg1am84TGthc3psclpoTmNoX1g4ZFEmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s15.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-40/cfd2aa5c0eac_42.jpg?acc=Ax0E7T9Q3VqXuBO5F23iQQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTQwL2NmZDJhYTVjMGVhY180Mi5qcGc/YWNjPUF4MEU3VDlRM1ZxWHVCTzVGMjNpUVEmZXhwPTE3MDQ0ODQ4MDA=");
    }
}

