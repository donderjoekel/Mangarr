using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaHentaiSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangahentai";

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
        // https://mangahentai.me/manga-hentai/you-came-during-the-massage-earlier-didnt-you/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91Lw==");
        // https://mangahentai.me/manga-hentai/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://mangahentai.me/manga-hentai/making-friends-with-streamers-by-hacking/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkvbWFraW5nLWZyaWVuZHMtd2l0aC1zdHJlYW1lcnMtYnktaGFja2luZy8=");
        // https://mangahentai.me/manga-hentai/not-at-work/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkvbm90LWF0LXdvcmsv");
        // https://mangahentai.me/manga-hentai/mr-wolfs-valley-girl-diet/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkvbXItd29sZnMtdmFsbGV5LWdpcmwtZGlldC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangahentai.me/manga-hentai/the-story-of-how-i-got-together-with-the-manager-on-christmas/chapter-0/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy9jaGFwdGVyLTAv");
        // https://mangahentai.me/manga-hentai/mr-wolfs-valley-girl-diet/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkvbXItd29sZnMtdmFsbGV5LWdpcmwtZGlldC9jaGFwdGVyLTQv");
        // https://mangahentai.me/manga-hentai/you-came-during-the-massage-earlier-didnt-you/chapter-13/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMTMv");
        // https://mangahentai.me/manga-hentai/you-came-during-the-massage-earlier-didnt-you/chapter-10/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMTAv");
        // https://mangahentai.me/manga-hentai/you-came-during-the-massage-earlier-didnt-you/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS9tYW5nYS1oZW50YWkveW91LWNhbWUtZHVyaW5nLXRoZS1tYXNzYWdlLWVhcmxpZXItZGlkbnQteW91L2NoYXB0ZXItMTgv");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangahentai.me/wp-content/uploads/WP-manga/data/manga_659644cebbb2a/ebf7740b1e182e2dd1efc2a7fce28a2d/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NDRjZWJiYjJhL2ViZjc3NDBiMWUxODJlMmRkMWVmYzJhN2ZjZTI4YTJkLzA4LmpwZw==");
        // https://mangahentai.me/wp-content/uploads/WP-manga/data/manga_659644cebbb2a/f7a9f8d33658442428a04b20c13e4d60/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NDRjZWJiYjJhL2Y3YTlmOGQzMzY1ODQ0MjQyOGEwNGIyMGMxM2U0ZDYwLzA0LmpwZw==");
        // https://mangahentai.me/wp-content/uploads/WP-manga/data/manga_658bcebf6896a/bfd2ab4644c0120552a4a53664dd056d/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NThiY2ViZjY4OTZhL2JmZDJhYjQ2NDRjMDEyMDU1MmE0YTUzNjY0ZGQwNTZkLzUuanBn");
        // https://mangahentai.me/wp-content/uploads/WP-manga/data/manga_659644cebbb2a/bf228ba324a5ed0ad3d33d02671ac6df/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NDRjZWJiYjJhL2JmMjI4YmEzMjRhNWVkMGFkM2QzM2QwMjY3MWFjNmRmLzA4LmpwZw==");
        // https://mangahentai.me/wp-content/uploads/WP-manga/data/manga_659644cebbb2a/ebf7740b1e182e2dd1efc2a7fce28a2d/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWhlbnRhaS5tZS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk2NDRjZWJiYjJhL2ViZjc3NDBiMWUxODJlMmRkMWVmYzJhN2ZjZTI4YTJkLzA5LmpwZw==");
    }
}

