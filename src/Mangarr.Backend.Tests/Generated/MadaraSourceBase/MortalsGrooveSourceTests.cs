using System.Collections;

namespace Mangarr.Backend.Tests;

public class MortalsGrooveSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mortalsgroove";

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
        // https://mortalsgroove.com/manga/i-have-999-abilities/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9pLWhhdmUtOTk5LWFiaWxpdGllcy8=");
        // https://mortalsgroove.com/manga/karuna/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9rYXJ1bmEv");
        // https://mortalsgroove.com/manga/vivace-of-atlania/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS92aXZhY2Utb2YtYXRsYW5pYS8=");
        // https://mortalsgroove.com/manga/memoir-of-the-god-of-war/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9tZW1vaXItb2YtdGhlLWdvZC1vZi13YXIv");
        // https://mortalsgroove.com/manga/please-take-care-of-me-in-this-life/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9wbGVhc2UtdGFrZS1jYXJlLW9mLW1lLWluLXRoaXMtbGlmZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mortalsgroove.com/manga/i-have-999-abilities/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9pLWhhdmUtOTk5LWFiaWxpdGllcy9jaGFwdGVyLTUv");
        // https://mortalsgroove.com/manga/karuna/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9rYXJ1bmEvY2hhcHRlci00Lw==");
        // https://mortalsgroove.com/manga/i-have-999-abilities/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9pLWhhdmUtOTk5LWFiaWxpdGllcy9jaGFwdGVyLTEv");
        // https://mortalsgroove.com/manga/memoir-of-the-god-of-war/chapter-49/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9tZW1vaXItb2YtdGhlLWdvZC1vZi13YXIvY2hhcHRlci00OS8=");
        // https://mortalsgroove.com/manga/karuna/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS9tYW5nYS9rYXJ1bmEvY2hhcHRlci0zLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://mortalsgroove.com/wp-content/uploads/WP-manga/data/manga_60ec6497243be/5c194b419341054de7e4717dc813a5f8/06_01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MGVjNjQ5NzI0M2JlLzVjMTk0YjQxOTM0MTA1NGRlN2U0NzE3ZGM4MTNhNWY4LzA2XzAxLmpwZw==");
        // https://mortalsgroove.com/wp-content/uploads/WP-manga/data/manga_60ec6497243be/5c194b419341054de7e4717dc813a5f8/08_03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MGVjNjQ5NzI0M2JlLzVjMTk0YjQxOTM0MTA1NGRlN2U0NzE3ZGM4MTNhNWY4LzA4XzAzLmpwZw==");
        // https://mortalsgroove.com/wp-content/uploads/WP-manga/data/manga_612c9b871b3dd/61edce36499cabb41e1d0b92420f6f8f/04_03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MTJjOWI4NzFiM2RkLzYxZWRjZTM2NDk5Y2FiYjQxZTFkMGI5MjQyMGY2ZjhmLzA0XzAzLmpwZw==");
        // https://mortalsgroove.com/wp-content/uploads/WP-manga/data/manga_60ec6497243be/da905473c7a568ea4ba2670879700d32/05_04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MGVjNjQ5NzI0M2JlL2RhOTA1NDczYzdhNTY4ZWE0YmEyNjcwODc5NzAwZDMyLzA1XzA0LmpwZw==");
        // https://mortalsgroove.com/wp-content/uploads/WP-manga/data/manga_60a2988f9ce1a/6757a4af612cf99c11690bb394271d84/04_03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tb3J0YWxzZ3Jvb3ZlLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MGEyOTg4ZjljZTFhLzY3NTdhNGFmNjEyY2Y5OWMxMTY5MGJiMzk0MjcxZDg0LzA0XzAzLmpwZw==");
    }
}

