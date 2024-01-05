using System.Collections;

namespace Mangarr.Backend.Tests;

public class DrakeScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "drakescans";

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
        // https://drakescans.com/series/sss-grade-saint-knight/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvc3NzLWdyYWRlLXNhaW50LWtuaWdodC8=");
        // https://drakescans.com/series/the-final-boss-became-a-player/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvdGhlLWZpbmFsLWJvc3MtYmVjYW1lLWEtcGxheWVyLw==");
        // https://drakescans.com/series/i-the-demon-lord-am-being-targeted-by-my-female-disciples/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvaS10aGUtZGVtb24tbG9yZC1hbS1iZWluZy10YXJnZXRlZC1ieS1teS1mZW1hbGUtZGlzY2lwbGVzLw==");
        // https://drakescans.com/series/my-skills-are-automatically-max-level/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvbXktc2tpbGxzLWFyZS1hdXRvbWF0aWNhbGx5LW1heC1sZXZlbC8=");
        // https://drakescans.com/series/overmortal/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvb3Zlcm1vcnRhbC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://drakescans.com/series/overmortal/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvb3Zlcm1vcnRhbC9jaGFwdGVyLTIv");
        // https://drakescans.com/series/overmortal/chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvb3Zlcm1vcnRhbC9jaGFwdGVyLTgv");
        // https://drakescans.com/series/overmortal/chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvb3Zlcm1vcnRhbC9jaGFwdGVyLTcv");
        // https://drakescans.com/series/overmortal/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvb3Zlcm1vcnRhbC9jaGFwdGVyLTEv");
        // https://drakescans.com/series/overmortal/chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS9zZXJpZXMvb3Zlcm1vcnRhbC9jaGFwdGVyLTUv");
    }

    public static IEnumerable ValidImages()
    {
        // https://drakescans.com/wp-content/uploads/WP-manga/data/manga_658190ac18273/eb29d68a0703976440e6f034505153ab/7_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgxOTBhYzE4MjczL2ViMjlkNjhhMDcwMzk3NjQ0MGU2ZjAzNDUwNTE1M2FiLzdfMTAuanBn");
        // https://drakescans.com/wp-content/uploads/WP-manga/data/manga_658190ac18273/b861bacca176d405cfcc45a17d40d3d4/8_05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgxOTBhYzE4MjczL2I4NjFiYWNjYTE3NmQ0MDVjZmNjNDVhMTdkNDBkM2Q0LzhfMDUuanBn");
        // https://drakescans.com/wp-content/uploads/WP-manga/data/manga_658190ac18273/f88e326dca07fde60d928b7c3dac0ce6/5_05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgxOTBhYzE4MjczL2Y4OGUzMjZkY2EwN2ZkZTYwZDkyOGI3YzNkYWMwY2U2LzVfMDUuanBn");
        // https://drakescans.com/wp-content/uploads/WP-manga/data/manga_658190ac18273/2f31ed65049427904bd881d9e35540d4/1_07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgxOTBhYzE4MjczLzJmMzFlZDY1MDQ5NDI3OTA0YmQ4ODFkOWUzNTU0MGQ0LzFfMDcuanBn");
        // https://drakescans.com/wp-content/uploads/WP-manga/data/manga_658190ac18273/eb29d68a0703976440e6f034505153ab/7_07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9kcmFrZXNjYW5zLmNvbS93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTgxOTBhYzE4MjczL2ViMjlkNjhhMDcwMzk3NjQ0MGU2ZjAzNDUwNTE1M2FiLzdfMDcuanBn");
    }
}

