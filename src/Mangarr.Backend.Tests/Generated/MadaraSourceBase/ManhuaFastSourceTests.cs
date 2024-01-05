using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaFastSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuafast";

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
        // https://manhuafast.com/manga/full-time-swordsman/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9mdWxsLXRpbWUtc3dvcmRzbWFuLw==");
        // https://manhuafast.com/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3Iv");
        // https://manhuafast.com/manga/emperor-qin-returns-i-am-the-eternal-immortal-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9lbXBlcm9yLXFpbi1yZXR1cm5zLWktYW0tdGhlLWV0ZXJuYWwtaW1tb3J0YWwtZW1wZXJvci8=");
        // https://manhuafast.com/manga/the-unbeatable-dungeons-lazy-boss-monster/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS90aGUtdW5iZWF0YWJsZS1kdW5nZW9ucy1sYXp5LWJvc3MtbW9uc3Rlci8=");
        // https://manhuafast.com/manga/reincarnator/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9yZWluY2FybmF0b3Iv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuafast.com/manga/dark-and-light-martial-emperor/chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci0yMC8=");
        // https://manhuafast.com/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS90aGUtdW5iZWF0YWJsZS1kdW5nZW9ucy1sYXp5LWJvc3MtbW9uc3Rlci9jaGFwdGVyLTgv");
        // https://manhuafast.com/manga/the-unbeatable-dungeons-lazy-boss-monster/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS90aGUtdW5iZWF0YWJsZS1kdW5nZW9ucy1sYXp5LWJvc3MtbW9uc3Rlci9jaGFwdGVyLTIxLw==");
        // https://manhuafast.com/manga/dark-and-light-martial-emperor/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9kYXJrLWFuZC1saWdodC1tYXJ0aWFsLWVtcGVyb3IvY2hhcHRlci0yLw==");
        // https://manhuafast.com/manga/emperor-qin-returns-i-am-the-eternal-immortal-emperor/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFmYXN0LmNvbS9tYW5nYS9lbXBlcm9yLXFpbi1yZXR1cm5zLWktYW0tdGhlLWV0ZXJuYWwtaW1tb3J0YWwtZW1wZXJvci9jaGFwdGVyLTIv");
    }

    public static IEnumerable ValidImages()
    {
        // https://img.manhuafast.com/uploads/manga_659172d80fb1b/0995de713c4b3c798c3ad8c14c0c5a4b/014.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWcubWFuaHVhZmFzdC5jb20vdXBsb2Fkcy9tYW5nYV82NTkxNzJkODBmYjFiLzA5OTVkZTcxM2M0YjNjNzk4YzNhZDhjMTRjMGM1YTRiLzAxNC53ZWJw");
        // https://cdn.manhuafast.com/uploads/manga_659172d80fb1b/7c2f9c8de54d4ccb44aa429d8528408c/09.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhZmFzdC5jb20vdXBsb2Fkcy9tYW5nYV82NTkxNzJkODBmYjFiLzdjMmY5YzhkZTU0ZDRjY2I0NGFhNDI5ZDg1Mjg0MDhjLzA5LndlYnA=");
        // https://cdn.manhuafast.com/uploads/manga_659172d80fb1b/7c2f9c8de54d4ccb44aa429d8528408c/20.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhZmFzdC5jb20vdXBsb2Fkcy9tYW5nYV82NTkxNzJkODBmYjFiLzdjMmY5YzhkZTU0ZDRjY2I0NGFhNDI5ZDg1Mjg0MDhjLzIwLndlYnA=");
        // https://cdn.manhuafast.com/uploads/manga_659172d80fb1b/7c2f9c8de54d4ccb44aa429d8528408c/07.webp
        yield return new TestCaseData("aHR0cHM6Ly9jZG4ubWFuaHVhZmFzdC5jb20vdXBsb2Fkcy9tYW5nYV82NTkxNzJkODBmYjFiLzdjMmY5YzhkZTU0ZDRjY2I0NGFhNDI5ZDg1Mjg0MDhjLzA3LndlYnA=");
        // http://manhuafast.com/wp-content/uploads/WP-manga/data/manga_659237495edc2/fe3ec808a996421a389bdc8fa6a65ad8/030.webp
        yield return new TestCaseData("aHR0cDovL21hbmh1YWZhc3QuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1OTIzNzQ5NWVkYzIvZmUzZWM4MDhhOTk2NDIxYTM4OWJkYzhmYTZhNjVhZDgvMDMwLndlYnA=");
    }
}

