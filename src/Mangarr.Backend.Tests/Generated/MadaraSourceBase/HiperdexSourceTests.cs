using System.Collections;

namespace Mangarr.Backend.Tests;

public class HiperdexSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "hiperdex";

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
        // https://hiperdex.com/manga/healers-unique-skill-pleasuring-girls/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2EvaGVhbGVycy11bmlxdWUtc2tpbGwtcGxlYXN1cmluZy1naXJscy8=");
        // https://hiperdex.com/manga/shiboritoranaide-onna-shounin-san/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuLw==");
        // https://hiperdex.com/manga/the-story-of-how-i-got-together-with-the-manager-on-christmas/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2EvdGhlLXN0b3J5LW9mLWhvdy1pLWdvdC10b2dldGhlci13aXRoLXRoZS1tYW5hZ2VyLW9uLWNocmlzdG1hcy8=");
        // https://hiperdex.com/manga/the-extras-academy-survival-guide/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2EvdGhlLWV4dHJhcy1hY2FkZW15LXN1cnZpdmFsLWd1aWRlLw==");
        // https://hiperdex.com/manga/the-crown-prince-that-sells-medicine/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2EvdGhlLWNyb3duLXByaW5jZS10aGF0LXNlbGxzLW1lZGljaW5lLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://hiperdex.com/manga/shiboritoranaide-onna-shounin-san/chapter-15-1/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMTUtMS8=");
        // https://hiperdex.com/manga/shiboritoranaide-onna-shounin-san/chapter-31-1/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMzEtMS8=");
        // https://hiperdex.com/manga/shiboritoranaide-onna-shounin-san/chapter-28-1/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMjgtMS8=");
        // https://hiperdex.com/manga/shiboritoranaide-onna-shounin-san/chapter-14-5/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMTQtNS8=");
        // https://hiperdex.com/manga/shiboritoranaide-onna-shounin-san/chapter-12-1/
        yield return new TestCaseData("aHR0cHM6Ly9oaXBlcmRleC5jb20vbWFuZ2Evc2hpYm9yaXRvcmFuYWlkZS1vbm5hLXNob3VuaW4tc2FuL2NoYXB0ZXItMTItMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cdn.hiperdex.com//home/newdex/en/wp-content/uploads/WP-manga/data/manga_65908f9e5988f/temp_unzip_659091f3b842b/6accdf5056b351fc523287c44435d21b/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaGlwZXJkZXguY29tLy9ob21lL25ld2RleC9lbi93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOGY5ZTU5ODhmL3RlbXBfdW56aXBfNjU5MDkxZjNiODQyYi82YWNjZGY1MDU2YjM1MWZjNTIzMjg3YzQ0NDM1ZDIxYi8wNS5qcGc=");
        // https://cdn.hiperdex.com//home/newdex/en/wp-content/uploads/WP-manga/data/manga_65908f9e5988f/temp_unzip_65909227da015/d4cba0e700f6a7a2efd8f1591408b290/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaGlwZXJkZXguY29tLy9ob21lL25ld2RleC9lbi93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOGY5ZTU5ODhmL3RlbXBfdW56aXBfNjU5MDkyMjdkYTAxNS9kNGNiYTBlNzAwZjZhN2EyZWZkOGYxNTkxNDA4YjI5MC8wOC5qcGc=");
        // https://cdn.hiperdex.com//home/newdex/en/wp-content/uploads/WP-manga/data/manga_65908f9e5988f/temp_unzip_6590918256d2a/e51c5656c470b29df921a5642e6edde1/07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaGlwZXJkZXguY29tLy9ob21lL25ld2RleC9lbi93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOGY5ZTU5ODhmL3RlbXBfdW56aXBfNjU5MDkxODI1NmQyYS9lNTFjNTY1NmM0NzBiMjlkZjkyMWE1NjQyZTZlZGRlMS8wNy5qcGc=");
        // https://cdn.hiperdex.com//home/newdex/en/wp-content/uploads/WP-manga/data/manga_65908f9e5988f/temp_unzip_65909227da015/d4cba0e700f6a7a2efd8f1591408b290/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaGlwZXJkZXguY29tLy9ob21lL25ld2RleC9lbi93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOGY5ZTU5ODhmL3RlbXBfdW56aXBfNjU5MDkyMjdkYTAxNS9kNGNiYTBlNzAwZjZhN2EyZWZkOGYxNTkxNDA4YjI5MC8wMy5qcGc=");
        // https://cdn.hiperdex.com//home/newdex/en/wp-content/uploads/WP-manga/data/manga_65908f9e5988f/temp_unzip_6590918256d2a/38c045fa07f1eecb5e4469d3d4e775f1/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9jZG4uaGlwZXJkZXguY29tLy9ob21lL25ld2RleC9lbi93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTkwOGY5ZTU5ODhmL3RlbXBfdW56aXBfNjU5MDkxODI1NmQyYS8zOGMwNDVmYTA3ZjFlZWNiNWU0NDY5ZDNkNGU3NzVmMS8wOS5qcGc=");
    }
}

