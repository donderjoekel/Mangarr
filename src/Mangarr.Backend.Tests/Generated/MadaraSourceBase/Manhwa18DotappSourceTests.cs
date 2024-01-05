using System.Collections;

namespace Mangarr.Backend.Tests;

public class Manhwa18DotappSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhwa18.app";

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
        // https://manhwa18.app/manga/heroine-app/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2EvaGVyb2luZS1hcHAv");
        // https://manhwa18.app/manga/close-family/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2EvY2xvc2UtZmFtaWx5Lw==");
        // https://manhwa18.app/manga/welcome-to-kids-cafe/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2Evd2VsY29tZS10by1raWRzLWNhZmUv");
        // https://manhwa18.app/manga/secret-class-001/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2Evc2VjcmV0LWNsYXNzLTAwMS8=");
        // https://manhwa18.app/manga/private-tutoring-in-these-trying-times/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2EvcHJpdmF0ZS10dXRvcmluZy1pbi10aGVzZS10cnlpbmctdGltZXMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhwa18.app/manga/private-tutoring-in-these-trying-times/chapter-36/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2EvcHJpdmF0ZS10dXRvcmluZy1pbi10aGVzZS10cnlpbmctdGltZXMvY2hhcHRlci0zNi8=");
        // https://manhwa18.app/manga/welcome-to-kids-cafe/chapter-48/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2Evd2VsY29tZS10by1raWRzLWNhZmUvY2hhcHRlci00OC8=");
        // https://manhwa18.app/manga/close-family/chapter-06/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2EvY2xvc2UtZmFtaWx5L2NoYXB0ZXItMDYv");
        // https://manhwa18.app/manga/private-tutoring-in-these-trying-times/chapter-87/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2EvcHJpdmF0ZS10dXRvcmluZy1pbi10aGVzZS10cnlpbmctdGltZXMvY2hhcHRlci04Ny8=");
        // https://manhwa18.app/manga/secret-class-001/chapter-05/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5od2ExOC5hcHAvbWFuZ2Evc2VjcmV0LWNsYXNzLTAwMS9jaGFwdGVyLTA1Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // http://images.hentaimanga.me/manga_61416b36810ef/bb928aefde7ae8d1aa38b23359a23843/5.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYV82MTQxNmIzNjgxMGVmL2JiOTI4YWVmZGU3YWU4ZDFhYTM4YjIzMzU5YTIzODQzLzUuanBn");
        // http://images.hentaimanga.me/manga5/close-family/chapter-06/6025_Q2hhcHRlciUyMDA2_5.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYTUvY2xvc2UtZmFtaWx5L2NoYXB0ZXItMDYvNjAyNV9RMmhoY0hSbGNpVXlNREEyXzUuanBn");
        // http://images.hentaimanga.me/manga5/close-family/chapter-06/6025_Q2hhcHRlciUyMDA2_18.jpg
        yield return new TestCaseData("aHR0cDovL2ltYWdlcy5oZW50YWltYW5nYS5tZS9tYW5nYTUvY2xvc2UtZmFtaWx5L2NoYXB0ZXItMDYvNjAyNV9RMmhoY0hSbGNpVXlNREEyXzE4LmpwZw==");
    }
}

