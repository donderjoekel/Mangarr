using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaForestSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangaforest";

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
        // https://mangaforest.me/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9wYWludGVyLW9mLXRoZS1uaWdodHxwYWludGVyLW9mLXRoZS1uaWdodA==");
        // https://mangaforest.me/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lfGktY2FuLWhlYXItaXQtd2l0aG91dC1hLW1pY3JvcGhvbmU=");
        // https://mangaforest.me/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9iai1hbGV4fGJqLWFsZXg=");
        // https://mangaforest.me/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS8xOS1kYXlzfDE5LWRheXM=");
        // https://mangaforest.me/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmV8ZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3Jl");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangaforest.me/bj-alex/chapter-54
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9iai1hbGV4L2NoYXB0ZXItNTQ=");
        // https://mangaforest.me/bj-alex/chapter-56
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9iai1hbGV4L2NoYXB0ZXItNTY=");
        // https://mangaforest.me/dangerous-convenience-store/chapter-90
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci05MA==");
        // https://mangaforest.me/bj-alex/chapter-81
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9iai1hbGV4L2NoYXB0ZXItODE=");
        // https://mangaforest.me/dangerous-convenience-store/chapter-51
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZvcmVzdC5tZS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci01MQ==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s9.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-90/6e35fa2053ed6eee1a514e61ec56e104.jpeg?acc=tIhajvGRavEtsZdxrWVJvQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zOS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9kYW5nZXJvdXMtY29udmVuaWVuY2Utc3RvcmUvY2hhcHRlci05MC82ZTM1ZmEyMDUzZWQ2ZWVlMWE1MTRlNjFlYzU2ZTEwNC5qcGVnP2FjYz10SWhhanZHUmF2RXRzWmR4cldWSnZRJmV4cD0xNzA0NDg0ODAw");
        // https://s15.mbbcdn.com/res/manga/bj-alex/chapter-54/ade8fe966575_7.jpg?acc=u_kZdnUrGfZA-EOkPTXfsw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTUubWJiY2RuLmNvbS9yZXMvbWFuZ2EvYmotYWxleC9jaGFwdGVyLTU0L2FkZThmZTk2NjU3NV83LmpwZz9hY2M9dV9rWmRuVXJHZlpBLUVPa1BUWGZzdyZleHA9MTcwNDQ4NDgwMA==");
        // https://s11.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-90/dac237cba9f0df2bcdad95512fe1fe67.jpeg?acc=nTZqMDKEsfV88fN_N5FFPg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItOTAvZGFjMjM3Y2JhOWYwZGYyYmNkYWQ5NTUxMmZlMWZlNjcuanBlZz9hY2M9blRacU1ES0VzZlY4OGZOX041RkZQZyZleHA9MTcwNDQ4NDgwMA==");
        // https://s11.mbbcdn.com/res/manga/dangerous-convenience-store/chapter-51/b9e3e1046c27_1638553102084_4.jpg?acc=XBxXGzIN-VHyviRzoBeQwg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlL2NoYXB0ZXItNTEvYjllM2UxMDQ2YzI3XzE2Mzg1NTMxMDIwODRfNC5qcGc/YWNjPVhCeFhHeklOLVZIeXZpUnpvQmVRd2cmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s7.mbbcdn.com/res/manga/bj-alex/chapter-56/80e173acc5c7_11.jpg?acc=PU5wnfQjUaA7dAbqnnALOA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zNy5tYmJjZG4uY29tL3Jlcy9tYW5nYS9iai1hbGV4L2NoYXB0ZXItNTYvODBlMTczYWNjNWM3XzExLmpwZz9hY2M9UFU1d25mUWpVYUE3ZEFicW5uQUxPQSZleHA9MTcwNDQ4NDgwMA==");
    }
}

