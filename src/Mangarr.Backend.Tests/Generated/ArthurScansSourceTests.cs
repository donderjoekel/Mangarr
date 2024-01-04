using System.Collections;

namespace Mangarr.Backend.Tests;

public class ArthurScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "arthurscans";

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
        // https://arthurscan.xyz/manga/rebirth-of-the-godly-prodigal/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9yZWJpcnRoLW9mLXRoZS1nb2RseS1wcm9kaWdhbC8=");
        // https://arthurscan.xyz/manga/i-randomly-have-a-new-career-every-week/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9pLXJhbmRvbWx5LWhhdmUtYS1uZXctY2FyZWVyLWV2ZXJ5LXdlZWsv");
        // https://arthurscan.xyz/manga/return-of-soul-master/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9yZXR1cm4tb2Ytc291bC1tYXN0ZXIv");
        // https://arthurscan.xyz/manga/hero-with-another-opinion/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9oZXJvLXdpdGgtYW5vdGhlci1vcGluaW9uLw==");
        // https://arthurscan.xyz/manga/kaiju-girl-caramelise/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9rYWlqdS1naXJsLWNhcmFtZWxpc2Uv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://arthurscan.xyz/manga/i-randomly-have-a-new-career-every-week/capitulo-45/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9pLXJhbmRvbWx5LWhhdmUtYS1uZXctY2FyZWVyLWV2ZXJ5LXdlZWsvY2FwaXR1bG8tNDUv");
        // https://arthurscan.xyz/manga/return-of-soul-master/capitulo-105/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9yZXR1cm4tb2Ytc291bC1tYXN0ZXIvY2FwaXR1bG8tMTA1Lw==");
        // https://arthurscan.xyz/manga/kaiju-girl-caramelise/capitulo-22/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9rYWlqdS1naXJsLWNhcmFtZWxpc2UvY2FwaXR1bG8tMjIv");
        // https://arthurscan.xyz/manga/return-of-soul-master/capitulo-44/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9yZXR1cm4tb2Ytc291bC1tYXN0ZXIvY2FwaXR1bG8tNDQv");
        // https://arthurscan.xyz/manga/i-randomly-have-a-new-career-every-week/capitulo-61/
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei9tYW5nYS9pLXJhbmRvbWx5LWhhdmUtYS1uZXctY2FyZWVyLWV2ZXJ5LXdlZWsvY2FwaXR1bG8tNjEv");
    }

    public static IEnumerable ValidImages()
    {
        // https://arthurscan.xyz/wp-content/uploads/WP-manga/data/manga_5fefb8c7a1817/78d023a29ac2ffc18d8a1371a7f0873f/02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmVmYjhjN2ExODE3Lzc4ZDAyM2EyOWFjMmZmYzE4ZDhhMTM3MWE3ZjA4NzNmLzAyLmpwZw==");
        // https://arthurscan.xyz/wp-content/uploads/WP-manga/data/manga_5fefb8c7a1817/78d023a29ac2ffc18d8a1371a7f0873f/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmVmYjhjN2ExODE3Lzc4ZDAyM2EyOWFjMmZmYzE4ZDhhMTM3MWE3ZjA4NzNmLzA5LmpwZw==");
        // https://arthurscan.xyz/wp-content/uploads/WP-manga/data/manga_61be914e034c2/59632123527112450b633d7db369657f/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82MWJlOTE0ZTAzNGMyLzU5NjMyMTIzNTI3MTEyNDUwYjYzM2Q3ZGIzNjk2NTdmLzA1LmpwZw==");
        // https://arthurscan.xyz/wp-content/uploads/WP-manga/data/manga_5fefb8c7a1817/78d023a29ac2ffc18d8a1371a7f0873f/01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmVmYjhjN2ExODE3Lzc4ZDAyM2EyOWFjMmZmYzE4ZDhhMTM3MWE3ZjA4NzNmLzAxLmpwZw==");
        // https://arthurscan.xyz/wp-content/uploads/WP-manga/data/manga_5fefb8c7a1817/a7288d2c688add36a18314d4a714da83/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hcnRodXJzY2FuLnh5ei93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV81ZmVmYjhjN2ExODE3L2E3Mjg4ZDJjNjg4YWRkMzZhMTgzMTRkNGE3MTRkYTgzLzA0LmpwZw==");
    }
}

