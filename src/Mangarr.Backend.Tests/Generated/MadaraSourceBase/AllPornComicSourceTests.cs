using System.Collections;

namespace Mangarr.Backend.Tests;

public class AllPornComicSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "allporncomic";

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
        // https://allporncomic.com/porncomic/pervy-sage-adventures-naruto-super-melons/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9wZXJ2eS1zYWdlLWFkdmVudHVyZXMtbmFydXRvLXN1cGVyLW1lbG9ucy8=");
        // https://allporncomic.com/porncomic/christmas-meeting-naruto-super-melons/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9jaHJpc3RtYXMtbWVldGluZy1uYXJ1dG8tc3VwZXItbWVsb25zLw==");
        // https://allporncomic.com/porncomic/christmas-1955-jdseal/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9jaHJpc3RtYXMtMTk1NS1qZHNlYWwv");
        // https://allporncomic.com/porncomic/hot-n-fast-johnpersons-com-flypaper/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9ob3Qtbi1mYXN0LWpvaG5wZXJzb25zLWNvbS1mbHlwYXBlci8=");
        // https://allporncomic.com/porncomic/lustfilled-lillymon-digimon-palcomix/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9sdXN0ZmlsbGVkLWxpbGx5bW9uLWRpZ2ltb24tcGFsY29taXgv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://allporncomic.com/porncomic/christmas-1955-jdseal/1-christmas-1955/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9jaHJpc3RtYXMtMTk1NS1qZHNlYWwvMS1jaHJpc3RtYXMtMTk1NS8=");
        // https://allporncomic.com/porncomic/lustfilled-lillymon-digimon-palcomix/1-lustfilled-lillymon/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9sdXN0ZmlsbGVkLWxpbGx5bW9uLWRpZ2ltb24tcGFsY29taXgvMS1sdXN0ZmlsbGVkLWxpbGx5bW9uLw==");
        // https://allporncomic.com/porncomic/christmas-meeting-naruto-super-melons/1-christmas-meeting/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9jaHJpc3RtYXMtbWVldGluZy1uYXJ1dG8tc3VwZXItbWVsb25zLzEtY2hyaXN0bWFzLW1lZXRpbmcv");
        // https://allporncomic.com/porncomic/hot-n-fast-johnpersons-com-flypaper/1-hot-n-fast/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9ob3Qtbi1mYXN0LWpvaG5wZXJzb25zLWNvbS1mbHlwYXBlci8xLWhvdC1uLWZhc3Qv");
        // https://allporncomic.com/porncomic/pervy-sage-adventures-naruto-super-melons/1-pervy-sage-adventures/
        yield return new TestCaseData("aHR0cHM6Ly9hbGxwb3JuY29taWMuY29tL3Bvcm5jb21pYy9wZXJ2eS1zYWdlLWFkdmVudHVyZXMtbmFydXRvLXN1cGVyLW1lbG9ucy8xLXBlcnZ5LXNhZ2UtYWR2ZW50dXJlcy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.allporncomic.com/wp-content/uploads/WP-manga/data/manga_65929029dd752/a06d0625cb89042fccf2925490386a47/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYWxscG9ybmNvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkyOTAyOWRkNzUyL2EwNmQwNjI1Y2I4OTA0MmZjY2YyOTI1NDkwMzg2YTQ3LzAxLmpwZw==");
        // https://cdn.allporncomic.com/wp-content/uploads/WP-manga/data/manga_659564646fbbf/7b8244636db501f1dda8deff65efaa1c/009.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYWxscG9ybmNvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk1NjQ2NDZmYmJmLzdiODI0NDYzNmRiNTAxZjFkZGE4ZGVmZjY1ZWZhYTFjLzAwOS5qcGc=");
        // https://cdn.allporncomic.com/wp-content/uploads/WP-manga/data/manga_6591664c711b8/70135388aa40e668860c1dfa1fcc5373/011.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYWxscG9ybmNvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxNjY0YzcxMWI4LzcwMTM1Mzg4YWE0MGU2Njg4NjBjMWRmYTFmY2M1MzczLzAxMS5qcGc=");
        // https://cdn.allporncomic.com/wp-content/uploads/WP-manga/data/manga_6591664c711b8/70135388aa40e668860c1dfa1fcc5373/016.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYWxscG9ybmNvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkxNjY0YzcxMWI4LzcwMTM1Mzg4YWE0MGU2Njg4NjBjMWRmYTFmY2M1MzczLzAxNi5qcGc=");
        // https://cdn.allporncomic.com/wp-content/uploads/WP-manga/data/manga_659277fa14896/509c2f5638eb01894bedeea5d7487c90/015.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uYWxscG9ybmNvbWljLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkyNzdmYTE0ODk2LzUwOWMyZjU2MzhlYjAxODk0YmVkZWVhNWQ3NDg3YzkwLzAxNS5qcGc=");
    }
}

