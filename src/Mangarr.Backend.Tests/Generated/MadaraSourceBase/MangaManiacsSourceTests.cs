using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaManiacsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangamaniacs";

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
        // https://mangamaniacs.org/manga/the-baby-that-master-brought-is-sus/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3RoZS1iYWJ5LXRoYXQtbWFzdGVyLWJyb3VnaHQtaXMtc3VzLw==");
        // https://mangamaniacs.org/manga/rabbits-ejaculate-in-3-seconds-mgs/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3JhYmJpdHMtZWphY3VsYXRlLWluLTMtc2Vjb25kcy1tZ3Mv");
        // https://mangamaniacs.org/manga/tonari-no-ecchi-na-oniisan/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3RvbmFyaS1uby1lY2NoaS1uYS1vbmlpc2FuLw==");
        // https://mangamaniacs.org/manga/paper-flower/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3BhcGVyLWZsb3dlci8=");
        // https://mangamaniacs.org/manga/polar-bunny/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3BvbGFyLWJ1bm55Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangamaniacs.org/manga/the-baby-that-master-brought-is-sus/0008-chapter-008/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3RoZS1iYWJ5LXRoYXQtbWFzdGVyLWJyb3VnaHQtaXMtc3VzLzAwMDgtY2hhcHRlci0wMDgv");
        // https://mangamaniacs.org/manga/paper-flower/0037-chapter-038/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3BhcGVyLWZsb3dlci8wMDM3LWNoYXB0ZXItMDM4Lw==");
        // https://mangamaniacs.org/manga/rabbits-ejaculate-in-3-seconds-mgs/0003-chapter-003/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3JhYmJpdHMtZWphY3VsYXRlLWluLTMtc2Vjb25kcy1tZ3MvMDAwMy1jaGFwdGVyLTAwMy8=");
        // https://mangamaniacs.org/manga/paper-flower/0056-chapter-055/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3BhcGVyLWZsb3dlci8wMDU2LWNoYXB0ZXItMDU1Lw==");
        // https://mangamaniacs.org/manga/paper-flower/0044-chapter-045/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL21hbmdhL3BhcGVyLWZsb3dlci8wMDQ0LWNoYXB0ZXItMDQ1Lw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangamaniacs.org/wp-content/uploads/WP-manga/data/manga_6564a8407d8d5/42f13f6becb99491799b7c19bf7d5219/005.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NjRhODQwN2Q4ZDUvNDJmMTNmNmJlY2I5OTQ5MTc5OWI3YzE5YmY3ZDUyMTkvMDA1LmpwZw==");
        // https://mangamaniacs.org/wp-content/uploads/WP-manga/data/manga_6564a4775642c/aadab9086f469ac7b6e849f63b04f173/021.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NjRhNDc3NTY0MmMvYWFkYWI5MDg2ZjQ2OWFjN2I2ZTg0OWY2M2IwNGYxNzMvMDIxLmpwZw==");
        // https://mangamaniacs.org/wp-content/uploads/WP-manga/data/manga_6564a4775642c/aadab9086f469ac7b6e849f63b04f173/007.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NjRhNDc3NTY0MmMvYWFkYWI5MDg2ZjQ2OWFjN2I2ZTg0OWY2M2IwNGYxNzMvMDA3LmpwZw==");
        // https://mangamaniacs.org/wp-content/uploads/WP-manga/data/manga_6564a4775642c/fe1b4947d2d3493f96480694c25218dc/023.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NjRhNDc3NTY0MmMvZmUxYjQ5NDdkMmQzNDkzZjk2NDgwNjk0YzI1MjE4ZGMvMDIzLmpwZw==");
        // https://mangamaniacs.org/wp-content/uploads/WP-manga/data/manga_6564a4775642c/fe1b4947d2d3493f96480694c25218dc/022.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYW1hbmlhY3Mub3JnL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NjRhNDc3NTY0MmMvZmUxYjQ5NDdkMmQzNDkzZjk2NDgwNjk0YzI1MjE4ZGMvMDIyLmpwZw==");
    }
}

