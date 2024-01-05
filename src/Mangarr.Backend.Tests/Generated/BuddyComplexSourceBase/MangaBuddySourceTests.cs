using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaBuddySourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangabuddy";

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
        // https://mangabuddy.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9wYWludGVyLW9mLXRoZS1uaWdodHxwYWludGVyLW9mLXRoZS1uaWdodA==");
        // https://mangabuddy.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lfGktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmU=");
        // https://mangabuddy.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9iai1hbGV4fGJqLWFsZXg=");
        // https://mangabuddy.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS8xOS1kYXlzfDE5LWRheXM=");
        // https://mangabuddy.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmV8ZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3Jl");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangabuddy.com/bj-alex/chapter-82
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9iai1hbGV4L2NoYXB0ZXItODI=");
        // https://mangabuddy.com/painter-of-the-night/hiatus-0801
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9wYWludGVyLW9mLXRoZS1uaWdodC9oaWF0dXMtMDgwMQ==");
        // https://mangabuddy.com/i-can-hear-it-without-a-microphone/chapter-60
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNjA=");
        // https://mangabuddy.com/i-can-hear-it-without-a-microphone/chapter-115
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMTE1");
        // https://mangabuddy.com/i-can-hear-it-without-a-microphone/chapter-56
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWJ1ZGR5LmNvbS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItNTY=");
    }

    public static IEnumerable ValidImages()
    {
        // https://s2.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-115/603856e51997bf502c23ebabbf1d7167.jpeg?acc=k2KNzp9hW20gYOx81BHEBg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMi5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMTE1LzYwMzg1NmU1MTk5N2JmNTAyYzIzZWJhYmJmMWQ3MTY3LmpwZWc/YWNjPWsyS056cDloVzIwZ1lPeDgxQkhFQmcmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s11.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-56/6de5132e5116_43.jpg?acc=7qH7XlTwHp3Mqm3nuGpWDQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTU2LzZkZTUxMzJlNTExNl80My5qcGc/YWNjPTdxSDdYbFR3SHAzTXFtM251R3BXRFEmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s14.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-60/eb2df9aea805_12.jpg?acc=fwch1yb4b1Y9BtWAP4oNMQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTYwL2ViMmRmOWFlYTgwNV8xMi5qcGc/YWNjPWZ3Y2gxeWI0YjFZOUJ0V0FQNG9OTVEmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s14.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-60/1c40ed3ba94c_32.jpg?acc=nhnZcVSGUGmQXaDFA7h2KA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTYwLzFjNDBlZDNiYTk0Y18zMi5qcGc/YWNjPW5oblpjVlNHVUdtUVhhREZBN2gyS0EmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s10.mbbcdn.com/res/manga/bj-alex/chapter-82/ebb73eaaad86_1.jpg?acc=t650t-DDrZcQsBNMFVrd-Q&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTAubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTgyL2ViYjczZWFhYWQ4Nl8xLmpwZz9hY2M9dDY1MHQtRERyWmNRc0JOTUZWcmQtUSZleHA9MTcwNDQ4NDgwMA==");
    }
}

