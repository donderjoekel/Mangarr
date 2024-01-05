using System.Collections;

namespace Mangarr.Backend.Tests;

public class PlatinumCrownSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "platinumcrown";

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
        // https://platinumscans.com/manga/unique-skill-slave-encyclopedia/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS91bmlxdWUtc2tpbGwtc2xhdmUtZW5jeWNsb3BlZGlhLw==");
        // https://platinumscans.com/manga/beyond-santas-gravestone/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS9iZXlvbmQtc2FudGFzLWdyYXZlc3RvbmUv");
        // https://platinumscans.com/manga/the-story-of-an-exorcist-possession/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS90aGUtc3Rvcnktb2YtYW4tZXhvcmNpc3QtcG9zc2Vzc2lvbi8=");
        // https://platinumscans.com/manga/magician-of-the-abyss-i-was-imprisoned-as-a-traitor-but-i-obtained-an-immortal-body-and-the-strongest-power-to-rise-as-an-adventurer/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS9tYWdpY2lhbi1vZi10aGUtYWJ5c3MtaS13YXMtaW1wcmlzb25lZC1hcy1hLXRyYWl0b3ItYnV0LWktb2J0YWluZWQtYW4taW1tb3J0YWwtYm9keS1hbmQtdGhlLXN0cm9uZ2VzdC1wb3dlci10by1yaXNlLWFzLWFuLWFkdmVudHVyZXIv");
        // https://platinumscans.com/manga/the-deadly-sin-demon-king-the-destructive-skill-the-deadly-sin-was-actually-the-strongest-through-gacha-and-combination-i-will-rise-as-a-demon-king/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS90aGUtZGVhZGx5LXNpbi1kZW1vbi1raW5nLXRoZS1kZXN0cnVjdGl2ZS1za2lsbC10aGUtZGVhZGx5LXNpbi13YXMtYWN0dWFsbHktdGhlLXN0cm9uZ2VzdC10aHJvdWdoLWdhY2hhLWFuZC1jb21iaW5hdGlvbi1pLXdpbGwtcmlzZS1hcy1hLWRlbW9uLWtpbmcv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://platinumscans.com/manga/magician-of-the-abyss-i-was-imprisoned-as-a-traitor-but-i-obtained-an-immortal-body-and-the-strongest-power-to-rise-as-an-adventurer/chapter-4-2/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS9tYWdpY2lhbi1vZi10aGUtYWJ5c3MtaS13YXMtaW1wcmlzb25lZC1hcy1hLXRyYWl0b3ItYnV0LWktb2J0YWluZWQtYW4taW1tb3J0YWwtYm9keS1hbmQtdGhlLXN0cm9uZ2VzdC1wb3dlci10by1yaXNlLWFzLWFuLWFkdmVudHVyZXIvY2hhcHRlci00LTIv");
        // https://platinumscans.com/manga/magician-of-the-abyss-i-was-imprisoned-as-a-traitor-but-i-obtained-an-immortal-body-and-the-strongest-power-to-rise-as-an-adventurer/chapter-4-1/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS9tYWdpY2lhbi1vZi10aGUtYWJ5c3MtaS13YXMtaW1wcmlzb25lZC1hcy1hLXRyYWl0b3ItYnV0LWktb2J0YWluZWQtYW4taW1tb3J0YWwtYm9keS1hbmQtdGhlLXN0cm9uZ2VzdC1wb3dlci10by1yaXNlLWFzLWFuLWFkdmVudHVyZXIvY2hhcHRlci00LTEv");
        // https://platinumscans.com/manga/beyond-santas-gravestone/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS9iZXlvbmQtc2FudGFzLWdyYXZlc3RvbmUvb25lc2hvdC8=");
        // https://platinumscans.com/manga/the-story-of-an-exorcist-possession/oneshot/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS90aGUtc3Rvcnktb2YtYW4tZXhvcmNpc3QtcG9zc2Vzc2lvbi9vbmVzaG90Lw==");
        // https://platinumscans.com/manga/magician-of-the-abyss-i-was-imprisoned-as-a-traitor-but-i-obtained-an-immortal-body-and-the-strongest-power-to-rise-as-an-adventurer/chapter-7-2-vol-1-end/
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS9tYW5nYS9tYWdpY2lhbi1vZi10aGUtYWJ5c3MtaS13YXMtaW1wcmlzb25lZC1hcy1hLXRyYWl0b3ItYnV0LWktb2J0YWluZWQtYW4taW1tb3J0YWwtYm9keS1hbmQtdGhlLXN0cm9uZ2VzdC1wb3dlci10by1yaXNlLWFzLWFuLWFkdmVudHVyZXIvY2hhcHRlci03LTItdm9sLTEtZW5kLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://platinumscans.com/wp-content/uploads/WP-manga/data/manga_653187c658ab2/40d0d6aaf1afc32886c34de60534f91b/5.jpg
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTMxODdjNjU4YWIyLzQwZDBkNmFhZjFhZmMzMjg4NmMzNGRlNjA1MzRmOTFiLzUuanBn");
        // https://platinumscans.com/wp-content/uploads/WP-manga/data/manga_65744a744c583/05ec327c78ac615d64c469900cefecea/32.jpg
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc0NGE3NDRjNTgzLzA1ZWMzMjdjNzhhYzYxNWQ2NGM0Njk5MDBjZWZlY2VhLzMyLmpwZw==");
        // https://platinumscans.com/wp-content/uploads/WP-manga/data/manga_65744a744c583/05ec327c78ac615d64c469900cefecea/23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc0NGE3NDRjNTgzLzA1ZWMzMjdjNzhhYzYxNWQ2NGM0Njk5MDBjZWZlY2VhLzIzLmpwZw==");
        // https://platinumscans.com/wp-content/uploads/WP-manga/data/manga_65744a744c583/05ec327c78ac615d64c469900cefecea/14.jpg
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc0NGE3NDRjNTgzLzA1ZWMzMjdjNzhhYzYxNWQ2NGM0Njk5MDBjZWZlY2VhLzE0LmpwZw==");
        // https://platinumscans.com/wp-content/uploads/WP-manga/data/manga_65744a744c583/05ec327c78ac615d64c469900cefecea/46.jpg
        yield return new TestCaseData("aHR0cHM6Ly9wbGF0aW51bXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTc0NGE3NDRjNTgzLzA1ZWMzMjdjNzhhYzYxNWQ2NGM0Njk5MDBjZWZlY2VhLzQ2LmpwZw==");
    }
}

