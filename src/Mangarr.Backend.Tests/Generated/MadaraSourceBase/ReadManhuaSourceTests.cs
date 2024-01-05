using System.Collections;

namespace Mangarr.Backend.Tests;

public class ReadManhuaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "readmanhua";

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
        // https://readmanhua.net/manga/absolute-resonance-mg/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9hYnNvbHV0ZS1yZXNvbmFuY2UtbWcv");
        // https://readmanhua.net/manga/peerless-martial-spirit-reboot-mg/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9wZWVybGVzcy1tYXJ0aWFsLXNwaXJpdC1yZWJvb3QtbWcv");
        // https://readmanhua.net/manga/chaotic-sword-god/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9jaGFvdGljLXN3b3JkLWdvZC8=");
        // https://readmanhua.net/manga/holy-ancestor-mg/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9ob2x5LWFuY2VzdG9yLW1nLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://readmanhua.net/manga/holy-ancestor-mg/chapter-121/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9ob2x5LWFuY2VzdG9yLW1nL2NoYXB0ZXItMTIxLw==");
        // https://readmanhua.net/manga/holy-ancestor-mg/chapter-30/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9ob2x5LWFuY2VzdG9yLW1nL2NoYXB0ZXItMzAv");
        // https://readmanhua.net/manga/holy-ancestor-mg/chapter-62/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9ob2x5LWFuY2VzdG9yLW1nL2NoYXB0ZXItNjIv");
        // https://readmanhua.net/manga/holy-ancestor-mg/chapter-47/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9ob2x5LWFuY2VzdG9yLW1nL2NoYXB0ZXItNDcv");
        // https://readmanhua.net/manga/chaotic-sword-god/chapter-52/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC9tYW5nYS9jaGFvdGljLXN3b3JkLWdvZC9jaGFwdGVyLTUyLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://readmanhua.net/wp-content/uploads/WP-manga/data/manga_5fffda7dbef0b/df450e9bd4532edf694f9e8e29e35d93/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmZmZGE3ZGJlZjBiL2RmNDUwZTliZDQ1MzJlZGY2OTRmOWU4ZTI5ZTM1ZDkzLzA5LmpwZw==");
        // https://readmanhua.net/wp-content/uploads/WP-manga/data/manga_5fffda7dbef0b/df450e9bd4532edf694f9e8e29e35d93/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmZmZGE3ZGJlZjBiL2RmNDUwZTliZDQ1MzJlZGY2OTRmOWU4ZTI5ZTM1ZDkzLzA1LmpwZw==");
        // https://readmanhua.net/wp-content/uploads/WP-manga/data/manga_5fffda7dbef0b/df450e9bd4532edf694f9e8e29e35d93/07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmZmZGE3ZGJlZjBiL2RmNDUwZTliZDQ1MzJlZGY2OTRmOWU4ZTI5ZTM1ZDkzLzA3LmpwZw==");
        // https://readmanhua.net/wp-content/uploads/WP-manga/data/manga_5fffda7dbef0b/14828767bc890d563726a47eef58bfe2/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmZmZGE3ZGJlZjBiLzE0ODI4NzY3YmM4OTBkNTYzNzI2YTQ3ZWVmNThiZmUyLzAyLmpwZw==");
        // https://readmanhua.net/wp-content/uploads/WP-manga/data/manga_5fffda7dbef0b/14828767bc890d563726a47eef58bfe2/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkbWFuaHVhLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmZmZGE3ZGJlZjBiLzE0ODI4NzY3YmM4OTBkNTYzNzI2YTQ3ZWVmNThiZmUyLzAzLmpwZw==");
    }
}

