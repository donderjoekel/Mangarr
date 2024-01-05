using System.Collections;

namespace Mangarr.Backend.Tests;

public class GalaxyDegenScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "galaxydegenscans";

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
        // https://gdscans.com/manga/mamakano/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS9tYW1ha2Fuby8=");
        // https://gdscans.com/manga/yatarato-sasshi-no-ii-ore-wa-dokuzetsu-kuudere-bishoujo-no-chiisana-dere-mo-minogasazu-ni-guigui-iku/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS95YXRhcmF0by1zYXNzaGktbm8taWktb3JlLXdhLWRva3V6ZXRzdS1rdXVkZXJlLWJpc2hvdWpvLW5vLWNoaWlzYW5hLWRlcmUtbW8tbWlub2dhc2F6dS1uaS1ndWlndWktaWt1Lw==");
        // https://gdscans.com/manga/villain-loop/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS92aWxsYWluLWxvb3Av");
        // https://gdscans.com/manga/villain-sex-slave/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS92aWxsYWluLXNleC1zbGF2ZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://gdscans.com/manga/mamakano/volume-5/ch-26/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS9tYW1ha2Fuby92b2x1bWUtNS9jaC0yNi8=");
        // https://gdscans.com/manga/yatarato-sasshi-no-ii-ore-wa-dokuzetsu-kuudere-bishoujo-no-chiisana-dere-mo-minogasazu-ni-guigui-iku/volume-2/chapter-7-5/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS95YXRhcmF0by1zYXNzaGktbm8taWktb3JlLXdhLWRva3V6ZXRzdS1rdXVkZXJlLWJpc2hvdWpvLW5vLWNoaWlzYW5hLWRlcmUtbW8tbWlub2dhc2F6dS1uaS1ndWlndWktaWt1L3ZvbHVtZS0yL2NoYXB0ZXItNy01Lw==");
        // https://gdscans.com/manga/yatarato-sasshi-no-ii-ore-wa-dokuzetsu-kuudere-bishoujo-no-chiisana-dere-mo-minogasazu-ni-guigui-iku/volume-2/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS95YXRhcmF0by1zYXNzaGktbm8taWktb3JlLXdhLWRva3V6ZXRzdS1rdXVkZXJlLWJpc2hvdWpvLW5vLWNoaWlzYW5hLWRlcmUtbW8tbWlub2dhc2F6dS1uaS1ndWlndWktaWt1L3ZvbHVtZS0yL2NoYXB0ZXItNy8=");
        // https://gdscans.com/manga/villain-loop/volume-1/ch-1-1/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS92aWxsYWluLWxvb3Avdm9sdW1lLTEvY2gtMS0xLw==");
        // https://gdscans.com/manga/mamakano/volume-5/ch-27/
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS9tYW5nYS9tYW1ha2Fuby92b2x1bWUtNS9jaC0yNy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://gdscans.com/wp-content/uploads/WP-manga/data/manga_656fed0c4df0f/e69003e22980721c6a2ba403004a7f2c/007.webp
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZmZWQwYzRkZjBmL2U2OTAwM2UyMjk4MDcyMWM2YTJiYTQwMzAwNGE3ZjJjLzAwNy53ZWJw");
        // https://gdscans.com/wp-content/uploads/WP-manga/data/manga_656fed0c4df0f/e69003e22980721c6a2ba403004a7f2c/002.webp
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZmZWQwYzRkZjBmL2U2OTAwM2UyMjk4MDcyMWM2YTJiYTQwMzAwNGE3ZjJjLzAwMi53ZWJw");
        // https://gdscans.com/wp-content/uploads/WP-manga/data/manga_656fed0c4df0f/e69003e22980721c6a2ba403004a7f2c/006.webp
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZmZWQwYzRkZjBmL2U2OTAwM2UyMjk4MDcyMWM2YTJiYTQwMzAwNGE3ZjJjLzAwNi53ZWJw");
        // https://gdscans.com/wp-content/uploads/WP-manga/data/manga_659749110aa79/0dc5986be4ee4104c3a2660f9b15dd6d/037.webp
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTk3NDkxMTBhYTc5LzBkYzU5ODZiZTRlZTQxMDRjM2EyNjYwZjliMTVkZDZkLzAzNy53ZWJw");
        // https://gdscans.com/wp-content/uploads/WP-manga/data/manga_656fed0c4df0f/e69003e22980721c6a2ba403004a7f2c/011.webp
        yield return new TestCaseData("aHR0cHM6Ly9nZHNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTZmZWQwYzRkZjBmL2U2OTAwM2UyMjk4MDcyMWM2YTJiYTQwMzAwNGE3ZjJjLzAxMS53ZWJw");
    }
}

