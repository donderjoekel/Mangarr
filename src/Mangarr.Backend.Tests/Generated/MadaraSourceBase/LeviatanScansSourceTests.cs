using System.Collections;

namespace Mangarr.Backend.Tests;

public class LeviatanScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "leviatanscans";

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
        // https://lscomic.com/manga/i-will-rewrite-the-dead-end-novel/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS9pLXdpbGwtcmV3cml0ZS10aGUtZGVhZC1lbmQtbm92ZWwv");
        // https://lscomic.com/manga/my-insanely-strong-henchmen/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS9teS1pbnNhbmVseS1zdHJvbmctaGVuY2htZW4v");
        // https://lscomic.com/manga/boxer-kali/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS9ib3hlci1rYWxpLw==");
        // https://lscomic.com/manga/tale-of-a-scribe-who-retires-to-the-countryside/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS90YWxlLW9mLWEtc2NyaWJlLXdoby1yZXRpcmVzLXRvLXRoZS1jb3VudHJ5c2lkZS8=");
        // https://lscomic.com/manga/the-descent-of-the-demonic-master/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS90aGUtZGVzY2VudC1vZi10aGUtZGVtb25pYy1tYXN0ZXIv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://lscomic.com/manga/the-descent-of-the-demonic-master/chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS90aGUtZGVzY2VudC1vZi10aGUtZGVtb25pYy1tYXN0ZXIvY2hhcHRlci0yOS8=");
        // https://lscomic.com/manga/the-descent-of-the-demonic-master/chapter-27/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS90aGUtZGVzY2VudC1vZi10aGUtZGVtb25pYy1tYXN0ZXIvY2hhcHRlci0yNy8=");
        // https://lscomic.com/manga/boxer-kali/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS9ib3hlci1rYWxpL2NoYXB0ZXItMjEv");
        // https://lscomic.com/manga/i-will-rewrite-the-dead-end-novel/chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS9pLXdpbGwtcmV3cml0ZS10aGUtZGVhZC1lbmQtbm92ZWwvY2hhcHRlci0yMC8=");
        // https://lscomic.com/manga/boxer-kali/chapter-29/
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS9tYW5nYS9ib3hlci1rYWxpL2NoYXB0ZXItMjkv");
    }

    public static IEnumerable ValidImages()
    {
        // https://lscomic.com/wp-content/uploads/WP-manga/data/manga_6537388584d87/2652d8814575f8f7ce515f6c2c5c5749/04_02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTM3Mzg4NTg0ZDg3LzI2NTJkODgxNDU3NWY4ZjdjZTUxNWY2YzJjNWM1NzQ5LzA0XzAyLmpwZw==");
        // https://lscomic.com/wp-content/uploads/WP-manga/data/manga_6537388584d87/39b33c98917b9eeb362bb7557609f9b0/02_07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTM3Mzg4NTg0ZDg3LzM5YjMzYzk4OTE3YjllZWIzNjJiYjc1NTc2MDlmOWIwLzAyXzA3LmpwZw==");
        // https://lscomic.com/wp-content/uploads/WP-manga/data/manga_6537388584d87/39b33c98917b9eeb362bb7557609f9b0/04_07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTM3Mzg4NTg0ZDg3LzM5YjMzYzk4OTE3YjllZWIzNjJiYjc1NTc2MDlmOWIwLzA0XzA3LmpwZw==");
        // https://lscomic.com/wp-content/uploads/WP-manga/data/manga_6537388584d87/39b33c98917b9eeb362bb7557609f9b0/01_04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTM3Mzg4NTg0ZDg3LzM5YjMzYzk4OTE3YjllZWIzNjJiYjc1NTc2MDlmOWIwLzAxXzA0LmpwZw==");
        // https://lscomic.com/wp-content/uploads/WP-manga/data/manga_6537388584d87/39b33c98917b9eeb362bb7557609f9b0/05_09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9sc2NvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTM3Mzg4NTg0ZDg3LzM5YjMzYzk4OTE3YjllZWIzNjJiYjc1NTc2MDlmOWIwLzA1XzA5LmpwZw==");
    }
}

